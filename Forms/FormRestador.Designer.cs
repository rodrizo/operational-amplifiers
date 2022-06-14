namespace Operational_amplifiers.Forms
{
    partial class FormRestador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestador));
            System.Windows.Forms.PictureBox pictureBox1;
            this.labelGanancia = new System.Windows.Forms.Label();
            this.resistTwo = new System.Windows.Forms.TextBox();
            this.voltTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnVout = new System.Windows.Forms.Button();
            this.lblVolt = new System.Windows.Forms.Label();
            this.resistF = new System.Windows.Forms.TextBox();
            this.resistI = new System.Windows.Forms.TextBox();
            this.voltI = new System.Windows.Forms.TextBox();
            this.resistFour = new System.Windows.Forms.TextBox();
            lblGanancia = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGanancia
            // 
            this.labelGanancia.AutoSize = true;
            this.labelGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanancia.ForeColor = System.Drawing.Color.IndianRed;
            this.labelGanancia.Location = new System.Drawing.Point(729, 493);
            this.labelGanancia.Name = "labelGanancia";
            this.labelGanancia.Size = new System.Drawing.Size(0, 26);
            this.labelGanancia.TabIndex = 44;
            // 
            // resistTwo
            // 
            this.resistTwo.Location = new System.Drawing.Point(233, 136);
            this.resistTwo.Name = "resistTwo";
            this.resistTwo.Size = new System.Drawing.Size(100, 26);
            this.resistTwo.TabIndex = 43;
            this.resistTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistTwo_KeyPress);
            // 
            // voltTwo
            // 
            this.voltTwo.Location = new System.Drawing.Point(79, 169);
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
            this.label1.Location = new System.Drawing.Point(539, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 59);
            this.label1.TabIndex = 41;
            this.label1.Text = "Vout = [ ((Rx(R2 + Rf)) / (R2(R1 + Rx))) * V1 ] - ((Rf / R2) * V2)\r\n\r\n";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(991, 385);
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
            this.btnVout.Location = new System.Drawing.Point(991, 272);
            this.btnVout.Name = "btnVout";
            this.btnVout.Size = new System.Drawing.Size(164, 55);
            this.btnVout.TabIndex = 37;
            this.btnVout.Text = "Calcular V out";
            this.btnVout.UseVisualStyleBackColor = false;
            this.btnVout.Click += new System.EventHandler(this.btnVout_Click);
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVolt.Location = new System.Drawing.Point(867, 301);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(41, 26);
            this.lblVolt.TabIndex = 36;
            this.lblVolt.Text = "0V";
            // 
            // resistF
            // 
            this.resistF.Location = new System.Drawing.Point(512, 23);
            this.resistF.Name = "resistF";
            this.resistF.Size = new System.Drawing.Size(100, 26);
            this.resistF.TabIndex = 35;
            this.resistF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistF_KeyPress);
            // 
            // resistI
            // 
            this.resistI.Location = new System.Drawing.Point(233, 493);
            this.resistI.Name = "resistI";
            this.resistI.Size = new System.Drawing.Size(100, 26);
            this.resistI.TabIndex = 34;
            this.resistI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistI_KeyPress);
            // 
            // voltI
            // 
            this.voltI.Location = new System.Drawing.Point(79, 469);
            this.voltI.Name = "voltI";
            this.voltI.Size = new System.Drawing.Size(100, 26);
            this.voltI.TabIndex = 33;
            this.voltI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltI_KeyPress);
            // 
            // resistFour
            // 
            this.resistFour.Location = new System.Drawing.Point(512, 509);
            this.resistFour.Name = "resistFour";
            this.resistFour.Size = new System.Drawing.Size(100, 26);
            this.resistFour.TabIndex = 45;
            this.resistFour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resistFour_KeyPress);
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGanancia.ForeColor = System.Drawing.Color.IndianRed;
            lblGanancia.Image = ((System.Drawing.Image)(resources.GetObject("lblGanancia.Image")));
            lblGanancia.Location = new System.Drawing.Point(754, 535);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new System.Drawing.Size(0, 26);
            lblGanancia.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::Operational_amplifiers.Properties.Resources.restador;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(56, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(863, 627);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // FormRestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1202, 784);
            this.Controls.Add(this.resistFour);
            this.Controls.Add(this.labelGanancia);
            this.Controls.Add(this.resistTwo);
            this.Controls.Add(this.voltTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(lblGanancia);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnVout);
            this.Controls.Add(this.lblVolt);
            this.Controls.Add(this.resistF);
            this.Controls.Add(this.resistI);
            this.Controls.Add(this.voltI);
            this.Controls.Add(pictureBox1);
            this.Name = "FormRestador";
            this.Text = "FormRestador";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGanancia;
        private System.Windows.Forms.TextBox resistTwo;
        private System.Windows.Forms.TextBox voltTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnVout;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.TextBox resistF;
        private System.Windows.Forms.TextBox resistI;
        private System.Windows.Forms.TextBox voltI;
        private System.Windows.Forms.TextBox resistFour;
    }
}