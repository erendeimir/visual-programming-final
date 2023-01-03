namespace kuaföreren
{
    partial class hizmet
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
            this.hizmetdata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthizmet = new System.Windows.Forms.TextBox();
            this.txtfiyatt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetdata)).BeginInit();
            this.SuspendLayout();
            // 
            // hizmetdata
            // 
            this.hizmetdata.AllowUserToAddRows = false;
            this.hizmetdata.AllowUserToDeleteRows = false;
            this.hizmetdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hizmetdata.Location = new System.Drawing.Point(137, 43);
            this.hizmetdata.Name = "hizmetdata";
            this.hizmetdata.ReadOnly = true;
            this.hizmetdata.RowHeadersWidth = 51;
            this.hizmetdata.RowTemplate.Height = 24;
            this.hizmetdata.Size = new System.Drawing.Size(521, 154);
            this.hizmetdata.TabIndex = 0;
            this.hizmetdata.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.hizmetdata_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hizmet Ekle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat :";
            // 
            // txthizmet
            // 
            this.txthizmet.Location = new System.Drawing.Point(362, 231);
            this.txthizmet.Name = "txthizmet";
            this.txthizmet.Size = new System.Drawing.Size(100, 22);
            this.txthizmet.TabIndex = 3;
            // 
            // txtfiyatt
            // 
            this.txtfiyatt.Location = new System.Drawing.Point(362, 272);
            this.txtfiyatt.Name = "txtfiyatt";
            this.txtfiyatt.Size = new System.Drawing.Size(100, 22);
            this.txtfiyatt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(362, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(362, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfiyatt);
            this.Controls.Add(this.txthizmet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hizmetdata);
            this.Name = "hizmet";
            this.Text = "hizmet";
            this.Load += new System.EventHandler(this.hizmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hizmetdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hizmetdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthizmet;
        private System.Windows.Forms.TextBox txtfiyatt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}