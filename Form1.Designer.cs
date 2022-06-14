namespace Operational_amplifiers
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnNivel = new System.Windows.Forms.Button();
            this.btnVolt = new System.Windows.Forms.Button();
            this.btnCruce = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnNoInv = new System.Windows.Forms.Button();
            this.btnInversor = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnNivel);
            this.panelMenu.Controls.Add(this.btnVolt);
            this.panelMenu.Controls.Add(this.btnCruce);
            this.panelMenu.Controls.Add(this.btnRest);
            this.panelMenu.Controls.Add(this.btnSum);
            this.panelMenu.Controls.Add(this.btnNoInv);
            this.panelMenu.Controls.Add(this.btnInversor);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(396, 823);
            this.panelMenu.TabIndex = 0;
            // 
            // btnNivel
            // 
            this.btnNivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNivel.FlatAppearance.BorderSize = 0;
            this.btnNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNivel.Location = new System.Drawing.Point(0, 555);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(396, 73);
            this.btnNivel.TabIndex = 7;
            this.btnNivel.Text = "Nivel de voltaje";
            this.btnNivel.UseVisualStyleBackColor = true;
            this.btnNivel.Click += new System.EventHandler(this.btnNivel_Click);
            // 
            // btnVolt
            // 
            this.btnVolt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVolt.FlatAppearance.BorderSize = 0;
            this.btnVolt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolt.Location = new System.Drawing.Point(0, 482);
            this.btnVolt.Name = "btnVolt";
            this.btnVolt.Size = new System.Drawing.Size(396, 73);
            this.btnVolt.TabIndex = 6;
            this.btnVolt.Text = "Voltaje + o -";
            this.btnVolt.UseVisualStyleBackColor = true;
            this.btnVolt.Click += new System.EventHandler(this.btnVolt_Click);
            // 
            // btnCruce
            // 
            this.btnCruce.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCruce.FlatAppearance.BorderSize = 0;
            this.btnCruce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCruce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCruce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCruce.Location = new System.Drawing.Point(0, 409);
            this.btnCruce.Name = "btnCruce";
            this.btnCruce.Size = new System.Drawing.Size(396, 73);
            this.btnCruce.TabIndex = 5;
            this.btnCruce.Text = "Detección cruce por cero";
            this.btnCruce.UseVisualStyleBackColor = true;
            this.btnCruce.Click += new System.EventHandler(this.btnCruce_Click);
            // 
            // btnRest
            // 
            this.btnRest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRest.FlatAppearance.BorderSize = 0;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRest.Location = new System.Drawing.Point(0, 336);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(396, 73);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Restador";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnSum
            // 
            this.btnSum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSum.FlatAppearance.BorderSize = 0;
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSum.Location = new System.Drawing.Point(0, 263);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(396, 73);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Sumador";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnNoInv
            // 
            this.btnNoInv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoInv.FlatAppearance.BorderSize = 0;
            this.btnNoInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoInv.Location = new System.Drawing.Point(0, 190);
            this.btnNoInv.Name = "btnNoInv";
            this.btnNoInv.Size = new System.Drawing.Size(396, 73);
            this.btnNoInv.TabIndex = 2;
            this.btnNoInv.Text = "No inversor";
            this.btnNoInv.UseVisualStyleBackColor = true;
            this.btnNoInv.Click += new System.EventHandler(this.btnNoInv_Click);
            // 
            // btnInversor
            // 
            this.btnInversor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInversor.FlatAppearance.BorderSize = 0;
            this.btnInversor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInversor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInversor.Location = new System.Drawing.Point(0, 117);
            this.btnInversor.Name = "btnInversor";
            this.btnInversor.Size = new System.Drawing.Size(396, 73);
            this.btnInversor.TabIndex = 1;
            this.btnInversor.Text = "Inversor";
            this.btnInversor.UseVisualStyleBackColor = true;
            this.btnInversor.Click += new System.EventHandler(this.btnInversor_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(396, 117);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(396, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1226, 117);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(427, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electrónica Analógica";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.LightGray;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(396, 117);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1226, 706);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1622, 823);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Amplificadores operacionales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnInversor;
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.Button btnVolt;
        private System.Windows.Forms.Button btnCruce;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnNoInv;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

