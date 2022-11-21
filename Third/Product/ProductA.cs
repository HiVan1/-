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
            set{sku = value; }
        }

        // private IDictionary<string, string> NameSKU = new Dictionary<string, string>();

        // //Method return SKU(Acticle)
        // public string getSKUname(string name){
        //     return NameSKU.ElementAt(1).Value;
        // }

        // //Method return Name
        // public string getNameSKU(string SKU){
        //     return NameSKU.ElementAt(1).Key;
        // }

        // public void setNameSKU(string name, string SKU){
        //     NameSKU.Add(name, SKU);
        // }

        // public void remNameSKU(string name){
        //     NameSKU.Remove(name);
        // }

        public void AddProduct(string name, string sku, float cost){
            
        }

        public void ProductInformation(){
            System.Console.WriteLine("Name: ");
            System.Console.WriteLine("SKU: " );
            System.Console.WriteLine("Cost: " + Cost);
        }

    }
}