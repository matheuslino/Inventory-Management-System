// Model/User.cs

namespace InventoryApp
{
    public class User
    {
        // Attributes
        int    id   { get; }
        string name { get; set; }
        string pass { get; set; }

        // Constructor
        public User(int id)
        {
            this.id = id;
        }
    }
}