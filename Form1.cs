namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void bntSpend_Click(object sender, EventArgs e)
        {
            string typed_msg = txtInsert.Text;
            lstTotalMessege.Items.Add(typed_msg);
            txtInsert.Clear();

            //입력창으로 커서를 다시 보냅니다.
            txtInsert.Focus();
        }

        private void lstTotalMessege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
