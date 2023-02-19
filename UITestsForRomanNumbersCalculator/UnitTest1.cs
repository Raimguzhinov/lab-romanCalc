using Avalonia;
using Avalonia.Controls;
using Avalonia.VisualTree;
using RomanNumbersCalculator.Views;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTests
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var Plus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Plus");
            var D = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            I.Command.Execute(I.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            D.Command.Execute(D.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "DI", "result != VI");
        }

        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var D = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            D.Command.Execute(D.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);
            I.Command.Execute(I.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "CDXCIX", "result != CDXCIX");
        }

        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var L = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var Mul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Mul");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            L.Command.Execute(L.CommandParameter);
            Mul.Command.Execute(Mul.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "D", "result != L");
        }

        [Fact]
        public async void Test4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var L = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var Div = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Div");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            L.Command.Execute(L.CommandParameter);
            Div.Command.Execute(Div.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "V", "result != X");
        }

        [Fact]
        public async void Test5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var Plus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Plus");
            var Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var D = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var C = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            I.Command.Execute(I.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            V.Command.Execute(V.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            C.Command.Execute(C.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);
            D.Command.Execute(D.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test6()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var Div = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Div");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            I.Command.Execute(I.CommandParameter);
            Div.Command.Execute(Div.CommandParameter);
            V.Command.Execute(V.CommandParameter);

            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test7()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var Mul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Mul");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            X.Command.Execute(X.CommandParameter);
            Mul.Command.Execute(Mul.CommandParameter);
            M.Command.Execute(M.CommandParameter);

            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test8()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            X.Command.Execute(X.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);
            M.Command.Execute(M.CommandParameter);

            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test9()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);

            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test10()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            M.Command.Execute(M.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "CMLXXX", "result != CMLXXX");
        }

        [Fact]
        public async void Test11()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var Div = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Div");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            M.Command.Execute(M.CommandParameter);
            Div.Command.Execute(Div.CommandParameter);
            V.Command.Execute(V.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);
            X.Command.Execute(X.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "X", "result != X");
        }

        [Fact]
        public async void Test12()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var Mul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Mul");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            Mul.Command.Execute(Mul.CommandParameter);
            M.Command.Execute(M.CommandParameter);

            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test13()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");

            I.Command.Execute(I.CommandParameter);
            CE.Command.Execute(CE.CommandParameter);

            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            Assert.True(text == "", "result != '");
        }

        [Fact]
        public async void Test14()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var Plus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Plus");
            var Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            I.Command.Execute(I.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            V.Command.Execute(V.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "VI", "result != VI");
        }

        [Fact]
        public async void Test15()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var L = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var Plus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Plus");
            var Sub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var C = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var Result = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            L.Command.Execute(L.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            V.Command.Execute(V.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            C.Command.Execute(C.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);
            Sub.Command.Execute(Sub.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            Result.Command.Execute(Result.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "CXLV", "result != CXLV");
        }
    }
}