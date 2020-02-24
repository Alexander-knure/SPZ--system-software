namespace SPZ8_var_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CPUtextBox = new System.Windows.Forms.TextBox();
            this.BIOStextBox = new System.Windows.Forms.TextBox();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnBIOS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPUtextBox
            // 
            this.CPUtextBox.Location = new System.Drawing.Point(22, 248);
            this.CPUtextBox.Multiline = true;
            this.CPUtextBox.Name = "CPUtextBox";
            this.CPUtextBox.Size = new System.Drawing.Size(257, 88);
            this.CPUtextBox.TabIndex = 2;
            // 
            // BIOStextBox
            // 
            this.BIOStextBox.Location = new System.Drawing.Point(303, 248);
            this.BIOStextBox.Multiline = true;
            this.BIOStextBox.Name = "BIOStextBox";
            this.BIOStextBox.Size = new System.Drawing.Size(257, 88);
            this.BIOStextBox.TabIndex = 3;
            // 
            // btnCPU
            // 
            this.btnCPU.BackgroundImage = global::SPZ8_var_9.Properties.Resources.CPU;
            this.btnCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCPU.Location = new System.Drawing.Point(22, 25);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(257, 217);
            this.btnCPU.TabIndex = 1;
            this.btnCPU.UseVisualStyleBackColor = true;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnBIOS
            // 
            this.btnBIOS.BackgroundImage = global::SPZ8_var_9.Properties.Resources.Bios;
            this.btnBIOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBIOS.Location = new System.Drawing.Point(303, 25);
            this.btnBIOS.Name = "btnBIOS";
            this.btnBIOS.Size = new System.Drawing.Size(257, 217);
            this.btnBIOS.TabIndex = 0;
            this.btnBIOS.UseVisualStyleBackColor = true;
            this.btnBIOS.Click += new System.EventHandler(this.btnBIOS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(584, 348);
            this.Controls.Add(this.BIOStextBox);
            this.Controls.Add(this.CPUtextBox);
            this.Controls.Add(this.btnCPU);
            this.Controls.Add(this.btnBIOS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBIOS;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.TextBox CPUtextBox;
        private System.Windows.Forms.TextBox BIOStextBox;
    }
}

