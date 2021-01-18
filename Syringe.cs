using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyTaskManager
{
    class Syringe :Item
    {
        public Syringe(int ID, string Name, int UnitQuantity, double Price, DateTime ProductionDate, DateTime ExpirationDate)
            : base(ID, Name, UnitQuantity, Price, ProductionDate, ExpirationDate)
        {
            Type = ItemType.Syringe;
        }

        public override string ToString()
        {
            return "ID: " + id
                + ", Name: " + name
                + ", Unit: " + unitQuantity + " pieces in 1 pack"
                + ", Price: " + price + " $"
                + ", Production Date: " + productionDate.ToString()
                + ", Expiration Date: " + expirationDate.ToString()
                + ", Type: " + Type + "\n";
        }
    }
}
