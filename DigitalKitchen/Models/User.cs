using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalKitchen.Models
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }//имя пользователя.
        
        public bool IsAdmin { get; set; }//проверка на администратора.
    }
}
