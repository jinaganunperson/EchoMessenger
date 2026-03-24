using System;
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // [핵심] 모든 전송 로직 (시간 결합 + 개수 업데이트 포함)
        private void SendMessage()
        {
            // 1. 공백 제거
            string typedMsg = txtBox.Text.Trim();

            // 2. 내용 확인
            if (!string.IsNullOrWhiteSpace(typedMsg))
            {
                // 3. 시간 정보 결합
                string currentTime = DateTime.Now.ToString("HH:mm:ss");
                string messageWithTime = $"[{currentTime}] {typedMsg}";

                // 4. 리스트박스에 추가
                listBox.Items.Add(messageWithTime);

                // 5. [중요] 메시지 개수 실시간 업데이트
                lblnum.Text = $"총 메시지: {listBox.Items.Count}개";

                // 6. 마무리
                txtBox.Clear();
                txtBox.Focus();
            }
        }

        // 버튼 클릭 시
        private void btnInput_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        // 텍스트박스에서 엔터키 입력 시
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 엔터키를 쳤을 때도 SendMessage()를 실행해야 숫자가 바뀝니다!
                SendMessage();

                // '띵' 소리 방지
                e.SuppressKeyPress = true;
            }
        }
    }
}