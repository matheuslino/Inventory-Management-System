// Model/Brand.cs

namespace InventoryApp
{
    public class Brand
    {
        // Attributes
        public int    id   { get; }
        public string name { get; set; }

        // Constructor
        public Brand(int id)
        {
            this.id = id;
        }
    }
}