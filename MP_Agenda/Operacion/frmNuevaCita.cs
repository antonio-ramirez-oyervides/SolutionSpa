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

namespace MP_Agenda
{
    public partial class frmNuevaCita : MaterialSkin.Controls.MaterialForm
    {
        public frmNuevaCita()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink700, Primary.Pink900, Primary.Pink500, Accent.Pink100, TextShade.WHITE);
        }

        private void frmNuevaCita_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 50);



            dataGridView1.DataSource = ListaServicios().Tables[0];
            dataGridView1.Columns[0].Width = 300;

            dataGridView1.Columns[1].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        public DataSet ListaServicios()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn { ColumnName = "Servicio" });
            dt.Columns.Add(new DataColumn { ColumnName = "Costo", DataType = typeof(int) });
            dt.Columns.Add(new DataColumn { ColumnName = "Tiempo" });
            dt.Columns.Add(new DataColumn { ColumnName = "Sesiones" });
            dt.AcceptChanges();

            DataRow row;

            row = dt.NewRow(); row["Servicio"] = "Cuidado Pies y Manos"; row["Costo"] = 1190; row["Tiempo"] = ""; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Depilacion"; row["Costo"] = 2499; row["Tiempo"] = "90"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Depilacion Media Pierna"; row["Costo"] = 999; row["Tiempo"] = "30"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Exfoliacion Cuerpo Completo"; row["Costo"] = 2499; row["Tiempo"] = "90"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Exfoliacion Espalda"; row["Costo"] = 999; row["Tiempo"] = "30"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Facial Express"; row["Costo"] = 1099; row["Tiempo"] = "45"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Drenaje Linfatico"; row["Costo"] = 1199; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Manicure"; row["Costo"] = 299; row["Tiempo"] = "30"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Masaje Prenatal"; row["Costo"] = 1290; row["Tiempo"] = "50"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Masaje Reductivo"; row["Costo"] = 1199; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Pedicure"; row["Costo"] = 350; row["Tiempo"] = "30"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Amore Amore"; row["Costo"] = 3399; row["Tiempo"] = "120"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Romance H20"; row["Costo"] = 2999; row["Tiempo"] = "90"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "T. Tradicional"; row["Costo"] = 2599; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "T. Tradicional con Jacuzzi"; row["Costo"] = 2899; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Velo de Novios"; row["Costo"] = 3199; row["Tiempo"] = "120"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Akasuri"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Ayurveda"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Fussion "; row["Costo"] = 1599; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "T. Tradicional"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Tibetano"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Ventosas"; row["Costo"] = 1399; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Woman 360"; row["Costo"] = 1300; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "4 Manos Thai"; row["Costo"] = 1899; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Aromaterapeutico"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Deportivo"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Descontracturante"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Hidromasaje"; row["Costo"] = 1599; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Holistico"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Hot Masaje"; row["Costo"] = 1399; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Masaje Combinado"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Masaje y Vapor"; row["Costo"] = 1499; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Piedras Calientes"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Sueco"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Thailandes"; row["Costo"] = 1250; row["Tiempo"] = "60"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Envolvente de manos con reflexologia"; row["Costo"] = 899; row["Tiempo"] = "45"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Envolvente de pies con reflexologia"; row["Costo"] = 899; row["Tiempo"] = "45"; row["Sesiones"] = ""; dt.Rows.Add(row); dt.AcceptChanges();
            row = dt.NewRow(); row["Servicio"] = "Anticelulitis"; row["Costo"] = 4689; row["Tiempo"] = ""; row["Sesiones"] = "8 sesiones"; dt.Rows.Add(row); dt.AcceptChanges();

            ds.Tables.Add(dt);
            ds.AcceptChanges();

            return ds;
        }
    }
}
