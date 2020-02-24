namespace _SPZ6_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btBuyMaterials = new System.Windows.Forms.Button();
            this.btBuyManufactory = new System.Windows.Forms.Button();
            this.btSellProduction = new System.Windows.Forms.Button();
            this.btProduce = new System.Windows.Forms.Button();
            this.lbCostBuyingMaterials = new System.Windows.Forms.Label();
            this.lbCountMaterials = new System.Windows.Forms.Label();
            this.lbCostManufactory = new System.Windows.Forms.Label();
            this.lbCountProduction = new System.Windows.Forms.Label();
            this.lbCostProduction = new System.Windows.Forms.Label();
            this.lbCountProduce = new System.Windows.Forms.Label();
            this.lbCostProduce = new System.Windows.Forms.Label();
            this.lbCostBuyingMaterialsProduce = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbMaterials = new System.Windows.Forms.TextBox();
            this.tbManufactories = new System.Windows.Forms.TextBox();
            this.tbProduction = new System.Windows.Forms.TextBox();
            this.lbIMoney = new System.Windows.Forms.Label();
            this.lbIMaterials = new System.Windows.Forms.Label();
            this.lbIProduction = new System.Windows.Forms.Label();
            this.lbIManufactories = new System.Windows.Forms.Label();
            this.lbMODE = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btBuyMaterials
            // 
            this.btBuyMaterials.BackColor = System.Drawing.Color.Gold;
            this.btBuyMaterials.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btBuyMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuyMaterials.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBuyMaterials.Location = new System.Drawing.Point(32, 577);
            this.btBuyMaterials.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btBuyMaterials.Name = "btBuyMaterials";
            this.btBuyMaterials.Size = new System.Drawing.Size(284, 138);
            this.btBuyMaterials.TabIndex = 0;
            this.btBuyMaterials.Text = "Buy materials";
            this.btBuyMaterials.UseVisualStyleBackColor = false;
            this.btBuyMaterials.Click += new System.EventHandler(this.btBuyMaterials_Click);
            // 
            // btBuyManufactory
            // 
            this.btBuyManufactory.BackColor = System.Drawing.Color.Gold;
            this.btBuyManufactory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btBuyManufactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuyManufactory.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBuyManufactory.Location = new System.Drawing.Point(334, 577);
            this.btBuyManufactory.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btBuyManufactory.Name = "btBuyManufactory";
            this.btBuyManufactory.Size = new System.Drawing.Size(284, 138);
            this.btBuyManufactory.TabIndex = 1;
            this.btBuyManufactory.Text = "Buy manufactory";
            this.btBuyManufactory.UseVisualStyleBackColor = false;
            this.btBuyManufactory.Click += new System.EventHandler(this.btBuyManufactory_Click);
            // 
            // btSellProduction
            // 
            this.btSellProduction.BackColor = System.Drawing.Color.Gold;
            this.btSellProduction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSellProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSellProduction.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSellProduction.Location = new System.Drawing.Point(334, 833);
            this.btSellProduction.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btSellProduction.Name = "btSellProduction";
            this.btSellProduction.Size = new System.Drawing.Size(284, 138);
            this.btSellProduction.TabIndex = 2;
            this.btSellProduction.Text = "Sell production";
            this.btSellProduction.UseVisualStyleBackColor = false;
            this.btSellProduction.Click += new System.EventHandler(this.btSellProduction_Click);
            // 
            // btProduce
            // 
            this.btProduce.BackColor = System.Drawing.Color.Gold;
            this.btProduce.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btProduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduce.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btProduce.Location = new System.Drawing.Point(32, 833);
            this.btProduce.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btProduce.Name = "btProduce";
            this.btProduce.Size = new System.Drawing.Size(284, 138);
            this.btProduce.TabIndex = 3;
            this.btProduce.Text = "Produce";
            this.btProduce.UseVisualStyleBackColor = false;
            this.btProduce.Click += new System.EventHandler(this.btProduce_Click);
            // 
            // lbCostBuyingMaterials
            // 
            this.lbCostBuyingMaterials.AutoSize = true;
            this.lbCostBuyingMaterials.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCostBuyingMaterials.Location = new System.Drawing.Point(32, 723);
            this.lbCostBuyingMaterials.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCostBuyingMaterials.Name = "lbCostBuyingMaterials";
            this.lbCostBuyingMaterials.Size = new System.Drawing.Size(92, 41);
            this.lbCostBuyingMaterials.TabIndex = 6;
            this.lbCostBuyingMaterials.Text = "Cost: ";
            // 
            // lbCountMaterials
            // 
            this.lbCountMaterials.AutoSize = true;
            this.lbCountMaterials.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountMaterials.Location = new System.Drawing.Point(32, 785);
            this.lbCountMaterials.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCountMaterials.Name = "lbCountMaterials";
            this.lbCountMaterials.Size = new System.Drawing.Size(162, 41);
            this.lbCountMaterials.TabIndex = 7;
            this.lbCountMaterials.Text = "Materials: ";
            // 
            // lbCostManufactory
            // 
            this.lbCostManufactory.AutoSize = true;
            this.lbCostManufactory.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCostManufactory.Location = new System.Drawing.Point(342, 723);
            this.lbCostManufactory.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCostManufactory.Name = "lbCostManufactory";
            this.lbCostManufactory.Size = new System.Drawing.Size(92, 41);
            this.lbCostManufactory.TabIndex = 8;
            this.lbCostManufactory.Text = "Cost: ";
            // 
            // lbCountProduction
            // 
            this.lbCountProduction.AutoSize = true;
            this.lbCountProduction.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountProduction.Location = new System.Drawing.Point(326, 1040);
            this.lbCountProduction.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCountProduction.Name = "lbCountProduction";
            this.lbCountProduction.Size = new System.Drawing.Size(180, 41);
            this.lbCountProduction.TabIndex = 10;
            this.lbCountProduction.Text = "Production: ";
            // 
            // lbCostProduction
            // 
            this.lbCostProduction.AutoSize = true;
            this.lbCostProduction.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCostProduction.Location = new System.Drawing.Point(326, 978);
            this.lbCostProduction.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCostProduction.Name = "lbCostProduction";
            this.lbCostProduction.Size = new System.Drawing.Size(92, 41);
            this.lbCostProduction.TabIndex = 9;
            this.lbCostProduction.Text = "Cost: ";
            // 
            // lbCountProduce
            // 
            this.lbCountProduce.AutoSize = true;
            this.lbCountProduce.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountProduce.Location = new System.Drawing.Point(32, 1099);
            this.lbCountProduce.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCountProduce.Name = "lbCountProduce";
            this.lbCountProduce.Size = new System.Drawing.Size(180, 41);
            this.lbCountProduce.TabIndex = 12;
            this.lbCountProduce.Text = "Production: ";
            // 
            // lbCostProduce
            // 
            this.lbCostProduce.AutoSize = true;
            this.lbCostProduce.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCostProduce.Location = new System.Drawing.Point(32, 978);
            this.lbCostProduce.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCostProduce.Name = "lbCostProduce";
            this.lbCostProduce.Size = new System.Drawing.Size(92, 41);
            this.lbCostProduce.TabIndex = 11;
            this.lbCostProduce.Text = "Cost: ";
            // 
            // lbCostBuyingMaterialsProduce
            // 
            this.lbCostBuyingMaterialsProduce.AutoSize = true;
            this.lbCostBuyingMaterialsProduce.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCostBuyingMaterialsProduce.Location = new System.Drawing.Point(32, 1037);
            this.lbCostBuyingMaterialsProduce.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCostBuyingMaterialsProduce.Name = "lbCostBuyingMaterialsProduce";
            this.lbCostBuyingMaterialsProduce.Size = new System.Drawing.Size(162, 41);
            this.lbCostBuyingMaterialsProduce.TabIndex = 13;
            this.lbCostBuyingMaterialsProduce.Text = "Materials: ";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(374, 17);
            this.tbMoney.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(260, 38);
            this.tbMoney.TabIndex = 14;
            // 
            // tbMaterials
            // 
            this.tbMaterials.Location = new System.Drawing.Point(374, 107);
            this.tbMaterials.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbMaterials.Name = "tbMaterials";
            this.tbMaterials.Size = new System.Drawing.Size(260, 38);
            this.tbMaterials.TabIndex = 15;
            // 
            // tbManufactories
            // 
            this.tbManufactories.Location = new System.Drawing.Point(374, 283);
            this.tbManufactories.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbManufactories.Name = "tbManufactories";
            this.tbManufactories.Size = new System.Drawing.Size(260, 38);
            this.tbManufactories.TabIndex = 16;
            // 
            // tbProduction
            // 
            this.tbProduction.Location = new System.Drawing.Point(374, 194);
            this.tbProduction.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbProduction.Name = "tbProduction";
            this.tbProduction.Size = new System.Drawing.Size(260, 38);
            this.tbProduction.TabIndex = 17;
            // 
            // lbIMoney
            // 
            this.lbIMoney.AutoSize = true;
            this.lbIMoney.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIMoney.Location = new System.Drawing.Point(22, 17);
            this.lbIMoney.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbIMoney.Name = "lbIMoney";
            this.lbIMoney.Size = new System.Drawing.Size(156, 60);
            this.lbIMoney.TabIndex = 19;
            this.lbIMoney.Text = "Money";
            // 
            // lbIMaterials
            // 
            this.lbIMaterials.AutoSize = true;
            this.lbIMaterials.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIMaterials.Location = new System.Drawing.Point(22, 107);
            this.lbIMaterials.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbIMaterials.Name = "lbIMaterials";
            this.lbIMaterials.Size = new System.Drawing.Size(213, 60);
            this.lbIMaterials.TabIndex = 20;
            this.lbIMaterials.Text = "Materials";
            // 
            // lbIProduction
            // 
            this.lbIProduction.AutoSize = true;
            this.lbIProduction.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIProduction.Location = new System.Drawing.Point(22, 194);
            this.lbIProduction.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbIProduction.Name = "lbIProduction";
            this.lbIProduction.Size = new System.Drawing.Size(243, 60);
            this.lbIProduction.TabIndex = 21;
            this.lbIProduction.Text = "Production";
            // 
            // lbIManufactories
            // 
            this.lbIManufactories.AutoSize = true;
            this.lbIManufactories.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIManufactories.Location = new System.Drawing.Point(22, 283);
            this.lbIManufactories.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbIManufactories.Name = "lbIManufactories";
            this.lbIManufactories.Size = new System.Drawing.Size(313, 60);
            this.lbIManufactories.TabIndex = 22;
            this.lbIManufactories.Text = "Manufactories";
            // 
            // lbMODE
            // 
            this.lbMODE.AutoSize = true;
            this.lbMODE.BackColor = System.Drawing.Color.OrangeRed;
            this.lbMODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMODE.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMODE.ForeColor = System.Drawing.Color.Black;
            this.lbMODE.Location = new System.Drawing.Point(32, 453);
            this.lbMODE.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbMODE.Name = "lbMODE";
            this.lbMODE.Size = new System.Drawing.Size(154, 62);
            this.lbMODE.TabIndex = 23;
            this.lbMODE.Text = "Mode: ";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 300;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 368);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 60);
            this.label1.TabIndex = 24;
            this.label1.Text = "Volume";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(374, 368);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(260, 38);
            this.tbVolume.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(662, 1157);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMODE);
            this.Controls.Add(this.lbIManufactories);
            this.Controls.Add(this.lbIProduction);
            this.Controls.Add(this.lbIMaterials);
            this.Controls.Add(this.lbIMoney);
            this.Controls.Add(this.tbProduction);
            this.Controls.Add(this.tbManufactories);
            this.Controls.Add(this.tbMaterials);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.lbCostBuyingMaterialsProduce);
            this.Controls.Add(this.lbCountProduce);
            this.Controls.Add(this.lbCostProduce);
            this.Controls.Add(this.lbCountProduction);
            this.Controls.Add(this.lbCostProduction);
            this.Controls.Add(this.lbCostManufactory);
            this.Controls.Add(this.lbCountMaterials);
            this.Controls.Add(this.lbCostBuyingMaterials);
            this.Controls.Add(this.btProduce);
            this.Controls.Add(this.btSellProduction);
            this.Controls.Add(this.btBuyManufactory);
            this.Controls.Add(this.btBuyMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab №6";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuyMaterials;
        private System.Windows.Forms.Button btBuyManufactory;
        private System.Windows.Forms.Button btSellProduction;
        private System.Windows.Forms.Button btProduce;
        private System.Windows.Forms.Label lbCostBuyingMaterials;
        private System.Windows.Forms.Label lbCountMaterials;
        private System.Windows.Forms.Label lbCostManufactory;
        private System.Windows.Forms.Label lbCountProduction;
        private System.Windows.Forms.Label lbCostProduction;
        private System.Windows.Forms.Label lbCountProduce;
        private System.Windows.Forms.Label lbCostProduce;
        private System.Windows.Forms.Label lbCostBuyingMaterialsProduce;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.TextBox tbMaterials;
        private System.Windows.Forms.TextBox tbManufactories;
        private System.Windows.Forms.TextBox tbProduction;
        private System.Windows.Forms.Label lbIMoney;
        private System.Windows.Forms.Label lbIMaterials;
        private System.Windows.Forms.Label lbIProduction;
        private System.Windows.Forms.Label lbIManufactories;
        private System.Windows.Forms.Label lbMODE;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVolume;
    }
}

