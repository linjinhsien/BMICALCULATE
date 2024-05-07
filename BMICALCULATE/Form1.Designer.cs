namespace BMICALCULATE
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.身高 = new System.Windows.Forms.Label();
            this.體重 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bmiout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 身高
            // 
            this.身高.AutoSize = true;
            this.身高.Location = new System.Drawing.Point(98, 67);
            this.身高.Name = "身高";
            this.身高.Size = new System.Drawing.Size(102, 18);
            this.身高.TabIndex = 0;
            this.身高.Text = "身高: (公尺)";
            // 
            // 體重
            // 
            this.體重.AutoSize = true;
            this.體重.Location = new System.Drawing.Point(98, 146);
            this.體重.Name = "體重";
            this.體重.Size = new System.Drawing.Size(97, 18);
            this.體重.TabIndex = 1;
            this.體重.Text = "體重:(公斤)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 29);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 29);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(457, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "計算bmi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bmiout
            // 
            this.bmiout.AutoSize = true;
            this.bmiout.Location = new System.Drawing.Point(249, 226);
            this.bmiout.Name = "bmiout";
            this.bmiout.Size = new System.Drawing.Size(0, 18);
            this.bmiout.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bmiout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.體重);
            this.Controls.Add(this.身高);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 身高;
        private System.Windows.Forms.Label 體重;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bmiout;
    }
}

