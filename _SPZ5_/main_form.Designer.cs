namespace StudentList
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._addStudentButton = new System.Windows.Forms.Button();
            this._removeStudentButton = new System.Windows.Forms.Button();
            this._addSubjectButton = new System.Windows.Forms.Button();
            this._removeSubjectButton = new System.Windows.Forms.Button();
            this._surnameRadioButton = new System.Windows.Forms.RadioButton();
            this._achievementRadioButton = new System.Windows.Forms.RadioButton();
            this._updateListButton = new System.Windows.Forms.Button();
            this._mainListView = new System.Windows.Forms.ListView();
            this._subjectRadioButton = new System.Windows.Forms.RadioButton();
            this._editStudentButton = new System.Windows.Forms.Button();
            this._editSubjectButton = new System.Windows.Forms.Button();
            this._serializeButton = new System.Windows.Forms.Button();
            this._deserializeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _addStudentButton
            // 
            this._addStudentButton.BackColor = System.Drawing.Color.Lime;
            this._addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._addStudentButton.Location = new System.Drawing.Point(8, 322);
            this._addStudentButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._addStudentButton.Name = "_addStudentButton";
            this._addStudentButton.Size = new System.Drawing.Size(87, 63);
            this._addStudentButton.TabIndex = 2;
            this._addStudentButton.Text = "Add \r\nStudent";
            this._addStudentButton.UseVisualStyleBackColor = false;
            this._addStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // _removeStudentButton
            // 
            this._removeStudentButton.BackColor = System.Drawing.Color.Crimson;
            this._removeStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._removeStudentButton.Location = new System.Drawing.Point(191, 322);
            this._removeStudentButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._removeStudentButton.Name = "_removeStudentButton";
            this._removeStudentButton.Size = new System.Drawing.Size(87, 62);
            this._removeStudentButton.TabIndex = 3;
            this._removeStudentButton.Text = "Remove Student";
            this._removeStudentButton.UseVisualStyleBackColor = false;
            this._removeStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // _addSubjectButton
            // 
            this._addSubjectButton.BackColor = System.Drawing.Color.Lime;
            this._addSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._addSubjectButton.Location = new System.Drawing.Point(8, 391);
            this._addSubjectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._addSubjectButton.Name = "_addSubjectButton";
            this._addSubjectButton.Size = new System.Drawing.Size(87, 63);
            this._addSubjectButton.TabIndex = 4;
            this._addSubjectButton.Text = "Add \r\nSubject";
            this._addSubjectButton.UseVisualStyleBackColor = false;
            this._addSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // _removeSubjectButton
            // 
            this._removeSubjectButton.BackColor = System.Drawing.Color.Crimson;
            this._removeSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._removeSubjectButton.Location = new System.Drawing.Point(191, 391);
            this._removeSubjectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._removeSubjectButton.Name = "_removeSubjectButton";
            this._removeSubjectButton.Size = new System.Drawing.Size(87, 63);
            this._removeSubjectButton.TabIndex = 5;
            this._removeSubjectButton.Text = "Remove Subject";
            this._removeSubjectButton.UseVisualStyleBackColor = false;
            this._removeSubjectButton.Click += new System.EventHandler(this.RemoveSubjectButton_Click);
            // 
            // _surnameRadioButton
            // 
            this._surnameRadioButton.AutoSize = true;
            this._surnameRadioButton.BackColor = System.Drawing.Color.Transparent;
            this._surnameRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._surnameRadioButton.FlatAppearance.BorderSize = 3;
            this._surnameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._surnameRadioButton.Location = new System.Drawing.Point(282, 390);
            this._surnameRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._surnameRadioButton.Name = "_surnameRadioButton";
            this._surnameRadioButton.Size = new System.Drawing.Size(120, 24);
            this._surnameRadioButton.TabIndex = 7;
            this._surnameRadioButton.TabStop = true;
            this._surnameRadioButton.Text = "Surname       ";
            this._surnameRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._surnameRadioButton.UseVisualStyleBackColor = false;
            this._surnameRadioButton.CheckedChanged += new System.EventHandler(this.StudentIDRadioButton_CheckedChanged);
            // 
            // _achievementRadioButton
            // 
            this._achievementRadioButton.AutoSize = true;
            this._achievementRadioButton.BackColor = System.Drawing.Color.Transparent;
            this._achievementRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._achievementRadioButton.FlatAppearance.BorderSize = 3;
            this._achievementRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._achievementRadioButton.Location = new System.Drawing.Point(283, 432);
            this._achievementRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._achievementRadioButton.Name = "_achievementRadioButton";
            this._achievementRadioButton.Size = new System.Drawing.Size(119, 24);
            this._achievementRadioButton.TabIndex = 8;
            this._achievementRadioButton.TabStop = true;
            this._achievementRadioButton.Text = "Achievement";
            this._achievementRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._achievementRadioButton.UseVisualStyleBackColor = false;
            this._achievementRadioButton.CheckedChanged += new System.EventHandler(this.SubjectNameRadioButton_CheckedChanged);
            // 
            // _updateListButton
            // 
            this._updateListButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this._updateListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._updateListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._updateListButton.Location = new System.Drawing.Point(283, 321);
            this._updateListButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._updateListButton.Name = "_updateListButton";
            this._updateListButton.Size = new System.Drawing.Size(110, 63);
            this._updateListButton.TabIndex = 9;
            this._updateListButton.Text = "Update \r\nList";
            this._updateListButton.UseVisualStyleBackColor = false;
            this._updateListButton.Click += new System.EventHandler(this.UpdateListButton_Click);
            // 
            // _mainListView
            // 
            this._mainListView.BackColor = System.Drawing.Color.White;
            this._mainListView.BackgroundImageTiled = true;
            this._mainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._mainListView.HideSelection = false;
            this._mainListView.Location = new System.Drawing.Point(8, 8);
            this._mainListView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._mainListView.Name = "_mainListView";
            this._mainListView.Size = new System.Drawing.Size(500, 309);
            this._mainListView.TabIndex = 10;
            this._mainListView.UseCompatibleStateImageBehavior = false;
            this._mainListView.SelectedIndexChanged += new System.EventHandler(this.MainListView_SelectedIndexChanged);
            // 
            // _subjectRadioButton
            // 
            this._subjectRadioButton.AutoSize = true;
            this._subjectRadioButton.BackColor = System.Drawing.Color.Transparent;
            this._subjectRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._subjectRadioButton.FlatAppearance.BorderSize = 3;
            this._subjectRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._subjectRadioButton.Location = new System.Drawing.Point(283, 411);
            this._subjectRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._subjectRadioButton.Name = "_subjectRadioButton";
            this._subjectRadioButton.Size = new System.Drawing.Size(117, 24);
            this._subjectRadioButton.TabIndex = 11;
            this._subjectRadioButton.TabStop = true;
            this._subjectRadioButton.Text = "Subject         ";
            this._subjectRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._subjectRadioButton.UseVisualStyleBackColor = false;
            this._subjectRadioButton.CheckedChanged += new System.EventHandler(this._subjectRadioButton_CheckedChanged);
            // 
            // _editStudentButton
            // 
            this._editStudentButton.BackColor = System.Drawing.Color.Gold;
            this._editStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._editStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._editStudentButton.Location = new System.Drawing.Point(99, 323);
            this._editStudentButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._editStudentButton.Name = "_editStudentButton";
            this._editStudentButton.Size = new System.Drawing.Size(87, 62);
            this._editStudentButton.TabIndex = 12;
            this._editStudentButton.Text = "Edit Student";
            this._editStudentButton.UseVisualStyleBackColor = false;
            this._editStudentButton.Click += new System.EventHandler(this._editStudentButton_Click);
            // 
            // _editSubjectButton
            // 
            this._editSubjectButton.BackColor = System.Drawing.Color.Gold;
            this._editSubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._editSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._editSubjectButton.Location = new System.Drawing.Point(99, 391);
            this._editSubjectButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._editSubjectButton.Name = "_editSubjectButton";
            this._editSubjectButton.Size = new System.Drawing.Size(87, 62);
            this._editSubjectButton.TabIndex = 13;
            this._editSubjectButton.Text = "Edit Subject";
            this._editSubjectButton.UseVisualStyleBackColor = false;
            this._editSubjectButton.Click += new System.EventHandler(this._editSubjectButton_Click);
            // 
            // _serializeButton
            // 
            this._serializeButton.BackColor = System.Drawing.Color.SpringGreen;
            this._serializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._serializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._serializeButton.Location = new System.Drawing.Point(398, 321);
            this._serializeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._serializeButton.Name = "_serializeButton";
            this._serializeButton.Size = new System.Drawing.Size(110, 63);
            this._serializeButton.TabIndex = 14;
            this._serializeButton.Text = "Serialize";
            this._serializeButton.UseVisualStyleBackColor = false;
            this._serializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // _deserializeButton
            // 
            this._deserializeButton.BackColor = System.Drawing.Color.Yellow;
            this._deserializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._deserializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._deserializeButton.Location = new System.Drawing.Point(398, 390);
            this._deserializeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._deserializeButton.Name = "_deserializeButton";
            this._deserializeButton.Size = new System.Drawing.Size(110, 63);
            this._deserializeButton.TabIndex = 15;
            this._deserializeButton.Text = "Deserialize";
            this._deserializeButton.UseVisualStyleBackColor = false;
            this._deserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 462);
            this.Controls.Add(this._deserializeButton);
            this.Controls.Add(this._serializeButton);
            this.Controls.Add(this._editSubjectButton);
            this.Controls.Add(this._editStudentButton);
            this.Controls.Add(this._subjectRadioButton);
            this.Controls.Add(this._mainListView);
            this.Controls.Add(this._updateListButton);
            this.Controls.Add(this._achievementRadioButton);
            this.Controls.Add(this._surnameRadioButton);
            this.Controls.Add(this._removeSubjectButton);
            this.Controls.Add(this._addSubjectButton);
            this.Controls.Add(this._removeStudentButton);
            this.Controls.Add(this._addStudentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 5";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.Deserialize_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _addStudentButton;
        private System.Windows.Forms.Button _removeStudentButton;
        private System.Windows.Forms.Button _addSubjectButton;
        private System.Windows.Forms.Button _removeSubjectButton;
        private System.Windows.Forms.RadioButton _surnameRadioButton;
        private System.Windows.Forms.RadioButton _achievementRadioButton;
        private System.Windows.Forms.Button _updateListButton;
        private System.Windows.Forms.ListView _mainListView;
        private System.Windows.Forms.RadioButton _subjectRadioButton;
        private System.Windows.Forms.Button _editStudentButton;
        private System.Windows.Forms.Button _editSubjectButton;
        private System.Windows.Forms.Button _serializeButton;
        private System.Windows.Forms.Button _deserializeButton;
    }
}

