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
            label1 = new Label();
            lstTotalMessege = new ListBox();
            bntSpend = new Button();
            txtInsert = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(512, 86);
            label1.TabIndex = 0;
            label1.Text = "EchoMessenger";
            // 
            // lstTotalMessege
            // 
            lstTotalMessege.FormattingEnabled = true;
            lstTotalMessege.Location = new Point(71, 122);
            lstTotalMessege.Name = "lstTotalMessege";
            lstTotalMessege.Size = new Size(948, 452);
            lstTotalMessege.TabIndex = 1;
            lstTotalMessege.SelectedIndexChanged += lstTotalMessege_SelectedIndexChanged;
            // 
            // bntSpend
            // 
            bntSpend.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            bntSpend.Location = new Point(914, 629);
            bntSpend.Name = "bntSpend";
            bntSpend.Size = new Size(96, 65);
            bntSpend.TabIndex = 2;
            bntSpend.Text = "전송\r\n";
            bntSpend.UseVisualStyleBackColor = true;
            bntSpend.Click += bntSpend_Click;
            // 
            // txtInsert
            // 
            txtInsert.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInsert.Location = new Point(71, 629);
            txtInsert.Name = "txtInsert";
            txtInsert.Size = new Size(847, 65);
            txtInsert.TabIndex = 3;
            txtInsert.Text = "여기에 입력하세요";
            txtInsert.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1332, 789);
            Controls.Add(txtInsert);
            Controls.Add(bntSpend);
            Controls.Add(lstTotalMessege);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstTotalMessege;
        private Button bntSpend;
        private TextBox txtInsert;
    }
}
