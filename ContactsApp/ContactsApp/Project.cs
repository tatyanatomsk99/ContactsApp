using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ContactsApp;
using System.Collections.Concurrent;



namespace ContactsApp
{
    
    public class Project
    {

        ///<summary>
        ///массив контактов 
        ///</summary>
        public List<Contact> СontactsList = new List<Contact>();//массив контактов 
        /// <summary>
        /// Метод сортировки контактов по алфавиту.
        /// </summary>
        /// <returns></returns>
        public List<Contact> SortingContacts()//сортировка
        {
            var sortedСontactsList = СontactsList.OrderBy(u => u.Surname);
            return sortedСontactsList.ToList();
        }
        /// <summary>
        /// Метод поиска контакта.
        /// </summary>
        /// <param name="Find"></param>
        /// <returns></returns>
        public List<Contact> SortingContacts(string Find)
        {
            var sortedСontactsList = СontactsList.OrderBy(u => u.Surname);
            var FindsortedСontactsList = sortedСontactsList.ToList().FindAll(t => t.Surname.StartsWith(Find) || t.Name.StartsWith(Find));
            return FindsortedСontactsList;
        }
        /// <summary>
        /// Метод для проверки даты рождения (именниники).
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Contact> BdateContact (DateTime date)
        {
            List<Contact> contacts = new List<Contact>();
                for (int i = 0; i< СontactsList.Count; i++)
                if(date.Day == СontactsList[i].Bdate.Day &&
                   date.Month == СontactsList[i].Bdate.Month)
                {
                    contacts.Add(СontactsList[i]);
                }
            return contacts.ToList();
        }
    }
}
