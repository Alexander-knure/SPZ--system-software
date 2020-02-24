namespace SPZ3
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
            this.COMPUTERS = new System.Windows.Forms.Label();
            this.ChangeComp = new System.Windows.Forms.Button();
            this.AddComp = new System.Windows.Forms.Button();
            this.DeleteComp = new System.Windows.Forms.Button();
            this.AddProc = new System.Windows.Forms.Button();
            this.CurrentPC = new System.Windows.Forms.ComboBox();
            this.DeleteProc = new System.Windows.Forms.Button();
            this.ChangeProcess = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // COMPUTERS
            // 
            this.COMPUTERS.AutoSize = true;
            this.COMPUTERS.Location = new System.Drawing.Point(12, 9);
            this.COMPUTERS.Name = "COMPUTERS";
            this.COMPUTERS.Size = new System.Drawing.Size(95, 17);
            this.COMPUTERS.TabIndex = 0;
            this.COMPUTERS.Text = "COMPUTERS";
            // 
            // ChangeComp
            // 
            this.ChangeComp.Enabled = false;
            this.ChangeComp.Location = new System.Drawing.Point(486, 6);
            this.ChangeComp.Name = "ChangeComp";
            this.ChangeComp.Size = new System.Drawing.Size(136, 23);
            this.ChangeComp.TabIndex = 1;
            this.ChangeComp.Text = "CHANGE";
            this.ChangeComp.UseVisualStyleBackColor = true;
            this.ChangeComp.Click += new System.EventHandler(this.ChangeComp_Click);
            // 
            // AddComp
            // 
            this.AddComp.Enabled = false;
            this.AddComp.Location = new System.Drawing.Point(649, 6);
            this.AddComp.Name = "AddComp";
            this.AddComp.Size = new System.Drawing.Size(131, 23);
            this.AddComp.TabIndex = 2;
            this.AddComp.Text = "ADD";
            this.AddComp.UseVisualStyleBackColor = true;
            this.AddComp.Click += new System.EventHandler(this.AddComp_Click);
            // 
            // DeleteComp
            // 
            this.DeleteComp.Enabled = false;
            this.DeleteComp.Location = new System.Drawing.Point(798, 6);
            this.DeleteComp.Name = "DeleteComp";
            this.DeleteComp.Size = new System.Drawing.Size(121, 23);
            this.DeleteComp.TabIndex = 3;
            this.DeleteComp.Text = "DELETE";
            this.DeleteComp.UseVisualStyleBackColor = true;
            this.DeleteComp.Click += new System.EventHandler(this.DeleteComp_Click);
            // 
            // AddProc
            // 
            this.AddProc.Enabled = false;
            this.AddProc.Location = new System.Drawing.Point(30, 378);
            this.AddProc.Name = "AddProc";
            this.AddProc.Size = new System.Drawing.Size(156, 35);
            this.AddProc.TabIndex = 4;
            this.AddProc.Text = "ADD PROCESS";
            this.AddProc.UseVisualStyleBackColor = true;
            this.AddProc.Click += new System.EventHandler(this.AddProc_Click);
            // 
            // CurrentPC
            // 
            this.CurrentPC.FormattingEnabled = true;
            this.CurrentPC.Location = new System.Drawing.Point(113, 6);
            this.CurrentPC.Name = "CurrentPC";
            this.CurrentPC.Size = new System.Drawing.Size(276, 24);
            this.CurrentPC.TabIndex = 5;
            // 
            // DeleteProc
            // 
            this.DeleteProc.Enabled = false;
            this.DeleteProc.Location = new System.Drawing.Point(235, 378);
            this.DeleteProc.Name = "DeleteProc";
            this.DeleteProc.Size = new System.Drawing.Size(154, 35);
            this.DeleteProc.TabIndex = 7;
            this.DeleteProc.Text = "DELETE PROCESS";
            this.DeleteProc.UseVisualStyleBackColor = true;
            this.DeleteProc.Click += new System.EventHandler(this.DeleteProc_Click);
            // 
            // ChangeProcess
            // 
            this.ChangeProcess.Enabled = false;
            this.ChangeProcess.Location = new System.Drawing.Point(757, 378);
            this.ChangeProcess.Name = "ChangeProcess";
            this.ChangeProcess.Size = new System.Drawing.Size(177, 35);
            this.ChangeProcess.TabIndex = 8;
            this.ChangeProcess.Text = "CHANGE PROCESS";
            this.ChangeProcess.UseVisualStyleBackColor = true;
            this.ChangeProcess.Click += new System.EventHandler(this.ChangeProcess_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(30, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(889, 294);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ChangeProcess);
            this.Controls.Add(this.DeleteProc);
            this.Controls.Add(this.CurrentPC);
            this.Controls.Add(this.AddProc);
            this.Controls.Add(this.DeleteComp);
            this.Controls.Add(this.AddComp);
            this.Controls.Add(this.ChangeComp);
            this.Controls.Add(this.COMPUTERS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label COMPUTERS;
        private System.Windows.Forms.Button ChangeComp;
        private System.Windows.Forms.Button AddComp;
        private System.Windows.Forms.Button DeleteComp;
        private System.Windows.Forms.Button AddProc;
        private System.Windows.Forms.ComboBox CurrentPC;
        private System.Windows.Forms.Button DeleteProc;
        private System.Windows.Forms.Button ChangeProcess;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

