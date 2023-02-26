namespace Practica1_Inventarios
{
    partial class FrmMostrarAreas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.btn_Modificar = new FontAwesome.Sharp.IconButton();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.dgv_Areas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.dgv_Areas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 619);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Agregar.IconColor = System.Drawing.Color.White;
            this.btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Agregar.IconSize = 70;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Agregar.Location = new System.Drawing.Point(147, 508);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(204, 67);
            this.btn_Agregar.TabIndex = 15;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_Modificar.IconColor = System.Drawing.Color.White;
            this.btn_Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Modificar.IconSize = 70;
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Modificar.Location = new System.Drawing.Point(397, 508);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(215, 67);
            this.btn_Modificar.TabIndex = 16;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Eliminar.IconColor = System.Drawing.Color.White;
            this.btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Eliminar.IconSize = 70;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Eliminar.Location = new System.Drawing.Point(655, 508);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(215, 67);
            this.btn_Eliminar.TabIndex = 17;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowsDownToPeople;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkOrange;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 159;
            this.iconPictureBox1.Location = new System.Drawing.Point(627, 8);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(228, 159);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            // 
            // dgv_Areas
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_Areas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Areas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Areas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Areas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Areas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Areas.Location = new System.Drawing.Point(37, 173);
            this.dgv_Areas.Name = "dgv_Areas";
            this.dgv_Areas.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgv_Areas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Areas.RowTemplate.Height = 28;
            this.dgv_Areas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Areas.Size = new System.Drawing.Size(949, 315);
            this.dgv_Areas.TabIndex = 13;
            this.dgv_Areas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Areas_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(48, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 72);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Areas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(51, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 70);
            this.panel4.TabIndex = 12;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 50;
            this.iconButton2.Location = new System.Drawing.Point(890, 8);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(96, 50);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // FrmMostrarAreas
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 625);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrarAreas";
            this.Load += new System.EventHandler(this.FrmMostrarAreas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Areas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dgv_Areas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton btn_Modificar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
    }
}