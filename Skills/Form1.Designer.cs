namespace Skills
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.appFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.packData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClose = new System.Windows.Forms.ToolStripMenuItem();
            this.dodawanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUmiejętnośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addJob = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.ChooseType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.errors = new System.Windows.Forms.ToolStripStatusLabel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edytujTool = new System.Windows.Forms.ToolStripMenuItem();
            this.usunTool = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazywaczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacjaToolStripMenuItem,
            this.dodawanieToolStripMenuItem,
            this.toolStripMenuItem2,
            this.searchBox,
            this.ChooseType,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacjaToolStripMenuItem
            // 
            this.aplikacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolAbout,
            this.toolClose,
            this.pokazywaczToolStripMenuItem});
            this.aplikacjaToolStripMenuItem.Image = global::Skills.Properties.Resources.Applications_icon;
            this.aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            this.aplikacjaToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.aplikacjaToolStripMenuItem.Text = "Aplikacja";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataFolder,
            this.appFolder,
            this.packData});
            this.toolStripMenuItem3.Image = global::Skills.Properties.Resources.Folder_icon;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Foldery";
            // 
            // dataFolder
            // 
            this.dataFolder.Image = global::Skills.Properties.Resources.Folder_Generic_Green_icon;
            this.dataFolder.Name = "dataFolder";
            this.dataFolder.Size = new System.Drawing.Size(153, 22);
            this.dataFolder.Text = "Folder danych";
            this.dataFolder.Click += new System.EventHandler(this.dataFolder_Click);
            // 
            // appFolder
            // 
            this.appFolder.Image = global::Skills.Properties.Resources.Places_folder_red_icon;
            this.appFolder.Name = "appFolder";
            this.appFolder.Size = new System.Drawing.Size(153, 22);
            this.appFolder.Text = "Folder aplikacji";
            this.appFolder.Click += new System.EventHandler(this.appFolder_Click);
            // 
            // packData
            // 
            this.packData.Image = global::Skills.Properties.Resources.Compressed_File_Zip_icon;
            this.packData.Name = "packData";
            this.packData.Size = new System.Drawing.Size(153, 22);
            this.packData.Text = "Spakuj dane";
            this.packData.Click += new System.EventHandler(this.packData_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.Image = global::Skills.Properties.Resources.Info_icon;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(152, 22);
            this.toolAbout.Text = "Info";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // toolClose
            // 
            this.toolClose.Image = global::Skills.Properties.Resources.logout_icon;
            this.toolClose.Name = "toolClose";
            this.toolClose.Size = new System.Drawing.Size(152, 22);
            this.toolClose.Text = "Zamknij";
            this.toolClose.Click += new System.EventHandler(this.toolClose_Click);
            // 
            // dodawanieToolStripMenuItem
            // 
            this.dodawanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUmiejętnośćToolStripMenuItem,
            this.dodajZadanieToolStripMenuItem,
            this.employerTool,
            this.addJob});
            this.dodawanieToolStripMenuItem.Image = global::Skills.Properties.Resources.Pencil_icon;
            this.dodawanieToolStripMenuItem.Name = "dodawanieToolStripMenuItem";
            this.dodawanieToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.dodawanieToolStripMenuItem.Text = "Edycja";
            // 
            // dodajUmiejętnośćToolStripMenuItem
            // 
            this.dodajUmiejętnośćToolStripMenuItem.Image = global::Skills.Properties.Resources.tool_box_icon;
            this.dodajUmiejętnośćToolStripMenuItem.Name = "dodajUmiejętnośćToolStripMenuItem";
            this.dodajUmiejętnośćToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dodajUmiejętnośćToolStripMenuItem.Text = "Dodaj umiejętność";
            this.dodajUmiejętnośćToolStripMenuItem.Click += new System.EventHandler(this.dodajUmiejętnośćToolStripMenuItem_Click);
            // 
            // dodajZadanieToolStripMenuItem
            // 
            this.dodajZadanieToolStripMenuItem.Image = global::Skills.Properties.Resources.Actions_mail_mark_task_icon;
            this.dodajZadanieToolStripMenuItem.Name = "dodajZadanieToolStripMenuItem";
            this.dodajZadanieToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dodajZadanieToolStripMenuItem.Text = "Dodaj zadanie";
            this.dodajZadanieToolStripMenuItem.Click += new System.EventHandler(this.dodajZadanieToolStripMenuItem_Click);
            // 
            // employerTool
            // 
            this.employerTool.Image = global::Skills.Properties.Resources.tester_icon;
            this.employerTool.Name = "employerTool";
            this.employerTool.Size = new System.Drawing.Size(173, 22);
            this.employerTool.Text = "Dodaj pracodawcę";
            this.employerTool.Click += new System.EventHandler(this.employerTool_Click);
            // 
            // addJob
            // 
            this.addJob.Image = global::Skills.Properties.Resources.Unemployed_icon;
            this.addJob.Name = "addJob";
            this.addJob.Size = new System.Drawing.Size(173, 22);
            this.addJob.Text = "Dodaj pracę";
            this.addJob.Click += new System.EventHandler(this.addJob_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Skills.Properties.Resources.search_icon;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 23);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.LightGray;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(300, 23);
            this.searchBox.Text = "wpisz szukane słowo";
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // ChooseType
            // 
            this.ChooseType.AutoToolTip = true;
            this.ChooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseType.DropDownWidth = 150;
            this.ChooseType.Items.AddRange(new object[] {
            "Umiejętności",
            "Zadania",
            "Pracodawcy",
            "Prace"});
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(150, 23);
            this.ChooseType.SelectedIndexChanged += new System.EventHandler(this.ChooseType_SelectedIndexChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.errors});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // errors
            // 
            this.errors.BackColor = System.Drawing.Color.Transparent;
            this.errors.ForeColor = System.Drawing.Color.Red;
            this.errors.Image = global::Skills.Properties.Resources.International_Red_Cross_Flag_3_icon;
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(86, 17);
            this.errors.Text = "Pokaż błędy";
            this.errors.Visible = false;
            this.errors.MouseLeave += new System.EventHandler(this.errors_MouseLeave);
            this.errors.MouseHover += new System.EventHandler(this.errors_MouseHover);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ContextMenuStrip = this.contextMenuGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.GridColor = System.Drawing.Color.LightGray;
            this.grid.Location = new System.Drawing.Point(0, 27);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(683, 272);
            this.grid.TabIndex = 2;
            // 
            // contextMenuGrid
            // 
            this.contextMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujTool,
            this.usunTool});
            this.contextMenuGrid.Name = "contextMenuGrid";
            this.contextMenuGrid.Size = new System.Drawing.Size(108, 48);
            // 
            // edytujTool
            // 
            this.edytujTool.Image = global::Skills.Properties.Resources.Pencil_icon;
            this.edytujTool.Name = "edytujTool";
            this.edytujTool.Size = new System.Drawing.Size(107, 22);
            this.edytujTool.Text = "Edytuj";
            this.edytujTool.Click += new System.EventHandler(this.edytujTool_Click);
            // 
            // usunTool
            // 
            this.usunTool.Image = global::Skills.Properties.Resources.Close_2_icon;
            this.usunTool.Name = "usunTool";
            this.usunTool.Size = new System.Drawing.Size(107, 22);
            this.usunTool.Text = "Usuń";
            this.usunTool.Click += new System.EventHandler(this.usunTool_Click);
            // 
            // pokazywaczToolStripMenuItem
            // 
            this.pokazywaczToolStripMenuItem.Name = "pokazywaczToolStripMenuItem";
            this.pokazywaczToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pokazywaczToolStripMenuItem.Text = "Pokazywacz";
            this.pokazywaczToolStripMenuItem.Click += new System.EventHandler(this.pokazywaczToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(683, 321);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(670, 360);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Umiejętności i zadania";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodawanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUmiejętnośćToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripComboBox ChooseType;
        private System.Windows.Forms.ToolStripMenuItem toolAbout;
        private System.Windows.Forms.ToolStripMenuItem toolClose;
        private System.Windows.Forms.ToolStripMenuItem dodajZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dataFolder;
        private System.Windows.Forms.ToolStripMenuItem appFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem edytujTool;
        private System.Windows.Forms.ToolStripMenuItem usunTool;
        private System.Windows.Forms.ToolStripMenuItem employerTool;
        private System.Windows.Forms.ToolStripMenuItem addJob;
        private System.Windows.Forms.ToolStripStatusLabel errors;
        private System.Windows.Forms.ToolStripMenuItem packData;
        private System.Windows.Forms.ToolStripMenuItem pokazywaczToolStripMenuItem;
    }
}

