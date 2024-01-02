namespace Tarea2_CarlosGarita
{
    partial class MenuPrincipal
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
            System.Windows.Forms.MenuStrip Menu;
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCajeros = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mitProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCajerosRegistrados = new System.Windows.Forms.ToolStripMenuItem();
            this.mitCategoriasRegistradas = new System.Windows.Forms.ToolStripMenuItem();
            this.mitProductosRegistrados = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Menu = new System.Windows.Forms.MenuStrip();
            Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new System.Drawing.Size(40, 40);
            Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.mostrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            Menu.Location = new System.Drawing.Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new System.Drawing.Size(1617, 49);
            Menu.TabIndex = 1;
            Menu.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitCajeros,
            this.mitCategorias,
            this.mitProductos});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(146, 45);
            this.registroToolStripMenuItem.Text = "Registrar";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // mitCajeros
            // 
            this.mitCajeros.Name = "mitCajeros";
            this.mitCajeros.Size = new System.Drawing.Size(273, 46);
            this.mitCajeros.Text = "Cajeros";
            this.mitCajeros.Click += new System.EventHandler(this.cajerosToolStripMenuItem_Click);
            // 
            // mitCategorias
            // 
            this.mitCategorias.Name = "mitCategorias";
            this.mitCategorias.Size = new System.Drawing.Size(273, 46);
            this.mitCategorias.Text = "Categorías";
            this.mitCategorias.Click += new System.EventHandler(this.mitCategorias_Click);
            // 
            // mitProductos
            // 
            this.mitProductos.Name = "mitProductos";
            this.mitProductos.Size = new System.Drawing.Size(273, 46);
            this.mitProductos.Text = "Productos";
            this.mitProductos.Click += new System.EventHandler(this.mitProductos_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitCajerosRegistrados,
            this.mitCategoriasRegistradas,
            this.mitProductosRegistrados});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(133, 45);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // mitCajerosRegistrados
            // 
            this.mitCajerosRegistrados.Name = "mitCajerosRegistrados";
            this.mitCajerosRegistrados.Size = new System.Drawing.Size(426, 46);
            this.mitCajerosRegistrados.Text = "Cajeros registrados";
            this.mitCajerosRegistrados.Click += new System.EventHandler(this.mitCajerosRegistrados_Click);
            // 
            // mitCategoriasRegistradas
            // 
            this.mitCategoriasRegistradas.Name = "mitCategoriasRegistradas";
            this.mitCategoriasRegistradas.Size = new System.Drawing.Size(426, 46);
            this.mitCategoriasRegistradas.Text = "Categorías registradas";
            this.mitCategoriasRegistradas.Click += new System.EventHandler(this.mitCategoriasRegistradas_Click);
            // 
            // mitProductosRegistrados
            // 
            this.mitProductosRegistrados.Name = "mitProductosRegistrados";
            this.mitProductosRegistrados.Size = new System.Drawing.Size(426, 46);
            this.mitProductosRegistrados.Text = "Productos registrados";
            this.mitProductosRegistrados.Click += new System.EventHandler(this.mitProductosRegistrados_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(85, 45);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 1002);
            this.Controls.Add(Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = Menu;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal \"Supermercado El Buen Precio\"";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitCajeros;
        private System.Windows.Forms.ToolStripMenuItem mitCategorias;
        private System.Windows.Forms.ToolStripMenuItem mitProductos;
        private System.Windows.Forms.ToolStripMenuItem mitCajerosRegistrados;
        private System.Windows.Forms.ToolStripMenuItem mitCategoriasRegistradas;
        private System.Windows.Forms.ToolStripMenuItem mitProductosRegistrados;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

