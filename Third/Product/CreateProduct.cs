using Shop.DB;

namespace Shop.Product{
    public class CreateProduct{
        private EmulatorDBproduct DataBase;

        public CreateProduct(){
            DataBase = new EmulatorDBproduct();
        }

        public ProductA CreateProductX(string name, string sku, float cost, string type){
            var prod = new ProductA(name, sku, cost, type); 
            DataBase.AddToDB(prod);
            return prod;
        }

        public void ProductSell(){
            
        }

        public void ShowProduct(){
            DataBase.ShowTable();
        }
    }
}