using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtCapp.Text = "0";
            txtCarlton.Text = "0";
            txtCoffee.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCapp.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilburn.Text = "0";
            txtLagos.Text = "0";
            txtLate.Text = "0";
            txtRed.Text = "0";
            txtVale.Text = "0";
            lblCake.Text = "0";
            lblDrink.Text = "0";
            lblCharge.Text = "1,75";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            chkAfrican.Checked = false;
            chkBlack.Checked = false;
            chkBoston.Checked = false;
            chkCappuccino.Checked = false;
            chkCarlton.Checked = false;
            chkCoffee.Checked = false;
            chkEspresso.Checked = false;
            chkIcedCap.Checked = false;
            chkIcedLatte.Checked = false;
            chkKilburn.Checked = false;
            chkLagos.Checked = false;
            chkLatte.Checked = false;
            chkRedValvet.Checked = false;
            chkVale.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            Timer1.Start();

            txtAfrican.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtCapp.Text = "0";
            txtCarlton.Text = "0";
            txtCoffee.Text = "0";
            txtEspresso.Text = "0";
            txtIcedCapp.Text = "0";
            txtIcedLatte.Text = "0";
            txtKilburn.Text = "0";
            txtLagos.Text = "0";
            txtLate.Text = "0";
            txtRed.Text = "0";
            txtVale.Text = "0";
            lblCake.Text = "0";
            lblDrink.Text = "0";
            lblCharge.Text = "1,75";

            txtLate.Enabled = false;
            txtEspresso.Enabled = false;
            txtAfrican.Enabled = false;
            txtBlack.Enabled = false;
            txtBoston.Enabled = false;
            txtCapp.Enabled = false;
            txtCarlton.Enabled = false;
            txtCoffee.Enabled = false;
            txtIcedCapp.Enabled = false;
            txtIcedLatte.Enabled = false;
            txtKilburn.Enabled = false;
            txtLagos.Enabled = false;
            txtRed.Enabled = false;
            txtVale.Enabled = false;

            chkAfrican.Checked = false;
            chkBlack.Checked = false;
            chkBoston.Checked = false;
            chkCappuccino.Checked = false;
            chkCarlton.Checked = false;
            chkCoffee.Checked = false;
            chkEspresso.Checked = false;
            chkIcedCap.Checked = false;
            chkIcedLatte.Checked = false;
            chkKilburn.Checked = false;
            chkLagos.Checked = false;
            chkLatte.Checked = false;
            chkRedValvet.Checked = false;
            chkVale.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLate.Enabled = true;
            }
            if (chkLatte.Checked == false)
            {
                txtLate.Enabled = false;
                txtLate.Text = "0";
            }
        }

        private void txtLate_Click(object sender, EventArgs e)
        {
            txtLate.Text = "";
            txtLate.Focus();
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
            }
            if (chkEspresso.Checked == false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void chkIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == true)
            {
                txtIcedLatte.Enabled = true;
            }
            if (chkIcedLatte.Checked == false)
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "";
            txtIcedLatte.Focus();
        }

        private void chkVale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVale.Checked == true)
            {
                txtVale.Enabled = true;
            }
            if (chkVale.Checked == false)
            {
                txtVale.Enabled = false;
                txtVale.Text = "0";
            }
        }

        private void txtVale_Click(object sender, EventArgs e)
        {
            txtVale.Text = "";
            txtVale.Focus();
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCapp.Enabled = true;
            }
            if (chkCappuccino.Checked == false)
            {
                txtCapp.Enabled = false;
                txtCapp.Text = "0";
            }
        }

        private void txtCapp_Click(object sender, EventArgs e)
        {
            txtCapp.Text = "";
            txtCapp.Focus();
        }

        private void chkAfrican_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfrican.Checked == true)
            {
                txtAfrican.Enabled = true;
            }
            if (chkAfrican.Checked == false)
            {
                txtAfrican.Enabled = false;
                txtAfrican.Text = "0";
            }
        }

        private void txtAfrican_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "";
            txtAfrican.Focus();
        }

        private void chkIcedCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedCap.Checked == true)
            {
                txtIcedCapp.Enabled = true;
            }
            if (chkIcedCap.Checked == false)
            {
                txtIcedCapp.Enabled = false;
                txtIcedCapp.Text = "0";
            }
        }

        private void txtIcedCapp_Click(object sender, EventArgs e)
        {
            txtIcedCapp.Text = "";
            txtIcedCapp.Focus();
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {
                txtCoffee.Enabled = true;
            }
            if (chkCoffee.Checked == false)
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void txtCoffee_Click(object sender, EventArgs e)
        {
            txtCoffee.Text = "";
            txtCoffee.Focus();
        }

        private void chkRedValvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvet.Checked == true)
            {
                txtRed.Enabled = true;
            }
            if (chkRedValvet.Checked == false)
            {
                txtRed.Enabled = false;
                txtRed.Text = "0";
            }
        }

        private void txtRed_Click(object sender, EventArgs e)
        {
            txtRed.Text = "";
            txtRed.Focus();
        }

        private void chkBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlack.Checked == true)
            {
                txtBlack.Enabled = true;
            }
            if (chkBlack.Checked == false)
            {
                txtBlack.Enabled = false;
                txtBlack.Text = "0";
            }
        }

        private void txtBlack_Click(object sender, EventArgs e)
        {
            txtBlack.Text = "";
            txtBlack.Focus();
        }

        private void chkBoston_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoston.Checked == true)
            {
                txtBoston.Enabled = true;
            }
            if (chkBoston.Checked == false)
            {
                txtBoston.Enabled = false;
                txtBoston.Text = "0";
            }
        }

        private void txtBoston_Click(object sender, EventArgs e)
        {
            txtBoston.Text = "";
            txtBoston.Focus();
        }

        private void chkLagos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagos.Checked == true)
            {
                txtLagos.Enabled = true;
            }
            if (chkLagos.Checked == false)
            {
                txtLagos.Enabled = false;
                txtLagos.Text = "0";
            }
        }

        private void txtLagos_Click(object sender, EventArgs e)
        {
            txtLagos.Text = "";
            txtLagos.Focus();
        }

        private void chkKilburn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilburn.Checked == true)
            {
                txtKilburn.Enabled = true;
            }
            if (chkKilburn.Checked == false)
            {
                txtKilburn.Enabled = false;
                txtKilburn.Text = "0";
            }
        }

        private void txtKilburn_Click(object sender, EventArgs e)
        {
            txtKilburn.Text = "";
            txtKilburn.Focus();
        }

        private void chkCarlton_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarlton.Checked == true)
            {
                txtCarlton.Enabled = true;
            }
            if (chkCarlton.Checked == false)
            {
                txtCarlton.Enabled = false;
                txtCarlton.Text = "0";
            }
        }

        private void txtCarlton_Click(object sender, EventArgs e)
        {
            txtCarlton.Text = "";
            txtCarlton.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Just Do Cafe " + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte \t\t\t\t\t\t" + txtLate.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Vale Coffee \t\t\t\t" + txtVale.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappuccino \t\t\t\t" + txtCapp.Text + Environment.NewLine);
            rtfReceipt.AppendText("African Coffee \t\t\t\t" + txtAfrican.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Cappuccino \t\t\t\t" + txtIcedCapp.Text + Environment.NewLine);
            rtfReceipt.AppendText("Coffee Cake \t\t\t\t" + txtCoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Velvet Cake \t\t\t\t" + txtRed.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest Cake \t\t\t" + txtBlack.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cream Cake \t\t\t" + txtBoston.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Chocolate Cake \t\t\t" + txtLagos.Text + Environment.NewLine);
            rtfReceipt.AppendText("Kilburn Chocolate Cake \t\t" + txtKilburn.Text + Environment.NewLine);
            rtfReceipt.AppendText("Carlton HIll Chocolate Cake \t\t" + txtCarlton.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total Cost \t\t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "\t" + lblDate.Text);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 0.45;
            double latte, ilatte, espresso, capp, iCapp, aCoffee, vale;
            double cCake, red, black, boston, lagos, kilburn, carlton;

            latte = 1.20; ilatte = 1.29; espresso = 1.95; capp = 1.15; iCapp = 1.70; aCoffee = 1.15; vale = 1.30;            
            //Coffee

            double latte_Coff = Convert.ToDouble(txtLate.Text);
            double espress = Convert.ToDouble(txtEspresso.Text);
            double IcedLatte = Convert.ToDouble(txtIcedLatte.Text);
            double vale_Coff = Convert.ToDouble(txtVale.Text);
            double Afri_Coff = Convert.ToDouble(txtAfrican.Text);
            double Capp_Coff = Convert.ToDouble(txtCapp.Text);
            double iCapp_Coff = Convert.ToDouble(txtIcedCapp.Text);
            //Cakes
            cCake = 1.15; red = 1.25; black = 1.35; boston = 1.70; lagos = 1.50; kilburn = 1.90; carlton = 1.40;
            double c_Cakes = Convert.ToDouble(txtCoffee.Text);
            double vl_Cakes = Convert.ToDouble(txtRed.Text);
            double bF_Cakes = Convert.ToDouble(txtBlack.Text);
            double cB_Cakes = Convert.ToDouble(txtBoston.Text);
            double cL_Cakes = Convert.ToDouble(txtLagos.Text);
            double cC_Cakes = Convert.ToDouble(txtCarlton.Text);
            double cK_Cakes = Convert.ToDouble(txtKilburn.Text);

            Coffee eat_in_Coffee = new Coffee(latte_Coff, espress, IcedLatte, vale_Coff, Afri_Coff, Capp_Coff,
            iCapp_Coff, c_Cakes, vl_Cakes, bF_Cakes, cB_Cakes, cL_Cakes, cC_Cakes, cK_Cakes);

            double cost_of_drinks = (latte_Coff * latte) + (espress * espresso) + (IcedLatte * ilatte) + (vale_Coff * vale)
                + (Afri_Coff * aCoffee) + (Capp_Coff * capp) + (iCapp_Coff * iCapp);
            lblDrink.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cakes = (c_Cakes * cCake) + (vl_Cakes * red) + (bF_Cakes * black) + (cB_Cakes * boston)
                + (cL_Cakes * lagos) + (cC_Cakes * carlton) + (cK_Cakes * kilburn);
            lblCake.Text = Convert.ToString(cost_of_cakes);

            double sevice_charge = Convert.ToDouble(lblCharge.Text);

            lblSubTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + sevice_charge);
            lblTax.Text = Convert.ToString(((cost_of_cakes + cost_of_drinks + sevice_charge) * tax) / 100);
            double iTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + iTax + sevice_charge);

            lblCake.Text = String.Format("{0:C}", cost_of_cakes);
            lblDrink.Text = String.Format("{0:C}", cost_of_drinks);
            lblCharge.Text = String.Format("{0:C}", sevice_charge);
            lblSubTotal.Text = String.Format("{0:C}", (cost_of_cakes + cost_of_drinks + sevice_charge));
            lblTax.Text = String.Format("{0:C}", iTax);
            lblTotal.Text = String.Format("{0:C}", (cost_of_cakes + cost_of_drinks + sevice_charge + iTax));
        }

    }
}
