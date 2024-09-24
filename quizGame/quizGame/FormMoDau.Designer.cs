namespace quizGame
{
    partial class FormMoDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoDau));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnFormMoDau_Start = new System.Windows.Forms.Button();
            this.btnCreateQR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcome.Image = ((System.Drawing.Image)(resources.GetObject("lblWelcome.Image")));
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Location = new System.Drawing.Point(-1, -1);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1215, 826);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Chào mừng quý thầy cô đang sử dụng phần mềm điểm danh của công ty TNHH TDDDN";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnFormMoDau_Start
            // 
            this.btnFormMoDau_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormMoDau_Start.ForeColor = System.Drawing.Color.Black;
            this.btnFormMoDau_Start.Location = new System.Drawing.Point(221, 665);
            this.btnFormMoDau_Start.Name = "btnFormMoDau_Start";
            this.btnFormMoDau_Start.Size = new System.Drawing.Size(154, 55);
            this.btnFormMoDau_Start.TabIndex = 2;
            this.btnFormMoDau_Start.Text = "Bắt đầu ";
            this.btnFormMoDau_Start.UseVisualStyleBackColor = true;
            this.btnFormMoDau_Start.Click += new System.EventHandler(this.btnFormMoDau_Start_Click);
            // 
            // btnCreateQR
            // 
            this.btnCreateQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQR.ForeColor = System.Drawing.Color.Black;
            this.btnCreateQR.Location = new System.Drawing.Point(424, 665);
            this.btnCreateQR.Name = "btnCreateQR";
            this.btnCreateQR.Size = new System.Drawing.Size(154, 55);
            this.btnCreateQR.TabIndex = 4;
            this.btnCreateQR.Text = "Tạo Mã QR";
            this.btnCreateQR.UseVisualStyleBackColor = true;
            this.btnCreateQR.Click += new System.EventHandler(this.btnCreateQR_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(627, 665);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(830, 665);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormMoDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1217, 824);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateQR);
            this.Controls.Add(this.btnFormMoDau_Start);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.IsMdiContainer = true;
            this.Name = "FormMoDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm điểm danh cho giảng viên";
            this.Load += new System.EventHandler(this.FormMoDau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnFormMoDau_Start;
        private System.Windows.Forms.Button btnCreateQR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}