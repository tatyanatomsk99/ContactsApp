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

        public List<Contact> SortingContacts()//сортировка
        {
            var sortedСontactsList = СontactsList.OrderBy(u => u.Surname);
            return sortedСontactsList.ToList();
        }
        public List<Contact> SortingContacts(string Find)
        {
            var sortedСontactsList = СontactsList.OrderBy(u => u.Surname);
            var FindsortedСontactsList = sortedСontactsList.ToList().FindAll(t => t.Surname.StartsWith(Find) || t.Name.StartsWith(Find));
            return FindsortedСontactsList;
        }
    }
}
