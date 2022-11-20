
namespace FormulariosMallaCurricular
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsdOperaciones = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmFacultad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdOperaciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsdOperaciones
            // 
            this.tsdOperaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsdOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFacultad});
            this.tsdOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("tsdOperaciones.Image")));
            this.tsdOperaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdOperaciones.Name = "tsdOperaciones";
            this.tsdOperaciones.Size = new System.Drawing.Size(29, 22);
            this.tsdOperaciones.Text = "toolStripDropDownButton1";
            // 
            // tsmFacultad
            // 
            this.tsmFacultad.Name = "tsmFacultad";
            this.tsmFacultad.Size = new System.Drawing.Size(180, 22);
            this.tsmFacultad.Text = "Facultad";
            this.tsmFacultad.Click += new System.EventHandler(this.tsmFacultad_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsdOperaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmFacultad;
    }
}