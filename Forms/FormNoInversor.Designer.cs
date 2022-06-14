namespace Operational_amplifiers.Forms
{
    partial class FormNoInversor
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
            this.lblGanancia = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.btnVout = new System.Windows.Forms.Button();
            this.lblVolt = new System.Windows.Forms.Label();
            this.resistF = new System.Windows.Forms.TextBox();
            this.resistI = new System.Windows.Forms.TextBox();
            this.voltI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGanancia.Location = new System.Drawing.Point(709, 529);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(0, 26);
            this.lblGanancia.TabIndex = 17;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(965, 449);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(164, 56);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Limpiar datos";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click_1);
            // 
            // btnGanancia
            // 
            this.btnGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnGanancia.FlatAppearance.BorderSize = 0;
            this.btnGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGanancia.Location = new System.Drawing.Point(965, 355);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(164, 56);
            this.btnGanancia.TabIndex = 15;
            this.btnGanancia.Text = "Calcular ganancia";
            this.btnGanancia.UseVisualStyleBackColor = false;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click_1);
            // 
            // btnVout
            // 
            this.btnVout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnVout.FlatAppearance.BorderSize = 0;
            this.btnVout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVout.Location = new System.Drawing.Point(965, 259);
            this.btnVout.Name = "btnVout";
            this.btnVout.Size = new System.Drawing.Size(164, 55);
            this.btnVout.TabIndex = 14;
            this.btnVout.Text = "Calcular V out";
            this.btnVout.UseVisualStyleBackColor = false;
            this.btnVout.Click += new System.EventHandler(this.btnVout_Click_1);
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVolt.Location = new System.Drawing.Point(861, 385);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(41, 26);
            this.lblVolt.TabIndex = 13;
            this.lblVolt.Text = "0V";
            // 
            // resistF
            // 
            this.resistF.Location = new System.Drawing.Point(487, 49);
            this.resistF.Name = "resistF";
            this.resistF.Size = new System.Drawing.Size(100, 26);
            this.resistF.TabIndex = 12;
            // 
            // resistI
            // 
            this.resistI.Location = new System.Drawing.Point(194, 259);
            this.resistI.Name = "resistI";
            this.resistI.Size = new System.Drawing.Size(100, 26);
            this.resistI.TabIndex = 11;
            // 
            // voltI
            // 
            this.voltI.Location = new System.Drawing.Point(275, 565);
            this.voltI.Name = "voltI";
            this.voltI.Size = new System.Drawing.Size(100, 26);
            this.voltI.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 59);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vout = (1+ Rf/Ri) Vi\r\nAv = 1 + Rf/Ri\r\n";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Operational_amplifiers.Properties.Resources.no_inversor;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 501);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormNoInversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1207, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGanancia);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGanancia);
            this.Controls.Add(this.btnVout);
            this.Controls.Add(this.lblVolt);
            this.Controls.Add(this.resistF);
            this.Controls.Add(this.resistI);
            this.Controls.Add(this.voltI);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormNoInversor";
            this.Text = "FormNoInversor";
            this.Load += new System.EventHandler(this.FormNoInversor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.Button btnVout;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.TextBox resistF;
        private System.Windows.Forms.TextBox resistI;
        private System.Windows.Forms.TextBox voltI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}