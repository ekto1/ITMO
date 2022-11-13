using BiblWorm.Bibl;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab2_Ex6_BiblWorm
{
    public partial class Form1 : Form
    {
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру 
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Срок использования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        List<Item> its = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Book b = new Book(
                Author,
                Title,
                PublishHouse,
                Page,
                Year,
                InvNumber,
                Existence);
            
            if (ReturnTime) //проверка возврата книги в срок
                b.ReturnSrok();

            b.PriceBook(PeriodUse); // расчет стоимости с учетом срока пользования книгой

            its.Add(b); // добавить книгу в список

            // очистка поля ввода для новой информации
            Author = Title = PublishHouse = "";
            Page = 12;
            InvNumber = PeriodUse = 1; 
            Year = 1900;
            Existence = ReturnTime = false;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (SortInvNumber) // проверьте состояние флажка сортировки и в случае его установки отсортируйте список
                its.Sort();

            // построение строк и информации о единице хранения
            StringBuilder sb = new StringBuilder(); 
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString(); // выведение строки в элемент richTextBox1
        }
    }
}