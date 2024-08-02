using System;
using Base.GUIControls;
using Base.Interfaces;

namespace Factory.GUIControls
{
    public class GuiControlFactory 
    {
        private IGUIFactory lightFactory;
        private IGUIFactory darkFactory;

        public GuiControlFactory()
        {
            lightFactory = new LightThemeFactory();
            darkFactory = new DarkThemeFactory();
        }

        public IGUIFactory GetFactory(string theme)
        {

            IGUIFactory factory = null;
            if (string.Compare(theme, GUIConstants.lightTheme) == 0)
            { 
                factory = lightFactory; 
            }
            else if (string.Compare(theme, GUIConstants.darkTheme) == 0)
            { 
                factory = darkFactory; 
            }
            else { }

            return factory;
        }

       
    }
}
