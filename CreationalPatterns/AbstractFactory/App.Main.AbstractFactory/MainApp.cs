using System;
using System.Drawing;
using System.Windows.Forms;
using Base.GUIControls;
using Base.Interfaces;
using Factory.GUIControls;

namespace App.Main.AbstractFactory
{
    public partial class MainApp : Form
    {
        GuiControlFactory controlFactory;
        public MainApp()
        {
            InitializeComponent();
            controlFactory = new GuiControlFactory();

        }

        private void OnApplyButtonClicked(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            CreateSampleUI();
        }

        private void CreateSampleUI()
        {
            string theme = ((string)cmbBoxTheme.SelectedItem);
            if (!string.IsNullOrEmpty(theme))
            {
                IGUIFactory factory = controlFactory.GetFactory(theme.ToLower());
                if (factory != null)
                {
                    CreateActionButton(0, factory);

                    CreateLabel(1, factory);

                    CreateImageButton(2, factory);
                }
            }
        }

        private void CreateActionButton(int displayOrder, IGUIFactory factory)
        {
            ActionButton btn = factory.CreateButton();
            btn.Location = new Point(60, 10 + 100* displayOrder);
            btn.Text = "Theme Button";
            panelDisplay.Controls.Add(btn);
        }

        private void CreateLabel(int displayOrder, IGUIFactory factory)
        {
            CenteredLabel btn = factory.CreateLabel();
            btn.Location = new Point(60, 10 + 100 * displayOrder);
            btn.Text = "Theme Label";
            panelDisplay.Controls.Add(btn);
        }

        private void CreateImageButton(int displayOrder, IGUIFactory factory)
        {
            ImageButton btn = factory.CreateImageButton();
            btn.Location = new Point(60, 10 + 100 * displayOrder);
            btn.TileButton.Text = "Img Button";
            panelDisplay.Controls.Add(btn);
        }




    }
}
