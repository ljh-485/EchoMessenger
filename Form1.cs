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
           
            

            // 1. .Trim()을 사용하여 앞뒤 공백을 제거한 텍스트를 가져옵니다.
            typed_msg = txtInsert.Text.Trim();

            // 2. 내용이 비어있거나 공백만 있다면 전송하지 않고 종료(return)합니다.
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtInsert.Clear(); // 스페이스바만 쳤을 경우를 대비해 칸을 비워줌
                return;
            }

            // 3. 정상적인 내용이 있을 때만 리스트에 추가
            lstTotalMessege.Items.Add(typed_msg);

            txtInsert.Clear();
            //입력창으로 커서를 다시 보냅니다.
            txtInsert.Focus();
        }

        private void lstTotalMessege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInsert_KeyDown(object sender, KeyEventArgs e)
        {
            // 누른 키가 엔터키인지 확인
            if (e.KeyCode == Keys.Enter)
            {
                // 소리 방지 (엔터 누를 때 '띵' 소리가 나는 것을 막아줍니다)
                e.SuppressKeyPress = true;

                // 이미 만들어둔 전송 버튼 클릭 이벤트를 실행
                bntSpend.PerformClick();
            }
        }
    }
}
