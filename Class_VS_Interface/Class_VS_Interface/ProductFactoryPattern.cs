using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_VS_Interface
{

    public abstract class ProductFactoryPattern
    {
        protected String description = "";
        public abstract void MakeComputer(int cpu, int ram, int storage, int display);
        public String GetInfo()
        {
            return this.description;
        }
    }


    public class PC : ProductFactoryPattern
    {
        public override void MakeComputer(int cpu, int ram, int storage, int display)
        {
            this.description = $"DELL PC: CPU {cpu}, RAM {ram}, STORAGE {storage}, DISPLAY {display}";
        }
    }

    public class Laptop : ProductFactoryPattern
    {
        public override void MakeComputer(int cpu, int ram, int storage, int display)
        {
            this.description = $"DELL Laptop: CPU {cpu}, RAM {ram}, STORAGE {storage}, DISPLAY {display}";
        }
    }

    public class Tablet : ProductFactoryPattern
    {
        public override void MakeComputer(int cpu, int ram, int storage, int display)
        {
            this.description = $"DELL Tablet: CPU {cpu}, RAM {ram}, STORAGE {storage}, DISPLAY {display}";
        }
    }

    public class Order
    {
        Dictionary<string, ProductFactoryPattern> productTypeDict = new ()
        {
            {"Tablet", new Tablet() },
            {"PC", new PC() },
            {"Laptop", new Laptop() }
        };

        public ProductFactoryPattern? PlaceOrder(String type, int cpu, int ram, int storage, int display)
        {
            ProductFactoryPattern? product = null;

            if (productTypeDict.ContainsKey(type))
            {
                product = productTypeDict[type];
                product.MakeComputer(cpu, ram, storage, display);
            }

            return product;

        }



    }
}
