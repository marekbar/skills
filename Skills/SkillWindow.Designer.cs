namespace marekbar
{
    partial class SkillWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillWindow));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NameOfSkill = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Rate = new System.Windows.Forms.ComboBox();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.StillInterestedInNo = new System.Windows.Forms.RadioButton();
            this.StillInterestedInYes = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBack = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameOfSkill
            // 
            this.NameOfSkill.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.NameOfSkill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameOfSkill.Location = new System.Drawing.Point(21, 55);
            this.NameOfSkill.Name = "NameOfSkill";
            this.NameOfSkill.Size = new System.Drawing.Size(360, 22);
            this.NameOfSkill.TabIndex = 3;
            this.toolTip.SetToolTip(this.NameOfSkill, "Podaj nazwę umiejętnośći");
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(21, 116);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(357, 131);
            this.Description.TabIndex = 5;
            this.Description.Text = "";
            this.toolTip.SetToolTip(this.Description, "Opisz co potrafisz");
            // 
            // Rate
            // 
            this.Rate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Rate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Rate.FormattingEnabled = true;
            this.Rate.Items.AddRange(new object[] {
            "Profesjonalnie",
            "Dobrze",
            "Normalnie",
            "Trenuję",
            "Uczę się",
            "Nie znam"});
            this.Rate.Location = new System.Drawing.Point(96, 261);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(282, 24);
            this.Rate.TabIndex = 7;
            this.toolTip.SetToolTip(this.Rate, "Jak się oceniasz?");
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(96, 302);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(282, 22);
            this.FromDate.TabIndex = 9;
            this.toolTip.SetToolTip(this.FromDate, "Od kiedy posiadasz umiejętność?");
            // 
            // StillInterestedInNo
            // 
            this.StillInterestedInNo.AutoSize = true;
            this.StillInterestedInNo.Location = new System.Drawing.Point(64, 22);
            this.StillInterestedInNo.Name = "StillInterestedInNo";
            this.StillInterestedInNo.Size = new System.Drawing.Size(47, 20);
            this.StillInterestedInNo.TabIndex = 1;
            this.StillInterestedInNo.Text = "Nie";
            this.toolTip.SetToolTip(this.StillInterestedInNo, "Nie potrafię lub nie chcę");
            this.StillInterestedInNo.UseVisualStyleBackColor = true;
            // 
            // StillInterestedInYes
            // 
            this.StillInterestedInYes.AutoSize = true;
            this.StillInterestedInYes.Checked = true;
            this.StillInterestedInYes.Location = new System.Drawing.Point(7, 22);
            this.StillInterestedInYes.Name = "StillInterestedInYes";
            this.StillInterestedInYes.Size = new System.Drawing.Size(50, 20);
            this.StillInterestedInYes.TabIndex = 0;
            this.StillInterestedInYes.TabStop = true;
            this.StillInterestedInYes.Text = "Tak";
            this.toolTip.SetToolTip(this.StillInterestedInYes, "Potrafię");
            this.StillInterestedInYes.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(303, 374);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Zapisz";
            this.toolTip.SetToolTip(this.buttonSave, "Zapamiętaj");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.save);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(223, 374);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(74, 23);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Wróć";
            this.toolTip.SetToolTip(this.buttonBack, "Wróć do okna głównego");
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.back);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(136, 17);
            this.status.Text = "Dodawanie i edytowanie";
            this.status.ToolTipText = "Status okna";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBack,
            this.toolSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(399, 25);
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
            this.toolBack.ToolTipText = "Wróć do okna głównego";
            this.toolBack.Click += new System.EventHandler(this.back);
            // 
            // toolSave
            // 
            this.toolSave.Image = global::Skills.Properties.Resources.Actions_document_save_icon;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(60, 22);
            this.toolSave.Text = "Zapisz";
            this.toolSave.ToolTipText = "Zapamiętaj";
            this.toolSave.Click += new System.EventHandler(this.save);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ocena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Od kiedy:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StillInterestedInNo);
            this.groupBox1.Controls.Add(this.StillInterestedInYes);
            this.groupBox1.Location = new System.Drawing.Point(21, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Czy jesteś zainteresowany?";
            // 
            // SkillWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(399, 431);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameOfSkill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 470);
            this.MinimumSize = new System.Drawing.Size(415, 470);
            this.Name = "SkillWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Umiejętność";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBack;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameOfSkill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Rate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton StillInterestedInNo;
        private System.Windows.Forms.RadioButton StillInterestedInYes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
    }
}