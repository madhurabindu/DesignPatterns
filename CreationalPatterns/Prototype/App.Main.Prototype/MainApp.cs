using Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Main.Prototype
{
    public partial class MainApp : Form
    {
        private LetterGenerator lGen;
        private ILetter currentDetails;
        public MainApp()
        {
            InitializeComponent();
            lGen = new LetterGenerator();
        }

        private void OnGenerateButtonClicked(object sender, EventArgs e)
        {
            FillLetterDetailsFromUI();
            webBrowser1.DocumentText = lGen.GenerateLeter(currentDetails);
        }

       

        private void OnLetterTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            int item = cmbBoxType.SelectedIndex;
            currentDetails = lGen.GetLetterForType((string)cmbBoxType.SelectedItem);
            switch (item)
            {
                case 0:
                case 1:
                    DisplayDefaultLetter();
                    break;
                default:
                    DisplayTBD();
                    break;
            }
        }

        private void DisplayDefaultLetter()
        {
            FillLetterDetailsFromUI();
            webBrowser1.DocumentText = currentDetails.HTMLTemplate;
        }

        private void DisplayTBD()
        {
            webBrowser1.DocumentText = "TBD";
        }

        private ILetter FillLetterDetailsFromUI()
        {
            currentDetails.Date = DateTime.Today.ToShortDateString();
            currentDetails.FromName = txtFromName.Text;
            currentDetails.FromAddress = new string[] { txtFromAddr1.Text, txtFromAddr2.Text, txtFromAddr3.Text };
            currentDetails.ToName = txtToName.Text;
            currentDetails.ToAddress = new string[] { txtToAddr1.Text, txtToAddr2.Text, txtToAddr3.Text};
            currentDetails.ToGender = (string)listBoxGender.SelectedItem;
            return currentDetails;
        }
    }
}
