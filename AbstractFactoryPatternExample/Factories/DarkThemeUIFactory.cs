using AbstractFactoryPatternExample.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPatternExample.Factories
{
    public class DarkThemeUIFactory : ComponentThemeFactory
    {
        public override Sheet GetSheet()
        {
            return new DarkSheet();
        }

        public override Textbox GetTextbox()
        {
            return new DarkTextbox();
        }
    }
}
