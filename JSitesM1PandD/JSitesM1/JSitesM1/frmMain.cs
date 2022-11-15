using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSitesM1
{
    public partial class frmMain : Form
    {
        public static decimal subTotal;
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();

            about.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Form customer = new frmCustomer();

            customer.Show();
        }

        private void btnBlackOps_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Black Ops:");
            lbxCart.Items.Add("$" + 20.00.ToString("F"));

            subTotal = subTotal + 20;
        }

        private void btnBlackOps2_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Black Ops 2:");
            lbxCart.Items.Add("$" + 30.00.ToString("F"));

            subTotal = subTotal + 30;
        }

        private void btnBlackOps3_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Black Ops 3:");
            lbxCart.Items.Add("$" + 40.00.ToString("F"));

            subTotal = subTotal + 40;
        }

        private void btnBorderlands_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Borderlands:");
            lbxCart.Items.Add("$" + 30.50.ToString("F"));

            subTotal = subTotal + 30.50m;
        }

        private void btnBorderlands2_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Borderlands 2:");
            lbxCart.Items.Add("$" + 31.50.ToString("F"));

            subTotal = subTotal + 31.50m;
        }

        private void btnBorderlands3_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Borderlands 3:");
            lbxCart.Items.Add("$" + 32.50.ToString("F"));

            subTotal = subTotal + 32.50m;
        }

        private void btnDishonored_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Dishonored:");
            lbxCart.Items.Add("$" + 20.00.ToString("F"));

            subTotal = subTotal + 20;
        }

        private void btnDishonored2_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Dishonored 2:");
            lbxCart.Items.Add("$" + 25.00.ToString("F"));

            subTotal = subTotal + 25;
        }

        private void btnFallout4_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Fallout 4:");
            lbxCart.Items.Add("$" + 40.00.ToString("F"));

            subTotal = subTotal + 40;
        }

        private void btnFallout76_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Fallout 76:");
            lbxCart.Items.Add("$" + 30.00.ToString("F"));

            subTotal = subTotal + 30;
        }

        private void btnMorrowind_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Morrowind:");
            lbxCart.Items.Add("$" + 10.50.ToString("F"));

            subTotal = subTotal + 10.50m;
        }

        private void btnOblivion_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Oblivion:");
            lbxCart.Items.Add("$" + 20.00.ToString("F"));

            subTotal = subTotal + 20;
        }

        private void btnPrey_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Prey:");
            lbxCart.Items.Add("$" + 21.50.ToString("F"));

            subTotal = subTotal + 21.50m;
        }

        private void btnSeaOfThieves_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Sea of Thieves:");
            lbxCart.Items.Add("$" + 20.00.ToString("F"));

            subTotal = subTotal + 20;
        }

        private void btnShadowOfMordor_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Shadow of Morder:");
            lbxCart.Items.Add("$" + 24.50.ToString("F"));

            subTotal = subTotal + 24.50m;
        }

        private void btnSkyrim_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Skyrim:");
            lbxCart.Items.Add("$" + 30.00.ToString("F"));

            subTotal = subTotal + 30;
        }

        private void btnSpiderman_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Spiderman:");
            lbxCart.Items.Add("$" + 30.00.ToString("F"));

            subTotal = subTotal + 30;
        }

        private void btnTerraria_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("Terraria:");
            lbxCart.Items.Add("$" + 5.00.ToString("F"));

            subTotal = subTotal + 5;
        }

        private void btnTheEvilWithin_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("The Evil Within:");
            lbxCart.Items.Add("$" + 24.00.ToString("F"));

            subTotal = subTotal + 24;
        }

        private void btnTheEvilWithin2_Click(object sender, EventArgs e)
        {
            lbxCart.Items.Add("The Evil Within 2:");
            lbxCart.Items.Add("$" + 28.00.ToString("F"));

            subTotal = subTotal + 28;
        }
    }
}
