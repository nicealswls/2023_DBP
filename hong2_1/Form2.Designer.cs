namespace hong2_1
{
    partial class Form2
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
            this.flavordb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flavorTB1 = new System.Windows.Forms.TextBox();
            this.fsave = new System.Windows.Forms.Button();
            this.CalBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flavordb)).BeginInit();
            this.SuspendLayout();
            // 
            // flavordb
            // 
            this.flavordb.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.flavordb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flavordb.Location = new System.Drawing.Point(50, 82);
            this.flavordb.Name = "flavordb";
            this.flavordb.RowHeadersWidth = 62;
            this.flavordb.RowTemplate.Height = 30;
            this.flavordb.Size = new System.Drawing.Size(495, 366);
            this.flavordb.TabIndex = 0;
            this.flavordb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.flavordb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(600, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "맛";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flavorTB1
            // 
            this.flavorTB1.Location = new System.Drawing.Point(604, 99);
            this.flavorTB1.Name = "flavorTB1";
            this.flavorTB1.Size = new System.Drawing.Size(138, 28);
            this.flavorTB1.TabIndex = 3;
            this.flavorTB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fsave
            // 
            this.fsave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fsave.Location = new System.Drawing.Point(604, 323);
            this.fsave.Name = "fsave";
            this.fsave.Size = new System.Drawing.Size(138, 29);
            this.fsave.TabIndex = 5;
            this.fsave.Text = "담기";
            this.fsave.UseVisualStyleBackColor = true;
            this.fsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalBtn
            // 
            this.CalBtn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalBtn.Location = new System.Drawing.Point(691, 416);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(138, 45);
            this.CalBtn.TabIndex = 6;
            this.CalBtn.Text = "결제하기";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "맛 선택(파인트-3가지)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 11;
            // 
            // spnum
            // 
            this.spnum.Location = new System.Drawing.Point(604, 220);
            this.spnum.Name = "spnum";
            this.spnum.Size = new System.Drawing.Size(138, 28);
            this.spnum.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(600, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "스푼";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.spnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.fsave);
            this.Controls.Add(this.flavorTB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flavordb);
            this.Name = "Form2";
            this.Text = "아이스크림 선택";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flavordb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView flavordb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flavorTB1;
        private System.Windows.Forms.Button fsave;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox spnum;
        private System.Windows.Forms.Label label2;
    }
}