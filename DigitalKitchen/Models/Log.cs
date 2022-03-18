using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen.Models
{
    /// <summary>
    /// фиксация изменений.
    /// </summary>
    public class Log//форма для внесения измений в датабазу кухни, например кол-во продуктов и т.д, также екзепшины.
    {
        public int Id { get; set; }

        public string Text { get; set; }//текст события.

        public DateTime Date { get; set; }//дата и время события.

        public int UserId { get; set; }//ссылка на пользователя, логируемся через айдишник, не через имя пользователя.
    }
}
