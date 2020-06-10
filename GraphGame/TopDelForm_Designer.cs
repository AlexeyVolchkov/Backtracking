namespace GraphGame
{
    partial class TopDelForm
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
            this.lbNum = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(9, 13);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(133, 13);
            this.lbNum.TabIndex = 0;
            this.lbNum.Text = "Введите номер вершины";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(12, 29);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(231, 20);
            this.tbNum.TabIndex = 1;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(12, 55);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(79, 42);
            this.btDel.TabIndex = 2;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.BtDel_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(164, 55);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(79, 42);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // TopDelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 114);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lbNum);
            this.Name = "TopDelForm";
            this.Text = "Удаление вершины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btCancel;
    }
}