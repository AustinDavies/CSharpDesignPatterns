using AbstractFactoryPatternExample.Components;

namespace AbstractFactoryPatternExample.Factories
{
    public abstract class ComponentThemeFactory
    {
        public abstract Textbox GetTextbox();
        public abstract Sheet GetSheet(); 
    }
}
