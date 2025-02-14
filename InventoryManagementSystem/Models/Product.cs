using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        // Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public Product()
        {
        }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public Part lookupAssociatedPart(int partID)
        {
            // Check if the part is associated with a product
            var associatedPart = AssociatedParts.FirstOrDefault(part => part.PartID == partID);
            return associatedPart;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            bool isValid = false;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
