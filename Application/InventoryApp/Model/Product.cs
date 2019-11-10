// Model/Product.cs

// Imports
using System;
using System.Collections.Generic;

namespace InventoryApp
{
    public class Product
    {
        // Attributes
        private int id;
        private string name;
        private string desc;
        private int qtd;
        private float price;
        private string unitType;
        private List<Category> category    = new List<Category>();
        private List<Brand>    brand       = new List<Brand>();
        private DateTime       currentDate = new DateTime();
        private DateTime       shelfLife   = new DateTime();

        // Constructor
        public Product(int id)
        {
            this.id = id;
        }

        // Other methods
        public int getId()
        {
            return id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setDesc(string desc)
        {
            this.desc = desc;
        }
        public string getDesc()
        {
            return desc;
        }
        public void setCategory(List<Category> cat)
        {
            category = cat;
        }
        public List<Category> getCategory()
        {
            return category;
        }
        public void setBrand(List<Brand> brand)
        {
            this.brand = brand;
        }
        public List<Brand> getBrand()
        {
            return brand;
        }
        public void setQtd(int qtd)
        {
            this.qtd = qtd;
        }
        public int getQtd()
        {
            return qtd;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        public float getPrice()
        {
            return price;
        }
        public void setUnitType(string un)
        {
            unitType = un;
        }
        public string getUnitType()
        {
            return unitType;
        }
        public void setCurrentDate(DateTime current)
        {
            currentDate = current;
        }
        public DateTime getCurrentDate()
        {
            return currentDate;
        }
        public void setShelfLife(DateTime shelfLife)
        {
            this.shelfLife = shelfLife;
        }
        public DateTime getShelfLife()
        {
            return shelfLife;
        }
    }
}