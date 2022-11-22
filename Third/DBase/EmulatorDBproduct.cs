using Shop.Product;

namespace Shop.DB{
    public class EmulatorDBproduct{
        private List<ProductA> DataBase;

        public EmulatorDBproduct(){
            DataBase = new List<ProductA>();
        }

        public void AddToDB(ProductA product){
            DataBase.Add(product);
        }

        public void RemoveFromDB(ProductA product){
            DataBase.Remove(product);
        }

        public void ShowTable(){
            foreach(var x in DataBase){
                System.Console.WriteLine("\n==== " + x.Name + " ====");
                System.Console.WriteLine("SKU: " + x.SKU);
                System.Console.WriteLine("Type: " + x.Type);
                System.Console.WriteLine("Cost: " + x.Cost);
            }
        }
    }
}