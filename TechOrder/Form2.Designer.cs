namespace TechOrder
{
    partial class TechOrderMainPage
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
            this.ConsolesLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConsolesLabel
            // 
            this.ConsolesLabel.AutoSize = true;
            this.ConsolesLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsolesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConsolesLabel.Location = new System.Drawing.Point(109, 128);
            this.ConsolesLabel.Name = "ConsolesLabel";
            this.ConsolesLabel.Size = new System.Drawing.Size(199, 42);
            this.ConsolesLabel.TabIndex = 1;
            this.ConsolesLabel.Text = "Consoles";
            this.ConsolesLabel.Click += new System.EventHandler(this.ConsolesLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Azure;
            this.comboBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 42);
            this.comboBox1.TabIndex = 2;
            // 
            // TechOrderMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1328, 955);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ConsolesLabel);
            this.Name = "TechOrderMainPage";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsolesLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}