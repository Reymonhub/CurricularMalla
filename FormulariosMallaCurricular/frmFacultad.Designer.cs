
namespace FormulariosMallaCurricular
{
    partial class frmFacultad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacultad));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.s = new System.Windows.Forms.GroupBox();
            this.txtFacultad = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblFacultad = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvFacultad = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxBuscarFacultad = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFacuBuscar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultad)).BeginInit();
            this.gbxBuscarFacultad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(655, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Snow;
            this.s.Controls.Add(this.txtFacultad);
            this.s.Controls.Add(this.txtId);
            this.s.Controls.Add(this.lblFacultad);
            this.s.Controls.Add(this.lblId);
            this.s.Location = new System.Drawing.Point(362, 137);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(281, 166);
            this.s.TabIndex = 1;
            this.s.TabStop = false;
            this.s.Text = "Datos Facultad";
            // 
            // txtFacultad
            // 
            this.txtFacultad.Enabled = false;
            this.txtFacultad.Location = new System.Drawing.Point(61, 52);
            this.txtFacultad.Multiline = true;
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(214, 95);
            this.txtFacultad.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(30, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 2;
            // 
            // lblFacultad
            // 
            this.lblFacultad.AutoSize = true;
            this.lblFacultad.Location = new System.Drawing.Point(4, 55);
            this.lblFacultad.Name = "lblFacultad";
            this.lblFacultad.Size = new System.Drawing.Size(51, 13);
            this.lblFacultad.TabIndex = 1;
            this.lblFacultad.Text = "Facultad:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // dgvFacultad
            // 
            this.dgvFacultad.AllowUserToAddRows = false;
            this.dgvFacultad.AllowUserToDeleteRows = false;
            this.dgvFacultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultad.Location = new System.Drawing.Point(12, 126);
            this.dgvFacultad.Name = "dgvFacultad";
            this.dgvFacultad.ReadOnly = true;
            this.dgvFacultad.Size = new System.Drawing.Size(331, 219);
            this.dgvFacultad.TabIndex = 2;
            this.dgvFacultad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacultad_CellClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(411, 309);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(100, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(181, 351);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(19, 351);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxBuscarFacultad
            // 
            this.gbxBuscarFacultad.BackColor = System.Drawing.Color.Snow;
            this.gbxBuscarFacultad.Controls.Add(this.btnBuscar);
            this.gbxBuscarFacultad.Controls.Add(this.txtBuscar);
            this.gbxBuscarFacultad.Controls.Add(this.lblFacuBuscar);
            this.gbxBuscarFacultad.Location = new System.Drawing.Point(13, 39);
            this.gbxBuscarFacultad.Name = "gbxBuscarFacultad";
            this.gbxBuscarFacultad.Size = new System.Drawing.Size(630, 69);
            this.gbxBuscarFacultad.TabIndex = 7;
            this.gbxBuscarFacultad.TabStop = false;
            this.gbxBuscarFacultad.Text = "Buscar Facultad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(527, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(63, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(441, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblFacuBuscar
            // 
            this.lblFacuBuscar.AutoSize = true;
            this.lblFacuBuscar.Location = new System.Drawing.Point(6, 29);
            this.lblFacuBuscar.Name = "lblFacuBuscar";
            this.lblFacuBuscar.Size = new System.Drawing.Size(51, 13);
            this.lblFacuBuscar.TabIndex = 0;
            this.lblFacuBuscar.Text = "Facultad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(516, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Enabled = false;
            this.btnListar.Location = new System.Drawing.Point(262, 351);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(655, 415);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxBuscarFacultad);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvFacultad);
            this.Controls.Add(this.s);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacultad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facultad";
            this.Load += new System.EventHandler(this.frmFacultad_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultad)).EndInit();
            this.gbxBuscarFacultad.ResumeLayout(false);
            this.gbxBuscarFacultad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox s;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFacultad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.DataGridView dgvFacultad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxBuscarFacultad;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFacuBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListar;
    }
}