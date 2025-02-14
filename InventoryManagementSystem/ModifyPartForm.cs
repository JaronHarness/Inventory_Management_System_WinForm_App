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
    public partial class ModifyPartForm : Form
    {
        int partToModifyPartID;
        Part partToModify;
        public ModifyPartForm(DataGridViewRow inboundPart)
        {
            InitializeComponent();

            // Retrieves and stores selected rows PartID
            partToModifyPartID = Convert.ToInt32(inboundPart.Cells["PartID"].Value);

            // Retrieves and stores selected part object by its ID
            partToModify = MainInventory.Inventory.lookupPart(partToModifyPartID);

            // Display the parts current information
            DisplayPartInformation();
        }

        private void ModifyPartScreenInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartScreenInHouseRadioButton.Checked)
            {
                ModifyPartScreenMachineIDLabel.Text = "Machine ID";
            }
        }

        private void ModifyPartScreenOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartScreenOutsourcedRadioButton.Checked)
            {
                ModifyPartScreenMachineIDLabel.Text = "Company Name";
            }
        }

        private void ModifyPartScreenCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayPartInformation()
        {

            ModifyPartScreenIDTextBox.Text = partToModify.PartID.ToString();
            ModifyPartScreenNameTextBox.Text = partToModify.Name.ToString();
            ModifyPartScreenInventoryTextBox.Text = partToModify.InStock.ToString();
            ModifyPartScreenPriceCostTextBox.Text = partToModify.Price.ToString();
            ModifyPartScreenMaxTextBox.Text = partToModify.Max.ToString();
            ModifyPartScreenMinTextBox.Text = partToModify.Min.ToString();

            if (partToModify is InHouse inHousePart)
            {
                ModifyPartScreenInHouseRadioButton.Checked = true;
                ModifyPartScreenMachineIDTextBox.Text = inHousePart.MachineID.ToString();
            }
            else if (partToModify is OutSourced outsourcedPart)
            {
                ModifyPartScreenOutsourcedRadioButton.Checked = true;
                ModifyPartScreenMachineIDTextBox.Text = outsourcedPart.CompanyName.ToString();
            }
        }

        private void ModifyPartScreenSaveButton_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected
            if (ModifyPartScreenInHouseRadioButton.Checked)
            {
                // Create InHouse Instance for the part
                var inHousePart = new InHouse();

                inHousePart.PartID = Convert.ToInt32(ModifyPartScreenIDTextBox.Text);

                // Update Name
                if (ModifyPartScreenNameTextBox.Text == "")
                {
                    MessageBox.Show("A part name must be entered.");
                    return;
                }
                else
                {
                    inHousePart.Name = ModifyPartScreenNameTextBox.Text;
                }

                // Update Inventory
                try
                {
                    inHousePart.InStock = Convert.ToInt32(ModifyPartScreenInventoryTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Inventory field.");
                    return;
                }

                // Update Price/Cost
                try
                {
                    inHousePart.Price = Convert.ToDecimal(ModifyPartScreenPriceCostTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Price/Cost field.");
                    return;
                }

                // Update Max
                try
                {
                    inHousePart.Max = Convert.ToInt32(ModifyPartScreenMaxTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Max field.");
                    return;
                }

                // Update Min
                try
                {
                    inHousePart.Min = Convert.ToInt32(ModifyPartScreenMinTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Min field.");
                    return;
                }

                // Verify Inventory value between Min and Max values
                if (ModifyPartScreenInventoryTextBox != null && ModifyPartScreenMinTextBox != null && ModifyPartScreenMaxTextBox != null)
                {
                    try
                    {
                        if (Convert.ToInt32(ModifyPartScreenMinTextBox.Text) > Convert.ToInt32(ModifyPartScreenMaxTextBox.Text))
                        {
                            MessageBox.Show("Min value can not be greater than the Max value.");
                            return;
                        }
                        else if (Convert.ToInt32(ModifyPartScreenInventoryTextBox.Text) < Convert.ToInt32(ModifyPartScreenMinTextBox.Text))
                        {
                            MessageBox.Show("Inventory value can not be less than the Min value.");
                            return;
                        }
                        else if (Convert.ToInt32(ModifyPartScreenInventoryTextBox.Text) > Convert.ToInt32(ModifyPartScreenMaxTextBox.Text))
                        {
                            MessageBox.Show("Inventory value can not be greater than the Max value.");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Verify that the Min, Max, and Inventory fields all have whole numbers entered.");
                        return;
                    }

                }

                // Update MachineID
                try
                {
                    inHousePart.MachineID = Convert.ToInt32(ModifyPartScreenMachineIDTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the MachineID field.");
                    return;
                }

                // Update part and close window
                MainInventory.Inventory.updatePart(inHousePart.PartID, inHousePart);
                Close();
            }
            
            if (ModifyPartScreenOutsourcedRadioButton.Checked)
            {

                // Create Outsourced Instance for the part
                var outsourcedPart = new OutSourced();

                outsourcedPart.PartID = Convert.ToInt32(ModifyPartScreenIDTextBox.Text);

                // Update Name
                if (ModifyPartScreenNameTextBox.Text == "")
                {
                    MessageBox.Show("A part name must be entered.");
                    return;
                }
                else
                {
                    outsourcedPart.Name = ModifyPartScreenNameTextBox.Text;
                }

                // Update Inventory
                try
                {
                    outsourcedPart.InStock = Convert.ToInt32(ModifyPartScreenInventoryTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Inventory field.");
                    return;
                }

                // Update Price/Cost
                try
                {
                    outsourcedPart.Price = Convert.ToDecimal(ModifyPartScreenPriceCostTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Price/Cost field.");
                    return;
                }

                // Update Max
                try
                {
                    outsourcedPart.Max = Convert.ToInt32(ModifyPartScreenMaxTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Max field.");
                    return;
                }

                // Update Min
                try
                {
                    outsourcedPart.Min = Convert.ToInt32(ModifyPartScreenMinTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the Min field.");
                    return;
                }

                // Verify Inventory value between Min and Max values
                if (ModifyPartScreenInventoryTextBox != null && ModifyPartScreenMinTextBox != null && ModifyPartScreenMaxTextBox != null)
                {
                    try
                    {
                        if (Convert.ToInt32(ModifyPartScreenMinTextBox.Text) > Convert.ToInt32(ModifyPartScreenMaxTextBox.Text))
                        {
                            MessageBox.Show("Min value can not be greater than the Max value.");
                            return;
                        }
                        else if (Convert.ToInt32(ModifyPartScreenInventoryTextBox.Text) < Convert.ToInt32(ModifyPartScreenMinTextBox.Text))
                        {
                            MessageBox.Show("Inventory value can not be less than the Min value.");
                            return;
                        }
                        else if (Convert.ToInt32(ModifyPartScreenInventoryTextBox.Text) > Convert.ToInt32(ModifyPartScreenMaxTextBox.Text))
                        {
                            MessageBox.Show("Inventory value can not be greater than the Max value.");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Verify that the Min, Max, and Inventory fields all have whole numbers entered.");
                        return;
                    }

                }

                // Update Company Name
                try
                {
                    outsourcedPart.CompanyName = ModifyPartScreenMachineIDTextBox.Text;
                }
                catch
                {
                    MessageBox.Show("A valid number should be entered for the MachineID field.");
                    return;
                }

                // Add part and close window
                MainInventory.Inventory.updatePart(outsourcedPart.PartID, outsourcedPart);
                Close();
            }
        }
    }

}
