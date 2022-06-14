namespace Operational_amplifiers.Forms
{
    partial class FormInversor
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
            this.voltI = new System.Windows.Forms.TextBox();
            this.resistI = new System.Windows.Forms.TextBox();
            this.resistF = new System.Windows.Forms.TextBox();
            this.lblVolt = new System.Windows.Forms.Label();
            this.btnVout = new System.Windows.Forms.Button();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voltI
            // 
            this.voltI.Location = new System.Drawing.Point(76, 241);
            this.voltI.Name = "voltI";
            this.voltI.Size = new System.Drawing.Size(100, 26);
            this.voltI.TabIndex = 1;
            this.voltI.TextChanged += new System.EventHandler(this.voltI_TextChanged);
            this.voltI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltI_KeyPress_1);
            // 
            // resistI
            // 
            this.resistI.Location = new System.Drawing.Point(244, 200);
            this.resistI.Name = "resistI";
            this.resistI.Size = new System.Drawing.Size(100, 26);
            this.resistI.TabIndex = 2;
            this.resistI.TextChanged += new System.EventHandler(this.resistI_TextChanged);
            this.resistI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistI_KeyPress);
            // 
            // resistF
            // 
            this.resistF.Location = new System.Drawing.Point(517, 18);
            this.resistF.Name = "resistF";
            this.resistF.Size = new System.Drawing.Size(100, 26);
            this.resistF.TabIndex = 3;
            this.resistF.TextChanged += new System.EventHandler(this.resistF_TextChanged);
            this.resistF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistF_KeyPress);
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVolt.Location = new System.Drawing.Point(874, 315);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(41, 26);
            this.lblVolt.TabIndex = 4;
            this.lblVolt.Text = "0V";
            this.lblVolt.Click += new System.EventHandler(this.lblVolt_Click);
            // 
            // btnVout
            // 
            this.btnVout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnVout.FlatAppearance.BorderSize = 0;
            this.btnVout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVout.Location = new System.Drawing.Point(963, 219);
            this.btnVout.Name = "btnVout";
            this.btnVout.Size = new System.Drawing.Size(164, 55);
            this.btnVout.TabIndex = 5;
            this.btnVout.Text = "Calcular V out";
            this.btnVout.UseVisualStyleBackColor = false;
            this.btnVout.Click += new System.EventHandler(this.btnVout_Click);
            // 
            // btnGanancia
            // 
            this.btnGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnGanancia.FlatAppearance.BorderSize = 0;
            this.btnGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGanancia.Location = new System.Drawing.Point(963, 315);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(164, 56);
            this.btnGanancia.TabIndex = 6;
            this.btnGanancia.Text = "Calcular ganancia";
            this.btnGanancia.UseVisualStyleBackColor = false;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(963, 409);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(164, 56);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Limpiar datos";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGanancia.Location = new System.Drawing.Point(707, 489);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(0, 26);
            this.lblGanancia.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Operational_amplifiers.Properties.Resources.inv1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(101, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 559);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vout = (-Rf/Ri) Vin\r\nAv = (Vout / Vin) = (-Rf/Ri)\r\n";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // FormInversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1175, 703);
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
            this.Name = "FormInversor";
            this.Text = "FormInversor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox voltI;
        private System.Windows.Forms.TextBox resistI;
        private System.Windows.Forms.TextBox resistF;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.Button btnVout;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label label1;
    }
}