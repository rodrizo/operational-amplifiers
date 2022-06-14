namespace Operational_amplifiers.Forms
{
    partial class FormCero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCero));
            System.Windows.Forms.PictureBox pictureBox1;
            this.voltTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnVout = new System.Windows.Forms.Button();
            this.lblVout = new System.Windows.Forms.Label();
            this.voltI = new System.Windows.Forms.TextBox();
            this.lblSatP = new System.Windows.Forms.Label();
            this.lblSatM = new System.Windows.Forms.Label();
            lblGanancia = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voltTwo
            // 
            this.voltTwo.Location = new System.Drawing.Point(290, 430);
            this.voltTwo.Name = "voltTwo";
            this.voltTwo.Size = new System.Drawing.Size(100, 26);
            this.voltTwo.TabIndex = 42;
            this.voltTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltTwo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 59);
            this.label1.TabIndex = 41;
            this.label1.Text = "Si NO INV > INV -> Vo = +Vsat\r\nSi NO INV < INV -> Vo = -Vsat";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(1001, 340);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(164, 56);
            this.btnClean.TabIndex = 39;
            this.btnClean.Text = "Limpiar datos";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnVout
            // 
            this.btnVout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnVout.FlatAppearance.BorderSize = 0;
            this.btnVout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVout.Location = new System.Drawing.Point(1001, 232);
            this.btnVout.Name = "btnVout";
            this.btnVout.Size = new System.Drawing.Size(164, 55);
            this.btnVout.TabIndex = 37;
            this.btnVout.Text = "Calcular V out";
            this.btnVout.UseVisualStyleBackColor = false;
            this.btnVout.Click += new System.EventHandler(this.btnVout_Click);
            // 
            // lblVout
            // 
            this.lblVout.AutoSize = true;
            this.lblVout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVout.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVout.Location = new System.Drawing.Point(712, 201);
            this.lblVout.Name = "lblVout";
            this.lblVout.Size = new System.Drawing.Size(41, 26);
            this.lblVout.TabIndex = 36;
            this.lblVout.Text = "0V";
            // 
            // voltI
            // 
            this.voltI.Location = new System.Drawing.Point(290, 165);
            this.voltI.Name = "voltI";
            this.voltI.Size = new System.Drawing.Size(100, 26);
            this.voltI.TabIndex = 33;
            this.voltI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltI_KeyPress);
            // 
            // lblSatP
            // 
            this.lblSatP.AutoSize = true;
            this.lblSatP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatP.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSatP.Location = new System.Drawing.Point(595, 100);
            this.lblSatP.Name = "lblSatP";
            this.lblSatP.Size = new System.Drawing.Size(54, 26);
            this.lblSatP.TabIndex = 43;
            this.lblSatP.Text = "10V";
            // 
            // lblSatM
            // 
            this.lblSatM.AutoSize = true;
            this.lblSatM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatM.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSatM.Location = new System.Drawing.Point(587, 520);
            this.lblSatM.Name = "lblSatM";
            this.lblSatM.Size = new System.Drawing.Size(62, 26);
            this.lblSatM.TabIndex = 44;
            this.lblSatM.Text = "-10V";
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGanancia.ForeColor = System.Drawing.Color.IndianRed;
            lblGanancia.Image = ((System.Drawing.Image)(resources.GetObject("lblGanancia.Image")));
            lblGanancia.Location = new System.Drawing.Point(781, 529);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new System.Drawing.Size(0, 26);
            lblGanancia.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::Operational_amplifiers.Properties.Resources.comparador;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(118, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(829, 529);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // FormCero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1231, 781);
            this.Controls.Add(this.lblSatM);
            this.Controls.Add(this.lblSatP);
            this.Controls.Add(this.voltTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(lblGanancia);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnVout);
            this.Controls.Add(this.lblVout);
            this.Controls.Add(this.voltI);
            this.Controls.Add(pictureBox1);
            this.Name = "FormCero";
            this.Text = "FormCero";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox voltTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnVout;
        private System.Windows.Forms.Label lblVout;
        private System.Windows.Forms.TextBox voltI;
        private System.Windows.Forms.Label lblSatP;
        private System.Windows.Forms.Label lblSatM;
    }
}