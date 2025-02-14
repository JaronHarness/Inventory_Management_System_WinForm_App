using InventoryManagementSystem.Models;
namespace InventoryManagementSystem.Models
{
    public abstract class Part
    {
        // Properties
        public int PartID {  get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }
    }
}
