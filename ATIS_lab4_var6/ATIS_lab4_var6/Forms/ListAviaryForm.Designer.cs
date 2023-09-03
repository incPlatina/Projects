namespace ATIS_lab4_var6
{
    partial class ListAviaryForm
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
            this.listAviary = new System.Windows.Forms.ListView();
            this.IdAv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeAv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CleanAv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesAv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecommentTempAv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TemperatureAv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModeAv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAviary
            // 
            this.listAviary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAv,
            this.TypeAv,
            this.CleanAv,
            this.DesAv,
            this.RecommentTempAv,
            this.TemperatureAv,
            this.ModeAv});
            this.listAviary.HideSelection = false;
            this.listAviary.Location = new System.Drawing.Point(-2, 0);
            this.listAviary.Margin = new System.Windows.Forms.Padding(2);
            this.listAviary.Name = "listAviary";
            this.listAviary.Size = new System.Drawing.Size(845, 314);
            this.listAviary.TabIndex = 0;
            this.listAviary.UseCompatibleStateImageBehavior = false;
            this.listAviary.View = System.Windows.Forms.View.Details;
            // 
            // IdAv
            // 
            this.IdAv.Text = "ID";
            // 
            // TypeAv
            // 
            this.TypeAv.Text = "Тип";
            this.TypeAv.Width = 100;
            // 
            // CleanAv
            // 
            this.CleanAv.Text = "Убран";
            this.CleanAv.Width = 100;
            // 
            // DesAv
            // 
            this.DesAv.Text = "Продезинфицирован";
            this.DesAv.Width = 150;
            // 
            // RecommentTempAv
            // 
            this.RecommentTempAv.DisplayIndex = 6;
            this.RecommentTempAv.Text = "Рекомендуемая температура";
            this.RecommentTempAv.Width = 150;
            // 
            // TemperatureAv
            // 
            this.TemperatureAv.DisplayIndex = 4;
            this.TemperatureAv.Text = "Температура";
            this.TemperatureAv.Width = 150;
            // 
            // ModeAv
            // 
            this.ModeAv.DisplayIndex = 5;
            this.ModeAv.Text = "Режим";
            this.ModeAv.Width = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(39, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(534, 337);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Критерии";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListAviaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(844, 402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listAviary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListAviaryForm";
            this.Text = "ListAviaryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAviary;
        private System.Windows.Forms.ColumnHeader IdAv;
        private System.Windows.Forms.ColumnHeader TypeAv;
        private System.Windows.Forms.ColumnHeader CleanAv;
        private System.Windows.Forms.ColumnHeader DesAv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader TemperatureAv;
        private System.Windows.Forms.ColumnHeader ModeAv;
        private System.Windows.Forms.ColumnHeader RecommentTempAv;
    }
}