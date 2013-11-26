namespace Skills
{
    partial class TaskWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBack = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.When = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.ComboBox();
            this.lalala = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(49, 17);
            this.status.Text = "Zadanie";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBack,
            this.toolSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(384, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBack
            // 
            this.toolBack.Image = global::Skills.Properties.Resources.Sign_Back_icon;
            this.toolBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBack.Name = "toolBack";
            this.toolBack.Size = new System.Drawing.Size(55, 22);
            this.toolBack.Text = "Wróć";
            this.toolBack.Click += new System.EventHandler(this.back);
            // 
            // toolSave
            // 
            this.toolSave.Image = global::Skills.Properties.Resources.Actions_document_save_icon;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(60, 22);
            this.toolSave.Text = "Zapisz";
            this.toolSave.Click += new System.EventHandler(this.save);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(21, 115);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(357, 131);
            this.Description.TabIndex = 9;
            this.Description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis:";
            // 
            // NameOfTask
            // 
            this.NameOfTask.AutoCompleteCustomSource.AddRange(new string[] {
            "C#",
            "Java",
            "C",
            "C++",
            "Javascript",
            "jQuery",
            "PHP",
            "CSS",
            "HTML",
            "SQL",
            "T-SQL",
            "MySQL",
            "Mongo DB"});
            this.NameOfTask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameOfTask.Location = new System.Drawing.Point(21, 54);
            this.NameOfTask.Name = "NameOfTask";
            this.NameOfTask.Size = new System.Drawing.Size(360, 20);
            this.NameOfTask.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(226, 330);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(74, 23);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.back);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(306, 330);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.save);
            // 
            // When
            // 
            this.When.Location = new System.Drawing.Point(117, 304);
            this.When.Name = "When";
            this.When.Size = new System.Drawing.Size(261, 20);
            this.When.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kiedy:";
            // 
            // Level
            // 
            this.Level.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Level.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Level.FormattingEnabled = true;
            this.Level.Items.AddRange(new object[] {
            "Trudne",
            "Umiarkowane",
            "Łatwe"});
            this.Level.Location = new System.Drawing.Point(117, 263);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(261, 21);
            this.Level.TabIndex = 16;
            // 
            // lalala
            // 
            this.lalala.AutoSize = true;
            this.lalala.Location = new System.Drawing.Point(21, 269);
            this.lalala.Name = "lalala";
            this.lalala.Size = new System.Drawing.Size(90, 13);
            this.lalala.TabIndex = 15;
            this.lalala.Text = "Poziom trudności:";
            // 
            // TaskWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.When);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.lalala);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameOfTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 420);
            this.MinimumSize = new System.Drawing.Size(400, 420);
            this.Name = "TaskWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zadanie";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBack;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameOfTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker When;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Level;
        private System.Windows.Forms.Label lalala;
    }
}