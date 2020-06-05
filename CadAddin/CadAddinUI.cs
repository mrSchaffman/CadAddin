using System;
using System.Collections;
using System.Windows.Forms;

namespace CadAddin
{
    public partial class CadAddinUI : Form
    {
        public CadAddinUI()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            string choice = "";

            // Get Things from ComboBox

            choice = cboOptions.SelectedIndex.ToString();

            // Get Item from MessageBox
            //choice = txtItemDisplay.Text.Trim();

            DisplayItems(choice);

        }


        public void DisplayItems(string choice)
        {
            ControlCadUtil cutil = new ControlCadUtil();
            if (choice == "1")
            {
                ArrayList layer = cutil.GetLayers();
                lstLayer.DataSource = layer;
                lstLineType.DataSource = null; //rien de sera affichee sur le Gui a ce niveau!
                lstTextStyle.DataSource = null;

                lblLayerCount.Text = "Layers Count: " + layer.Count;
            }
            else if (choice == "2")
            {

                ArrayList lines = cutil.GetLineTypes();
                lstLayer.DataSource = null;
                lstLineType.DataSource = lines;
                lstTextStyle.DataSource = null;
                lblLineTypeCount.Text = "Linetypes Count: " + lines.Count;
            }
            else if (choice == "3")
            {

                ArrayList textStyle = cutil.GetTextStyles();
                lstLayer.DataSource = null;
                lstLineType.DataSource = null;
                lstTextStyle.DataSource = textStyle;
                lblTextStyleCount.Text = "textstyles Count: " + textStyle.Count;
            }
            else if (choice == "0")
            {
                // je speichern mes resultats dans des Arraylist
                ArrayList textStyle = cutil.GetTextStyles();
                ArrayList layer = cutil.GetLayers();
                ArrayList lines = cutil.GetLineTypes();

                lstLayer.DataSource = layer;
                lstLineType.DataSource = lines ;   // je voudrais afficher en forme "1-traie "
                lstTextStyle.DataSource = textStyle;

                lblLayerCount.Text = "Layers Count: " + layer.Count;
                lblLineTypeCount.Text = "Linetypes Count: " + lines.Count;
                lblTextStyleCount.Text = "textstyles Count: " + textStyle.Count;
            }
            else
            {
                MessageBox.Show("Please enter a valid value: ", "Invalide Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            lstLayer.DataSource = null;
            lstLineType.DataSource = null;
            lstTextStyle.DataSource = null;
        }
    }
}
