using Conexion;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_Inventarios
{
    public partial class Frm_Inventario : Form
    {
        private bool estado2;
        public Frm_Inventario(Boolean estado)
        {
            this.estado2 = estado;
            InitializeComponent();
            if (estado)
            {
                panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
                panel2.BackColor = Color.DarkOrange;
            }
            else
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.DeepSkyBlue;
                panel3.BackColor = Color.Aqua;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1(estado2);
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1(estado2);
            obj.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Descripcion.Text != "" && txt_Color.Text != "" && txt_Serie.Text != "" && txt_Observaciones.Text != "")
            {
                try
                {
                    Productos objProducto = new Productos();
                    objProducto.nombreCorto = txt_Nombre.Text.Trim();
                    objProducto.descripcion = txt_Descripcion.Text.Trim();
                    objProducto.serie = txt_Serie.Text.Trim();
                    DateTime fecha;
                    fecha = dateTimePicker1.Value;
                    objProducto.fechaAdquision = fecha.ToShortDateString();
                    objProducto.nombre = cbo_Area.SelectedText;
                    objProducto.observaciones = txt_Observaciones.Text.Trim();
                    objProducto.color = txt_Color.Text.Trim();
                    objProducto.tipoAdquision = cbo_tipoAd.SelectedValue.ToString().Trim();
                    int idGenerado = new DAOProductos().agregar(objProducto);
                    MessageBox.Show("Producto almacenado correctamente");
                    txt_Id.Text = "";
                    txt_Nombre.Text = "";
                    txt_Descripcion.Text = "";
                    txt_Serie.Text = "";
                    cbo_Area.SelectedText = "";
                    txt_Observaciones.Text = "";
                    txt_Color.Text = "";
                    cbo_tipoAd.SelectedText = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "No se guardo el producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos o inválidos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            Form1 obj = new Form1(true);
            obj.Show();
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            DAOProductos obj = new DAOProductos();
            DataTable dt = obj.areas();
            cbo_Area.DataSource = dt;
            cbo_Area.ValueMember = "nombre";
            cbo_Area.DisplayMember = "CategoryName";
            DataTable dt2 = obj.tipoAdquisicion();
            cbo_tipoAd.DataSource = dt2;
            cbo_tipoAd.ValueMember = "tipoAdquisicion";
            cbo_tipoAd.DisplayMember = "CategoryName";
            txt_Id.Text = Convert.ToString(obj.id());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Productos objProducto = new Productos();
                objProducto.id_Inventario = Convert.ToInt32(txt_Id.Text);
                objProducto.nombreCorto = txt_Nombre.Text.Trim();
                objProducto.descripcion = txt_Descripcion.Text.Trim();
                objProducto.serie = txt_Serie.Text.Trim();
                DateTime fecha;
                fecha = dateTimePicker1.Value;
                objProducto.fechaAdquision = fecha.ToShortDateString();
                objProducto.nombre = cbo_Area.SelectedText;
                objProducto.observaciones = txt_Observaciones.Text.Trim();
                objProducto.color = txt_Color.Text.Trim();
                objProducto.tipoAdquision = cbo_tipoAd.SelectedValue.ToString().Trim();
                int idGenerado = new DAOProductos().modificar(objProducto);
                MessageBox.Show("Cambios almacenados correctamente");
                txt_Id.Text = "";
                txt_Nombre.Text = "";
                txt_Descripcion.Text = "";
                txt_Serie.Text = "";
                cbo_Area.SelectedText = "";
                txt_Observaciones.Text = "";
                txt_Color.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "No se realizaron los cambios al producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            Form1 obj = new Form1(true);
            obj.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1(true);
            obj.Show();
        }

        private void cbo_tipoAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
