namespace Kliensalkalmazas_AzMintTavaly
{
    partial class UtazasEditForm
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
            this.URLSlug_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nev_TextBox = new System.Windows.Forms.TextBox();
            this.ar_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.leiras_listBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ar_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // URLSlug_TextBox
            // 
            this.URLSlug_TextBox.Location = new System.Drawing.Point(39, 175);
            this.URLSlug_TextBox.Name = "URLSlug_TextBox";
            this.URLSlug_TextBox.Size = new System.Drawing.Size(100, 20);
            this.URLSlug_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL Slug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név";
            // 
            // nev_TextBox
            // 
            this.nev_TextBox.Location = new System.Drawing.Point(39, 107);
            this.nev_TextBox.Name = "nev_TextBox";
            this.nev_TextBox.Size = new System.Drawing.Size(100, 20);
            this.nev_TextBox.TabIndex = 2;
            // 
            // ar_numericUpDown
            // 
            this.ar_numericUpDown.Location = new System.Drawing.Point(237, 108);
            this.ar_numericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ar_numericUpDown.Name = "ar_numericUpDown";
            this.ar_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ar_numericUpDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ár";
            // 
            // leiras_listBox
            // 
            this.leiras_listBox.FormattingEnabled = true;
            this.leiras_listBox.Location = new System.Drawing.Point(39, 235);
            this.leiras_listBox.Name = "leiras_listBox";
            this.leiras_listBox.Size = new System.Drawing.Size(120, 95);
            this.leiras_listBox.TabIndex = 6;
            // 
            // UtazasEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leiras_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ar_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nev_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLSlug_TextBox);
            this.Name = "UtazasEditForm";
            this.Text = "UtazasEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.ar_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLSlug_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nev_TextBox;
        private System.Windows.Forms.NumericUpDown ar_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox leiras_listBox;
    }
}