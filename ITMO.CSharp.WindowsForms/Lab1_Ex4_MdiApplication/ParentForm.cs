namespace Lab1_Ex4_MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm(); 
            newChild.MdiParent = this; 
            newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments;
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
    }
}