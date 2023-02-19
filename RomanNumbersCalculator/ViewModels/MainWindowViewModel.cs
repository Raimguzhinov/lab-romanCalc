using ReactiveUI;
using RomanNumbersCalculator.Models;
using System;
using System.Collections.Generic;
using System.Reactive;

namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string currentOperationStringRepresentation = "";
        private object? currentResult;
        private string currentNumberStringRepresentation = "";
        private Stack<RomanNumberExtend> stackRomanNumbers =
            new Stack<RomanNumberExtend>();

        public string CurrentNumberStringRepresentation
        {
            get => currentNumberStringRepresentation;
            set
            {
                this.RaiseAndSetIfChanged(ref currentNumberStringRepresentation, value);
            }
        }
        public ReactiveCommand<string, Unit> AddNumber { get; }
        public ReactiveCommand<Unit, Unit> PlusCommand { get; }
        public ReactiveCommand<Unit, Unit> SubCommand { get; }
        public ReactiveCommand<Unit, Unit> MulCommand { get; }
        public ReactiveCommand<Unit, Unit> DivCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
        public ReactiveCommand<Unit, Unit> ResetCommand { get; }

        public MainWindowViewModel()
        {
            AddNumber = ReactiveCommand.Create<string>(str =>
            {
                if (currentOperationStringRepresentation == "=")
                {
                    CurrentNumberStringRepresentation = str;
                    stackRomanNumbers.Clear();
                    currentOperationStringRepresentation = "";
                }
                else
                {
                    if (currentNumberStringRepresentation != "#ERROR")
                    {
                        CurrentNumberStringRepresentation += str;
                    }
                }
            });

            PlusCommand =
                ReactiveCommand.Create(() => DoOperation(PerformAddition, "+"));
            SubCommand =
                ReactiveCommand.Create(() => DoOperation(PerformSubtraction, "-"));
            MulCommand =
                ReactiveCommand.Create(() => DoOperation(PerformMultiplication, "*"));
            DivCommand =
                ReactiveCommand.Create(() => DoOperation(PerformDivision, "/"));
            CalculateCommand = ReactiveCommand.Create(() =>
            {
                if (stackRomanNumbers.Count == 1 &&
                    currentNumberStringRepresentation != "" &&
                    currentNumberStringRepresentation != "#ERROR")
                {
                    try
                    {
                        RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);

                        RomanNumberExtend number1 = stackRomanNumbers.Pop();
                        RomanNumberExtend number2 = newNumber;

                        if (currentOperationStringRepresentation == "+")
                        {
                            stackRomanNumbers.Push(number1 + number2);
                        }
                        else if (currentOperationStringRepresentation == "-")
                        {
                            stackRomanNumbers.Push(number1 - number2);
                        }
                        else if (currentOperationStringRepresentation == "*")
                        {
                            stackRomanNumbers.Push(number1 * number2);
                        }
                        else if (currentOperationStringRepresentation == "/")
                        {
                            stackRomanNumbers.Push(number1 / number2);
                        }

                        currentOperationStringRepresentation = "=";
                        CurrentNumberStringRepresentation = stackRomanNumbers.Peek().ToString();
                    }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }
            });
            ResetCommand = ReactiveCommand.Create(() =>
            {
                CurrentNumberStringRepresentation = "";
                stackRomanNumbers.Clear();
                currentOperationStringRepresentation = "";
            });
        }

        private void DoOperation(
            Func<RomanNumberExtend, RomanNumberExtend, RomanNumberExtend> operation,
            string operationString)
        {
            if (currentNumberStringRepresentation == "#ERROR")
                return;

            if (currentNumberStringRepresentation == "" &&
                currentOperationStringRepresentation != "")
            {
                currentOperationStringRepresentation = operationString;
                return;
            }

            if (currentNumberStringRepresentation == "")
                return;

            try
            {
                if (currentOperationStringRepresentation == "=")
                {
                    currentOperationStringRepresentation = operationString;
                    currentResult = null;
                    CurrentNumberStringRepresentation = "";
                }
                else
                {
                    if (currentOperationStringRepresentation == "")
                    {
                        currentOperationStringRepresentation = operationString;
                        currentResult =
                            new RomanNumberExtend(currentNumberStringRepresentation);
                        stackRomanNumbers.Push((RomanNumberExtend)currentResult);
                        CurrentNumberStringRepresentation = "";
                    }
                    else
                    {
                        RomanNumberExtend newNumber =
                            new RomanNumberExtend(currentNumberStringRepresentation);
                        currentResult = operation(
                            (RomanNumberExtend)(currentResult ?? stackRomanNumbers.Pop()),
                            newNumber);
                        currentOperationStringRepresentation = operationString;
                        CurrentNumberStringRepresentation = "";
                    }
                }
            }
            catch (RomanNumberException ex)
            {
                CurrentNumberStringRepresentation = ex.Message;
            }
        }

        private RomanNumberExtend PerformAddition(RomanNumberExtend a,
                                                  RomanNumberExtend b)
        {
            return a + b;
        }

        private RomanNumberExtend PerformSubtraction(RomanNumberExtend a,
                                                     RomanNumberExtend b)
        {
            return a - b;
        }

        private RomanNumberExtend PerformMultiplication(RomanNumberExtend a,
                                                        RomanNumberExtend b)
        {
            return a * b;
        }

        private RomanNumberExtend PerformDivision(RomanNumberExtend a,
                                                  RomanNumberExtend b)
        {
            return a / b;
        }
    }
}
