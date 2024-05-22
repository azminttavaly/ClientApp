namespace Kliensalkalmazas_AzMintTavaly
{
    partial class Form1
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
            this.utazasokDGV = new System.Windows.Forms.DataGridView();
            this.Név = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ár = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.utazasokDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // utazasokDGV
            // 
            this.utazasokDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utazasokDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Név,
            this.Ár});
            this.utazasokDGV.Location = new System.Drawing.Point(49, 44);
            this.utazasokDGV.Name = "utazasokDGV";
            this.utazasokDGV.Size = new System.Drawing.Size(637, 368);
            this.utazasokDGV.TabIndex = 0;
            this.utazasokDGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.utazasokDGV_MouseClick);
            // 
            // Név
            // 
            this.Név.HeaderText = "Név";
            this.Név.Name = "Név";
            this.Név.Width = 250;
            // 
            // Ár
            // 
            this.Ár.HeaderText = "Ár";
            this.Ár.Name = "Ár";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_button.Location = new System.Drawing.Point(721, 381);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(38, 31);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.utazasokDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.utazasokDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView utazasokDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Név;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ár;
        private System.Windows.Forms.Button add_button;
    }
}

