using MaterialSkin;
using MaterialSkin.Controls;
using MP_Agenda.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Agenda
{
    public partial class frmPrincipal : MaterialForm
    {
        enum eOpcionesMenu : int
        {
            Servicios = 0,
            Citas = 1,
            Cobros =2,
            Catalogos = 3,
            Salir = 4
        }



        public frmPrincipal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink700, Primary.Pink900, Primary.Pink500, Accent.Pink100, TextShade.WHITE);
        }



        private void Principal_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 50);


            frmCatalogos myForm = new frmCatalogos();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(myForm);
            myForm.Show();

        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int indice = e.TabPageIndex;
            
            switch (indice)
            {
                case (int)eOpcionesMenu.Servicios:

                    break;

                case (int) eOpcionesMenu.Citas:
                    frmNuevaCita frm = new frmNuevaCita();
                    frm.ShowDialog();
                    break;

                case (int) eOpcionesMenu.Catalogos:
            
                    frmCatalogos frmCat = new frmCatalogos();
                    frmCat.ShowDialog();
                    //this.Hide();
                    break;

                case (int) eOpcionesMenu.Salir:
                    DialogResult resp = MessageBox.Show("Confirma salir del sistema?", "Salir", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                    if(resp== DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    materialTabControl1.SelectedIndex = 0;
                    break;
            }

        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void materialTabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show (e.RowIndex.ToString());
        }
    }
}
