namespace ATIS_lab4_var6
{
    partial class AddForm3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aviary3 = new System.Windows.Forms.TextBox();
            this.AddBotton = new System.Windows.Forms.Button();
            this.Type3 = new System.Windows.Forms.ComboBox();
            this.condition3 = new System.Windows.Forms.ComboBox();
            this.diet3 = new System.Windows.Forms.ComboBox();
            this.therapy3 = new System.Windows.Forms.ComboBox();
            this.ID3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(280, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Состояние животного";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(280, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тип животного";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(280, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер вольера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(280, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Накормлено";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(280, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "Лечение";
            // 
            // aviary3
            // 
            this.aviary3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aviary3.Location = new System.Drawing.Point(712, 209);
            this.aviary3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aviary3.Name = "aviary3";
            this.aviary3.Size = new System.Drawing.Size(180, 34);
            this.aviary3.TabIndex = 11;
            // 
            // AddBotton
            // 
            this.AddBotton.BackColor = System.Drawing.Color.LightGreen;
            this.AddBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBotton.Location = new System.Drawing.Point(376, 404);
            this.AddBotton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBotton.Name = "AddBotton";
            this.AddBotton.Size = new System.Drawing.Size(357, 62);
            this.AddBotton.TabIndex = 14;
            this.AddBotton.Text = "Добавить";
            this.AddBotton.UseVisualStyleBackColor = false;
            this.AddBotton.Click += new System.EventHandler(this.AddBotton_Click);
            // 
            // Type3
            // 
            this.Type3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type3.FormattingEnabled = true;
            this.Type3.Items.AddRange(new object[] {
            "Млекопитающее",
            "Птица",
            "Пресмыкающееся"});
            this.Type3.Location = new System.Drawing.Point(712, 146);
            this.Type3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Type3.Name = "Type3";
            this.Type3.Size = new System.Drawing.Size(180, 37);
            this.Type3.TabIndex = 15;
            
            // 
            // condition3
            // 
            this.condition3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.condition3.FormattingEnabled = true;
            this.condition3.Items.AddRange(new object[] {
            "Здоровое",
            "Больное",
            "Умерло"});
            this.condition3.Location = new System.Drawing.Point(712, 81);
            this.condition3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.condition3.Name = "condition3";
            this.condition3.Size = new System.Drawing.Size(180, 37);
            this.condition3.TabIndex = 16;
                     // 
            // diet3
            // 
            this.diet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diet3.FormattingEnabled = true;
            this.diet3.Items.AddRange(new object[] {
            "да - 1",
            "нет - 0"});
            this.diet3.Location = new System.Drawing.Point(712, 266);
            this.diet3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diet3.Name = "diet3";
            this.diet3.Size = new System.Drawing.Size(180, 37);
            this.diet3.TabIndex = 17;
            // 
            // therapy3
            // 
            this.therapy3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.therapy3.FormattingEnabled = true;
            this.therapy3.Items.AddRange(new object[] {
            "Отсутсвует",
            "Охлаждение",
            "Подогрев",
            "Особое питание",
            "Дезинфекция"});
            this.therapy3.Location = new System.Drawing.Point(712, 325);
            this.therapy3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.therapy3.Name = "therapy3";
            this.therapy3.Size = new System.Drawing.Size(180, 37);
            this.therapy3.TabIndex = 18;
            // 
            // ID3
            // 
            this.ID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID3.Location = new System.Drawing.Point(712, 14);
            this.ID3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID3.Name = "ID3";
            this.ID3.Size = new System.Drawing.Size(180, 34);
            this.ID3.TabIndex = 19;
            this.ID3.Visible = false;
            // 
            // AddForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1125, 495);
            this.Controls.Add(this.ID3);
            this.Controls.Add(this.therapy3);
            this.Controls.Add(this.diet3);
            this.Controls.Add(this.condition3);
            this.Controls.Add(this.Type3);
            this.Controls.Add(this.AddBotton);
            this.Controls.Add(this.aviary3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить животное";
                    this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBotton;
        public System.Windows.Forms.TextBox aviary3;
        public System.Windows.Forms.ComboBox Type3;
        public System.Windows.Forms.ComboBox condition3;
        public System.Windows.Forms.ComboBox diet3;
        public System.Windows.Forms.ComboBox therapy3;
        public System.Windows.Forms.TextBox ID3;
    }
}