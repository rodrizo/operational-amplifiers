namespace Operational_amplifiers.Forms
{
    partial class FormSumador
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
            System.Windows.Forms.Label lblGanancia;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSumador));
            System.Windows.Forms.PictureBox pictureBox1;
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGanancia = new System.Windows.Forms.Button();
            this.btnVout = new System.Windows.Forms.Button();
            this.lblVolt = new System.Windows.Forms.Label();
            this.resistF = new System.Windows.Forms.TextBox();
            this.resistI = new System.Windows.Forms.TextBox();
            this.voltI = new System.Windows.Forms.TextBox();
            this.resistTwo = new System.Windows.Forms.TextBox();
            this.voltTwo = new System.Windows.Forms.TextBox();
            this.labelGanancia = new System.Windows.Forms.Label();
            lblGanancia = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGanancia.ForeColor = System.Drawing.Color.IndianRed;
            lblGanancia.Image = ((System.Drawing.Image)(resources.GetObject("lblGanancia.Image")));
            lblGanancia.Location = new System.Drawing.Point(760, 553);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new System.Drawing.Size(0, 26);
            lblGanancia.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::Operational_amplifiers.Properties.Resources.sumador;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(94, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(829, 531);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(106, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 59);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vout = -Rf [(V1/R1) + (V2/R2) ]\r\nAv = -(Rf/Rn)\r\n";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(997, 454);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(164, 56);
            this.btnClean.TabIndex = 26;
            this.btnClean.Text = "Limpiar datos";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnGanancia
            // 
            this.btnGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnGanancia.FlatAppearance.BorderSize = 0;
            this.btnGanancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGanancia.Location = new System.Drawing.Point(997, 360);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Size = new System.Drawing.Size(164, 56);
            this.btnGanancia.TabIndex = 25;
            this.btnGanancia.Text = "Calcular ganancia";
            this.btnGanancia.UseVisualStyleBackColor = false;
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);
            // 
            // btnVout
            // 
            this.btnVout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnVout.FlatAppearance.BorderSize = 0;
            this.btnVout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVout.Location = new System.Drawing.Point(997, 264);
            this.btnVout.Name = "btnVout";
            this.btnVout.Size = new System.Drawing.Size(164, 55);
            this.btnVout.TabIndex = 24;
            this.btnVout.Text = "Calcular V out";
            this.btnVout.UseVisualStyleBackColor = false;
            this.btnVout.Click += new System.EventHandler(this.btnVout_Click);
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVolt.Location = new System.Drawing.Point(873, 332);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(41, 26);
            this.lblVolt.TabIndex = 23;
            this.lblVolt.Text = "0V";
            // 
            // resistF
            // 
            this.resistF.Location = new System.Drawing.Point(518, 41);
            this.resistF.Name = "resistF";
            this.resistF.Size = new System.Drawing.Size(100, 26);
            this.resistF.TabIndex = 22;
            this.resistF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistF_KeyPress_1);
            // 
            // resistI
            // 
            this.resistI.Location = new System.Drawing.Point(240, 228);
            this.resistI.Name = "resistI";
            this.resistI.Size = new System.Drawing.Size(100, 26);
            this.resistI.TabIndex = 21;
            this.resistI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistI_KeyPress_1);
            // 
            // voltI
            // 
            this.voltI.Location = new System.Drawing.Point(71, 264);
            this.voltI.Name = "voltI";
            this.voltI.Size = new System.Drawing.Size(100, 26);
            this.voltI.TabIndex = 20;
            this.voltI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltI_KeyPress);
            // 
            // resistTwo
            // 
            this.resistTwo.Location = new System.Drawing.Point(240, 484);
            this.resistTwo.Name = "resistTwo";
            this.resistTwo.Size = new System.Drawing.Size(100, 26);
            this.resistTwo.TabIndex = 30;
            this.resistTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistTwo_KeyPress);
            // 
            // voltTwo
            // 
            this.voltTwo.Location = new System.Drawing.Point(71, 454);
            this.voltTwo.Name = "voltTwo";
            this.voltTwo.Size = new System.Drawing.Size(100, 26);
            this.voltTwo.TabIndex = 29;
            this.voltTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltTwo_KeyPress);
            // 
            // labelGanancia
            // 
            this.labelGanancia.AutoSize = true;
            this.labelGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanancia.ForeColor = System.Drawing.Color.IndianRed;
            this.labelGanancia.Location = new System.Drawing.Point(735, 511);
            this.labelGanancia.Name = "labelGanancia";
            this.labelGanancia.Size = new System.Drawing.Size(0, 26);
            this.labelGanancia.TabIndex = 31;
            // 
            // FormSumador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1203, 712);
            this.Controls.Add(this.labelGanancia);
            this.Controls.Add(this.resistTwo);
            this.Controls.Add(this.voltTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(lblGanancia);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGanancia);
            this.Controls.Add(this.btnVout);
            this.Controls.Add(this.lblVolt);
            this.Controls.Add(this.resistF);
            this.Controls.Add(this.resistI);
            this.Controls.Add(this.voltI);
            this.Controls.Add(pictureBox1);
            this.Name = "FormSumador";
            this.Text = "FormSumador";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGanancia;
        private System.Windows.Forms.Button btnVout;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.TextBox resistF;
        private System.Windows.Forms.TextBox resistI;
        private System.Windows.Forms.TextBox voltI;
        private System.Windows.Forms.TextBox resistTwo;
        private System.Windows.Forms.TextBox voltTwo;
        private System.Windows.Forms.Label labelGanancia;
    }
}