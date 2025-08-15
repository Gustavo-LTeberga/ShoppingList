using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if(txbProduct.Text.Length == 0) {
                txbProduct.BackColor = Color.DarkRed;
                txbProduct.ForeColor = Color.Salmon;
                MessageBox.Show("The product name cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbProduct.Text.Length < 2) {
                txbProduct.BackColor = Color.DarkRed;
                txbProduct.ForeColor = Color.Salmon;
                MessageBox.Show("It is not possible to place a component with a single letter!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (!libShopping.Items.Contains(txbProduct.Text)) {
                    libShopping.Items.Add(txbProduct.Text);
                    txbProduct.BackColor = Color.White;
                    txbProduct.ForeColor = Color.Black;
                    MessageBox.Show($"{txbProduct.Text} It has been added to the list!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbProduct.Text = "";
                }
                else {
                    txbProduct.BackColor = Color.DarkRed;
                    txbProduct.ForeColor = Color.Salmon;
                    MessageBox.Show($"There is already {txbProduct.Text} in the list!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e) {
            DialogResult Answer = MessageBox.Show("Are you sure you want to delete everything?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Answer == DialogResult.Yes) {
                libShopping.Items.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (libShopping.SelectedIndex == -1) {
                MessageBox.Show($"Select an item to remove!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string varSave = libShopping.SelectedItem.ToString(); //"Saving the name of the item to be removed."
                libShopping.Items.RemoveAt(libShopping.SelectedIndex);
                MessageBox.Show($"The {varSave} was successfully removed from the list.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Add by pressing the Enter key.
        private void txbProduct_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnAdd.PerformClick();
            }
        }
    }
}
