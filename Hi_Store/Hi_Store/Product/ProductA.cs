using System.Text.RegularExpressions;

namespace Hi_Store.Product {
    public class ProductA {

        private string name;
        public string Name { // Имя продукта 
            get { return name; }
            set { name = value; }
        }

        private string sku;
        public string SKU { // Код продукта
            get { return sku; }
            set {
                string pattern = @"^[1-9]{20}$";
                if (Regex.IsMatch(value, pattern)) {
                    sku = value;
                }
                else {
                    System.Console.WriteLine("Error. Incorrect input SKU");
                    sku = "undefined";
                }
            }
        }

        private string type;
        public string Type { // Тип продукта. (На пример: еда, алкоголь, бытовая техника и тд)
            get { return type; }
            set { type = value; }
        }

        private float cost;
        public float Cost { // Стоимость продукта
            get { return cost; }
            set {
                if (value < 0) {
                    System.Console.WriteLine("Error. Cannot be less than zero ");
                }
                else {
                    cost = value;
                }
            }
        }


        private int amount;
        public int Amount {
            get { return amount; }
            set { amount = value; }
        }

        private string about;
        public string About {
            get { return about; }
            set { about = value; }
        }

        public ProductA (string name, string sku, string type, float cost, int amount, string about) {
            Name = name;
            SKU = sku;
            Cost = cost;
            Type = type;
            Amount = amount;
            About = about;
        }

        public void ProductInformation () {

        }

    }
}
