using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Agenda.Operacion
{
    public partial class frmDashboard : MaterialSkin.Controls.MaterialForm
    {
        public frmDashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink700, Primary.Pink900, Primary.Pink500, Accent.Pink100, TextShade.WHITE);
        }
    }
}
