namespace _SPZ4_
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btSwap = new System.Windows.Forms.Button();
            this.lbMaximal = new System.Windows.Forms.Label();
            this.lbMinimal = new System.Windows.Forms.Label();
            this.lbOutMax = new System.Windows.Forms.Label();
            this.lbOutMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 289);
            this.textBox1.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(128, 41);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Open file";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.click_Open);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(150, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(126, 41);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save file";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.click_Save);
            // 
            // btSwap
            // 
            this.btSwap.Location = new System.Drawing.Point(12, 436);
            this.btSwap.Name = "btSwap";
            this.btSwap.Size = new System.Drawing.Size(263, 41);
            this.btSwap.TabIndex = 3;
            this.btSwap.Text = "Swap numbers";
            this.btSwap.UseVisualStyleBackColor = true;
            this.btSwap.Click += new System.EventHandler(this.click_Swap);
            // 
            // lbMaximal
            // 
            this.lbMaximal.AutoSize = true;
            this.lbMaximal.Location = new System.Drawing.Point(12, 363);
            this.lbMaximal.Name = "lbMaximal";
            this.lbMaximal.Size = new System.Drawing.Size(131, 20);
            this.lbMaximal.TabIndex = 4;
            this.lbMaximal.Text = "Maximal element:";
            // 
            // lbMinimal
            // 
            this.lbMinimal.AutoSize = true;
            this.lbMinimal.Location = new System.Drawing.Point(13, 398);
            this.lbMinimal.Name = "lbMinimal";
            this.lbMinimal.Size = new System.Drawing.Size(127, 20);
            this.lbMinimal.TabIndex = 5;
            this.lbMinimal.Text = "Minimal element:";
            // 
            // lbOutMax
            // 
            this.lbOutMax.AutoSize = true;
            this.lbOutMax.Location = new System.Drawing.Point(145, 363);
            this.lbOutMax.Name = "lbOutMax";
            this.lbOutMax.Size = new System.Drawing.Size(0, 20);
            this.lbOutMax.TabIndex = 6;
            // 
            // lbOutMin
            // 
            this.lbOutMin.AutoSize = true;
            this.lbOutMin.Location = new System.Drawing.Point(145, 398);
            this.lbOutMin.Name = "lbOutMin";
            this.lbOutMin.Size = new System.Drawing.Size(0, 20);
            this.lbOutMin.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 492);
            this.Controls.Add(this.lbOutMin);
            this.Controls.Add(this.lbOutMax);
            this.Controls.Add(this.lbMinimal);
            this.Controls.Add(this.lbMaximal);
            this.Controls.Add(this.btSwap);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSwap;
        private System.Windows.Forms.Label lbMaximal;
        private System.Windows.Forms.Label lbMinimal;
        private System.Windows.Forms.Label lbOutMax;
        private System.Windows.Forms.Label lbOutMin;
    }
}

