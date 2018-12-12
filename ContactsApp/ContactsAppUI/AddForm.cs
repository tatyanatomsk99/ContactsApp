using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsApp
{
    
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public Contact Cont;
        public PhoneNumber phone;

        public Contact Contact//метод
        {
           
            set
            {
                Cont = value;
                if (Cont != null)
                {

                    SurnameTextBox.Text = Cont.Surname;
                    NameTextBox.Text = Cont.Name;
                    MailTextBox.Text = Cont.Mail;
                    IDVKTextBox11.Text = Cont.IDVK;
                    BdateDateTime.Value = Cont.Bdate;
                    PhoneNumberTextBox.Text = Cont.Number.Number.ToString();
                }
                else
                {

                    SurnameTextBox.Text = "";
                    NameTextBox.Text = "";
                    MailTextBox.Text = "";
                    IDVKTextBox11.Text = "";
                    BdateDateTime.Value = DateTime.Today;
                    PhoneNumberTextBox.Text = "";
                }

            }
            get
            {
                return Cont;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)//добавление контакта в лист и сериализация
        {
            Cont = new Contact();
            Cont.Number = new PhoneNumber();
            try
            {
                if (SurnameTextBox.Text.Length > 1 && SurnameTextBox.Text.Length < 50 && NameTextBox.Text.Length > 1 && NameTextBox.Text.Length < 50 &&
                   PhoneNumberTextBox.Text.Length == 11 && BdateDateTime.Value > new DateTime(1900, 01, 01) &&
                   BdateDateTime.Value < DateTime.Today && MailTextBox.Text.Length > 1 && MailTextBox.Text.Length < 15 &&
                   IDVKTextBox11.Text.Length > 1 && IDVKTextBox11.Text.Length < 15)
                {
                    Cont.Surname = SurnameTextBox.Text;
                    Cont.Name = NameTextBox.Text;
                    Cont.Bdate = BdateDateTime.Value;
                    Cont.Number.Number = Convert.ToInt64(PhoneNumberTextBox.Text);
                    Cont.Mail = MailTextBox.Text;
                    Cont.IDVK = IDVKTextBox11.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    if (SurnameTextBox.Text.Length > 1 && SurnameTextBox.Text.Length < 50)
                    {
                        Cont.Surname = SurnameTextBox.Text;
                        SurnameTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректную фамилию контакта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        SurnameTextBox.BackColor = Color.LightSalmon;
                    }
                    if (NameTextBox.Text.Length > 1 && NameTextBox.Text.Length < 50)
                    {
                        Cont.Name = NameTextBox.Text;
                        NameTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное имя контакта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameTextBox.BackColor = Color.LightSalmon;
                    }
                    if (BdateDateTime.Value > new DateTime(1900, 01, 01) && BdateDateTime.Value < DateTime.Today)
                    {
                        Cont.Bdate = BdateDateTime.Value;
                        BdateDateTime.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректную дату рождения контакта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BdateDateTime.BackColor = Color.LightSalmon;
                    }
                    if (PhoneNumberTextBox.Text.Length == 11)
                    {
                        PhoneNumberTextBox.BackColor = Color.White;
                        Cont.Number.Number = Convert.ToInt64(PhoneNumberTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Введите корректный номер телефона контакта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PhoneNumberTextBox.BackColor = Color.LightSalmon;
                    }
                    if (MailTextBox.Text.Length > 1 && MailTextBox.Text.Length < 50)
                    {
                        Cont.Mail = MailTextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректную электронную почту контакта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MailTextBox.BackColor = Color.LightSalmon;
                    }
                    if (IDVKTextBox11.Text.Length > 1 && IDVKTextBox11.Text.Length < 15)
                    {
                        Cont.IDVK = IDVKTextBox11.Text;
                        IDVKTextBox11.BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное id vk.com контакта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        IDVKTextBox11.BackColor = Color.LightSalmon;
                    }
                }
            }

            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }

         }

        private void CloseButton_Click(object sender, EventArgs e)// закрытие addform
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)&& e.KeyChar != (char)Keys.Back)// запрет на ввод символов и разрешение на исправление
            {
                e.Handled = true;
            }
        }
    }
}