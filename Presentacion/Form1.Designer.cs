namespace Presentacion
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
            this.dataGWProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGWProductos
            // 
            this.dataGWProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWProductos.Location = new System.Drawing.Point(12, 37);
            this.dataGWProductos.Name = "dataGWProductos";
            this.dataGWProductos.Size = new System.Drawing.Size(776, 290);
            this.dataGWProductos.TabIndex = 0;
            this.dataGWProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGWProductos_CellContentClick);
            this.dataGWProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGWProductos_CellContentDoubleClick);
            this.dataGWProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGWProductos_CellEndEdit);
            this.dataGWProductos.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGWProductos_CellStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 355);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGWProductos);
            this.MaximumSize = new System.Drawing.Size(816, 434);
            this.MinimumSize = new System.Drawing.Size(816, 434);
            this.Name = "Form1";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGWProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGWProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}

