namespace Tarea2_CarlosGarita
{
    partial class MostrarProductos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.rdbRegistradosTotales = new System.Windows.Forms.RadioButton();
            this.rdbRegistradosCategoria = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(575, 650);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 57);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(61, 265);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 40;
            this.dgvProductos.Size = new System.Drawing.Size(1244, 336);
            this.dgvProductos.TabIndex = 7;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(1109, 81);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(196, 57);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.lblCategoria);
            this.gbOpciones.Controls.Add(this.cbxCategoria);
            this.gbOpciones.Controls.Add(this.rdbRegistradosTotales);
            this.gbOpciones.Controls.Add(this.rdbRegistradosCategoria);
            this.gbOpciones.Location = new System.Drawing.Point(61, 32);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(1007, 209);
            this.gbOpciones.TabIndex = 9;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Seleccione la opción a mostrar:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Enabled = false;
            this.lblCategoria.Location = new System.Drawing.Point(660, 25);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(319, 32);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Seleccione la categoría:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(666, 70);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(310, 39);
            this.cbxCategoria.TabIndex = 10;
            this.cbxCategoria.DropDown += new System.EventHandler(this.cbxCategoria_DropDown);
            this.cbxCategoria.DropDownClosed += new System.EventHandler(this.cbxCategoria_DropDownClosed);
            // 
            // rdbRegistradosTotales
            // 
            this.rdbRegistradosTotales.AutoSize = true;
            this.rdbRegistradosTotales.Location = new System.Drawing.Point(89, 141);
            this.rdbRegistradosTotales.Name = "rdbRegistradosTotales";
            this.rdbRegistradosTotales.Size = new System.Drawing.Size(420, 36);
            this.rdbRegistradosTotales.TabIndex = 1;
            this.rdbRegistradosTotales.TabStop = true;
            this.rdbRegistradosTotales.Text = "Productos registrados totales";
            this.rdbRegistradosTotales.UseVisualStyleBackColor = true;
            // 
            // rdbRegistradosCategoria
            // 
            this.rdbRegistradosCategoria.AutoSize = true;
            this.rdbRegistradosCategoria.Location = new System.Drawing.Point(89, 70);
            this.rdbRegistradosCategoria.Name = "rdbRegistradosCategoria";
            this.rdbRegistradosCategoria.Size = new System.Drawing.Size(547, 36);
            this.rdbRegistradosCategoria.TabIndex = 0;
            this.rdbRegistradosCategoria.TabStop = true;
            this.rdbRegistradosCategoria.Text = "Productos registrados de una categoría";
            this.rdbRegistradosCategoria.UseVisualStyleBackColor = true;
            this.rdbRegistradosCategoria.CheckedChanged += new System.EventHandler(this.rdbRegistradosCategoria_CheckedChanged);
            // 
            // MostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 754);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MostrarProductos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Registrados";
            this.Load += new System.EventHandler(this.MostrarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.RadioButton rdbRegistradosTotales;
        private System.Windows.Forms.RadioButton rdbRegistradosCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}