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
    public partial class FrmMostrarAreas : Form
    {
        public FrmMostrarAreas()
        {
            InitializeComponent();
            cargarTabla();
        }

        public int Modid(int id)
        {
            return id;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1(true);
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAreas ob= new FrmAreas();
            ob.iconButton1.Visible = true;
            ob.iconButton1.Enabled = true;
            ob.btnModificar.Visible = false;
            ob.btnModificar.Enabled = false;
            ob.txt_id.Enabled = false;
            ob.Show();
        }
        public void cargarTabla()
        {
            dgv_Areas.DataSource = new DAOArea().ObtenerTodos();
            dgv_Areas.Columns["id"].HeaderText = "ID";
            dgv_Areas.Columns["nombre"].HeaderText = "Nombre";
            dgv_Areas.Columns["ubicacion"].HeaderText = "ubicacion";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Areas.SelectedRows.Count > 0)
            {
                //Guarda el indice donde se selecciona la columna
                int a = dgv_Areas.CurrentRow.Index;
                //Muestra que columa se selecciono
                DialogResult dialogResult = MessageBox.Show("¿Segur@ que deseas modificar " + dgv_Areas.Rows[a].Cells[1].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    FrmAreas obj = new FrmAreas();
                    DAOArea ob = new DAOArea();
                    //Va a llenar el formulario con los datos del id
                    obj.iconButton1.Visible = false;
                    obj.iconButton1.Enabled = false;
                    obj.btnModificar.Visible = true;
                    obj.btnModificar.Enabled = true;;
                    obj.txt_id.Text = dgv_Areas.Rows[a].Cells[0].Value.ToString();
                    obj.txt_Nombre.Text = dgv_Areas.Rows[a].Cells[1].Value.ToString();
                    obj.txt_Ubicacion.Text = dgv_Areas.Rows[a].Cells[2].Value.ToString();
                    obj.Show();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna area para modificar");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Areas.SelectedRows.Count > 0)
            {
                int a = dgv_Areas.CurrentRow.Index;
                DialogResult dialogResult = MessageBox.Show("¿Segur@ que deseas eliminar " + dgv_Areas.Rows[a].Cells[1].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAOArea obj = new DAOArea();
                    if (obj.eliminar(Convert.ToInt32(dgv_Areas.Rows[a].Cells[0].Value.ToString())))
                    {
                        cargarTabla();
                        MessageBox.Show("Se ha eliminado el area correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No fue posible eliminar el area");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna area para modificar");
            }
        }

        private void dgv_Areas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMostrarAreas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
