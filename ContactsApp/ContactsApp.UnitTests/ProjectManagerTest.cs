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
    public class ProjectManagerTest
    {
        [Test(Description = "Тест для проверки дес-ции ")]
        public void DeserializerTest()
        {
            Contact cont1 = new Contact();
            Contact cont2 = new Contact();
            Project expectedProject = new Project();
            Project actualProject = new Project();
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                "/source/repos/ContactsApp/ContactsApp/ContactsApp.UnitTests/testProject.xml";

            cont1.Surname = "Иванов";
            cont1.Name = "Иван";
            cont1.Bdate = new DateTime(2014, 12, 20);
            cont1.Number.Number = 79996190196;
            cont1.Mail = "ivan1212@bk.com";
            cont1.IDVK = "id1254";
            expectedProject.СontactsList.Add(cont1);

            cont2.Surname = "Иванов";
            cont2.Name = "Сергей";
            cont2.Bdate = new DateTime(1997, 12, 20);
            cont2.Number.Number = 79996190196;
            cont2.Mail = "1212@bk.com";
            cont2.IDVK = "id1254";
            expectedProject.СontactsList.Add(cont2);

            actualProject = Projectmanager.Deserialization(actualProject, filePath);

            Assert.AreEqual(expectedProject.СontactsList.Count, actualProject.СontactsList.Count);

            Assert.AreEqual(expectedProject.СontactsList[0].Surname, actualProject.СontactsList[0].Surname);
            Assert.AreEqual(expectedProject.СontactsList[0].Name, actualProject.СontactsList[0].Name);
            Assert.AreEqual(expectedProject.СontactsList[0].Bdate, actualProject.СontactsList[0].Bdate);
            Assert.AreEqual(expectedProject.СontactsList[0].Number.Number, actualProject.СontactsList[0].Number.Number);
            Assert.AreEqual(expectedProject.СontactsList[0].Mail, actualProject.СontactsList[0].Mail);
            Assert.AreEqual(expectedProject.СontactsList[0].IDVK, actualProject.СontactsList[0].IDVK);

            Assert.AreEqual(expectedProject.СontactsList[1].Surname, actualProject.СontactsList[1].Surname);
            Assert.AreEqual(expectedProject.СontactsList[1].Name, actualProject.СontactsList[1].Name);
            Assert.AreEqual(expectedProject.СontactsList[1].Bdate, actualProject.СontactsList[1].Bdate);
            Assert.AreEqual(expectedProject.СontactsList[1].Number.Number, actualProject.СontactsList[1].Number.Number);
            Assert.AreEqual(expectedProject.СontactsList[1].Mail, actualProject.СontactsList[1].Mail);
            Assert.AreEqual(expectedProject.СontactsList[1].IDVK, actualProject.СontactsList[1].IDVK);
        }
        [Test(Description = "Тест для проверки сер-ции ")]
        public void SerializerTest()
        {
            Contact cont1 = new Contact();
            Contact cont2 = new Contact();
            Project expectedProject = new Project();
            Project actualProject = new Project();
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                "/source/repos/ContactsApp/ContactsApp/ContactsApp.UnitTests/testProject.xml";

            cont1.Surname = "Иванов";
            cont1.Name = "Иван";
            cont1.Bdate = new DateTime(2014, 12, 20);
            cont1.Number.Number = 79996190196;
            cont1.Mail = "ivan1212@bk.com";
            cont1.IDVK = "id1254";
            expectedProject.СontactsList.Add(cont1);

            cont2.Surname = "Иванов";
            cont2.Name = "Сергей";
            cont2.Bdate = new DateTime(1997, 12, 20);
            cont2.Number.Number = 79996190196;
            cont2.Mail = "1212@bk.com";
            cont2.IDVK = "id1254";
            expectedProject.СontactsList.Add(cont2);

            Projectmanager.Serialization(expectedProject, filePath);
            actualProject = Projectmanager.Deserialization(actualProject, filePath);

            Assert.AreEqual(expectedProject.СontactsList.Count, actualProject.СontactsList.Count);

            Assert.AreEqual(expectedProject.СontactsList[0].Surname, actualProject.СontactsList[0].Surname);
            Assert.AreEqual(expectedProject.СontactsList[0].Name, actualProject.СontactsList[0].Name);
            Assert.AreEqual(expectedProject.СontactsList[0].Bdate, actualProject.СontactsList[0].Bdate);
            Assert.AreEqual(expectedProject.СontactsList[0].Number.Number, actualProject.СontactsList[0].Number.Number);
            Assert.AreEqual(expectedProject.СontactsList[0].Mail, actualProject.СontactsList[0].Mail);
            Assert.AreEqual(expectedProject.СontactsList[0].IDVK, actualProject.СontactsList[0].IDVK);

            Assert.AreEqual(expectedProject.СontactsList[1].Surname, actualProject.СontactsList[1].Surname);
            Assert.AreEqual(expectedProject.СontactsList[1].Name, actualProject.СontactsList[1].Name);
            Assert.AreEqual(expectedProject.СontactsList[1].Bdate, actualProject.СontactsList[1].Bdate);
            Assert.AreEqual(expectedProject.СontactsList[1].Number.Number, actualProject.СontactsList[1].Number.Number);
            Assert.AreEqual(expectedProject.СontactsList[1].Mail, actualProject.СontactsList[1].Mail);
            Assert.AreEqual(expectedProject.СontactsList[1].IDVK, actualProject.СontactsList[1].IDVK);
        }
    }
}