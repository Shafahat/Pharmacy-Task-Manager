using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyTaskManager
{
    class Item
    {
        protected int id { get; set; }
        protected string name { get; set; }
        protected int unitQuantity { get; set; }
        protected double price { get; set; }
        protected DateTime productionDate { get; set; }
        protected DateTime expirationDate { get; set; }
        protected ItemType Type { get; set; }

        public Item(int ID, string Name, int UnitQuantity, double Price, DateTime ProductionDate, DateTime ExpirationDate)
        {
            this.id = ID;
            this.name = Name;
            this.unitQuantity = UnitQuantity;
            this.price = Price;
            this.productionDate = ProductionDate;
            this.expirationDate = ExpirationDate;
        }

        public override string ToString()
        {
            return
                "ID: " + id
                + ", Name: " + name
                + ", Unit: " + unitQuantity + "___"
                + ", Price: " + price + " $"
                + ", Production Date: " + productionDate.ToString()
                + ", Expiration Date: " + expirationDate.ToString()
                + ", Type: " + Type + "\n";
        }

    }
}
