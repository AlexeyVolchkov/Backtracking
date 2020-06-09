namespace GraphGame
{
    partial class EdgeForm
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
            this.lbFirst = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.lbSecond = new System.Windows.Forms.Label();
            this.btAct = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Location = new System.Drawing.Point(9, 10);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(92, 13);
            this.lbFirst.TabIndex = 0;
            this.lbFirst.Text = "Первая вершина";
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(12, 26);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(172, 20);
            this.tbFirst.TabIndex = 1;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(12, 66);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(172, 20);
            this.tbSecond.TabIndex = 3;
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(9, 50);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(90, 13);
            this.lbSecond.TabIndex = 2;
            this.lbSecond.Text = "Вторая вершина";
            // 
            // btAct
            // 
            this.btAct.Location = new System.Drawing.Point(12, 92);
            this.btAct.Name = "btAct";
            this.btAct.Size = new System.Drawing.Size(81, 51);
            this.btAct.TabIndex = 4;
            this.btAct.Text = "Добавить";
            this.btAct.UseVisualStyleBackColor = true;
            this.btAct.Click += new System.EventHandler(this.BtAct_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(103, 92);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(81, 51);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // EdgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 155);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAct);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.lbFirst);
            this.Name = "EdgeForm";
            this.Text = "EdgeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Button btAct;
        private System.Windows.Forms.Button btCancel;
    }
}