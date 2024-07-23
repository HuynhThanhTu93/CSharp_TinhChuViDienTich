namespace CSharp_TinhChuViDienTich
{
    partial class HinhChuNhat
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
            lblA = new Label();
            lblB = new Label();
            txtB = new TextBox();
            txtA = new TextBox();
            btxCHUVI = new Button();
            btxDIENTICH = new Button();
            lbl = new Label();
            button1 = new Button();
            lblKQ = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(57, 60);
            lblA.Name = "lblA";
            lblA.Size = new Size(97, 33);
            lblA.TabIndex = 0;
            lblA.Text = "Cạnh a";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(57, 121);
            lblB.Name = "lblB";
            lblB.Size = new Size(98, 33);
            lblB.TabIndex = 0;
            lblB.Text = "Cạnh b";
            // 
            // txtB
            // 
            txtB.Location = new Point(204, 114);
            txtB.Name = "txtB";
            txtB.Size = new Size(247, 40);
            txtB.TabIndex = 2;
            // 
            // txtA
            // 
            txtA.Location = new Point(204, 53);
            txtA.Name = "txtA";
            txtA.Size = new Size(247, 40);
            txtA.TabIndex = 1;
            // 
            // btxCHUVI
            // 
            btxCHUVI.Location = new Point(12, 315);
            btxCHUVI.Name = "btxCHUVI";
            btxCHUVI.Size = new Size(117, 47);
            btxCHUVI.TabIndex = 2;
            btxCHUVI.Text = "Chu Vi";
            btxCHUVI.UseVisualStyleBackColor = true;
            btxCHUVI.Click += btxCHUVI_Click;
            // 
            // btxDIENTICH
            // 
            btxDIENTICH.Location = new Point(151, 315);
            btxDIENTICH.Name = "btxDIENTICH";
            btxDIENTICH.Size = new Size(148, 47);
            btxDIENTICH.TabIndex = 2;
            btxDIENTICH.Text = "Diện Tích";
            btxDIENTICH.UseVisualStyleBackColor = true;
            btxDIENTICH.Click += btxDIENTICH_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(57, 187);
            lbl.Name = "lbl";
            lbl.Size = new Size(110, 33);
            lbl.TabIndex = 3;
            lbl.Text = "Kết Quả";
            // 
            // button1
            // 
            button1.Location = new Point(12, 262);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 2;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(204, 187);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(110, 33);
            lblKQ.TabIndex = 3;
            lblKQ.Text = "Kết Quả";
            // 
            // button2
            // 
            button2.Location = new Point(479, 315);
            button2.Name = "button2";
            button2.Size = new Size(148, 47);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 390);
            Controls.Add(lblKQ);
            Controls.Add(lbl);
            Controls.Add(button2);
            Controls.Add(btxDIENTICH);
            Controls.Add(button1);
            Controls.Add(btxCHUVI);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HÌNH CHỮ NHẬT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private TextBox txtB;
        private TextBox txtA;
        private Button btxCHUVI;
        private Button btxDIENTICH;
        private Label lbl;
        private Button button1;
        private Label lblKQ;
        private Button button2;
    }
}
