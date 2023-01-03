using BiblWorm.Bibl;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab2_Ex6_BiblWorm
{
    public partial class Form1 : Form
    {
        public string Author // �����
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // ��������
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string PublishHouse // ������������
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // ���������� �������
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // ��� �������
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // ����������� �����
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // �������
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // ���������� �� ������������ ������ 
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // ����������� � ����
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // ���� �������������
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }
        public int Number // ����� �������
        {
            get { return (int)numericUpDown5.Value; }
            set { numericUpDown5.Value = value; }
        }
        public string Volume // ��� �������
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string Title2 // �������� �������
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public int Year2 // ��� ������� �������
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public bool IfSubs2 // �������� �� ������
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }
        public int InvNumber2 // ����������� �����
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public bool Existence2 // ������� �������
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public bool ReturnTime2 // ����������� � ����
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
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
            
            if (ReturnTime) //�������� �������� ����� � ����
                b.ReturnSrok();

            b.PriceBook(PeriodUse); // ������ ��������� � ������ ����� ����������� ������

            its.Add(b); // �������� ����� � ������

            // ������� ���� ����� ��� ����� ����������
            Author = Title = PublishHouse = "";
            Page = 12;
            InvNumber = PeriodUse = 1; 
            Year = 1900;
            Existence = ReturnTime = false;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (SortInvNumber) // ��������� ��������� ������ ���������� � � ������ ��� ��������� ������������ ������
                its.Sort();

            // ���������� ����� � ���������� � ������� ��������
            StringBuilder sb = new StringBuilder(); 
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString(); // ��������� ������ � ������� richTextBox1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(
                Volume,
                Number,
                Title2,
                Year2,
                InvNumber2,
                Existence2);

            if (ReturnTime2) //�������� �������� �������
                m.Return();

            if (IfSubs2) //�������� �������� �� ������
                m.Subs();

            its.Add(m); // �������� ������ � ������

            // ������� ���� ����� ��� ����� ����������
            Volume = Title2 = "";
            Number = 100;
            Year2 = 1900;
            InvNumber2 = 1;
            Existence2 = ReturnTime2 = IfSubs2 = false;
        }
    }
}