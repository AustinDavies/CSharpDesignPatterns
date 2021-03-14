using AbstractFactoryPatternExample.Factories;
using System;

namespace AbstractFactoryPatternExample
{
    class Program
    {
        public static int Theme = 1;
        static void Main(string[] args)
        {
            ComponentThemeFactory uiFactory = null;

            if (Theme == 0)
                uiFactory = new LightThemeUIFactory();
            else
                uiFactory = new DarkThemeUIFactory();

            var textbox = uiFactory.GetTextbox();
            var sheet = uiFactory.GetSheet();

            Console.WriteLine($"Theme = {Theme} --> Textbox: {textbox.GetType().Name} | Sheet: {sheet.GetType().Name}");
        }
    }
}
