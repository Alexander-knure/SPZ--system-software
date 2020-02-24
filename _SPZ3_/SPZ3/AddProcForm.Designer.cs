namespace SPZ3
{
    partial class AddProcForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.ProcessUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cpu = new System.Windows.Forms.NumericUpDown();
            this.Ram = new System.Windows.Forms.NumericUpDown();
            this.Priority = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Discription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "RAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Priority";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProcessName
            // 
            this.ProcessName.Location = new System.Drawing.Point(117, 10);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(152, 22);
            this.ProcessName.TabIndex = 7;
            // 
            // ProcessUser
            // 
            this.ProcessUser.Location = new System.Drawing.Point(117, 41);
            this.ProcessUser.Name = "ProcessUser";
            this.ProcessUser.Size = new System.Drawing.Size(152, 22);
            this.ProcessUser.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "User";
            // 
            // Cpu
            // 
            this.Cpu.Location = new System.Drawing.Point(117, 76);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(151, 22);
            this.Cpu.TabIndex = 11;
            // 
            // Ram
            // 
            this.Ram.Location = new System.Drawing.Point(117, 112);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(151, 22);
            this.Ram.TabIndex = 12;
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(118, 188);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(151, 22);
            this.Priority.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Discription";
            // 
            // Discription
            // 
            this.Discription.Location = new System.Drawing.Point(118, 151);
            this.Discription.Name = "Discription";
            this.Discription.Size = new System.Drawing.Size(151, 22);
            this.Discription.TabIndex = 15;
            // 
            // AddProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 297);
            this.Controls.Add(this.Discription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.Ram);
            this.Controls.Add(this.Cpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProcessUser);
            this.Controls.Add(this.ProcessName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddProcForm";
            this.Text = "AddProcForm";
            ((System.ComponentModel.ISupportInitialize)(this.Cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox ProcessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox ProcessUser;
        public System.Windows.Forms.NumericUpDown Cpu;
        public System.Windows.Forms.NumericUpDown Ram;
        public System.Windows.Forms.NumericUpDown Priority;
        public System.Windows.Forms.TextBox Discription;
    }
}