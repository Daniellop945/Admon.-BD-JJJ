namespace Practica1_Inventarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btn_Agregar = new FontAwesome.Sharp.IconButton();
            this.btn_Modificar = new FontAwesome.Sharp.IconButton();
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.dgv_Products);
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 369);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgv_Products
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_Products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Products.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Products.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Products.Location = new System.Drawing.Point(0, 0);
            this.dgv_Products.Name = "dgv_Products";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Products.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Products.RowHeadersWidth = 62;
            this.dgv_Products.RowTemplate.Height = 28;
            this.dgv_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Products.Size = new System.Drawing.Size(980, 369);
            this.dgv_Products.TabIndex = 0;
            this.dgv_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Products_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 72);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario de productos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(33, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 70);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelPrincipal.Controls.Add(this.iconButton3);
            this.PanelPrincipal.Controls.Add(this.panel3);
            this.PanelPrincipal.Controls.Add(this.iconButton2);
            this.PanelPrincipal.Controls.Add(this.btn_Agregar);
            this.PanelPrincipal.Controls.Add(this.btn_Modificar);
            this.PanelPrincipal.Controls.Add(this.btn_Eliminar);
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Controls.Add(this.iconButton1);
            this.PanelPrincipal.Controls.Add(this.iconButton7);
            this.PanelPrincipal.Controls.Add(this.iconButton6);
            this.PanelPrincipal.Controls.Add(this.panel4);
            this.PanelPrincipal.Controls.Add(this.pictureBox1);
            this.PanelPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1017, 617);
            this.PanelPrincipal.TabIndex = 15;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 70;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton3.Location = new System.Drawing.Point(763, 523);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(229, 67);
            this.iconButton3.TabIndex = 15;
            this.iconButton3.Text = "Ver areas";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_2);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 50;
            this.iconButton2.Location = new System.Drawing.Point(913, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(96, 50);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
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
            this.btn_Agregar.Location = new System.Drawing.Point(13, 523);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(204, 67);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.iconButton3_Click);
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
            this.btn_Modificar.Location = new System.Drawing.Point(263, 523);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(215, 67);
            this.btn_Modificar.TabIndex = 11;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(521, 523);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(215, 67);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(816, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(94, 50);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconButton7.IconColor = System.Drawing.Color.Yellow;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton7.Location = new System.Drawing.Point(916, 65);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(61, 58);
            this.iconButton7.TabIndex = 14;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.iconButton6.IconColor = System.Drawing.SystemColors.Window;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton6.Location = new System.Drawing.Point(854, 65);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(61, 58);
            this.iconButton6.TabIndex = 13;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica1_Inventarios.Properties.Resources.forklift_lifting_load_PA_4355;
            this.pictureBox1.Location = new System.Drawing.Point(579, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.O;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(92, -44);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(70, 44);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 617);
            this.ControlBox = false;
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_Modificar;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.DataGridView dgv_Products;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}

