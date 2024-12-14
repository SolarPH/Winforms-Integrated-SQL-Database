namespace IntegratedDatabase
{
    public partial class Form1 : Form
    {
        ServerConnect srv;
        public Form1()
        {
            InitializeComponent();
            srv = new ServerConnect();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            srv.InsertData(txt_Text.Text.Trim(), Convert.ToInt32(num_Number.Value));
            reinitializeFields();
        }

        private void reinitializeFields()
        {
            txt_Text.Clear();
            num_Number.Value = 0;
        }
    }
}
