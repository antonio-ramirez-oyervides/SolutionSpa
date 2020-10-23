namespace MP_Agenda
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbServicios = new System.Windows.Forms.TabPage();
            this.tbCitas = new System.Windows.Forms.TabPage();
            this.tbCobros = new System.Windows.Forms.TabPage();
            this.tbCatalogos = new System.Windows.Forms.TabPage();
            this.tbSalir = new System.Windows.Forms.TabPage();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            this.menuIconList.Images.SetKeyName(9, "baseline_follow_the_signs_black_18dp.png");
            this.menuIconList.Images.SetKeyName(10, "baseline_hot_tub_black_18dp.png");
            this.menuIconList.Images.SetKeyName(11, "baseline_insert_chart_outlined_black_18dp.png");
            this.menuIconList.Images.SetKeyName(12, "baseline_people_alt_black_18dp.png");
            this.menuIconList.Images.SetKeyName(13, "baseline_redeem_black_18dp.png");
            this.menuIconList.Images.SetKeyName(14, "baseline_settings_black_18dp.png");
            this.menuIconList.Images.SetKeyName(15, "baseline_spa_black_18dp.png");
            this.menuIconList.Images.SetKeyName(16, "baseline_today_black_18dp.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbServicios);
            this.materialTabControl1.Controls.Add(this.tbCitas);
            this.materialTabControl1.Controls.Add(this.tbCobros);
            this.materialTabControl1.Controls.Add(this.tbCatalogos);
            this.materialTabControl1.Controls.Add(this.tbSalir);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(1113, 246);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(219, 83);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialTabControl1_Selecting);
            this.materialTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.materialTabControl1_Selected);
            this.materialTabControl1.Click += new System.EventHandler(this.materialTabControl1_Click);
            this.materialTabControl1.Enter += new System.EventHandler(this.materialTabControl1_Enter);
            // 
            // tbServicios
            // 
            this.tbServicios.ImageKey = "baseline_spa_black_18dp.png";
            this.tbServicios.Location = new System.Drawing.Point(4, 85);
            this.tbServicios.Name = "tbServicios";
            this.tbServicios.Size = new System.Drawing.Size(211, 0);
            this.tbServicios.TabIndex = 4;
            this.tbServicios.Text = "Servicios";
            this.tbServicios.UseVisualStyleBackColor = true;
            // 
            // tbCitas
            // 
            this.tbCitas.ImageKey = "baseline_today_black_18dp.png";
            this.tbCitas.Location = new System.Drawing.Point(4, 85);
            this.tbCitas.Name = "tbCitas";
            this.tbCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tbCitas.Size = new System.Drawing.Size(211, 0);
            this.tbCitas.TabIndex = 0;
            this.tbCitas.Text = "Citas";
            this.tbCitas.UseVisualStyleBackColor = true;
            // 
            // tbCobros
            // 
            this.tbCobros.ImageKey = "baseline_redeem_black_18dp.png";
            this.tbCobros.Location = new System.Drawing.Point(4, 85);
            this.tbCobros.Name = "tbCobros";
            this.tbCobros.Padding = new System.Windows.Forms.Padding(3);
            this.tbCobros.Size = new System.Drawing.Size(211, 0);
            this.tbCobros.TabIndex = 3;
            this.tbCobros.Text = "Cobros";
            this.tbCobros.UseVisualStyleBackColor = true;
            // 
            // tbCatalogos
            // 
            this.tbCatalogos.ImageKey = "baseline_settings_black_18dp.png";
            this.tbCatalogos.Location = new System.Drawing.Point(4, 85);
            this.tbCatalogos.Name = "tbCatalogos";
            this.tbCatalogos.Padding = new System.Windows.Forms.Padding(3);
            this.tbCatalogos.Size = new System.Drawing.Size(211, 0);
            this.tbCatalogos.TabIndex = 1;
            this.tbCatalogos.Text = "Catálogos";
            this.tbCatalogos.UseVisualStyleBackColor = true;
            // 
            // tbSalir
            // 
            this.tbSalir.ImageKey = "baseline_follow_the_signs_black_18dp.png";
            this.tbSalir.Location = new System.Drawing.Point(4, 85);
            this.tbSalir.Name = "tbSalir";
            this.tbSalir.Padding = new System.Windows.Forms.Padding(3);
            this.tbSalir.Size = new System.Drawing.Size(211, 0);
            this.tbSalir.TabIndex = 2;
            this.tbSalir.Text = "Salir";
            this.tbSalir.UseVisualStyleBackColor = true;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 534);
            this.panel2.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Madre Perla Spa";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList menuIconList;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbCitas;
        private System.Windows.Forms.TabPage tbCatalogos;
        private System.Windows.Forms.TabPage tbSalir;
        private System.Windows.Forms.TabPage tbCobros;
        private System.Windows.Forms.TabPage tbServicios;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
    }
}