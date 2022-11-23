using Shop.Product;

namespace Shop.DB{
    public static class EmulatorDBproduct{
        private static List<ProductA> DataBase = new List<ProductA>();

        public static void AddToDB(ProductA product){
            DataBase.Add(product);
        }

        public static void RemoveFromDB(ProductA product){
            DataBase.Remove(product);
        }

        public static ProductA SearchByName(string name){
            foreach(var x in DataBase){
                if (x.Name.Equals(name)){
                    System.Console.WriteLine("Test input by SearchByName: " + x.Name);
                    return x;
                }
            }
            return null;
        }

        public static void ShowTable(){
            foreach(var x in DataBase){
                System.Console.WriteLine("\n==== " + x.Name + " ====");
                System.Console.WriteLine("SKU: " + x.SKU);
                System.Console.WriteLine("Type: " + x.Type);
                System.Console.WriteLine("Cost: " + x.Cost);
            }
        }
    }
}