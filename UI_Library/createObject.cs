using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Library
{
    public partial class createObject : Form
    {
        public createObject()
        {
            InitializeComponent();
        }

        

        public void on_click_disabled(System.Windows.Forms.Button but)
        {
            butColor.Enabled = false;
            butForm.Enabled = false;
            butMaterial.Enabled = false;
            butMeasurement.Enabled = false;
            but.Enabled = true;

        }

        private void butForm_Click(object sender, EventArgs e)
        {
            on_click_disabled(butForm);

            pctBoxCarre.Enabled = true;
            pctBoxCarre.Visible = true;

            pctBoxTriangle.Enabled = true;
            pctBoxTriangle.Visible = true;

            pctBoxHexagone.Enabled = true;
            pctBoxHexagone.Visible = true;

            pctBoxPentagone.Enabled = true;
            pctBoxPentagone.Visible = true;

            pctBoxCercle.Enabled = true;
            pctBoxCercle.Visible = true;

            pctBoxShuriken.Enabled = true;
            pctBoxShuriken.Visible = true;

            butCancel.Visible = true;
            butOk.Visible = true;

        }

        private void pctBoxCarre_Click(object sender, EventArgs e)
        {
            pctBoxCreate.BackgroundImage = Properties.Resources.carréx600;
        }

        private void pctBoxTriangle_Click_1(object sender, EventArgs e)
        {
            pctBoxCreate.BackgroundImage = Properties.Resources.tringlex600;

        }

        private void pctBoxHexagone_Click_1(object sender, EventArgs e)
        {
            pctBoxCreate.BackgroundImage = Properties.Resources.hexagonex600;

        }

        private void pctBoxPentagone_Click_1(object sender, EventArgs e)
        {
            pctBoxCreate.BackgroundImage = Properties.Resources.pentagonex600;

        }

        private void pctBoxCercle_Click_1(object sender, EventArgs e)
        {
            pctBoxCreate.BackgroundImage = Properties.Resources.cerclex600;

        }
        private void pctBoxShuriken_Click_1(object sender, EventArgs e)
        {
            pctBoxCreate.BackgroundImage = Properties.Resources.shurikenx600;
        }

        private void butMaterial_Click(object sender, EventArgs e)
        {
            on_click_disabled(butMaterial);

            cmBoxMaterial.Enabled = true;
            cmBoxMaterial.Visible = true;

            butCancel.Visible = true;
            butOk.Visible = true;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            butForm.Enabled = true;
            butColor.Enabled = true;
            butMaterial.Enabled = true;
            butMeasurement.Enabled = true;

            pctBoxCarre.Enabled = false;
            pctBoxCarre.Visible = false;

            pctBoxTriangle.Enabled = false;
            pctBoxTriangle.Visible = false;

            pctBoxHexagone.Enabled = false;
            pctBoxHexagone.Visible = false;

            pctBoxPentagone.Enabled = false;
            pctBoxPentagone.Visible = false;

            pctBoxCercle.Enabled = false;
            pctBoxCercle.Visible = false;

            pctBoxShuriken.Enabled = false;
            pctBoxShuriken.Visible = false;

            cmBoxMaterial.Enabled = false;
            cmBoxMaterial.Visible = false;

            lblX.Visible = false;
            lblY.Visible = false;
            lblZ.Visible = false;

            txtBoxX.Visible = false;
            txtBoxY.Visible = false;
            txtBoxZ.Visible = false;

            arrowDown.Visible = false;
            arrowUp.Visible = false;

            checkedListBoxPoints.Visible = false;

            addButton.Visible = false;

            butOk.Visible = false;
            butCancel.Visible = false;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            butForm.Enabled = true;
            butColor.Enabled = true;
            butMaterial.Enabled = true;
            butMeasurement.Enabled = true;

            pctBoxCarre.Enabled = false;
            pctBoxCarre.Visible = false;

            pctBoxTriangle.Enabled = false;
            pctBoxTriangle.Visible = false;

            pctBoxHexagone.Enabled = false;
            pctBoxHexagone.Visible = false;

            pctBoxPentagone.Enabled = false;
            pctBoxPentagone.Visible = false;

            pctBoxCercle.Enabled = false;
            pctBoxCercle.Visible = false;

            pctBoxShuriken.Enabled = false;
            pctBoxShuriken.Visible = false;

            cmBoxMaterial.Enabled = false;
            cmBoxMaterial.Visible = false;

            lblX.Visible = false;
            lblY.Visible = false;
            lblZ.Visible = false;

            txtBoxX.Visible = false;
            txtBoxY.Visible = false;
            txtBoxZ.Visible = false;

            arrowDown.Visible = false;
            arrowUp.Visible = false;

            checkedListBoxPoints.Visible = false;

            addButton.Visible = false;

            butOk.Visible = false;
            butCancel.Visible = false;
        }

        private void butMeasurement_Click(object sender, EventArgs e)
        {
            on_click_disabled(butMeasurement);

            lblX.Visible = true;
            lblY.Visible = true;
            lblZ.Visible = true;

            txtBoxX.Visible = true;
            txtBoxY.Visible = true;
            txtBoxZ.Visible = true;

            arrowDown.Visible = true;
            arrowUp.Visible = true;

            checkedListBoxPoints.Visible = true;

            addButton.Visible = true;

            butOk.Visible = true;
            butCancel.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            float X, Y, Z;
            try
            {
                X = float.Parse(lblX.Text);
                lblX.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                lblX.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
