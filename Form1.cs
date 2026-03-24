using System;
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 사용자가 50자 넘게 입력은 할 수 있어야 경고창을 띄울 수 있으므로
            // MaxLength를 제한하지 않거나 크게 설정합니다.
            txtBox.MaxLength = 32767;
        }

        // [핵심] 메시지 전송 로직
        private void SendMessage()
        {
            // 1. 앞뒤 공백 제거
            string typedMsg = txtBox.Text.Trim();

            // 2. [검사] 50자를 초과했는지 확인
            if (typedMsg.Length > 50)
            {
                // 50자 초과 시 경고 메시지 출력
                MessageBox.Show("50자 이하만 입력해 주세요.", "알림");

                // 전송을 하지 않고 함수를 종료(return)하여 리스트 추가를 막음
                return;
            }

            // 3. 내용이 비어있지 않은 경우에만 전송 진행
            if (!string.IsNullOrWhiteSpace(typedMsg))
            {
                string currentTime = DateTime.Now.ToString("HH:mm:ss");
                listBox.Items.Add($"[{currentTime}] {typedMsg}");

                UpdateCount();
                txtBox.Clear();
                txtBox.Focus();
            }
        }

        private void UpdateCount()
        {
            lblnum.Text = $"총 메시지: {listBox.Items.Count}개";
        }

        private void btnInput_Click(object sender, EventArgs e) => SendMessage();

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true;
            }
        }

        // 선택 삭제 버튼 (btnremove)
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                UpdateCount();
            }
            else
            {
                MessageBox.Show("삭제할 메시지를 클릭해서 먼저 선택해 주세요!", "알림");
            }
        }

        // 전체 삭제 버튼 (btnremoveall)
        private void btnremoveall_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                if (MessageBox.Show("모든 대화 기록을 지우시겠습니까?", "전체 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listBox.Items.Clear();
                    UpdateCount();
                }
            }
        }
    }
}