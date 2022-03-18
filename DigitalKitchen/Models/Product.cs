using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen.Models
{
    /// <summary>
    /// Продукт.
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }//название продукта.

        public int Count { get; set; }//кол-во продуктов на складе.

        public decimal Price { get; set; }//цена за одно кол-во продукта.
    }
}
