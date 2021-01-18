using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyTaskManager
{
    class Tablet : Item
    {
        public Tablet(int ID, string Name, int UnitQuantity, double Price, DateTime ProductionDate, DateTime ExpirationDate)
            : base(ID, Name, UnitQuantity, Price, ProductionDate, ExpirationDate)
        {
            Type = ItemType.Tablet;
        }

        public override string ToString()
        {
            return "ID: " + id
                    + ", Name: " + name
                    + ", Unit: " + unitQuantity + " pills in 1 box"
                    + ", Price: " + price + " $"
                    + ", Production Date: " + productionDate.ToString()
                    + ", Expiration Date: " + expirationDate.ToString()
                    + ", Type: " + Type + "\n";
        }
    }
}
