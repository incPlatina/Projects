namespace ATIS_lab4_var6
{
    partial class ChangeForm
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
            this.butCoolHeat = new System.Windows.Forms.Button();
            this.IDBoxChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stateBoxChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCoolHeat
            // 
            this.butCoolHeat.BackColor = System.Drawing.Color.LightGreen;
            this.butCoolHeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCoolHeat.Location = new System.Drawing.Point(280, 282);
            this.butCoolHeat.Margin = new System.Windows.Forms.Padding(2);
            this.butCoolHeat.Name = "butCoolHeat";
            this.butCoolHeat.Size = new System.Drawing.Size(268, 50);
            this.butCoolHeat.TabIndex = 12;
            this.butCoolHeat.Text = "Далее";
            this.butCoolHeat.UseVisualStyleBackColor = false;
            this.butCoolHeat.Click += new System.EventHandler(this.butCoolHeat_Click);
            // 
            // IDBoxChange
            // 
            this.IDBoxChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDBoxChange.Location = new System.Drawing.Point(500, 97);
            this.IDBoxChange.Margin = new System.Windows.Forms.Padding(2);
            this.IDBoxChange.Name = "IDBoxChange";
            this.IDBoxChange.Size = new System.Drawing.Size(161, 29);
            this.IDBoxChange.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID животного";
            // 
            // stateBoxChange
            // 
            this.stateBoxChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateBoxChange.FormattingEnabled = true;
            this.stateBoxChange.Items.AddRange(new object[] {
            "здорово",
            "больное",
            "умерло"});
            this.stateBoxChange.Location = new System.Drawing.Point(500, 198);
            this.stateBoxChange.Margin = new System.Windows.Forms.Padding(2);
            this.stateBoxChange.Name = "stateBoxChange";
            this.stateBoxChange.Size = new System.Drawing.Size(161, 32);
            this.stateBoxChange.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Состояние животного";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(844, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateBoxChange);
            this.Controls.Add(this.butCoolHeat);
            this.Controls.Add(this.IDBoxChange);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCoolHeat;
        public System.Windows.Forms.TextBox IDBoxChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox stateBoxChange;
    }
}