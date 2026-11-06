using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Cafe_Order1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           string name = textCustomerName.Text;
            int quantity;

            if (string.IsNullOrWhiteSpace(name) ||
                !name.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Enter a valid name using letters only");
                return;
            }

            if (!int.TryParse(textQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Enter valid quantity");
                return;
            }

            string drink = "";

            if (rdoTea.Checked)
            {
                drink = "Tea";
            }
            else if (rdoCoffee.Checked)
            {
                drink = "Coffee";
            }
            else if (rdoJuice.Checked)
            {
                drink = "Juice";
            }
            else
            {
                MessageBox.Show("Select a drink");
                return;
            }

            double price = 0;

            switch (drink)
            {
                case "Tea":
                    price = 1;
                    break;

                case "Coffee":
                    price = 2;
                    break;

                case "Juice":
                    price = 3;
                    break;
            }

            lstOrderList.Items.Clear();

            bool prize = false;

            for (int i = 1; i <= quantity; i++)
            {
                int lucky = r.Next(1, 51);

                if (lucky == 7 || lucky == 17)
                {
                    prize = true;
                }

                lstOrderList.Items.Add(i + ") " + name +
                    " - " + drink +
                    " - Lucky: " + lucky +
                    " - $" + price.ToString("0.00"));
            }

            double total = price * quantity;

            if (chkStudentMember.Checked)
            {
                total = total - (total * 0.10);
            }

            lblTotalPrice.Text = "Total Price: $" + total.ToString("0.00");

            if (prize == true)
            {
                lblLuckyMessage.Text = "You got a Free Cookie!";
            }
            else
            {
                lblLuckyMessage.Text = "No prize this time.";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (lstOrderList.Items.Count == 0)
            {
                MessageBox.Show("No order to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter sw = File.AppendText("orders.txt"))
                {
                    foreach (var item in lstOrderList.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("-----------------------------------");
                }

                MessageBox.Show("Order saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("orders.txt"))
            {
                MessageBox.Show("No file found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                lstOrderList.Items.Clear();

                using (StreamReader sr = File.OpenText("orders.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lstOrderList.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textCustomerName.Clear();
            textQuantity.Clear();
            rdoTea.Checked = false;
            rdoCoffee.Checked = false;
            rdoJuice.Checked = false;
            chkStudentMember.Checked = false;
            lstOrderList.Items.Clear();
            lblTotalPrice.Text = "Total Price: $0.00";
            lblLuckyMessage.Text = "Lucky Message: ";
            textCustomerName.Focus();

        }
    }
}
