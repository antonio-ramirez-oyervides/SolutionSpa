namespace MP_Agenda.Catalogos
{
    partial class frmCatalogos
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
            this.ctrTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.tbSucursales = new System.Windows.Forms.TabPage();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel44 = new MaterialSkin.Controls.MaterialLabel();
            this.tbTipoServicios = new System.Windows.Forms.TabPage();
            this.tbServicios = new System.Windows.Forms.TabPage();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tbTerapeutas = new System.Windows.Forms.TabPage();
            this.tbCabinas = new System.Windows.Forms.TabPage();
            this.tbUsuarios = new System.Windows.Forms.TabPage();
            this.tbPerfiles = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrTabs.SuspendLayout();
            this.tbSucursales.SuspendLayout();
            this.tbServicios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrTabs
            // 
            this.ctrTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrTabs.Controls.Add(this.tbSucursales);
            this.ctrTabs.Controls.Add(this.tbTipoServicios);
            this.ctrTabs.Controls.Add(this.tbServicios);
            this.ctrTabs.Controls.Add(this.tbTerapeutas);
            this.ctrTabs.Controls.Add(this.tbCabinas);
            this.ctrTabs.Controls.Add(this.tbUsuarios);
            this.ctrTabs.Controls.Add(this.tbPerfiles);
            this.ctrTabs.Depth = 0;
            this.ctrTabs.Location = new System.Drawing.Point(2, 1);
            this.ctrTabs.Margin = new System.Windows.Forms.Padding(0);
            this.ctrTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.ctrTabs.Multiline = true;
            this.ctrTabs.Name = "ctrTabs";
            this.ctrTabs.SelectedIndex = 0;
            this.ctrTabs.Size = new System.Drawing.Size(1242, 652);
            this.ctrTabs.TabIndex = 25;
            // 
            // tbSucursales
            // 
            this.tbSucursales.BackColor = System.Drawing.Color.White;
            this.tbSucursales.Controls.Add(this.materialLabel45);
            this.tbSucursales.Controls.Add(this.materialLabel44);
            this.tbSucursales.Location = new System.Drawing.Point(4, 22);
            this.tbSucursales.Name = "tbSucursales";
            this.tbSucursales.Padding = new System.Windows.Forms.Padding(3);
            this.tbSucursales.Size = new System.Drawing.Size(1234, 626);
            this.tbSucursales.TabIndex = 0;
            this.tbSucursales.Text = "Sucursales";
            // 
            // materialLabel45
            // 
            this.materialLabel45.AutoSize = true;
            this.materialLabel45.Depth = 0;
            this.materialLabel45.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel45.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel45.HighEmphasis = true;
            this.materialLabel45.Location = new System.Drawing.Point(15, 14);
            this.materialLabel45.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel45.Name = "materialLabel45";
            this.materialLabel45.Size = new System.Drawing.Size(174, 24);
            this.materialLabel45.TabIndex = 4;
            this.materialLabel45.Text = "Tabs are supported";
            // 
            // materialLabel44
            // 
            this.materialLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel44.Depth = 0;
            this.materialLabel44.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel44.Location = new System.Drawing.Point(15, 55);
            this.materialLabel44.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel44.Name = "materialLabel44";
            this.materialLabel44.Size = new System.Drawing.Size(1197, 553);
            this.materialLabel44.TabIndex = 3;
            this.materialLabel44.Text = "However, in accordance with the Material Design principles, tabs should NOT be us" +
    "ed together with the Drawer menu, chose one or the other :)\r\n\r\nTry \'em!";
            // 
            // tbTipoServicios
            // 
            this.tbTipoServicios.Location = new System.Drawing.Point(4, 22);
            this.tbTipoServicios.Name = "tbTipoServicios";
            this.tbTipoServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tbTipoServicios.Size = new System.Drawing.Size(1234, 626);
            this.tbTipoServicios.TabIndex = 2;
            this.tbTipoServicios.Text = "Tipo de Servicios";
            this.tbTipoServicios.UseVisualStyleBackColor = true;
            // 
            // tbServicios
            // 
            this.tbServicios.BackColor = System.Drawing.Color.White;
            this.tbServicios.Controls.Add(this.materialLabel10);
            this.tbServicios.Location = new System.Drawing.Point(4, 22);
            this.tbServicios.Name = "tbServicios";
            this.tbServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tbServicios.Size = new System.Drawing.Size(1234, 626);
            this.tbServicios.TabIndex = 1;
            this.tbServicios.Text = "Servicios";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.HighEmphasis = true;
            this.materialLabel10.Location = new System.Drawing.Point(6, 7);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(475, 58);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Everything is possible!";
            this.materialLabel10.UseAccent = true;
            // 
            // tbTerapeutas
            // 
            this.tbTerapeutas.Location = new System.Drawing.Point(4, 22);
            this.tbTerapeutas.Name = "tbTerapeutas";
            this.tbTerapeutas.Size = new System.Drawing.Size(1234, 626);
            this.tbTerapeutas.TabIndex = 3;
            this.tbTerapeutas.Text = "Terapeutas";
            this.tbTerapeutas.UseVisualStyleBackColor = true;
            // 
            // tbCabinas
            // 
            this.tbCabinas.Location = new System.Drawing.Point(4, 22);
            this.tbCabinas.Name = "tbCabinas";
            this.tbCabinas.Size = new System.Drawing.Size(1234, 626);
            this.tbCabinas.TabIndex = 4;
            this.tbCabinas.Text = "Cabinas";
            this.tbCabinas.UseVisualStyleBackColor = true;
            // 
            // tbUsuarios
            // 
            this.tbUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbUsuarios.Name = "tbUsuarios";
            this.tbUsuarios.Size = new System.Drawing.Size(1234, 626);
            this.tbUsuarios.TabIndex = 5;
            this.tbUsuarios.Text = "Usuarios";
            this.tbUsuarios.UseVisualStyleBackColor = true;
            // 
            // tbPerfiles
            // 
            this.tbPerfiles.Location = new System.Drawing.Point(4, 22);
            this.tbPerfiles.Name = "tbPerfiles";
            this.tbPerfiles.Size = new System.Drawing.Size(1234, 626);
            this.tbPerfiles.TabIndex = 6;
            this.tbPerfiles.Text = "Perfiles";
            this.tbPerfiles.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.ctrTabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1284, 38);
            this.materialTabSelector1.TabIndex = 26;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ctrTabs);
            this.panel1.Location = new System.Drawing.Point(-1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 717);
            this.panel1.TabIndex = 27;
            // 
            // frmCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 800);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCatalogos";
            this.ShowInTaskbar = false;
            this.Text = "Catálogos";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCatalogos_FormClosing);
            this.Load += new System.EventHandler(this.frmCatalogos_Load);
            this.ctrTabs.ResumeLayout(false);
            this.tbSucursales.ResumeLayout(false);
            this.tbSucursales.PerformLayout();
            this.tbServicios.ResumeLayout(false);
            this.tbServicios.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl ctrTabs;
        private System.Windows.Forms.TabPage tbSucursales;
        private MaterialSkin.Controls.MaterialLabel materialLabel45;
        private MaterialSkin.Controls.MaterialLabel materialLabel44;
        private System.Windows.Forms.TabPage tbServicios;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tbTipoServicios;
        private System.Windows.Forms.TabPage tbTerapeutas;
        private System.Windows.Forms.TabPage tbCabinas;
        private System.Windows.Forms.TabPage tbUsuarios;
        private System.Windows.Forms.TabPage tbPerfiles;
    }
}