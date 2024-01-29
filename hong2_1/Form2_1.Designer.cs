namespace hong2_1
{
    partial class Form2_1
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
            this.Pintbtn = new System.Windows.Forms.Button();
            this.fabtn = new System.Windows.Forms.Button();
            this.qubtn = new System.Windows.Forms.Button();
            this.halbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pintbtn
            // 
            this.Pintbtn.BackColor = System.Drawing.Color.LightPink;
            this.Pintbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.Pintbtn.FlatAppearance.BorderSize = 0;
            this.Pintbtn.Font = new System.Drawing.Font("나눔손글씨 펜", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Pintbtn.Location = new System.Drawing.Point(0, -1);
            this.Pintbtn.Name = "Pintbtn";
            this.Pintbtn.Size = new System.Drawing.Size(400, 233);
            this.Pintbtn.TabIndex = 1;
            this.Pintbtn.Text = "파인트";
            this.Pintbtn.UseVisualStyleBackColor = false;
            this.Pintbtn.Click += new System.EventHandler(this.Pintbtn_Click);
            // 
            // fabtn
            // 
            this.fabtn.BackColor = System.Drawing.Color.LightPink;
            this.fabtn.FlatAppearance.BorderColor = System.Drawing.Color.LightPink;
            this.fabtn.FlatAppearance.BorderSize = 0;
            this.fabtn.Font = new System.Drawing.Font("나눔손글씨 펜", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fabtn.Location = new System.Drawing.Point(0, 229);
            this.fabtn.Name = "fabtn";
            this.fabtn.Size = new System.Drawing.Size(400, 223);
            this.fabtn.TabIndex = 2;
            this.fabtn.Text = "패밀리";
            this.fabtn.UseVisualStyleBackColor = false;
            // 
            // qubtn
            // 
            this.qubtn.BackColor = System.Drawing.Color.LightPink;
            this.qubtn.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.qubtn.FlatAppearance.BorderSize = 0;
            this.qubtn.Font = new System.Drawing.Font("나눔손글씨 펜", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.qubtn.Location = new System.Drawing.Point(396, -1);
            this.qubtn.Name = "qubtn";
            this.qubtn.Size = new System.Drawing.Size(404, 233);
            this.qubtn.TabIndex = 3;
            this.qubtn.Text = "쿼터";
            this.qubtn.UseVisualStyleBackColor = false;
            // 
            // halbtn
            // 
            this.halbtn.BackColor = System.Drawing.Color.LightPink;
            this.halbtn.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.halbtn.FlatAppearance.BorderSize = 0;
            this.halbtn.Font = new System.Drawing.Font("나눔손글씨 펜", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.halbtn.Location = new System.Drawing.Point(396, 229);
            this.halbtn.Name = "halbtn";
            this.halbtn.Size = new System.Drawing.Size(404, 223);
            this.halbtn.TabIndex = 4;
            this.halbtn.Text = "하프갤런";
            this.halbtn.UseVisualStyleBackColor = false;
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.halbtn);
            this.Controls.Add(this.qubtn);
            this.Controls.Add(this.fabtn);
            this.Controls.Add(this.Pintbtn);
            this.Name = "Form2_1";
            this.Text = "사이즈 선택";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pintbtn;
        private System.Windows.Forms.Button fabtn;
        private System.Windows.Forms.Button qubtn;
        private System.Windows.Forms.Button halbtn;
    }
}