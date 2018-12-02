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
    class PhoneNumberTest
    {
        private PhoneNumber _Pnumber;

        [SetUp]
        public void InitPhoneNumber()
        {
            _Pnumber = new PhoneNumber();
        }

        [Test(Description = "Присвоение номера телефона контакта меньше 70000000000")]
        public void TestNumberSet_inCorrectValue()
        {
            var wrongNumber = "65899874521";

            Assert.Throws<ArgumentException>(() => { _Pnumber.Number = wrongNumber.LongCount(); });
        }

        [Test(Description = "Присвоение номера телефона контакта больше 70000000000")]
        public void TestNumber2Set_inCorrectValue()
        {
            var wrongNumber = "988888888888888";

            Assert.Throws<ArgumentException>(() => { _Pnumber.Number = wrongNumber.LongCount(); });
        }
        [Test(Description = "Присвоение корректного номера телефона контакта ")]
        public void TestNumberSet_CorrectValue()
        {
            var expected = 79996190196;
            _Pnumber.Number = expected;
        }

        [Test(Description = "Позитивный тест для геттерa Number")]
        public void TestNumberGet_CorrectValue()
        {
            var expected = 79996190196;
            _Pnumber.Number = expected;
            var actual = _Pnumber.Number;

            Assert.AreEqual(expected, actual, "Геттер возвращает неправильное значение");
        }
    }
}
