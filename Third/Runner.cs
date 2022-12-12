using Shop.Product;
using Shop.Userss;
using Shop.DB;
using Shop.Store;

using System.Text.RegularExpressions;

namespace Shop{
    public class Runner{
        public static void Main(){
            Visual visual = new Visual();
            visual.startShop();   // Запускаем магазин

        }
    }

    
}