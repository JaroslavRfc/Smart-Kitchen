using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen.Models
{
    /// <summary>
    /// Детали тех-карты. 
    /// </summary>
    public class TechnicalCardDetail//если блюдо состоит из более чем одного вида ингридиентов, то для каждого ингридиента будет своя TCD
    {
        public int Id { get; set; }

        public int ProductId { get; set; }//ссылка на ингирдиент, если полуфабрикат то айди 0.

        public int TechnicalCardId { get; set; }//ссылка на тех-карту.

        public int Count { get; set; }//кол-во ингридиента.

        public bool IsHalfStuff { get; set; }//проверка на полуфабрикат.

        public int HalfStuffId { get; set; }//ссылка на тех-карту полуфабриката, если ингридиент не является полуфабрикатом то значение 0.
    }
}
