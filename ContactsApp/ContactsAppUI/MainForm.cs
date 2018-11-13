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
    public partial class MainForm : Form
    {

        private Project Contacts = new Project();
        public MainForm()
        {
            InitializeComponent();
            Contacts = Projectmanager.Deserialization();
            foreach (var contact in Contacts.СontactsList)
            {
                ContactslistBox.Items.Add(contact.Surname);
            }
        }
       

        
        private void EditButton_Click(object sender, EventArgs e) ///редактирование контакта
        {
            EditContact();
        }

        private void DeleteButton_Click(object sender, EventArgs e) ///удаление
        {
            
                DeleteContact();
            
            
        }
        private void AddButton_Click(object sender, EventArgs e) ///добавление нового контакта
        {
            AddContact();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditContact() ///метод для редактирование контакта
        {
            var sIndex = ContactslistBox.SelectedIndex;
            var inner = new ContactForm();
            if (sIndex == -1)
            {

            }
            else
            {
                inner.Contact = Contacts.СontactsList[sIndex];
                var result = inner.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    var upCont = inner.Contact;
                    ContactslistBox.Items.Clear();
                    Contacts.СontactsList.RemoveAt(sIndex);
                    Contacts.СontactsList.Add(upCont);


                    foreach (var contact in Contacts.СontactsList)
                    {
                        ContactslistBox.Items.Add(contact.Surname);
                    }
                    Projectmanager.Serialization(Contacts);
                }
            }
        }
        private void AddContact()///метод для создание нового контакта
        {
            var sIndex = ContactslistBox.SelectedIndex;// вытащили ндекс выбранного элемента
            var addater = new ContactForm();//создали переменную с типом данных окна, котоорый откроется при нажатии
            addater.Contact = null; // передали класс типа Сontact, пустой(так как новый контакт)
            var result = addater.ShowDialog(this);//вызвали это окно
            if (result == DialogResult.OK)// если нажато ок в окне, то сработает это условие
            {
                var upCont = addater.Contact; //создали новый класс, с одним кантактом, и записали в него то что заполнили в окне
                ContactslistBox.Items.Clear();// очистили листбокс
                Contacts.СontactsList.Add(upCont);//добавили в массив контактов, наш новвосозданный контакт


                foreach (var contact in Contacts.СontactsList)//з аполнили лист бокс
                {
                    ContactslistBox.Items.Add(contact.Surname);
                }
                Projectmanager.Serialization(Contacts);//сохранили в файл новый массив, с новым контактом
            }

        }
        private void DeleteContact() ///метод для удаление контакта
        {
            if (MessageBox.Show("Do you really want to remove this contacts: " + Contacts.СontactsList[ContactslistBox.SelectedIndex].Surname,
"DeleteNote", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var selectedIndex = ContactslistBox.SelectedIndex;// вытащили идекс выбранного элемента
                Contacts.СontactsList.RemoveAt(selectedIndex);
                Projectmanager.Serialization(Contacts);
                ContactslistBox.Items.Clear();
                foreach (var contact in Contacts.СontactsList)
                {
                    ContactslistBox.Items.Add(contact.Surname);
                }
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) //вывод окна информации
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e) //создание контакта, через верхнее еню
        {
            AddContact();
        }

        private void editContactToolStripMenuItem1_Click(object sender, EventArgs e)// редактирование контакта, через верхнее меню
        {
            EditContact();
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)//удаление контакта, через верхнее меню
        {
            DeleteContact();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactslistBox.SelectedIndex != -1)
            {
                SurnameTextBox.Text = Contacts.СontactsList[ContactslistBox.SelectedIndex].Surname;
                NameTextBox.Text = Contacts.СontactsList[ContactslistBox.SelectedIndex].Name;
                BdateDateTime.Value = Contacts.СontactsList[ContactslistBox.SelectedIndex].Bdate;
                NumberTextBox.Text = Contacts.СontactsList[ContactslistBox.SelectedIndex].Number.Number.ToString();
                MailTextBox.Text = Contacts.СontactsList[ContactslistBox.SelectedIndex].Mail;
                IDVKextBox.Text = Contacts.СontactsList[ContactslistBox.SelectedIndex].IDVK;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}