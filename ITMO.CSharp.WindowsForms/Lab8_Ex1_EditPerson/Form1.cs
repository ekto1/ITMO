using Lab4_Ex3_EditPerson;
using System;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_Ex2_EditPerson
{
    public partial class Form1 : Form
    {
        List<Person> pers = new List<Person>();
        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName); 
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName); 
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            EditPersonForm editForm = new EditPersonForm(p); //экземпляр формы диалоговогоокна

            ////Отобразите форму диалогового окна с помощью метода
            ////ShowDialog() и если будет нажата в диалоговом окне кнопка OK
            ////реализуйте заполнение списка ListView главной формы

            if (editForm.ShowDialog() != DialogResult.OK) return;

            //ListViewItem newItem = personsListView.Items.Add(editForm.FirstName); 
            //newItem.SubItems.Add(editForm.LastName);
            //newItem.SubItems.Add(editForm.Age.ToString());
            
            pers.Add(p);

            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0) 
                return;
            Person p = pers[personsListView.SelectedIndices[0]];

            EditPersonForm editForm = new EditPersonForm(p);
            
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }

            ////проверку,что не выбран элемент для редактирования и 
            ////присвойте выбранный элемент экземпляру списка

            //if (personsListView.SelectedItems.Count == 0) return;
            //ListViewItem item = personsListView.SelectedItems[0];

            ////Создайте форму диалогового окна и передайте содержимое элементов списка 
            ////главной формы в свойства диалогового окна

            //EditPersonForm editForm = new EditPersonForm();
            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text; 
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            ////В случае изменения данных и нажатия кнопки Сохранить на
            ////форме диалога передайте новые значения свойств в
            ////соответствующие элементы списка

            //if (editForm.ShowDialog() != DialogResult.OK) return;
            //item.Text = editForm.FirstName; 
            //item.SubItems[1].Text = editForm.LastName; 
            //item.SubItems[2].Text = editForm.Age.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 
            
            foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            
            richTextBox1.Text = sb.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream fStream = new FileStream("AllMyPerson.dat",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, pers);
            }

            using (FileStream fStream = new FileStream("PersonCollection.xml", 
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Person>));
                xmlFormat.Serialize(fStream, pers);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter(); 
            try
            {
                using (FileStream fStream = new FileStream("AllMyPerson.dat", 
                    FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    pers.AddRange((List<Person>)binFormat.Deserialize(fStream));
                }
            }
            catch 
            { }
        }
    }
}