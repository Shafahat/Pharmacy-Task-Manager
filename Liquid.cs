using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyTaskManager
{
    class Liquid : Item
    {
        public Liquid(int ID, string Name, int UnitQuantity, double Price, DateTime ProductionDate, DateTime ExpirationDate)
            : base(ID, Name, UnitQuantity, Price, ProductionDate, ExpirationDate)
        {
            Type = ItemType.Liquid;
        }

        public override string ToString()
        {
            return "ID: " + id
                + ", Name: " + name
                + ", Unit: " + unitQuantity + " m^3 in 1 bottle"
                + ", Price: " + price + " $"
                + ", Production Date: " + productionDate.ToString()
                + ", Expiration Date: " + expirationDate.ToString()
                + ", Type: " + Type + "\n";
        }
    }
}
