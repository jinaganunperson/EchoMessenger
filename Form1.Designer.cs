namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInput = new Button();
            lblEchoMessenger = new Label();
            listBox1 = new ListBox();
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.Location = new Point(571, 345);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(168, 71);
            btnInput.TabIndex = 0;
            btnInput.Text = "전송";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.MouseClick += btnInput_MouseClick;
            // 
            // lblEchoMessenger
            // 
            lblEchoMessenger.AutoSize = true;
            lblEchoMessenger.Font = new Font("휴먼편지체", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblEchoMessenger.Location = new Point(61, 34);
            lblEchoMessenger.Name = "lblEchoMessenger";
            lblEchoMessenger.Size = new Size(500, 81);
            lblEchoMessenger.TabIndex = 1;
            lblEchoMessenger.Text = "Echo Messenger";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(61, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(500, 184);
            listBox1.TabIndex = 2;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(59, 360);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(499, 42);
            txtBox.TabIndex = 3;
            txtBox.MouseClick += txtBox_MouseClick;
            txtBox.TextChanged += txtBox_TextChanged;
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox);
            Controls.Add(listBox1);
            Controls.Add(lblEchoMessenger);
            Controls.Add(btnInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInput;
        private Label lblEchoMessenger;
        private ListBox listBox1;
        private TextBox txtBox;
    }
}
