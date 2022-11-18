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

        private IDictionary<string, string> NameSKU = new Dictionary<string, string>();

        //Method return SKU(Acticle)
        public string getSKUname(string name){
            return null;
        }

        //Method return Name
        public string getNameSKU(string SKU){
            return null;
        }

        public void setNameSKU(string name, string SKU){
            NameSKU.Add(name, SKU);
        }

        public void remNameSKU(string name){
            NameSKU.Remove(name);
        }

    }
}