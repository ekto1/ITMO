namespace Lab1_Ex5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClosingBbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = 
                new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] 
            {
                new Point(0, this.Height/2),
                new Point(this.Width/2, this.Height), 
                new Point(this.Width, this.Height/2),
                new Point(this.Width/2, 0) 
            });
            Region myRegion = new Region(myPath); 
            this.Region = myRegion;
        }
    }
}