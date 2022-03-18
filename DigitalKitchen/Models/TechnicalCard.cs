using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen.Models
{
    /// <summary>
    /// Тех-карта.
    /// </summary>
    public class TechnicalCard
    {
        public int Id { get; set; }

        public string Name { get; set; }//название блюда.

        public bool IsHalfStuff { get; set; }//признак полуфабриката.

        public decimal CostPrice { get; set; }//себестоимость.

        public decimal FinalPrice { get; set; }//цена реализации с 20% накруткой.
    }
}
