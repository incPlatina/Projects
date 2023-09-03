namespace ATIS_lab4_var6
{
    partial class FeedForm
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
            this.allBoxFeed = new System.Windows.Forms.CheckBox();
            this.oneBoxFeed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBoxFeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allBoxFeed
            // 
            this.allBoxFeed.AutoSize = true;
            this.allBoxFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allBoxFeed.Location = new System.Drawing.Point(41, 94);
            this.allBoxFeed.Margin = new System.Windows.Forms.Padding(2);
            this.allBoxFeed.Name = "allBoxFeed";
            this.allBoxFeed.Size = new System.Drawing.Size(218, 35);
            this.allBoxFeed.TabIndex = 0;
            this.allBoxFeed.Text = "всех животных";
            this.allBoxFeed.UseVisualStyleBackColor = true;
            // 
            // oneBoxFeed
            // 
            this.oneBoxFeed.AutoSize = true;
            this.oneBoxFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneBoxFeed.Location = new System.Drawing.Point(41, 182);
            this.oneBoxFeed.Margin = new System.Windows.Forms.Padding(2);
            this.oneBoxFeed.Name = "oneBoxFeed";
            this.oneBoxFeed.Size = new System.Drawing.Size(341, 35);
            this.oneBoxFeed.TabIndex = 1;
            this.oneBoxFeed.Text = "определенное животное";
            this.oneBoxFeed.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Накормить";
            // 
            // IDBoxFeed
            // 
            this.IDBoxFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDBoxFeed.Location = new System.Drawing.Point(583, 190);
            this.IDBoxFeed.Margin = new System.Windows.Forms.Padding(2);
            this.IDBoxFeed.Name = "IDBoxFeed";
            this.IDBoxFeed.Size = new System.Drawing.Size(76, 29);
            this.IDBoxFeed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(498, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // butFeed
            // 
            this.butFeed.BackColor = System.Drawing.Color.LightGreen;
            this.butFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butFeed.Location = new System.Drawing.Point(272, 284);
            this.butFeed.Margin = new System.Windows.Forms.Padding(2);
            this.butFeed.Name = "butFeed";
            this.butFeed.Size = new System.Drawing.Size(268, 50);
            this.butFeed.TabIndex = 5;
            this.butFeed.Text = "Далее";
            this.butFeed.UseVisualStyleBackColor = false;
            this.butFeed.Click += new System.EventHandler(this.butFeed_Click);
            // 
            // FeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(844, 402);
            this.Controls.Add(this.butFeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBoxFeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oneBoxFeed);
            this.Controls.Add(this.allBoxFeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FeedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox allBoxFeed;
        public System.Windows.Forms.CheckBox oneBoxFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button butFeed;
        public System.Windows.Forms.TextBox IDBoxFeed;
    }
}