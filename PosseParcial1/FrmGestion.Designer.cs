namespace PosseParcial1
{
    partial class FrmGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRubro = new System.Windows.Forms.Label();
            this.grbG = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblCantArt = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.lnkAcerca = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.grbG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(58, 43);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(49, 16);
            this.lblRubro.TabIndex = 1;
            this.lblRubro.Text = "Rubro";
            // 
            // grbG
            // 
            this.grbG.BackColor = System.Drawing.Color.RosyBrown;
            this.grbG.Controls.Add(this.lnkAcerca);
            this.grbG.Controls.Add(this.btnExportar);
            this.grbG.Controls.Add(this.lblTotal);
            this.grbG.Controls.Add(this.lblT);
            this.grbG.Controls.Add(this.lblCant);
            this.grbG.Controls.Add(this.lblCantArt);
            this.grbG.Controls.Add(this.btnListar);
            this.grbG.Controls.Add(this.dgvGrilla);
            this.grbG.Controls.Add(this.cmbRubro);
            this.grbG.Controls.Add(this.lblRubro);
            this.grbG.Location = new System.Drawing.Point(21, 43);
            this.grbG.Name = "grbG";
            this.grbG.Size = new System.Drawing.Size(597, 426);
            this.grbG.TabIndex = 2;
            this.grbG.TabStop = false;
            this.grbG.Text = "Gestión";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MistyRose;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(452, 39);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(116, 25);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.MistyRose;
            this.lblTotal.Location = new System.Drawing.Point(387, 366);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(107, 18);
            this.lblTotal.TabIndex = 8;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(329, 366);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(43, 16);
            this.lblT.TabIndex = 7;
            this.lblT.Text = "Total";
            // 
            // lblCant
            // 
            this.lblCant.BackColor = System.Drawing.Color.MistyRose;
            this.lblCant.Location = new System.Drawing.Point(204, 366);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(107, 18);
            this.lblCant.TabIndex = 6;
            // 
            // lblCantArt
            // 
            this.lblCantArt.AutoSize = true;
            this.lblCantArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantArt.Location = new System.Drawing.Point(43, 366);
            this.lblCantArt.Name = "lblCantArt";
            this.lblCantArt.Size = new System.Drawing.Size(155, 16);
            this.lblCantArt.TabIndex = 5;
            this.lblCantArt.Text = "Cantidad de Artículos";
            this.lblCantArt.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.MistyRose;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(323, 39);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(116, 25);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Artículos";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvGrilla.Location = new System.Drawing.Point(33, 83);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(535, 263);
            this.dgvGrilla.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Códogo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor en Stock";
            this.Column5.Name = "Column5";
            // 
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(127, 42);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(162, 21);
            this.cmbRubro.TabIndex = 2;
            // 
            // lnkAcerca
            // 
            this.lnkAcerca.AutoSize = true;
            this.lnkAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAcerca.LinkColor = System.Drawing.Color.DeepPink;
            this.lnkAcerca.Location = new System.Drawing.Point(491, 397);
            this.lnkAcerca.Name = "lnkAcerca";
            this.lnkAcerca.Size = new System.Drawing.Size(77, 16);
            this.lnkAcerca.TabIndex = 10;
            this.lnkAcerca.TabStop = true;
            this.lnkAcerca.Text = "Acerca De..";
            this.lnkAcerca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAcerca_LinkClicked);
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(639, 481);
            this.Controls.Add(this.grbG);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión";
            this.Load += new System.EventHandler(this.FrmGestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbG.ResumeLayout(false);
            this.grbG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.GroupBox grbG;
        private System.Windows.Forms.Label lblCantArt;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.LinkLabel lnkAcerca;
    }
}

