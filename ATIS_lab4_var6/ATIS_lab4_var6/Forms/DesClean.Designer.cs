namespace ATIS_lab4_var6
{
    partial class DesClean
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
            this.label1 = new System.Windows.Forms.Label();
            this.allBoxDes = new System.Windows.Forms.CheckBox();
            this.OneBoxDes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBoxDes = new System.Windows.Forms.TextBox();
            this.buttonDes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(286, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дезинфекия/уборка";
            // 
            // allBoxDes
            // 
            this.allBoxDes.AutoSize = true;
            this.allBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allBoxDes.Location = new System.Drawing.Point(51, 108);
            this.allBoxDes.Margin = new System.Windows.Forms.Padding(2);
            this.allBoxDes.Name = "allBoxDes";
            this.allBoxDes.Size = new System.Drawing.Size(213, 35);
            this.allBoxDes.TabIndex = 1;
            this.allBoxDes.Text = "всех вольеров";
            this.allBoxDes.UseVisualStyleBackColor = true;
            // 
            // OneBoxDes
            // 
            this.OneBoxDes.AutoSize = true;
            this.OneBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneBoxDes.Location = new System.Drawing.Point(51, 216);
            this.OneBoxDes.Margin = new System.Windows.Forms.Padding(2);
            this.OneBoxDes.Name = "OneBoxDes";
            this.OneBoxDes.Size = new System.Drawing.Size(313, 35);
            this.OneBoxDes.TabIndex = 2;
            this.OneBoxDes.Text = "определенный вольер";
            this.OneBoxDes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(491, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // IDBoxDes
            // 
            this.IDBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDBoxDes.Location = new System.Drawing.Point(570, 224);
            this.IDBoxDes.Margin = new System.Windows.Forms.Padding(2);
            this.IDBoxDes.Name = "IDBoxDes";
            this.IDBoxDes.Size = new System.Drawing.Size(76, 29);
            this.IDBoxDes.TabIndex = 4;
            // 
            // buttonDes
            // 
            this.buttonDes.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDes.Location = new System.Drawing.Point(265, 299);
            this.buttonDes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDes.Name = "buttonDes";
            this.buttonDes.Size = new System.Drawing.Size(268, 50);
            this.buttonDes.TabIndex = 5;
            this.buttonDes.Text = "Далее";
            this.buttonDes.UseVisualStyleBackColor = false;
            this.buttonDes.Click += new System.EventHandler(this.buttonDes_Click);
            // 
            // DesClean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(844, 402);
            this.Controls.Add(this.buttonDes);
            this.Controls.Add(this.IDBoxDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OneBoxDes);
            this.Controls.Add(this.allBoxDes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DesClean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DesClean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox allBoxDes;
        public System.Windows.Forms.CheckBox OneBoxDes;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IDBoxDes;
        private System.Windows.Forms.Button buttonDes;
    }
}