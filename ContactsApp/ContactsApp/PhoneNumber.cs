using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    ///<summary>
    /// Класс номера телефона,содержит номер телефона
    ///</summary>
    public class PhoneNumber
    {
        ///<summary>
        ///поле содержит номер телефона
        ///</summary>
        private long _Number;

        ///<summary>
        ///Возвращает, задает и, проверяет при вводе, номер телефона 
        ///</summary>
        public long Number
        {
            set
            {
                if ((value >= 70000000000) && (value/10000000000 == 7))
                {
                    _Number = value;
                }
                else
                {
                    throw new ArgumentException("Телефон должен быть введен корректно");
                }
            }
            get { return _Number; }
        }

    }
}
