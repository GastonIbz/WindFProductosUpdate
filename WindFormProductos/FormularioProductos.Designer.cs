
namespace WindFormProductos
{
    partial class FormularioProductos
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
            this.tabC_Productos = new System.Windows.Forms.TabControl();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabP_Movimiento = new System.Windows.Forms.TabPage();
            this.rb_Egreso = new System.Windows.Forms.RadioButton();
            this.rb_Ingreso = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblStockmov = new System.Windows.Forms.Label();
            this.txb_Movim = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripMov = new System.Windows.Forms.Label();
            this.lblCodigoMov = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.tabC_Productos.SuspendLayout();
            this.SelectTab.SuspendLayout();
            this.tabP_Movimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabC_Productos
            // 
            this.tabC_Productos.Controls.Add(this.SelectTab);
            this.tabC_Productos.Controls.Add(this.tabP_Movimiento);
            this.tabC_Productos.Location = new System.Drawing.Point(151, 35);
            this.tabC_Productos.Name = "tabC_Productos";
            this.tabC_Productos.SelectedIndex = 0;
            this.tabC_Productos.Size = new System.Drawing.Size(653, 277);
            this.tabC_Productos.TabIndex = 0;
            this.tabC_Productos.SelectedIndexChanged += new System.EventHandler(this.tabC_Productos_SelectedIndexChanged);
            // 
            // SelectTab
            // 
            this.SelectTab.Controls.Add(this.btnCargar);
            this.SelectTab.Controls.Add(this.txtStock);
            this.SelectTab.Controls.Add(this.txtDescripcion);
            this.SelectTab.Controls.Add(this.txtCodigo);
            this.SelectTab.Controls.Add(this.lblStock);
            this.SelectTab.Controls.Add(this.lblDescripcion);
            this.SelectTab.Controls.Add(this.lblCodigo);
            this.SelectTab.Location = new System.Drawing.Point(4, 22);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTab.Size = new System.Drawing.Size(645, 251);
            this.SelectTab.TabIndex = 0;
            this.SelectTab.Text = "Carga de Productos";
            this.SelectTab.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(548, 200);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(258, 146);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(278, 20);
            this.txtStock.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(258, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(278, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(258, 59);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(278, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(197, 146);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(55, 19);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(156, 102);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 19);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(188, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código :";
            // 
            // tabP_Movimiento
            // 
            this.tabP_Movimiento.Controls.Add(this.rb_Egreso);
            this.tabP_Movimiento.Controls.Add(this.rb_Ingreso);
            this.tabP_Movimiento.Controls.Add(this.btnAceptar);
            this.tabP_Movimiento.Controls.Add(this.lblStockmov);
            this.tabP_Movimiento.Controls.Add(this.txb_Movim);
            this.tabP_Movimiento.Controls.Add(this.lblCantidad);
            this.tabP_Movimiento.Controls.Add(this.lblDescripMov);
            this.tabP_Movimiento.Controls.Add(this.lblCodigoMov);
            this.tabP_Movimiento.Location = new System.Drawing.Point(4, 22);
            this.tabP_Movimiento.Name = "tabP_Movimiento";
            this.tabP_Movimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Movimiento.Size = new System.Drawing.Size(645, 251);
            this.tabP_Movimiento.TabIndex = 1;
            this.tabP_Movimiento.Text = "Movimiento de Productos";
            this.tabP_Movimiento.UseVisualStyleBackColor = true;
            // 
            // rb_Egreso
            // 
            this.rb_Egreso.AutoSize = true;
            this.rb_Egreso.Location = new System.Drawing.Point(436, 169);
            this.rb_Egreso.Name = "rb_Egreso";
            this.rb_Egreso.Size = new System.Drawing.Size(58, 17);
            this.rb_Egreso.TabIndex = 7;
            this.rb_Egreso.TabStop = true;
            this.rb_Egreso.Text = "Egreso";
            this.rb_Egreso.UseVisualStyleBackColor = true;
            // 
            // rb_Ingreso
            // 
            this.rb_Ingreso.AutoSize = true;
            this.rb_Ingreso.Location = new System.Drawing.Point(436, 125);
            this.rb_Ingreso.Name = "rb_Ingreso";
            this.rb_Ingreso.Size = new System.Drawing.Size(60, 17);
            this.rb_Ingreso.TabIndex = 6;
            this.rb_Ingreso.TabStop = true;
            this.rb_Ingreso.Text = "Ingreso";
            this.rb_Ingreso.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(531, 101);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblStockmov
            // 
            this.lblStockmov.AutoSize = true;
            this.lblStockmov.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockmov.Location = new System.Drawing.Point(77, 101);
            this.lblStockmov.Name = "lblStockmov";
            this.lblStockmov.Size = new System.Drawing.Size(14, 19);
            this.lblStockmov.TabIndex = 4;
            this.lblStockmov.Text = "-";
            // 
            // txb_Movim
            // 
            this.txb_Movim.Location = new System.Drawing.Point(160, 126);
            this.txb_Movim.Name = "txb_Movim";
            this.txb_Movim.Size = new System.Drawing.Size(100, 20);
            this.txb_Movim.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(77, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 19);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad :";
            // 
            // lblDescripMov
            // 
            this.lblDescripMov.AutoSize = true;
            this.lblDescripMov.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripMov.Location = new System.Drawing.Point(77, 77);
            this.lblDescripMov.Name = "lblDescripMov";
            this.lblDescripMov.Size = new System.Drawing.Size(14, 19);
            this.lblDescripMov.TabIndex = 1;
            this.lblDescripMov.Text = "-";
            // 
            // lblCodigoMov
            // 
            this.lblCodigoMov.AutoSize = true;
            this.lblCodigoMov.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMov.Location = new System.Drawing.Point(77, 49);
            this.lblCodigoMov.Name = "lblCodigoMov";
            this.lblCodigoMov.Size = new System.Drawing.Size(14, 19);
            this.lblCodigoMov.TabIndex = 0;
            this.lblCodigoMov.Text = "-";
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Location = new System.Drawing.Point(151, 329);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.Size = new System.Drawing.Size(653, 252);
            this.dgv_Productos.TabIndex = 0;
            this.dgv_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellClick);
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(936, 611);
            this.Controls.Add(this.dgv_Productos);
            this.Controls.Add(this.tabC_Productos);
            this.Name = "FormularioProductos";
            this.Text = "FormularioProductos";
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            this.tabC_Productos.ResumeLayout(false);
            this.SelectTab.ResumeLayout(false);
            this.SelectTab.PerformLayout();
            this.tabP_Movimiento.ResumeLayout(false);
            this.tabP_Movimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabP_Movimiento;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.TextBox txb_Movim;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripMov;
        private System.Windows.Forms.Label lblCodigoMov;
        private System.Windows.Forms.Label lblStockmov;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rb_Egreso;
        private System.Windows.Forms.RadioButton rb_Ingreso;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabControl tabC_Productos;
    }
}