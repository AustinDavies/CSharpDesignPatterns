using AbstractFactoryPatternExample.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPatternExample.Factories
{
    public class LightThemeUIFactory : ComponentThemeFactory
    {
        public override Sheet GetSheet()
        {
            return new LightSheet();
        }

        public override Textbox GetTextbox()
        {
            return new LightTextbox();
        }
    }
}
