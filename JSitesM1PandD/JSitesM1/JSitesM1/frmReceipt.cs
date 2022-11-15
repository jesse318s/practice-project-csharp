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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }
        private void frmReceipt_Load(object sender, EventArgs e)
        {
            decimal tip = (frmMain.subTotal + (frmMain.subTotal * 0.0825m)) * 0.15m;

            lbxReceipt.Items.Add("Name: " + frmCustomer.name);
            lbxReceipt.Items.Add("Address: " + frmCustomer.address);
            lbxReceipt.Items.Add("State: " + frmCustomer.state);
            lbxReceipt.Items.Add("ZIP: " + frmCustomer.zip);
            lbxReceipt.Items.Add("Phone: " + frmCustomer.phone);
            lbxReceipt.Items.Add("Subtotal: $" + frmMain.subTotal.ToString("F"));
            lbxReceipt.Items.Add("Tax: $" + (frmMain.subTotal * 0.0825m).ToString("F"));
            lbxReceipt.Items.Add("Delivery Charge: $" + (frmMain.subTotal * 0.06m).ToString("F"));
            lbxReceipt.Items.Add("Tip: $" + tip.ToString("F"));
            lbxReceipt.Items.Add("Total Amount Due: $" + ((frmMain.subTotal + (frmMain.subTotal * 0.1425m)) + tip).ToString("F"));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdo15_CheckedChanged(object sender, EventArgs e)
        {
            decimal tip = (frmMain.subTotal + (frmMain.subTotal * 0.0825m)) * 0.15m;

            lbxReceipt.Items.Clear();
            lbxReceipt.Items.Add("Name: " + frmCustomer.name);
            lbxReceipt.Items.Add("Address: " + frmCustomer.address);
            lbxReceipt.Items.Add("State: " + frmCustomer.state);
            lbxReceipt.Items.Add("ZIP: " + frmCustomer.zip);
            lbxReceipt.Items.Add("Phone: " + frmCustomer.phone);
            lbxReceipt.Items.Add("Subtotal: $" + frmMain.subTotal.ToString("F"));
            lbxReceipt.Items.Add("Tax: $" + (frmMain.subTotal * 0.0825m).ToString("F"));
            lbxReceipt.Items.Add("Delivery Charge: $" + (frmMain.subTotal * 0.06m).ToString("F"));
            lbxReceipt.Items.Add("Tip: $" + tip.ToString("F"));
            lbxReceipt.Items.Add("Total Amount Due: $" + ((frmMain.subTotal + (frmMain.subTotal * 0.1425m)) + tip).ToString("F"));
        }

        private void rdo20_CheckedChanged(object sender, EventArgs e)
        {
            decimal tip = (frmMain.subTotal + (frmMain.subTotal * 0.0825m)) * 0.20m;

            lbxReceipt.Items.Clear();
            lbxReceipt.Items.Add("Name: " + frmCustomer.name);
            lbxReceipt.Items.Add("Address: " + frmCustomer.address);
            lbxReceipt.Items.Add("State: " + frmCustomer.state);
            lbxReceipt.Items.Add("ZIP: " + frmCustomer.zip);
            lbxReceipt.Items.Add("Phone: " + frmCustomer.phone);
            lbxReceipt.Items.Add("Subtotal: $" + frmMain.subTotal.ToString("F"));
            lbxReceipt.Items.Add("Tax: $" + (frmMain.subTotal * 0.0825m).ToString("F"));
            lbxReceipt.Items.Add("Delivery Charge: $" + (frmMain.subTotal * 0.06m).ToString("F"));
            lbxReceipt.Items.Add("Tip: $" + tip.ToString("F"));
            lbxReceipt.Items.Add("Total Amount Due: $" + ((frmMain.subTotal + (frmMain.subTotal * 0.1425m)) + tip).ToString("F"));
        }

        private void rdo25_CheckedChanged(object sender, EventArgs e)
        {
            decimal tip = (frmMain.subTotal + (frmMain.subTotal * 0.0825m)) * 0.25m;

            lbxReceipt.Items.Clear();
            lbxReceipt.Items.Add("Name: " + frmCustomer.name);
            lbxReceipt.Items.Add("Address: " + frmCustomer.address);
            lbxReceipt.Items.Add("State: " + frmCustomer.state);
            lbxReceipt.Items.Add("ZIP: " + frmCustomer.zip);
            lbxReceipt.Items.Add("Phone: " + frmCustomer.phone);
            lbxReceipt.Items.Add("Subtotal: $" + frmMain.subTotal.ToString("F"));
            lbxReceipt.Items.Add("Tax: $" + (frmMain.subTotal * 0.0825m).ToString("F"));
            lbxReceipt.Items.Add("Delivery Charge: $" + (frmMain.subTotal * 0.06m).ToString("F"));
            lbxReceipt.Items.Add("Tip: $" + tip.ToString("F"));
            lbxReceipt.Items.Add("Total Amount Due: $" + ((frmMain.subTotal + (frmMain.subTotal * 0.1425m)) + tip).ToString("F"));
        }
    }
}
