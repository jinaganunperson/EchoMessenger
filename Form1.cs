namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            // 1. 텍스트박스의 내용 가져오기
            string inputBox = txtBox.Text;

            // 2. 입력값이 비어있지 않은지 확인
            if (!string.IsNullOrWhiteSpace(inputBox))
            {
                // 리스트박스에 항목 추가
                listBox.Items.Add(inputBox);

                // 3. 입력 후 텍스트박스 비우기 및 포커스 이동
                txtBox.Clear();
                txtBox.Focus();
            }
            else
            {
                MessageBox.Show("내용을 입력해주세요!");
            }
        }
    }
}
