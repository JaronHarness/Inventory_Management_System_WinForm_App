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
    public partial class ModifyProductForm : Form
    {
        int productToModifyProductID;
        Product productToModify;


        public ModifyProductForm(DataGridViewRow inboundProduct)
        {
            InitializeComponent();

            // Retrieves and stores selected rows ProductID
            productToModifyProductID = Convert.ToInt32(inboundProduct.Cells["ProductID"].Value);

            // Retrieves and stores selected product object by its ID
            productToModify = MainInventory.Inventory.lookupProduct(productToModifyProductID);

            // Display the products current information
            DisplayProductInformation();
        }

        private void DisplayProductInformation()
        {
            ModifyProductScreenIDTextBox.Text = productToModify.ProductID.ToString();
            ModifyProductScreenNameTextBox.Text = productToModify.Name.ToString();
            ModifyProductScreenInventoryTextBox.Text = productToModify.InStock.ToString();
            ModifyProductScreenPriceTextBox.Text = productToModify.Price.ToString();
            ModifyProductScreenMaxTextBox.Text = productToModify.Max.ToString();
            ModifyProductScreenMinTextBox.Text = productToModify.Min.ToString();
            ModifyProductScreenAllPartsDGV.DataSource = MainInventory.Inventory.AllParts;
            ModifyProductScreenAssociatedPartsDGV.DataSource = productToModify.AssociatedParts;
        }

        private void ModifyProductScreenPartAddButton_Click(object sender, EventArgs e)
        {
            // If a part is selected add it to the associated parts queue
            if (ModifyProductScreenAllPartsDGV.CurrentRow != null)
            {
                var row = ModifyProductScreenAllPartsDGV.CurrentRow;
                Part part = (Part)row.DataBoundItem;
                productToModify.addAssociatedPart(part);
            }
        }

        private void ModifyProductScreenCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyProductScreenSaveButton_Click(object sender, EventArgs e)
        {
            var modifiedProduct = new Product();

            // ID
            modifiedProduct.ProductID = Convert.ToInt32(ModifyProductScreenIDTextBox.Text);

            // Update Name
            if (ModifyProductScreenNameTextBox.Text == "")
            {
                MessageBox.Show("A Part name must be entered.");
                return;
            }
            else
            {
                modifiedProduct.Name = ModifyProductScreenNameTextBox.Text;
            }
            // Update Inventory
            if (isInt(ModifyProductScreenInventoryTextBox.Text))
                modifiedProduct.InStock = Convert.ToInt32(ModifyProductScreenInventoryTextBox.Text);
            else
            {
                MessageBox.Show("A valid Inventory value must be entered.");
                return;
            }

            // Update Price / Cost
            if (isDecimal(ModifyProductScreenPriceTextBox.Text))
                modifiedProduct.Price = Convert.ToDecimal(ModifyProductScreenPriceTextBox.Text);
            else
            {
                MessageBox.Show("A valid Price value must be entered.");
                return;
            }

            // Update Max
            if (isInt(ModifyProductScreenMaxTextBox.Text))
                modifiedProduct.Max = Convert.ToInt32(ModifyProductScreenMaxTextBox.Text);
            else
            {
                MessageBox.Show("A valid Max value must be entered.");
                return;
            }

            // Update Min
            if (isInt(ModifyProductScreenMinTextBox.Text))
                modifiedProduct.Min = Convert.ToInt32(ModifyProductScreenMinTextBox.Text);
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

            modifiedProduct.AssociatedParts = productToModify.AssociatedParts;

            // Add Part
            MainInventory.Inventory.updateProduct(modifiedProduct.ProductID, modifiedProduct);
            Close();
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

            if (ModifyProductScreenInventoryTextBox != null && ModifyProductScreenMinTextBox != null && ModifyProductScreenMaxTextBox != null)
            {
                if (Convert.ToInt32(ModifyProductScreenMinTextBox.Text) > Convert.ToInt32(ModifyProductScreenMaxTextBox.Text))
                {
                    isValid = false;
                }
                else if (Convert.ToInt32(ModifyProductScreenInventoryTextBox.Text) < Convert.ToInt32(ModifyProductScreenMinTextBox.Text))
                {
                    isValid = false;
                }
                else if (Convert.ToInt32(ModifyProductScreenInventoryTextBox.Text) > Convert.ToInt32(ModifyProductScreenMaxTextBox.Text))
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

        private void ModifyProductScreenPartDeleteButton_Click(object sender, EventArgs e)
        {
            if (ModifyProductScreenAssociatedPartsDGV.CurrentRow != null)
            {
                var row = ModifyProductScreenAssociatedPartsDGV.CurrentRow;
                Part part = (Part)row.DataBoundItem;
                if (productToModify.removeAssociatedPart(part.PartID))
                {
                    productToModify.AssociatedParts.Remove(part);
                }
            }
        }

        private void ModifyProductScreenAllPartsSearchButton_Click(object sender, EventArgs e)
        {
            if (ModifyProductScreenAllPartsSearchTextBox.Text != "")
            {
                // Assign text to part ID variable
                int partID = Convert.ToInt32(ModifyProductScreenAllPartsSearchTextBox.Text);

                // Search for the part by the ID
                Part part = MainInventory.Inventory.lookupPart(partID);

                // Verify part exists in AllParts
                if (part != null)
                {
                    // If it exists than clear the DGV
                    ModifyProductScreenAllPartsDGV.ClearSelection();
                    // Display only that part in the DGV
                    ModifyProductScreenAllPartsDGV.DataSource = new List<Part> { part };
                }
                else
                {
                    MessageBox.Show("Part not found. Please very the correct Part ID has been entered for the desired part.");
                }
            }
            else
            {
                ModifyProductScreenAllPartsDGV.DataSource = MainInventory.Inventory.AllParts;
            }
        }
    }
}
