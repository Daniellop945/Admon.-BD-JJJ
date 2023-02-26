using Conexion;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_Inventarios
{
    public partial class FrmAreas : Form
    {
        public FrmAreas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMostrarAreas obj = new FrmMostrarAreas();
            obj.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMostrarAreas obj = new FrmMostrarAreas();
            obj.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Ubicacion.Text != "")
            {
                try
                {
                    Area objUbicacion = new Area();
                    objUbicacion.nombre = txt_Nombre.Text.Trim();
                    objUbicacion.ubicacion = txt_Ubicacion.Text.Trim();
                    int idGenerado = new DAOArea().agregar(objUbicacion);
                    MessageBox.Show("Area almacenada correctamente");
                    txt_Ubicacion.Text = "";
                    txt_Nombre.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "No se almaceno el area", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos o inválidos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            FrmMostrarAreas obj = new FrmMostrarAreas();
            obj.Show();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAreas_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Ubicacion.Text != "")
            {
                try
                {
                    Area objUbicacion = new Area();
                    objUbicacion.id = Convert.ToInt32(txt_id.Text.Trim());
                    objUbicacion.nombre = txt_Nombre.Text.Trim();
                    objUbicacion.ubicacion = txt_Ubicacion.Text.Trim();
                    int idGenerado = new DAOArea().modificar(objUbicacion);
                    txt_Ubicacion.Text = "";
                    txt_Nombre.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "No se ha modificado el area", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos o inválidos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            FrmMostrarAreas obj = new FrmMostrarAreas();
            obj.Show();
        }
    }
}
