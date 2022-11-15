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
    public partial class frmCustomer : Form
    {
        public static string name;
        public static string address;
        public static string state;
        public static string zip;
        public static string phone;
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            string[] states = new string[] { "AL", "AK", "AS", "AZ",
                "AR", "CA", "CO", "CT", "DE", "DC", "FM", "FL", "GA",
                "GU", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA",
                "ME", "MH", "MD", "MA", "MI", "MN", "MS", "MO", "MT",
                "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "MP",
                "OH", "OK", "OR", "PW", "PA", "PR", "RI", "SC", "SD",
                "TN", "TX", "UT", "VT", "VI", "VA", "WA", "WV", "WI", "WY" };

            foreach (var state in states)
            {
                cbxState.Items.Add(state);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            name = tbxName.Text;
            address = tbxAddress.Text;
            state = cbxState.Text;
            zip = tbxZip.Text;
            phone = mtxPhone.Text;
            int zipResult;

            // Validate name
            if (name == "")
            {
                MessageBox.Show("Name cannot be blank.");
                return;
            }
            // Validate address
            if (address == "")
            {
                MessageBox.Show("Address cannot be blank.");
                return;
            }
            // Validate state
            if (cbxState.SelectedIndex < 0)
            {
                MessageBox.Show("State must be selected.");
                return;
            }
            // Validate zip
            if (zip.Length != 5 || !int.TryParse(zip, out zipResult))
            {
                MessageBox.Show("ZIP must be five digits.");
                return;
            }
            if (zipResult < 0)
            {
                MessageBox.Show("ZIP must be five digits.");
                return;
            }
            // Validate phone
            if (!mtxPhone.MaskCompleted)
            {
                MessageBox.Show("Phone is incomplete.");
                return;
            }

            Form receipt = new frmReceipt();

            receipt.Show();
        }
    }
}
