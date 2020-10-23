using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Agenda.Catalogos
{
    public partial class frmCatalogos : Form
    {
        public frmCatalogos()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink700, Primary.Pink900, Primary.Pink500, Accent.Pink100, TextShade.WHITE);
        }

        private void frmCatalogos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            //this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 50);
            this.Size = new Size(this.Parent.Bounds.Width-100, this.Parent.Bounds.Height - 200);
        }

        private void frmCatalogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["frmPrincipal"].Show();
        }
    }
}
