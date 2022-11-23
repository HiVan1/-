using Shop.DB;

namespace Shop.Product{
    public class CreateProduct{

        public CreateProduct(){
        }

        public void CreateProductX(string name, string sku, float cost, string type){
            var prod = new ProductA(name, sku, cost, type); 
            EmulatorDBproduct.AddToDB(prod);
        }

        public void ProductSell(){
            
        }

        public void ShowProduct(){
            EmulatorDBproduct.ShowTable();
        }
    }
}