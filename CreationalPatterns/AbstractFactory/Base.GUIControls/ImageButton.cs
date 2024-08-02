using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Base.GUIControls
{
    public partial class ImageButton : UserControl
    {
        public ImageButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Caption Text
        /// </summary>
        [Category("Appearance"),
        Description("The Button control"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always)]
        public ActionButton TileButton
        {
            get
            {
                return actionButton1;
            }
            set
            {
                actionButton1 = value;
            }
        }

        /// <summary>
        /// Caption Text
        /// </summary>
        [Category("Appearance"),
        Description("The Image control"),
        Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always)]
        public PictureBox TileImageControl
        {
            get
            {
                return pictureBox1;
            }
            set
            {
                pictureBox1 = value;
            }
        }
    }
}
