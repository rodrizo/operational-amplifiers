namespace Operational_amplifiers.Forms
{
    partial class FormVoltage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVoltage));
            System.Windows.Forms.PictureBox pictureBox1;
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnVout = new System.Windows.Forms.Button();
            this.lblVref = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VUT = new System.Windows.Forms.TextBox();
            this.VLT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            lblGanancia = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(508, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 59);
            this.label1.TabIndex = 51;
            this.label1.Text = "n = ((+Vsat - (-Vsat)) / Vh) - 1\r\nVref = ((n+1) / n) (Vctr)";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(926, 300);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(164, 56);
            this.btnClean.TabIndex = 49;
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
            this.btnVout.Location = new System.Drawing.Point(926, 192);
            this.btnVout.Name = "btnVout";
            this.btnVout.Size = new System.Drawing.Size(164, 55);
            this.btnVout.TabIndex = 48;
            this.btnVout.Text = "Calcular V ref";
            this.btnVout.UseVisualStyleBackColor = false;
            this.btnVout.Click += new System.EventHandler(this.btnVout_Click);
            // 
            // lblVref
            // 
            this.lblVref.AutoSize = true;
            this.lblVref.BackColor = System.Drawing.Color.White;
            this.lblVref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVref.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVref.Location = new System.Drawing.Point(378, 476);
            this.lblVref.Name = "lblVref";
            this.lblVref.Size = new System.Drawing.Size(41, 26);
            this.lblVref.TabIndex = 47;
            this.lblVref.Text = "0V";
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGanancia.ForeColor = System.Drawing.Color.IndianRed;
            lblGanancia.Image = ((System.Drawing.Image)(resources.GetObject("lblGanancia.Image")));
            lblGanancia.Location = new System.Drawing.Point(706, 489);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new System.Drawing.Size(0, 26);
            lblGanancia.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::Operational_amplifiers.Properties.Resources.detector;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(119, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(733, 449);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(505, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "- 15V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(506, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "+15 V";
            // 
            // VUT
            // 
            this.VUT.Location = new System.Drawing.Point(193, 189);
            this.VUT.Name = "VUT";
            this.VUT.Size = new System.Drawing.Size(51, 26);
            this.VUT.TabIndex = 63;
            this.VUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VUT_KeyPress);
            // 
            // VLT
            // 
            this.VLT.Location = new System.Drawing.Point(193, 236);
            this.VLT.Name = "VLT";
            this.VLT.Size = new System.Drawing.Size(51, 26);
            this.VLT.TabIndex = 64;
            this.VLT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VLT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(128, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "VUT =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(131, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "VLT =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(179, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 59);
            this.label6.TabIndex = 67;
            this.label6.Text = "Vctr = ((VUT + VLT) / 2)\r\nVh = VUT - VLT";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // FormVoltage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1136, 759);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VLT);
            this.Controls.Add(this.VUT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(lblGanancia);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnVout);
            this.Controls.Add(this.lblVref);
            this.Controls.Add(pictureBox1);
            this.Name = "FormVoltage";
            this.Text = "FormVoltage";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnVout;
        private System.Windows.Forms.Label lblVref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VUT;
        private System.Windows.Forms.TextBox VLT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}