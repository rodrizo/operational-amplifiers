namespace Operational_amplifiers.Forms
{
    partial class FormMoreLess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoreLess));
            System.Windows.Forms.PictureBox pictureBox1;
            this.voltTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnVout = new System.Windows.Forms.Button();
            this.lblVout = new System.Windows.Forms.Label();
            this.voltI = new System.Windows.Forms.TextBox();
            lblGanancia = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voltTwo
            // 
            this.voltTwo.Location = new System.Drawing.Point(299, 427);
            this.voltTwo.Name = "voltTwo";
            this.voltTwo.Size = new System.Drawing.Size(100, 26);
            this.voltTwo.TabIndex = 52;
            this.voltTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltTwo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(415, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 59);
            this.label1.TabIndex = 51;
            this.label1.Text = "Si NO INV > INV -> Vo = +\r\nSi NO INV < INV -> Vo = -";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(134)))), ((int)(((byte)(115)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.Location = new System.Drawing.Point(1010, 337);
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
            this.btnVout.Location = new System.Drawing.Point(1010, 229);
            this.btnVout.Name = "btnVout";
            this.btnVout.Size = new System.Drawing.Size(164, 55);
            this.btnVout.TabIndex = 48;
            this.btnVout.Text = "Calcular V out";
            this.btnVout.UseVisualStyleBackColor = false;
            this.btnVout.Click += new System.EventHandler(this.btnVout_Click);
            // 
            // lblVout
            // 
            this.lblVout.AutoSize = true;
            this.lblVout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVout.ForeColor = System.Drawing.Color.IndianRed;
            this.lblVout.Location = new System.Drawing.Point(721, 198);
            this.lblVout.Name = "lblVout";
            this.lblVout.Size = new System.Drawing.Size(0, 39);
            this.lblVout.TabIndex = 47;
            // 
            // voltI
            // 
            this.voltI.Location = new System.Drawing.Point(299, 162);
            this.voltI.Name = "voltI";
            this.voltI.Size = new System.Drawing.Size(100, 26);
            this.voltI.TabIndex = 46;
            this.voltI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.voltI_KeyPress);
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGanancia.ForeColor = System.Drawing.Color.IndianRed;
            lblGanancia.Image = ((System.Drawing.Image)(resources.GetObject("lblGanancia.Image")));
            lblGanancia.Location = new System.Drawing.Point(790, 526);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new System.Drawing.Size(0, 26);
            lblGanancia.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::Operational_amplifiers.Properties.Resources.comparador;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(127, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(829, 529);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // FormMoreLess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1237, 724);
            this.Controls.Add(this.voltTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(lblGanancia);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnVout);
            this.Controls.Add(this.lblVout);
            this.Controls.Add(this.voltI);
            this.Controls.Add(pictureBox1);
            this.Name = "FormMoreLess";
            this.Text = "FormMoreLess";
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
    }
}