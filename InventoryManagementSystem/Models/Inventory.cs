using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Inventory
    {
        public  BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public  BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public void addProduct(Product product)
        {
            Products.Add(product);
        }

        public void updateProduct(int productId, Product product)
        {
            // Find product
            var deletionProduct = lookupProduct(productId);

            // Delete product
            removeProduct(productId);

            // Replace with updated product
            addProduct(product);
        }

        public Product lookupProduct(int productID)
        {
            var lookupProduct = Products.FirstOrDefault(product => product.ProductID == productID);
            return lookupProduct;
        }
        public bool removeProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            // Checks if the part is associated with a product
            foreach (var product in Products)
            {
                if (product.lookupAssociatedPart(part.PartID) != null)
                {
                    return false;
                }
            }
            // If not associated then delete part
            AllParts.Remove(part);
            return true;
        }

        public Part lookupPart(int partId)
        {
            var lookupPart = AllParts.FirstOrDefault(part => part.PartID == partId);
            return lookupPart;
        }

        public void updatePart(int partID, Part part)
        {
                // Find part
                var deletionPart = lookupPart(partID);

                // Delete part
                deletePart(deletionPart);

                // Replace with updated part
                AllParts.Add(part);
        }
    }
}
