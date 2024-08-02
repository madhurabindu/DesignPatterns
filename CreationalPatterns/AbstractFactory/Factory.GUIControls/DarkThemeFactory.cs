using System;
using Base.GUIControls;
using Base.Interfaces;
using GUIControls.DarkTheme;

namespace Factory.GUIControls
{
    public class DarkThemeFactory : IGUIFactory
    {
        public ActionButton CreateButton()
        {
            return new DarkActionButton();
        }

        public ImageButton CreateImageButton()
        {
            return new DarkImageButton();
        }

        public CenteredLabel CreateLabel()
        {
            return new DarkCenteredLabel();
        }
    }
}
