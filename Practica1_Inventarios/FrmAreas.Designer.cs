namespace Practica1_Inventarios
{
    partial class FrmAreas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 72);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Areas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel4.Location = new System.Drawing.Point(35, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 70);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Nombre.Location = new System.Drawing.Point(201, 207);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(353, 39);
            this.txt_Nombre.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ubicación:";
            // 
            // txt_Ubicacion
            // 
            this.txt_Ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Ubicacion.Location = new System.Drawing.Point(203, 287);
            this.txt_Ubicacion.Name = "txt_Ubicacion";
            this.txt_Ubicacion.Size = new System.Drawing.Size(353, 39);
            this.txt_Ubicacion.TabIndex = 16;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(411, 407);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(157, 50);
            this.iconButton3.TabIndex = 28;
            this.iconButton3.Text = "Cancelar";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(164, 407);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(143, 50);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.Text = "Guardar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_id.Location = new System.Drawing.Point(201, 134);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(353, 39);
            this.txt_id.TabIndex = 30;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 50;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(180, 407);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 50);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmAreas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(687, 504);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txt_Ubicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAreas";
            this.Load += new System.EventHandler(this.FrmAreas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Ubicacion;
        private FontAwesome.Sharp.IconButton iconButton3;
        public FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_id;
        public FontAwesome.Sharp.IconButton btnModificar;
    }
}