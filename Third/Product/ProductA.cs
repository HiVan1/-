using System.Text.RegularExpressions;

namespace Shop.Product{
    public class ProductA{

        private float cost;
        public float Cost{
            get{return cost;}
            set{
                if (value < 0){
                    System.Console.WriteLine("Error. Cannot be less than zero ");
                }else{
                    cost = value;
                }
            }
        }

        private string name;
        public string Name{
            get{return name;}
            set{name = value;}
        }

        private string sku;
        public string SKU{
            get{return sku;}
            set{
                string pattern = @"^#[1-9]{4}$";
                if (Regex.IsMatch(value, pattern)){
                    sku = value;
                }else{
                    System.Console.WriteLine("Error. Incorrect input SKU");
                    sku = "error";
                }
            }
        }

        private string type;
        public string Type{
            get{return type;}
            set{type = value;}
        }

        public ProductA(string name, string sku, float cost, string type){
            Name = name;
            SKU = sku;
            Cost = cost;
            Type = type;
        }

        public void ProductInformation(){
            
        }

    }
}