using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddPartForm : Form
    {
        // Creates Unique ID
        private static int lastID = 0;

        public AddPartForm()
        {
            InitializeComponent();
            AddPartScreenIDTextBox.Text = Convert.ToString(++lastID);
        }

        private void AddPartScreenInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddPartScreenInHouseRadioButton.Checked)
            {
                AddPartScreenMachineIDLabel.Text = "Machine ID";
            }
        }

        private void AddPartScreenOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddPartScreenOutsourcedRadioButton.Checked)
            {
                AddPartScreenMachineIDLabel.Text = "Company Name";
            }
        }

        private void AddPartScreenCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPartScreenSaveButton_Click(object sender, EventArgs e)
        {
            if (AddPartScreenInHouseRadioButton.Checked)
            {
                var newInHousePart = new InHouse();

                // ID
                newInHousePart.PartID = lastID;

                // Name
                if (AddPartScreenNameTextBox.Text == "")
                {
                    MessageBox.Show("A Part name must be entered.");
                    return;
                }
                else
                {
                    newInHousePart.Name = AddPartScreenNameTextBox.Text;
                }
                // Inventory
                if (isInt(AddPartScreenInventoryTextBox.Text))
                    newInHousePart.InStock = Convert.ToInt32(AddPartScreenInventoryTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Inventory value must be entered.");
                    return;
                }

                // Price / Cost
                if (isDecimal(AddPartScreenPriceCostTextBox.Text))
                    newInHousePart.Price = Convert.ToDecimal(AddPartScreenPriceCostTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Price value must be entered.");
                    return;
                }

                // Max
                if (isInt(AddPartScreenMaxTextBox.Text))
                    newInHousePart.Max = Convert.ToInt32(AddPartScreenMaxTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Max value must be entered.");
                    return;
                }

                // Min
                if (isInt(AddPartScreenMinTextBox.Text))
                    newInHousePart.Min = Convert.ToInt32(AddPartScreenMinTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Min value must be entered.");
                    return;
                }

                if (!isInventoryValueBetweenMinMax())
                {
                    MessageBox.Show("Verify Inventory value is between Min and Max values and Min value is smaller than Max Value.");
                }

                // Machine ID
                if (isInt(AddPartScreenMachineIDTextBox.Text))
                    newInHousePart.MachineID = Convert.ToInt32(AddPartScreenMachineIDTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Machine ID value must be entered.");
                    return;
                }

                // Add Part
                MainInventory.Inventory.addPart(newInHousePart);
                Close();
            }
            else
            {
                var newOutsourcedPart = new OutSourced();

                // ID
                newOutsourcedPart.PartID = lastID;

                // Name
                if (AddPartScreenNameTextBox.Text == "")
                {
                    MessageBox.Show("A Part name must be entered.");
                    return;
                }
                else
                {
                    newOutsourcedPart.Name = AddPartScreenNameTextBox.Text;
                }

                // Inventory
                if (isInt(AddPartScreenInventoryTextBox.Text))
                    newOutsourcedPart.InStock = Convert.ToInt32(AddPartScreenInventoryTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Inventory value must be entered.");
                    return;
                }

                // Price / Cost
                if (isDecimal(AddPartScreenPriceCostTextBox.Text))
                    newOutsourcedPart.Price = Convert.ToDecimal(AddPartScreenPriceCostTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Price value must be entered.");
                    return;
                }

                // Max
                if (isInt(AddPartScreenMaxTextBox.Text))
                    newOutsourcedPart.Max = Convert.ToInt32(AddPartScreenMaxTextBox.Text);
                else
                {
                    MessageBox.Show("A valid Max value must be entered.");
                    return;
                }

                // Min
                if (isInt(AddPartScreenMinTextBox.Text))
                    newOutsourcedPart.Min = Convert.ToInt32(AddPartScreenMinTextBox.Text);
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

                // Company Name
                try
                {
                    newOutsourcedPart.CompanyName = AddPartScreenMachineIDTextBox.Text;
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the MachineID field.");
                    return;
                }

                // Add Part
                MainInventory.Inventory.addPart(newOutsourcedPart);
                Close();
            }
        }

        public bool isInt(string inventoryText)
        {
            try
            {
                Convert.ToInt32(inventoryText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool isDecimal(string inventoryText)
        {
            try
            {
                Convert.ToDecimal(inventoryText);
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

            if (AddPartScreenInventoryTextBox != null && AddPartScreenMinTextBox != null && AddPartScreenMaxTextBox != null)
            {
                if (Convert.ToInt32(AddPartScreenMinTextBox.Text) > Convert.ToInt32(AddPartScreenMaxTextBox.Text))
                {
                    isValid = false;
                }
                else if (Convert.ToInt32(AddPartScreenInventoryTextBox.Text) < Convert.ToInt32(AddPartScreenMinTextBox.Text))
                {
                    isValid = false;
                }
                else if (Convert.ToInt32(AddPartScreenInventoryTextBox.Text) > Convert.ToInt32(AddPartScreenMaxTextBox.Text))
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
    }
}
