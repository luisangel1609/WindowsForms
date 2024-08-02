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

namespace WindowsForms_Casa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        #region HELPER
        private void Refrescar()
        {
            using (EntitiesWF_Casa db = new EntitiesWF_Casa())
            {
                var lst = from d in db.Casa
                          select d;
                TablaCasas.DataSource = lst.ToList();
            }
        }
        private int? GetId()
        {
            try
            {
                return
                 int.Parse(TablaCasas.Rows[TablaCasas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {

                return null;
            }
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Presentacion.FormularioTabla oFormularioTabla = new Presentacion.FormularioTabla();
            oFormularioTabla.ShowDialog();
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Presentacion.FormularioTabla oFormularioTabla = new Presentacion.FormularioTabla(id);
                oFormularioTabla.ShowDialog();
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (EntitiesWF_Casa db = new EntitiesWF_Casa())
                {
                    Casa OCasa = db.Casa.Find(id);
                    db.Casa.Remove(OCasa);
                    db.SaveChanges();
                }
                Refrescar();
            }
        }
    }
}
