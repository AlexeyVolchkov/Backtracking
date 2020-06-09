namespace GraphGame
{
    partial class ChipForm
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
            this.nudIndex = new System.Windows.Forms.NumericUpDown();
            this.lbIndex = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // nudIndex
            // 
            this.nudIndex.Location = new System.Drawing.Point(12, 33);
            this.nudIndex.Name = "nudIndex";
            this.nudIndex.Size = new System.Drawing.Size(236, 20);
            this.nudIndex.TabIndex = 0;
            this.nudIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Location = new System.Drawing.Point(9, 17);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(86, 13);
            this.lbIndex.TabIndex = 1;
            this.lbIndex.Text = "Вершина графа";
            // 
            // cbColor
            // 
            this.cbColor.DisplayMember = "Белый";
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Белый",
            "Черный"});
            this.cbColor.Location = new System.Drawing.Point(12, 73);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(236, 21);
            this.cbColor.TabIndex = 2;
            this.cbColor.ValueMember = "Белый";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(9, 57);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(32, 13);
            this.lbColor.TabIndex = 3;
            this.lbColor.Text = "Цвет";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 106);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(108, 40);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "ОК";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(138, 106);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(108, 40);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // ChipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 158);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.nudIndex);
            this.Name = "ChipForm";
            this.Text = "Фишки";
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudIndex;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}