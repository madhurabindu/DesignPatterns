using System;
using System.Windows.Forms;
using Base.GUIControls;
using Base.Interfaces;
using GUIControls.LightTheme;

namespace Factory.GUIControls
{
    public class LightThemeFactory : IGUIFactory
    {
        public ActionButton CreateButton()
        {
            return new LightActionButton();
        }

        public ImageButton CreateImageButton()
        {
            return new LightImageButton();
        }

        public CenteredLabel CreateLabel()
        {
            return new LightCenteredLabel();
        }
    }
}
