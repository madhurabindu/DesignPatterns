using Base.GUIControls;
using System;
using System.Windows.Forms;

namespace Base.Interfaces
{
    public interface IGUIFactory
    {
        ActionButton CreateButton();
        CenteredLabel CreateLabel();
        ImageButton CreateImageButton();
    }
}
