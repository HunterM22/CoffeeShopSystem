using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopSystem
{
    public partial class Mainscreen : Form
    {
        public Mainscreen()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MainscreenInsertButton_Click(object sender, EventArgs e)
        {
            if (MainscreenCoffeeNameComboBox.SelectedItem.ToString() == "Latte")
            {
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Frapp")
                {
                    MainscreenPaymentTextBox.Text =
                        (float.Parse(MainscreenQuantityComboBox.Text) * 9).ToString();
                }
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Ice")
                {
                    MainscreenPaymentTextBox.Text =
                        (float.Parse(MainscreenQuantityComboBox.Text) * 7).ToString();
                }
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Hot")
                {
                    MainscreenPaymentTextBox.Text =
                       (float.Parse(MainscreenQuantityComboBox.Text) * 5).ToString();
                }
                Dgv1.Rows.Add(MainscreenIDTextbox.Text, MainscreenCoffeeNameComboBox.Text,
                        MainscreenTypeComboBox.Text, MainscreenPaymentTextBox.Text);

            }

            else if (MainscreenCoffeeNameComboBox.SelectedItem.ToString() == "Cappuccino")
            {
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Frapp")
                {
                    MainscreenPaymentTextBox.Text =
                            (float.Parse(MainscreenQuantityComboBox.Text) * 10).ToString();
                }
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Ice")
                {
                    MainscreenPaymentTextBox.Text =
                            (float.Parse(MainscreenQuantityComboBox.Text) * 8).ToString();
                }
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Hot")
                {
                    MainscreenPaymentTextBox.Text =
                            (float.Parse(MainscreenQuantityComboBox.Text) * 5).ToString();
                }
                Dgv1.Rows.Add(MainscreenIDTextbox.Text, MainscreenCoffeeNameComboBox.Text,
                        MainscreenTypeComboBox.Text, MainscreenPaymentTextBox.Text);
            }

            else MainscreenCoffeeNameComboBox.SelectedItem.ToString() == "Chocolate"
            {
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Frapp")
                {
                    MainscreenPaymentTextBox.Text =
                        (float.Parse(MainscreenQuantityComboBox.Text) * 6).ToString();
                }
                if (MainscreenCoffeeNameComboBox.SelectedItem.ToString() == "Ice")
                {
                    MainscreenPaymentTextBox.Text =
                         (float.Parse(MainscreenQuantityComboBox.Text) * 5).ToString();
                }
                if (MainscreenTypeComboBox.SelectedItem.ToString() == "Hot")
                {
                    MainscreenPaymentTextBox.Text =
                          (float.Parse(MainscreenQuantityComboBox.Text) * 4).ToString();
                }
                Dgv1.Rows.Add(MainscreenIDTextbox.Text, MainscreenCoffeeNameComboBox.Text,
                    MainscreenTypeComboBox.Text, MainscreenPaymentTextBox.Text);
            }

        }
   

        private void MainscreenIDTextbox_TextChanged(object sender, EventArgs e)
        {
            //do not use
        }

        private void MainscreenIDTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void MainscreenExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainscreenClearButton_Click(object sender, EventArgs e)
        {
            MainscreenIDTextbox.Text = "";
            MainscreenCoffeeNameComboBox.Text = "";
            MainscreenTypeComboBox.Text = "";
            MainscreenQuantityComboBox.Text = "";
            MainscreenPaymentTextBox.Text = "";

        }
    }
}
