using Hi_Store.StoreDataBase;
using System;

namespace Hi_Store.Product {
    public class CreateProduct {

        private ProductTable productTable;
        public CreateProduct () {
            productTable = new ProductTable ();
        }
        public void ConnectionClose () {
            productTable.ConnectionClose();
        }

        #region createProduct
        /* public ProductA CreateProductX (string name, string sku, string type, float cost, int amount, string about) {
             ProductA product = null;
             *//*if (productTable.isHere(sku)) {
                 product = new ProductA(name, sku, type, cost, amount, about);
             }
             else {
                 Console.WriteLine("> Такой продукт уже есть. Введите данные ещё раз:");
                 Console.WriteLine("> Name: " + "name1");
                 Console.WriteLine("> SKU: " + "1254-5698");
                 Console.WriteLine("> Type: " + "PC");
                 Console.WriteLine("> Cost: " + "198.86");

             }*//*
             return product;
         }*/
        #endregion


        public void ShowProduct () {
            productTable.ShowProducts();
        }

        public void ShowProduct (string sku) {
            productTable.ShowProducts(sku);
        }

        public float GetProductCost(string sku) {
            return productTable.GetProductCost(sku);
        }

        public void BuyProduct (string sku, int number) {
            if (productTable.isHere(sku)) {
                int amount = productTable.GetProductAmount(sku);
                int x = amount - number;

                if (x < 0) {
                    Console.WriteLine("> На складе нет такого кол-ва продукта. Как только он появится, мы с Вами свяжемся)");
                }else if(x >= 0) {
                    
                }
            }
        }
    }
}
