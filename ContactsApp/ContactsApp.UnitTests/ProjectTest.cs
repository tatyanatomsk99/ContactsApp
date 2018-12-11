using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.UnitTests
{
    [TestFixture]
     public class ProjectTest
    {
        [Test(Description = "Тест для добавления контакта в массив контактов ")]
        public void ProjectTest_addContact()
        {
            Contact cont1 = new Contact();
            Contact cont2 = new Contact();
            Project pr = new Project();
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+ 
                "/source/repos/ContactsApp/ContactsApp/ContactsApp.UnitTests/testProject.xml";

            cont1.Surname = "Иванов";
            cont1.Name = "Иван";
            cont1.Bdate = new DateTime(2014, 12, 20);
            cont1.Number.Number = 75556664477;
            cont1.Mail = "ivan1212@bk.com";
            cont1.IDVK = "id424245";
            pr.СontactsList.Add(cont1);

            cont2.Surname = "Петров";
            cont2.Name = "Сергей";
            cont2.Bdate = new DateTime(1997, 12, 20);
            cont2.Number.Number = 77778884455;
            cont2.Mail = "1212@bk.com";
            cont2.IDVK = "id1254";
            pr.СontactsList.Add(cont2);
            Projectmanager.Serialization(pr, filePath);

        }

    }
}
