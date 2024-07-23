namespace CSharp_TinhChuViDienTich
{
    partial class HinhTron
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKQ = new Label();
            lbl = new Label();
            button2 = new Button();
            btxDIENTICH = new Button();
            button1 = new Button();
            btxCHUVI = new Button();
            txtB = new TextBox();
            txtA = new TextBox();
            lblB = new Label();
            lblA = new Label();
            SuspendLayout();
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(204, 210);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(110, 33);
            lblKQ.TabIndex = 12;
            lblKQ.Text = "Kết Quả";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(57, 210);
            lbl.Name = "lbl";
            lbl.Size = new Size(110, 33);
            lbl.TabIndex = 13;
            lbl.Text = "Kết Quả";
            // 
            // button2
            // 
            button2.Location = new Point(479, 338);
            button2.Name = "button2";
            button2.Size = new Size(148, 47);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btxDIENTICH
            // 
            btxDIENTICH.Location = new Point(151, 338);
            btxDIENTICH.Name = "btxDIENTICH";
            btxDIENTICH.Size = new Size(148, 47);
            btxDIENTICH.TabIndex = 8;
            btxDIENTICH.Text = "Diện Tích";
            btxDIENTICH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 285);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 9;
            button1.Text = "TÍNH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btxCHUVI
            // 
            btxCHUVI.Location = new Point(12, 338);
            btxCHUVI.Name = "btxCHUVI";
            btxCHUVI.Size = new Size(117, 47);
            btxCHUVI.TabIndex = 10;
            btxCHUVI.Text = "Chu Vi";
            btxCHUVI.UseVisualStyleBackColor = true;
            // 
            // txtB
            // 
            txtB.Location = new Point(204, 137);
            txtB.Name = "txtB";
            txtB.Size = new Size(247, 40);
            txtB.TabIndex = 11;
            // 
            // txtA
            // 
            txtA.Location = new Point(204, 76);
            txtA.Name = "txtA";
            txtA.Size = new Size(247, 40);
            txtA.TabIndex = 6;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(57, 144);
            lblB.Name = "lblB";
            lblB.Size = new Size(98, 33);
            lblB.TabIndex = 4;
            lblB.Text = "Cạnh b";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(57, 83);
            lblA.Name = "lblA";
            lblA.Size = new Size(97, 33);
            lblA.TabIndex = 5;
            lblA.Text = "Cạnh a";
            // 
            // HinhTron
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 461);
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
            Name = "HinhTron";
            Text = "HinhTron";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKQ;
        private Label lbl;
        private Button button2;
        private Button btxDIENTICH;
        private Button button1;
        private Button btxCHUVI;
        private TextBox txtB;
        private TextBox txtA;
        private Label lblB;
        private Label lblA;
    }
}