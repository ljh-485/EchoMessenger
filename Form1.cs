namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateMessageCount();
        }

        private void bntSpend_Click(object sender, EventArgs e)
        {
            // [3번 기능] 글자 수 제한 확인 (50자 초과 시 전송 차단)
            if (txtInsert.Text.Length > 50)
            {
                MessageBox.Show("메시지는 최대 50자까지만 입력 가능합니다.", "입력 제한", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string typed_msg = txtInsert.Text.Trim();

            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtInsert.Clear();
                return;
            }

            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            lstTotalMessege.Items.Add($"[{currentTime}] {typed_msg}");

            txtInsert.Clear();
            txtInsert.Focus();
            UpdateMessageCount();

            // 새 메시지 추가 시 스크롤 최하단 이동
            if (lstTotalMessege.Items.Count > 0)
                lstTotalMessege.TopIndex = lstTotalMessege.Items.Count - 1;
        }

      

        private void UpdateMessageCount()
        {
            lblCount.Text = $"총 메시지 개수: {lstTotalMessege.Items.Count}개";
        }

        private void txtInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bntSpend.PerformClick();
            }
        }

        // 다시 생성해주는 빈 메서드들
        private void lstTotalMessege_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 아무 내용도 없어도 됩니다. 연결 오류를 막기 위함입니다.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 아무 내용도 없어도 됩니다.
        }

        private void bntDeleteSelected_Click(object sender, EventArgs e)
        {
            // 선택된 항목의 인덱스 확인 (-1은 선택되지 않았음을 의미)
            if (lstTotalMessege.SelectedIndex != -1)
            {
                lstTotalMessege.Items.RemoveAt(lstTotalMessege.SelectedIndex);
                UpdateMessageCount(); // 개수 업데이트
            }
            else
            {
                // 선택하지 않고 삭제 버튼을 눌렀을 때 예외 처리(안내)
                MessageBox.Show("삭제할 메시지를 먼저 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bntClearAll_Click(object sender, EventArgs e)
        {
            // 사용자에게 정말 지울 것인지 한 번 더 물어보는 것이 좋습니다.
            DialogResult result = MessageBox.Show("대화 기록을 모두 삭제하시겠습니까?", "초기화 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstTotalMessege.Items.Clear();
                UpdateMessageCount();
                txtInsert.Focus();
            }
        }
    }
}