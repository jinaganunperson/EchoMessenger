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
            lbl = new Label();
            txtBox = new TextBox();
            listBox = new ListBox();
            lblnum = new Label();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.Location = new Point(821, 493);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(132, 58);
            btnInput.TabIndex = 0;
            btnInput.Text = "전송";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("휴먼편지체", 28.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            lbl.Location = new Point(242, 25);
            lbl.Name = "lbl";
            lbl.Size = new Size(513, 87);
            lbl.TabIndex = 1;
            lbl.Text = "EchoMessenger";
            // 
            // txtBox
            // 
            txtBox.Location = new Point(97, 494);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(711, 42);
            txtBox.TabIndex = 2;
            txtBox.KeyDown += txtBox_KeyDown;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(59, 116);
            listBox.Name = "listBox";
            listBox.Size = new Size(802, 328);
            listBox.TabIndex = 3;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(61, 445);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(85, 36);
            lblnum.TabIndex = 4;
            lblnum.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 620);
            Controls.Add(lblnum);
            Controls.Add(listBox);
            Controls.Add(txtBox);
            Controls.Add(lbl);
            Controls.Add(btnInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInput;
        private Label lbl;
        private TextBox txtBox;
        private ListBox listBox;
        private Label lblnum;
    }
}
