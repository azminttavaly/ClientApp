﻿namespace Kliensalkalmazas_AzMintTavaly
{
    partial class API_csatl_form
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
            this.buttonOFD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válassza ki a config fájlt az API-hoz való csatlakozáshoz!";
            // 
            // buttonOFD
            // 
            this.buttonOFD.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOFD.Location = new System.Drawing.Point(437, 29);
            this.buttonOFD.Name = "buttonOFD";
            this.buttonOFD.Size = new System.Drawing.Size(38, 28);
            this.buttonOFD.TabIndex = 1;
            this.buttonOFD.Text = "...";
            this.buttonOFD.UseVisualStyleBackColor = true;
            this.buttonOFD.Click += new System.EventHandler(this.buttonOFD_Click);
            // 
            // API_csatl_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 85);
            this.Controls.Add(this.buttonOFD);
            this.Controls.Add(this.label1);
            this.Name = "API_csatl_form";
            this.Text = "API_csatl_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOFD;
    }
}