using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddProductForm : Form
    {
        // Product ID variable
        private static int lastID = 0;

        // Holds parts until they are ready to be added to the Product's associatedParts list
        private BindingList<Part> associatedPartsQueue = new BindingList<Part>();


        public AddProductForm()
        {
            InitializeComponent();

            // All Parts DGV Source
            AddProductScreenAllPartsDGV.DataSource = MainInventory.Inventory.AllParts;

            // Associated Parts DGV Source
            AddProductScreenAssociatedPartsDGV.DataSource = associatedPartsQueue;

            // Product ID Generation
            AddProductScreenIDTextBox.Text = Convert.ToString(++lastID);
        }

        private void AddProductScreenSaveButton_Click(object sender, EventArgs e)
        {
            var newProduct = new Product();

            // ID
            newProduct.ProductID = lastID;

            // Name
            if (AddProductScreenNameTextBox.Text == "")
            {
                MessageBox.Show("A Part name must be entered.");
                return;
            }
            else
            {
                newProduct.Name = AddProductScreenNameTextBox.Text;
            }
            // Inventory
            if (isInt(AddProductScreenInventoryTextBox.Text))
                newProduct.InStock = Convert.ToInt32(AddProductScreenInventoryTextBox.Text);
            else
            {
                MessageBox.Show("A valid Inventory value must be entered.");
                return;
            }

            // Price / Cost
            if (isDecimal(AddProductScreenPriceTextBox.Text))
                newProduct.Price = Convert.ToDecimal(AddProductScreenPriceTextBox.Text);
            else
            {
                MessageBox.Show("A valid Price value must be entered.");
                return;
            }

            // Max
            if (isInt(AddProductScreenMaxTextBox.Text))
                newProduct.Max = Convert.ToInt32(AddProductScreenMaxTextBox.Text);
            else
            {
                MessageBox.Show("A valid Max value must be entered.");
                return;
            }

            // Min
            if (isInt(AddProductScreenMinTextBox.Text))
                newProduct.Min = Convert.ToInt32(AddProductScreenMinTextBox.Text);
            else
            {
                MessageBox.Show("A valid Min value must be entered.");
                return;
            }

            if (!isInventoryValueBetweenMinMax())
            {
                MessageBox.Show("Verify Inventory value is between Min and Max values and Min value is smaller than Max Value.");
                return;
            }

            // Copy part from queue list to associated
            newProduct.AssociatedParts = associatedPartsQueue;

            // Add Part
            MainInventory.Inventory.Products.Add(newProduct);
            Close();
        }

        private void AddProductScreenCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProductScreenPartAddButton_Click(object sender, EventArgs e)
        {
            // If a part is selected add it to the associated parts queue
            if (AddProductScreenAllPartsDGV.CurrentRow != null)
            {
                var row = AddProductScreenAllPartsDGV.CurrentRow;
                Part part = (Part)row.DataBoundItem; 
                associatedPartsQueue.Add(part);
            }
        }

        public bool isInt(string input)
        {
            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool isDecimal(string input)
        {
            try
            {
                Convert.ToDecimal(input);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool isInventoryValueBetweenMinMax()
        {
            bool isValid = true;

            if (AddProductScreenInventoryTextBox != null && AddProductScreenMinTextBox != null && AddProductScreenMaxTextBox != null)
            {
                if (Convert.ToInt32(AddProductScreenMinTextBox.Text) > Convert.ToInt32(AddProductScreenMaxTextBox.Text))
                {
                    isValid = false;
                }
                else if (Convert.ToInt32(AddProductScreenInventoryTextBox.Text) < Convert.ToInt32(AddProductScreenMinTextBox.Text))
                {
                    isValid = false;
                }
                else if (Convert.ToInt32(AddProductScreenInventoryTextBox.Text) > Convert.ToInt32(AddProductScreenMaxTextBox.Text))
                {
                    isValid = false;
                }
                return isValid;
            }
            else
            {
                isValid = true;
                return isValid;
            }
        }

        private void AddProductScreenPartDeleteButton_Click(object sender, EventArgs e)
        {
            if (AddProductScreenAssociatedPartsDGV.CurrentRow != null)
            {
                var row = AddProductScreenAssociatedPartsDGV.CurrentRow;
                Part part = (Part)row.DataBoundItem;
                associatedPartsQueue.Remove(part);
            }
        }
    }
}
