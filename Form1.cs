namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 시작할 때 메시지 개수를 0으로 초기화
            UpdateMessageCount();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void bntSpend_Click(object sender, EventArgs e)
        {
            // 1. 앞뒤 공백 제거 (Trim)
            string typed_msg = txtInsert.Text.Trim();

            // 2. 빈 문자열이나 공백만 있을 경우 차단
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtInsert.Clear();
                return;
            }

            // 3. 현재 시간 구하기 (ex. 13:04:34)
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            // 4. [시간]메시지 형식으로 딱 '한 번만' 리스트에 추가합니다.
            // 기존에 있던 lstTotalMessege.Items.Add(typed_msg); 코드는 지워야 합니다.
            lstTotalMessege.Items.Add($"[{currentTime}] {typed_msg}");

            // 5. 입력창 비우기 및 포커스
            txtInsert.Clear();
            txtInsert.Focus();

            // 6. 하단 라벨에 총 메시지 개수 업데이트
            UpdateMessageCount();

            // 7. (선택사항) 새 메시지가 추가되면 스크롤을 맨 아래로 내림
            lstTotalMessege.TopIndex = lstTotalMessege.Items.Count - 1;
        }

        // 메시지 개수를 업데이트하는 별도의 메서드 (중복 방지)
        private void UpdateMessageCount()
        {
            // lblCount는 하단에 배치한 Label의 Name입니다.
            lblCount.Text = $"총 메시지 개수: {lstTotalMessege.Items.Count}개";
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
