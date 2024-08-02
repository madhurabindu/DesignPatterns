using System;
using System.Windows.Forms;
using Base.GUIControls;

namespace GUIControls.LightTheme
{
    public partial class LightImageButton : ImageButton
    {
        public LightImageButton()
        {
            InitializeComponent();
            this.TileButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
    }
}
