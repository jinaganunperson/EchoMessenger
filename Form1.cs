namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // [핵심] 전송 로직을 공통 메서드로 분리
        private void SendMessage()
        {
            // 4. 입력 방어: 앞뒤 공백을 제거한 후 내용이 있는지 확인
            string typedMsg = txtBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(typedMsg))
            {
                // 리스트박스에 메시지 추가
                listBox.Items.Add(typedMsg);

                // 1. 입력창의 기존 메시지 지우기
                txtBox.Clear();

                // 2. 입력창에 입력 포커스 자동으로 갖다 놓기
                txtBox.Focus();
            }
        }

        // 버튼 클릭 시 호출
        private void btnInput_Click(object sender, EventArgs e)
        {
            SendMessage();
        }


        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터키가 눌렸는지 검사
            if (e.KeyCode == Keys.Enter)
            {
                // 버튼 클릭 시 실행되는 코드를 그대로 실행
                string typedMsg = txtBox.Text.Trim();

                if (!string.IsNullOrWhiteSpace(typedMsg))
                {
                    listBox.Items.Add(typedMsg);
                    txtBox.Clear();
                    txtBox.Focus();
                }

                // '띵' 소리 방지
                e.SuppressKeyPress = true;
            }
        }
    }
}
