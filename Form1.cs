namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_MouseClick(object sender, MouseEventArgs e)
        {
            string typed_msg = txtBox.Text; // (작성하신 txtBox 이름을 사용하세요)

            // 3. ListBox에서 항목들을 담는 곳은 어디인가요? -> listBox1.Items
            // 4. 새로운 항목을 추가하려면 어떻게 해야 하나요? -> .Add() 사용
            listBox1.Items.Add(typed_msg);

            // [추가 단계] 입력창을 비워줍니다.
            txtBox.Clear();
        }

        private void btnInput_MouseClick(object sender, MouseEventArgs e)
        {
            string typed_msg = txtBox.Text;
            if (!string.IsNullOrWhiteSpace(typed_msg))
            {
                listBox1.Items.Add(typed_msg);
                txtBox.Clear();
                txtBox.Focus();
            }
                // § ListBox에서 항목들을 담는 곳은 어디인가요? -> .Items
                // § 새로운 항목을 추가하려면 어떻게 해야 하나요? -> .Add() 메서드
                if (!string.IsNullOrWhiteSpace(typed_msg)) // 빈 내용이 아닐 때만 추가
            {
                listBox1.Items.Add(typed_msg);

                // § 추가 직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비합니다.
                txtBox.Clear();

                // 커서를 다시 텍스트박스로 (선택 사항)
                txtBox.Focus();
            }
        }
        // 이 메서드 이름이 Designer.cs에 적은 이름과 토씨 하나 안 틀리고 똑같아야 합니다.
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            // 1. 눌린 키가 엔터키인지 확인
            if (e.KeyCode == Keys.Enter)
            {
                // 2. 버튼 클릭과 동일한 전송 로직 실행
                string typed_msg = txtBox.Text;

                if (!string.IsNullOrWhiteSpace(typed_msg))
                {
                    listBox1.Items.Add(typed_msg);
                    txtBox.Clear();
                    txtBox.Focus(); // 전송 후 바로 다시 입력할 수 있게 포커스 유지
                }

                // 3. 엔터 입력 시 '띵' 소리 나는 것 방지 (UX 개선)
                e.SuppressKeyPress = true;
            }
        }
    }
}
