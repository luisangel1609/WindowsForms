using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_Casa.Models;

namespace WindowsForms_Casa.Presentacion
{
    public partial class FormularioTabla : Form
    {
        public int? id;
        Casa oCasa = null;
        public FormularioTabla(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
        }
        private void CargaDatos()
        {
            using (EntitiesWF_Casa db = new EntitiesWF_Casa())
            {
                oCasa = db.Casa.Find(id);
                txtUbicacion.Text = oCasa.Ubicacion;
                txtcosto.Text = oCasa.Costo;
                txtm2.Text = oCasa.MetrosCuadrados;
                txtda.Text = oCasa.DuenioAnterior;
            }
        }

        private void FormularioTabla_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            using (EntitiesWF_Casa db = new EntitiesWF_Casa())
            {
                if (id == null)
                    oCasa = new Casa();
                oCasa.Ubicacion = txtUbicacion.Text;
                oCasa.Costo = txtcosto.Text;
                oCasa.MetrosCuadrados = txtm2.Text;
                oCasa.DuenioAnterior = txtda.Text;

                if (id == null)
                    db.Casa.Add(oCasa);
                else
                {
                    db.Entry(oCasa).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();
            }
        }
    }
}
