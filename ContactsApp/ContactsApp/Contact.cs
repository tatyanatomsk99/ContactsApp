

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ContactsApp;
//TODO: изменить пространстао имен
//TODO: решарпер
namespace ContactsApp
{
    //TODO: xml-комментарии. ВЕЗДЕ!

    ///<summary>
    /// Класс одного контакта, содержащий фамилию, имя, почту, idvk и номер телефона
    ///</summary>
    public class Contact
    {
        //TODO: все поля в отдельных строкахж

        ///<summary>
        ///Поле фамилии контакта 
        ///</summary>
        private string _Surname;
        ///<summary>
        ///поле имя контакта 
        ///</summary>
        private string _Name;
        ///<summary>
        ///поле почты контакта 
        ///</summary>
        private string _mail;
        ///<summary>
        ///поле id вконтакте контакта 
        ///</summary>
        private string _IDVK;
        ///<summary>
        ///поле даты рождения контакта 
        ///</summary>
        private DateTime _Bdate = new DateTime();
        ///<summary>
        ///конструктор класса 
        ///</summary>
        public Contact()
        { }

        ///<summary>
        ///Возвращает, задает и, проверяет при вводе, Фамилию контакта 
        ///</summary>
        public string Surname
        {
            set
            {
                if (value.Length > 50)
                { throw new ArgumentException("Фамилия должна быть меньше 50 символов"); }
                else
                { _Surname = value; }
            }
            get { return _Surname; }
        }

        ///<summary>
        ///Возвращает, задает и, проверяет при вводе, имя контакта 
        ///</summary>
        public string Name
        {
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя должна быть меньше 50 символов");
                }
                else
                {
                    _Name = value;
                }
            }
            get { return _Name; }
        }

        ///<summary>
        ///Возвращает, задает и, проверяет при вводе, почту контакта 
        ///</summary>
        public string Mail
        {
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Почта должна быть меньше 50 символов");
                }
                else
                {
                    _mail = value;
                }
            }
            get { return _mail; }
        }

        ///<summary>
        ///Возвращает, задает и, проверяет при вводе, id вконтакте контакта 
        ///</summary>
        public string IDVK
        {
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("ссылка ВК должна быть меньше 15 символов");
                }
                else
                {
                    _IDVK = value;
                }
            }
            get { return _IDVK; }
        }
        ///<summary>
        ///Возвращает, задает и, проверяет при вводе, дату рождения контакта 
        ///</summary>
        public DateTime Bdate
        {
            set
            {

                DateTime date1 = new DateTime(1900);
                DateTime date2 = DateTime.Today;
                if ((value < date1) || (value > date2))
                { throw new ArgumentException("Дата рождения должна быть корректной"); }
                else
                { _Bdate = value; }
            }
            get { return _Bdate; }
        }
        ///<summary>
        ///Возвращает, задает номер телефона контакта 
        ///</summary>
        public PhoneNumber Number { set; get; } = new PhoneNumber();
    }
}
