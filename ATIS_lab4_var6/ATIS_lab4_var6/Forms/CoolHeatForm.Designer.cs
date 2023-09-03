namespace ATIS_lab4_var6
{
    partial class CoolHeatForm
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
            this.IDBoxCoolHeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butCoolHeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDBoxCoolHeat
            // 
            this.IDBoxCoolHeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDBoxCoolHeat.Location = new System.Drawing.Point(500, 151);
            this.IDBoxCoolHeat.Margin = new System.Windows.Forms.Padding(2);
            this.IDBoxCoolHeat.Name = "IDBoxCoolHeat";
            this.IDBoxCoolHeat.Size = new System.Drawing.Size(76, 29);
            this.IDBoxCoolHeat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID вольера";
            // 
            // butCoolHeat
            // 
            this.butCoolHeat.BackColor = System.Drawing.Color.LightGreen;
            this.butCoolHeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCoolHeat.Location = new System.Drawing.Point(295, 264);
            this.butCoolHeat.Margin = new System.Windows.Forms.Padding(2);
            this.butCoolHeat.Name = "butCoolHeat";
            this.butCoolHeat.Size = new System.Drawing.Size(268, 50);
            this.butCoolHeat.TabIndex = 9;
            this.butCoolHeat.Text = "Далее";
            this.butCoolHeat.UseVisualStyleBackColor = false;
            this.butCoolHeat.Click += new System.EventHandler(this.butCoolHeat_Click);
            // 
            // CoolHeatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(844, 402);
            this.Controls.Add(this.butCoolHeat);
            this.Controls.Add(this.IDBoxCoolHeat);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CoolHeatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CoolHeatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox IDBoxCoolHeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butCoolHeat;
    }
}