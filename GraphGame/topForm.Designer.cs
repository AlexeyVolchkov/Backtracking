namespace GraphGame
{
    partial class topForm
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
            this.lbX = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.btAct = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(9, 13);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(77, 13);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "Координата X";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(12, 29);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(260, 20);
            this.tbX.TabIndex = 1;
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbX_KeyPress);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(12, 75);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(260, 20);
            this.tbY.TabIndex = 3;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(9, 59);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(77, 13);
            this.lbY.TabIndex = 2;
            this.lbY.Text = "Координата Y";
            // 
            // btAct
            // 
            this.btAct.Location = new System.Drawing.Point(11, 110);
            this.btAct.Name = "btAct";
            this.btAct.Size = new System.Drawing.Size(125, 45);
            this.btAct.TabIndex = 4;
            this.btAct.Text = "Добавить";
            this.btAct.UseVisualStyleBackColor = true;
            this.btAct.Click += new System.EventHandler(this.BtAct_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(147, 110);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 45);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // topForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAct);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lbX);
            this.Name = "topForm";
            this.Text = "Вершина графа";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbX_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btAct;
        private System.Windows.Forms.Button btCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}