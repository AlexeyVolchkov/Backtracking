namespace GraphGame
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.fileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.topAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.topDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.taskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lbClick = new System.Windows.Forms.Label();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.clearMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 27);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(800, 500);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.topMenu,
            this.edgeMenu,
            this.taskMenu,
            this.chipMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCreate,
            this.fileOpen,
            this.fileSave,
            this.fileSaveAs,
            this.fileClear});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            // 
            // fileCreate
            // 
            this.fileCreate.Name = "fileCreate";
            this.fileCreate.Size = new System.Drawing.Size(154, 22);
            this.fileCreate.Text = "Создать";
            this.fileCreate.Click += new System.EventHandler(this.FileCreate_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(154, 22);
            this.fileOpen.Text = "Открыть";
            this.fileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(154, 22);
            this.fileSave.Text = "Сохранить";
            this.fileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.Size = new System.Drawing.Size(154, 22);
            this.fileSaveAs.Text = "Сохранить как";
            this.fileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // fileClear
            // 
            this.fileClear.Name = "fileClear";
            this.fileClear.Size = new System.Drawing.Size(154, 22);
            this.fileClear.Text = "Очистить";
            // 
            // topMenu
            // 
            this.topMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topAdd,
            this.topDelete});
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(73, 20);
            this.topMenu.Text = "Вершины";
            // 
            // topAdd
            // 
            this.topAdd.Name = "topAdd";
            this.topAdd.Size = new System.Drawing.Size(126, 22);
            this.topAdd.Text = "Добавить";
            this.topAdd.Click += new System.EventHandler(this.TopAdd_Click);
            // 
            // topDelete
            // 
            this.topDelete.Name = "topDelete";
            this.topDelete.Size = new System.Drawing.Size(126, 22);
            this.topDelete.Text = "Удалить";
            this.topDelete.Click += new System.EventHandler(this.TopDelete_Click);
            // 
            // edgeMenu
            // 
            this.edgeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgeAdd,
            this.edgeDelete});
            this.edgeMenu.Name = "edgeMenu";
            this.edgeMenu.Size = new System.Drawing.Size(52, 20);
            this.edgeMenu.Text = "Ребра";
            // 
            // edgeAdd
            // 
            this.edgeAdd.Name = "edgeAdd";
            this.edgeAdd.Size = new System.Drawing.Size(126, 22);
            this.edgeAdd.Text = "Добавить";
            this.edgeAdd.Click += new System.EventHandler(this.EdgeAdd_Click);
            // 
            // edgeDelete
            // 
            this.edgeDelete.Name = "edgeDelete";
            this.edgeDelete.Size = new System.Drawing.Size(126, 22);
            this.edgeDelete.Text = "Удалить";
            this.edgeDelete.Click += new System.EventHandler(this.EdgeDelete_Click);
            // 
            // taskMenu
            // 
            this.taskMenu.Name = "taskMenu";
            this.taskMenu.Size = new System.Drawing.Size(57, 20);
            this.taskMenu.Text = "Задача";
            this.taskMenu.Click += new System.EventHandler(this.TaskMenu_Click);
            // 
            // chipMenu
            // 
            this.chipMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenu,
            this.deleteMenu,
            this.clearMenu});
            this.chipMenu.Name = "chipMenu";
            this.chipMenu.Size = new System.Drawing.Size(59, 20);
            this.chipMenu.Text = "Фишки";
            // 
            // addMenu
            // 
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(180, 22);
            this.addMenu.Text = "Добавить";
            this.addMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(180, 22);
            this.deleteMenu.Text = "Удалить";
            this.deleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // lbClick
            // 
            this.lbClick.AutoSize = true;
            this.lbClick.Location = new System.Drawing.Point(818, 27);
            this.lbClick.Name = "lbClick";
            this.lbClick.Size = new System.Drawing.Size(91, 13);
            this.lbClick.TabIndex = 3;
            this.lbClick.Text = "При клике граф:";
            // 
            // cmbBox
            // 
            this.cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Items.AddRange(new object[] {
            "Добавить",
            "Удалить"});
            this.cmbBox.Location = new System.Drawing.Point(821, 43);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(91, 21);
            this.cmbBox.TabIndex = 4;
            // 
            // clearMenu
            // 
            this.clearMenu.Name = "clearMenu";
            this.clearMenu.Size = new System.Drawing.Size(180, 22);
            this.clearMenu.Text = "Очистить";
            this.clearMenu.Click += new System.EventHandler(this.ClearMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 533);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.lbClick);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Раскраска графов";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileCreate;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem fileClear;
        private System.Windows.Forms.ToolStripMenuItem topMenu;
        private System.Windows.Forms.ToolStripMenuItem topAdd;
        private System.Windows.Forms.ToolStripMenuItem topDelete;
        private System.Windows.Forms.ToolStripMenuItem edgeMenu;
        private System.Windows.Forms.ToolStripMenuItem edgeAdd;
        private System.Windows.Forms.ToolStripMenuItem edgeDelete;
        private System.Windows.Forms.ToolStripMenuItem taskMenu;
        private System.Windows.Forms.Label lbClick;
        private System.Windows.Forms.ComboBox cmbBox;
        private System.Windows.Forms.ToolStripMenuItem chipMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripMenuItem clearMenu;
    }
}

