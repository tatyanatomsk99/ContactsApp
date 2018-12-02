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
    class ContactTest
    {
        private Contact _cont;

       [SetUp]
        public void InitContact()
        {
            _cont = new Contact();
        }
        
        [Test(Description = "Присвоение фамилии контакта более 50 символов")]
        public void TestSurnameSet_inCorrectValue()
        {
            var wrongSurname = "ИвановСмирновСидоровКличкоПетровКравченкоИвановСмирновСидоровКличкоПетровКравченко";

            Assert.Throws<ArgumentException>(() => { _cont.Surname = wrongSurname; });
        }

        [Test(Description = "Присвоение корректной фамилии контакта менее 50 символов")]
        public void TestSurnameSet_CorrectValue()
        {
            var expected = "Иванов";
            _cont.Surname = expected;
        }

        [Test(Description = "Позитивный тест для геттерa Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            var expected = "Смиронов";
            _cont.Surname = expected;
            var actual = _cont.Surname;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное значение");
        }

        [Test(Description = "Присвоение имени контакта более 50 символов")]
        public void TestNameSet_inCorrectValue()
        {
            var wrongName = "ТаняВасяКатяМашаПашаИгорьПетяАнтонВитяГришаМишаДашаГлашаВикторДенисАндрей";

            Assert.Throws<ArgumentException>(() => { _cont.Name = wrongName; });
        }

        [Test(Description = "Присвоение корректного имени контакта менее 50 символов ")]
        public void TestNameSet_CorrectValue()
        {
            var expected = "Сергей";
            _cont.Name = expected;
        }

        [Test(Description = "Позитивный тест для геттерa Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Дмитрий";
            _cont.Name = expected;
            var actual = _cont.Name;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное значение");
        }

        [Test(Description = "Присвоение электронной почты контакта более 50 символов")]
        public void TestMailSet_inCorrectValue()
        {
            var wrongMail = "qwertyuiopasdfghjklzxcvbnmqwertyuiiopasdfghjklzxcvbnmqqewrwueodhsbckaodhdheydoxnd";

            Assert.Throws<ArgumentException>(() => { _cont.Mail = wrongMail; });
        }

        [Test(Description = "Присвоение корректной электронной почты контакта менее 50 символов ")]
        public void TestMaileSet_CorrectValue()
        {
            var expected = "IvanjvSergei@bk.com";
            _cont.Mail = expected;
        }

        [Test(Description = "Позитивный тест для геттерa Mail")]
        public void TestMailGet_CorrectValue()
        {
            var expected = "Tusur.ru";
            _cont.Mail = expected;
            var actual = _cont.Mail;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное значение");
        }

        [Test(Description = "Присвоение IDvk контакта более 15 символов")]
        public void TestIDVKSet_inCorrectValue()
        {
            var wrongIDVK = "1234567897894561232136484846565458468546549846546";

            Assert.Throws<ArgumentException>(() => { _cont.IDVK = wrongIDVK; });
        }
        [Test(Description = "Присвоение корректного Id vk.com контакта менеее 15 символов ")]
        public void TestIDVKSet_CorrectValue()
        {
            var expected = "id74589";
            _cont.IDVK = expected;
        }

        [Test(Description = "Позитивный тест для геттерa Idvk")]
        public void TestIDVKGet_CorrectValue()
        {
            var expected = "id124578";
            _cont.IDVK = expected;
            var actual = _cont.IDVK;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное значение");
        }

        [Test(Description = "Присвоение даты рождения больше текущей даты")]
        public void TestBdateSet_inCorrectValue()
        {
            var wrongBdate = new DateTime(2020, 05, 02);

            Assert.Throws<ArgumentException>(() => { _cont.Bdate = wrongBdate; });
        }

        [Test(Description = "Присвоение даты рождения меньше 1900,01,01")]
        public void TestBdate2Set_inCorrectValue()
        {
            var wrongBdate = new DateTime(1839,01,01);

            Assert.Throws<ArgumentException>(() => { _cont.Bdate = wrongBdate; });
        }

        [Test(Description = "Присвоение корректной даты рождения ")]
        public void TestBdateSet_CorrectValue()
        {
            var expected = new DateTime(2014, 05, 18);
            _cont.Bdate = expected;
        }

        [Test(Description = "Позитивный тест для геттерa Bdate")]
        public void TestBdateGet_CorrectValue()
        {
            var expected =  new DateTime(2015,02,09);
            _cont.Bdate = expected;
            var actual = _cont.Bdate;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное значение");
        }

        [Test(Description = "Присвоение корректного номера телефона контакта ")]
        public void TestNumberSet_CorrectValue()
        {
            var expected = 79996190196;
            _cont.Number.Number = expected;
        }

        [Test(Description = "Позитивный тест для геттерa Number")]
        public void TestNumberGet_CorrectValue()
        {
            var expected = 79996190196;
            _cont.Number.Number = expected;
            var actual = _cont.Number.Number;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное значение");
        }
    }
}
