// Model/Category.cs

namespace InventoryApp
{
    public class Category
    {
        // Attributes
        public int    id   { get; }             // Alternative to declare Getters and Setters automatically.
        public string name { get; set; }        // Declaration: visibility varType varName { method; method; }
        public string desc { get; set; }

        // Constructor
        public Category(int id)
        {
            this.id = id;
        }
    }
}