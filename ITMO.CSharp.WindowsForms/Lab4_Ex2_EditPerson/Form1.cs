using System;

namespace Lab4_Ex2_EditPerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EditPersonForm editForm = new EditPersonForm(); //экземпл€р формы диалоговогоокна
            
            //ќтобразите форму диалогового окна с помощью метода
            //ShowDialog() и если будет нажата в диалоговом окне кнопка OK
            //реализуйте заполнение списка ListView главной формы

            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName); 
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверку,что не выбран элемент дл€ редактировани€ и 
            //присвойте выбранный элемент экземпл€ру списка

            if (personsListView.SelectedItems.Count == 0) return;
            ListViewItem item = personsListView.SelectedItems[0];

            //—оздайте форму диалогового окна и передайте содержимое элементов списка 
            //главной формы в свойства диалогового окна
            
            EditPersonForm editForm = new EditPersonForm();
            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text; 
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            //¬ случае изменени€ данных и нажати€ кнопки —охранить на
            //форме диалога передайте новые значени€ свойств в
            //соответствующие элементы списка

            if (editForm.ShowDialog() != DialogResult.OK) return;
            item.Text = editForm.FirstName; 
            item.SubItems[1].Text = editForm.LastName; 
            item.SubItems[2].Text = editForm.Age.ToString();

        }
    }
}