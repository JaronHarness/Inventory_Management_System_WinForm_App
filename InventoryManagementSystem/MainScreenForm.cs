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
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();

            // Parts DGV Source
            MainScreenPartsDGV.DataSource = MainInventory.Inventory.AllParts;

            // Product DGV Source
            MainScreenProductsDGV.DataSource = MainInventory.Inventory.Products;
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MainScreenPartsDGV.ClearSelection();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            var newAddPartFormInstance = new AddPartForm();
            newAddPartFormInstance.Show();
        }

        private void MainScreenExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainScreenModifyPartButton_Click(object sender, EventArgs e)
        {
            if (MainScreenPartsDGV.CurrentRow != null)
            {
                // Select row
                var row = MainScreenPartsDGV.CurrentRow;

                // Pass part to Modify screen
                var modifyPartFormInstance = new ModifyPartForm(row);

                // Display Modify Form
                modifyPartFormInstance.Show();

            }
        }

        private void MainScreenDeletePartButton_Click(object sender, EventArgs e)
        {
            if (MainScreenPartsDGV.CurrentRow != null)
            {

                DialogResult deleteChoice = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteChoice == DialogResult.Yes)
                {
                    var currentRow = MainScreenPartsDGV.CurrentRow;
                    Part deletePart = (Part)currentRow.DataBoundItem;

                    if (MainInventory.Inventory.deletePart(deletePart) == false)
                    {
                        MessageBox.Show("Part deletion was unsuccessful. Verify that this part is not associated with a product before deleting.");
                    }
                }
            }
        }

        private void MainScreenAddProductButton_Click(object sender, EventArgs e)
        {
            var newAddProductFormInstance = new AddProductForm();
            newAddProductFormInstance.Show();
        }

        private void MainScreenDeleteProductButton_Click(object sender, EventArgs e)
        {
            if (MainScreenPartsDGV.CurrentRow != null)
            {

                DialogResult deleteChoice = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (deleteChoice == DialogResult.Yes)
                {
                    var currentRow = MainScreenProductsDGV.CurrentRow;
                    Product deleteProduct = new Product(); 
                    deleteProduct = (Product)currentRow.DataBoundItem;

                    // Verify Product does not have associated parts
                    if (deleteProduct.AssociatedParts.Count != 0)
                    {
                        MessageBox.Show("Product deletion was unsuccessful. Verify that this product does not have associated parts before deleting.");
                    }
                    else
                    {
                        MainInventory.Inventory.removeProduct(deleteProduct.ProductID);
                    }
                }
            }
        }

        private void myBindingComplete2(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MainScreenProductsDGV.ClearSelection();
        }

        private void MainScreenModifyProductButton_Click(object sender, EventArgs e)
        {
            if (MainScreenProductsDGV.CurrentRow != null)
            {
                // Select row
                var row = MainScreenProductsDGV.CurrentRow;

                // Pass product to Modify screen
                var newModifyProductFormInstance = new ModifyProductForm(row);

                // Display Modify Form
                newModifyProductFormInstance.Show();
            }
        }

        private void MainScreenPartsSearchButton_Click(object sender, EventArgs e)
        {
            if (MainScreenPartsSearchTextBox.Text != "")
            {
                // Assign text to part ID variable
                int partID = Convert.ToInt32(MainScreenPartsSearchTextBox.Text);

                // Search for the part by the ID
                Part part = MainInventory.Inventory.lookupPart(partID);

                // Verify part exists in AllParts
                if (part != null)
                {
                    // If it exists than clear the DGV
                    MainScreenPartsDGV.ClearSelection();
                    // Display only that part in the DGV
                    MainScreenPartsDGV.DataSource = new List<Part> { part };
                }
                else
                {
                    MessageBox.Show("Part not found. Please very the correct Part ID has been entered for the desired part.");
                }
            }
            else
            {
                MainScreenPartsDGV.DataSource = MainInventory.Inventory.AllParts;
            }
        }

        private void MainScreenProductsSearchButton_Click(object sender, EventArgs e)
        {
            if (MainScreenProductsSearchTextBox.Text != "")
            {
                // Assign text to product ID variable
                int productID = Convert.ToInt32(MainScreenProductsSearchTextBox.Text);

                // Search for the product by the ID
                Product product = MainInventory.Inventory.lookupProduct(productID);

                // Verify product exists in Products
                if (product != null)
                {
                    // If it exists than clear the DGV
                    MainScreenProductsDGV.ClearSelection();
                    // Display only that product in the DGV
                    MainScreenProductsDGV.DataSource = new List<Product> { product };
                }
                else
                {
                    MessageBox.Show("Product not found. Please very the correct Product ID has been entered for the desired product.");
                }
            }
            else
            {
                MainScreenProductsDGV.DataSource = MainInventory.Inventory.Products;
            }
        }
    }
}
