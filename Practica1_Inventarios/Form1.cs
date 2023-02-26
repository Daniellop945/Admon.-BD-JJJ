using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using Conexion;
using Datos;

namespace Practica1_Inventarios
{
    public partial class Form1 : Form
    {

        public bool isTrue = true;
        public Form1(Boolean modo)
        {
            InitializeComponent();
            cargarTabla();
            conexion obj = new conexion();
            if (obj.conectar())
            {
                MessageBox.Show("Conectado");
            }
            else
            {
                MessageBox.Show("Desconectar");
            }
            if (modo)
            {
                //Modo oscuro
                PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
                iconButton1.BackColor = System.Drawing.Color.DarkOrange;
                iconButton2.BackColor = System.Drawing.Color.DarkOrange;
                btn_Agregar.BackColor = System.Drawing.Color.DarkOrange;
                btn_Modificar.BackColor = System.Drawing.Color.DarkOrange;
                btn_Eliminar.BackColor = System.Drawing.Color.DarkOrange;
                iconButton6.IconColor = System.Drawing.Color.White;
                iconButton7.IconColor = System.Drawing.Color.Yellow;
                iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
                iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
                panel1.BackColor = System.Drawing.Color.DarkOrange;
                panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
                panel3.BackColor = System.Drawing.Color.Coral;
            }
            else
            {
                //Modo white
                PanelPrincipal.BackColor = System.Drawing.Color.White;
                iconButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
                iconButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
                btn_Agregar.BackColor = System.Drawing.Color.DeepSkyBlue;
                btn_Modificar.BackColor = System.Drawing.Color.DeepSkyBlue;
                btn_Eliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
                iconButton6.BackColor = System.Drawing.Color.White;
                iconButton7.BackColor = System.Drawing.Color.White;
                iconButton6.IconColor = System.Drawing.Color.DarkGray;
                iconButton7.IconColor = System.Drawing.Color.DarkOrange;
                panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
                panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
                panel4.BackColor = System.Drawing.Color.Aqua;
            }
        } 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Inventario panel2 = new Frm_Inventario(isTrue);
            panel2.txt_Id.Enabled= false;
            panel2.iconButton1.Enabled = true;
            panel2.iconButton1.Visible = true;
            panel2.iconButton4.Enabled = false;
            panel2.iconButton4.Visible = false;
            panel2.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            PanelPrincipal.BackColor = System.Drawing.Color.White;
            iconButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            iconButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_Agregar.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_Modificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            btn_Eliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            iconButton6.BackColor = System.Drawing.Color.White;
            iconButton7.BackColor = System.Drawing.Color.White;
            iconButton6.IconColor = System.Drawing.Color.DarkGray;
            iconButton7.IconColor = System.Drawing.Color.DarkOrange;
            panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel4.BackColor = System.Drawing.Color.Aqua;
            isTrue = false;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            iconButton1.BackColor = System.Drawing.Color.DarkOrange;
            iconButton2.BackColor = System.Drawing.Color.DarkOrange;
            btn_Agregar.BackColor = System.Drawing.Color.DarkOrange;
            btn_Modificar.BackColor = System.Drawing.Color.DarkOrange;
            btn_Eliminar.BackColor = System.Drawing.Color.DarkOrange;
            iconButton6.IconColor = System.Drawing.Color.White;
            iconButton7.IconColor = System.Drawing.Color.Yellow;
            iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            panel1.BackColor = System.Drawing.Color.DarkOrange;
            panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            panel3.BackColor = System.Drawing.Color.Coral;
            isTrue = true;
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargarTabla()
        {
            dgv_Products.DataSource = new DAOProductos().ObtenerTodos();
            dgv_Products.Columns["id_Inventario"].HeaderText= "ID";
            dgv_Products.Columns["nombreCorto"].HeaderText = "Nombre";
            dgv_Products.Columns["descripcion"].HeaderText = "Descripción";
            dgv_Products.Columns["serie"].HeaderText = "Serie";
            dgv_Products.Columns["color"].HeaderText = "Color";
            dgv_Products.Columns["fechaAdquision"].HeaderText = "Fecha de adquisión";
            dgv_Products.Columns["tipoAdquision"].HeaderText = "Tipo de adquisión";
            dgv_Products.Columns["nombre"].HeaderText = "nombre";
            dgv_Products.Columns["observaciones"].HeaderText = "Observaciones";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_Products.SelectedRows.Count > 0)
            {
                //Guarda el indice donde se selecciona la columna
                int a = dgv_Products.CurrentRow.Index;
                //Muestra que columa se selecciono
                DialogResult dialogResult = MessageBox.Show("¿Segur@ que deseas modificar "+ dgv_Products.Rows[a].Cells[1].Value.ToString()+"?","", MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    this.Hide();
                    Frm_Inventario obj = new Frm_Inventario(isTrue);
                    //Va a llenar el formulario con los datos del id
                    obj.txt_Id.Enabled = true;
                    obj.txt_Id.Text = dgv_Products.Rows[a].Cells[0].Value.ToString();
                    obj.txt_Nombre.Text = dgv_Products.Rows[a].Cells[1].Value.ToString();
                    obj.txt_Descripcion.Text = dgv_Products.Rows[a].Cells[2].Value.ToString();
                    obj.txt_Serie.Text = dgv_Products.Rows[a].Cells[3].Value.ToString();
                    obj.txt_Color.Text = dgv_Products.Rows[a].Cells[4].Value.ToString();
                    obj.dateTimePicker1.Text = dgv_Products.Rows[a].Cells[5].Value.ToString();
                    obj.cbo_Area.Text = dgv_Products.Rows[a].Cells[6].Value.ToString();
                    obj.cbo_tipoAd.Text = dgv_Products.Rows[a].Cells[7].Value.ToString();
                    obj.txt_Observaciones.Text = dgv_Products.Rows[a].Cells[8].Value.ToString();
                    obj.iconButton4.Visible = true;
                    obj.iconButton4.Enabled = true;
                    obj.iconButton1.Enabled = false;
                    obj.iconButton1.Visible = false;
                    obj.Show();
                    //Guarde los datos
                    obj.txt_Id.Text=dgv_Products.Rows[a].Cells[0].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun producto para modificar");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Products.SelectedRows.Count > 0)
            {
                //Guarda el indice donde se selecciona la columna
                int a = dgv_Products.CurrentRow.Index;
                //Muestra que columa se selecciono
                DialogResult dialogResult = MessageBox.Show("¿Segur@ que deseas modificar " + dgv_Products.Rows[a].Cells[1].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DAOProductos obj = new DAOProductos();
                    obj.eliminar(Convert.ToInt32(dgv_Products.Rows[a].Cells[0].Value.ToString()));
                }
            }
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void iconButton3_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FrmMostrarAreas obj = new FrmMostrarAreas();
            obj.Show(); 
        }
    }
}
