﻿namespace Kliensalkalmazas_AzMintTavaly
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
            this.keput_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leiras_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.kepvalaszto_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ar_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // URLSlug_TextBox
            // 
            this.URLSlug_TextBox.Location = new System.Drawing.Point(41, 95);
            this.URLSlug_TextBox.Name = "URLSlug_TextBox";
            this.URLSlug_TextBox.Size = new System.Drawing.Size(184, 20);
            this.URLSlug_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL Slug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név";
            // 
            // nev_TextBox
            // 
            this.nev_TextBox.Location = new System.Drawing.Point(39, 37);
            this.nev_TextBox.Name = "nev_TextBox";
            this.nev_TextBox.Size = new System.Drawing.Size(184, 20);
            this.nev_TextBox.TabIndex = 2;
            // 
            // ar_numericUpDown
            // 
            this.ar_numericUpDown.Location = new System.Drawing.Point(341, 38);
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
            this.label3.Location = new System.Drawing.Point(338, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ár";
            // 
            // keput_TextBox
            // 
            this.keput_TextBox.Enabled = false;
            this.keput_TextBox.Location = new System.Drawing.Point(341, 95);
            this.keput_TextBox.Name = "keput_TextBox";
            this.keput_TextBox.Size = new System.Drawing.Size(142, 20);
            this.keput_TextBox.TabIndex = 7;
            this.keput_TextBox.TextChanged += new System.EventHandler(this.keput_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Képút";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // leiras_textBox
            // 
            this.leiras_textBox.Location = new System.Drawing.Point(39, 172);
            this.leiras_textBox.Multiline = true;
            this.leiras_textBox.Name = "leiras_textBox";
            this.leiras_textBox.Size = new System.Drawing.Size(402, 207);
            this.leiras_textBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Leírás";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(584, 340);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(96, 39);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "Mentés";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // kepvalaszto_button
            // 
            this.kepvalaszto_button.Location = new System.Drawing.Point(502, 93);
            this.kepvalaszto_button.Name = "kepvalaszto_button";
            this.kepvalaszto_button.Size = new System.Drawing.Size(33, 23);
            this.kepvalaszto_button.TabIndex = 12;
            this.kepvalaszto_button.Text = "...";
            this.kepvalaszto_button.UseVisualStyleBackColor = true;
            this.kepvalaszto_button.Click += new System.EventHandler(this.kepvalaszto_button_Click);
            // 
            // UtazasEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kepvalaszto_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leiras_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keput_TextBox);
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
        private System.Windows.Forms.TextBox keput_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leiras_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button kepvalaszto_button;
    }
}