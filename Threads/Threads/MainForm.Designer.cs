namespace Threads
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelT1 = new System.Windows.Forms.Label();
            this.labelT2 = new System.Windows.Forms.Label();
            this.labelT3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelT1
            // 
            this.labelT1.AutoSize = true;
            this.labelT1.Location = new System.Drawing.Point(529, 141);
            this.labelT1.Name = "labelT1";
            this.labelT1.Size = new System.Drawing.Size(35, 12);
            this.labelT1.TabIndex = 0;
            this.labelT1.Text = "线程1";
            // 
            // labelT2
            // 
            this.labelT2.AutoSize = true;
            this.labelT2.Location = new System.Drawing.Point(529, 189);
            this.labelT2.Name = "labelT2";
            this.labelT2.Size = new System.Drawing.Size(35, 12);
            this.labelT2.TabIndex = 1;
            this.labelT2.Text = "线程2";
            // 
            // labelT3
            // 
            this.labelT3.AutoSize = true;
            this.labelT3.Location = new System.Drawing.Point(529, 239);
            this.labelT3.Name = "labelT3";
            this.labelT3.Size = new System.Drawing.Size(35, 12);
            this.labelT3.TabIndex = 2;
            this.labelT3.Text = "线程3";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(314, 130);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "开始线程1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(314, 178);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "开始线程2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(314, 234);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "开始线程3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 517);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.labelT3);
            this.Controls.Add(this.labelT2);
            this.Controls.Add(this.labelT1);
            this.Name = "MainForm";
            this.Text = "多线程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelT1;
        private System.Windows.Forms.Label labelT2;
        private System.Windows.Forms.Label labelT3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

