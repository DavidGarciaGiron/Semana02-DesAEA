namespace CasoPropuesto1
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
            this.components = new System.ComponentModel.Container();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.DgListado = new System.Windows.Forms.DataGridView();
            this.LblNCantidad = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(199, 6);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(329, 21);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Pedidos Registrados en la Base NegociosWeb ";
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltro.Location = new System.Drawing.Point(80, 33);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(138, 16);
            this.LblFiltro.TabIndex = 1;
            this.LblFiltro.Text = "Nombres y Apellidos: ";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(224, 31);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(362, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // DgListado
            // 
            this.DgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListado.Location = new System.Drawing.Point(98, 57);
            this.DgListado.Name = "DgListado";
            this.DgListado.Size = new System.Drawing.Size(561, 150);
            this.DgListado.TabIndex = 3;
            // 
            // LblNCantidad
            // 
            this.LblNCantidad.AutoSize = true;
            this.LblNCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNCantidad.Location = new System.Drawing.Point(541, 225);
            this.LblNCantidad.Name = "LblNCantidad";
            this.LblNCantidad.Size = new System.Drawing.Size(75, 16);
            this.LblNCantidad.TabIndex = 4;
            this.LblNCantidad.Text = "Cantidad : ";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(622, 225);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(22, 16);
            this.LblCantidad.TabIndex = 5;
            this.LblCantidad.Text = "[ ]";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(592, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 247);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblNCantidad);
            this.Controls.Add(this.DgListado);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView DgListado;
        private System.Windows.Forms.Label LblNCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnBuscar;
    }
}

