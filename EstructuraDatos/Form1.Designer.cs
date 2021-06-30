namespace EstructuraDatos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarAlInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarAlFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarAntesDeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarDespuesDeCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAntesDeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDespuesDeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaOrdenadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDesordenadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaRecursivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoIterativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoRecursivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecorridoRecursivo = new System.Windows.Forms.Button();
            this.btnBusqudaDesordenada = new System.Windows.Forms.Button();
            this.btnBusquedaRecursiva = new System.Windows.Forms.Button();
            this.btnEliminarDespuesX = new System.Windows.Forms.Button();
            this.btnEliminarAntesX = new System.Windows.Forms.Button();
            this.btnEliminarX = new System.Windows.Forms.Button();
            this.btnInsertarDespuesX = new System.Windows.Forms.Button();
            this.btnInsertarAntesX = new System.Windows.Forms.Button();
            this.btnBusquedaOrdenada = new System.Windows.Forms.Button();
            this.btnInsertarFinal = new System.Windows.Forms.Button();
            this.btnEliminarInicio = new System.Windows.Forms.Button();
            this.btnInsertarInicio = new System.Windows.Forms.Button();
            this.btnRecorridoIterativo = new System.Windows.Forms.Button();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbReferences = new System.Windows.Forms.GroupBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtReferences = new System.Windows.Forms.Label();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btnEliminarFInal = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.gpbReferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.busquedaToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarAlInicioToolStripMenuItem,
            this.insertarAlFinalToolStripMenuItem,
            this.insertarAntesDeXToolStripMenuItem,
            this.insertarDespuesDeCToolStripMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // insertarAlInicioToolStripMenuItem
            // 
            this.insertarAlInicioToolStripMenuItem.Name = "insertarAlInicioToolStripMenuItem";
            this.insertarAlInicioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.insertarAlInicioToolStripMenuItem.Text = "Insertar al Inicio";
            this.insertarAlInicioToolStripMenuItem.Click += new System.EventHandler(this.insertarAlInicioToolStripMenuItem_Click);
            // 
            // insertarAlFinalToolStripMenuItem
            // 
            this.insertarAlFinalToolStripMenuItem.Name = "insertarAlFinalToolStripMenuItem";
            this.insertarAlFinalToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.insertarAlFinalToolStripMenuItem.Text = "Insertar al final";
            this.insertarAlFinalToolStripMenuItem.Click += new System.EventHandler(this.insertarAlFinalToolStripMenuItem_Click_1);
            // 
            // insertarAntesDeXToolStripMenuItem
            // 
            this.insertarAntesDeXToolStripMenuItem.Name = "insertarAntesDeXToolStripMenuItem";
            this.insertarAntesDeXToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.insertarAntesDeXToolStripMenuItem.Text = "Insertar antes de X";
            this.insertarAntesDeXToolStripMenuItem.Click += new System.EventHandler(this.insertarAntesDeXToolStripMenuItem_Click_1);
            // 
            // insertarDespuesDeCToolStripMenuItem
            // 
            this.insertarDespuesDeCToolStripMenuItem.Name = "insertarDespuesDeCToolStripMenuItem";
            this.insertarDespuesDeCToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.insertarDespuesDeCToolStripMenuItem.Text = "Insertar Despues de x";
            this.insertarDespuesDeCToolStripMenuItem.Click += new System.EventHandler(this.insertarDespuesDeCToolStripMenuItem_Click_1);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarAlInicioToolStripMenuItem,
            this.eliminarAlFinalToolStripMenuItem,
            this.eliminarXToolStripMenuItem,
            this.eliminarAntesDeXToolStripMenuItem,
            this.eliminarDespuesDeXToolStripMenuItem});
            this.eliminarToolStripMenuItem.Enabled = false;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar ";
            // 
            // eliminarAlInicioToolStripMenuItem
            // 
            this.eliminarAlInicioToolStripMenuItem.Name = "eliminarAlInicioToolStripMenuItem";
            this.eliminarAlInicioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eliminarAlInicioToolStripMenuItem.Text = "Eliminar al Inicio";
            this.eliminarAlInicioToolStripMenuItem.Click += new System.EventHandler(this.eliminarAlInicioToolStripMenuItem_Click_1);
            // 
            // eliminarAlFinalToolStripMenuItem
            // 
            this.eliminarAlFinalToolStripMenuItem.Name = "eliminarAlFinalToolStripMenuItem";
            this.eliminarAlFinalToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eliminarAlFinalToolStripMenuItem.Text = "Eliminar al Final";
            this.eliminarAlFinalToolStripMenuItem.Click += new System.EventHandler(this.eliminarAlFinalToolStripMenuItem_Click_1);
            // 
            // eliminarXToolStripMenuItem
            // 
            this.eliminarXToolStripMenuItem.Name = "eliminarXToolStripMenuItem";
            this.eliminarXToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eliminarXToolStripMenuItem.Text = "Eliminar X";
            this.eliminarXToolStripMenuItem.Click += new System.EventHandler(this.eliminarXToolStripMenuItem_Click_1);
            // 
            // eliminarAntesDeXToolStripMenuItem
            // 
            this.eliminarAntesDeXToolStripMenuItem.Name = "eliminarAntesDeXToolStripMenuItem";
            this.eliminarAntesDeXToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eliminarAntesDeXToolStripMenuItem.Text = "Eliminar antes de X";
            this.eliminarAntesDeXToolStripMenuItem.Click += new System.EventHandler(this.eliminarAntesDeXToolStripMenuItem_Click_1);
            // 
            // eliminarDespuesDeXToolStripMenuItem
            // 
            this.eliminarDespuesDeXToolStripMenuItem.Name = "eliminarDespuesDeXToolStripMenuItem";
            this.eliminarDespuesDeXToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eliminarDespuesDeXToolStripMenuItem.Text = "Eliminar despues de X";
            this.eliminarDespuesDeXToolStripMenuItem.Click += new System.EventHandler(this.eliminarDespuesDeXToolStripMenuItem_Click_1);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaOrdenadaToolStripMenuItem,
            this.busquedaDesordenadaToolStripMenuItem,
            this.busquedaRecursivaToolStripMenuItem});
            this.busquedaToolStripMenuItem.Enabled = false;
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            // 
            // busquedaOrdenadaToolStripMenuItem
            // 
            this.busquedaOrdenadaToolStripMenuItem.Name = "busquedaOrdenadaToolStripMenuItem";
            this.busquedaOrdenadaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.busquedaOrdenadaToolStripMenuItem.Text = "Busqueda Ordenada";
            this.busquedaOrdenadaToolStripMenuItem.Click += new System.EventHandler(this.busquedaOrdenadaToolStripMenuItem_Click_1);
            // 
            // busquedaDesordenadaToolStripMenuItem
            // 
            this.busquedaDesordenadaToolStripMenuItem.Name = "busquedaDesordenadaToolStripMenuItem";
            this.busquedaDesordenadaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.busquedaDesordenadaToolStripMenuItem.Text = "Busqueda Desordenada";
            this.busquedaDesordenadaToolStripMenuItem.Click += new System.EventHandler(this.busquedaDesordenadaToolStripMenuItem_Click_1);
            // 
            // busquedaRecursivaToolStripMenuItem
            // 
            this.busquedaRecursivaToolStripMenuItem.Name = "busquedaRecursivaToolStripMenuItem";
            this.busquedaRecursivaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.busquedaRecursivaToolStripMenuItem.Text = "Busqueda Recursiva";
            this.busquedaRecursivaToolStripMenuItem.Click += new System.EventHandler(this.busquedaRecursivaToolStripMenuItem_Click_1);
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recorridoIterativoToolStripMenuItem,
            this.recorridoRecursivoToolStripMenuItem});
            this.recorridosToolStripMenuItem.Enabled = false;
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // recorridoIterativoToolStripMenuItem
            // 
            this.recorridoIterativoToolStripMenuItem.Name = "recorridoIterativoToolStripMenuItem";
            this.recorridoIterativoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.recorridoIterativoToolStripMenuItem.Text = "Recorrido Iterativo";
            this.recorridoIterativoToolStripMenuItem.Click += new System.EventHandler(this.recorridoIterativoToolStripMenuItem_Click_1);
            // 
            // recorridoRecursivoToolStripMenuItem
            // 
            this.recorridoRecursivoToolStripMenuItem.Name = "recorridoRecursivoToolStripMenuItem";
            this.recorridoRecursivoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.recorridoRecursivoToolStripMenuItem.Text = "Recorrido Recursivo";
            this.recorridoRecursivoToolStripMenuItem.Click += new System.EventHandler(this.recorridoRecursivoToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnRecorridoRecursivo
            // 
            this.btnRecorridoRecursivo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoRecursivo.Location = new System.Drawing.Point(446, 148);
            this.btnRecorridoRecursivo.Name = "btnRecorridoRecursivo";
            this.btnRecorridoRecursivo.Size = new System.Drawing.Size(173, 30);
            this.btnRecorridoRecursivo.TabIndex = 47;
            this.btnRecorridoRecursivo.Text = "RecorridoRecursivo\r\n";
            this.btnRecorridoRecursivo.UseVisualStyleBackColor = true;
            this.btnRecorridoRecursivo.Visible = false;
            this.btnRecorridoRecursivo.Click += new System.EventHandler(this.btnRecorridoRecursivo_Click);
            // 
            // btnBusqudaDesordenada
            // 
            this.btnBusqudaDesordenada.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqudaDesordenada.Location = new System.Drawing.Point(446, 148);
            this.btnBusqudaDesordenada.Name = "btnBusqudaDesordenada";
            this.btnBusqudaDesordenada.Size = new System.Drawing.Size(173, 31);
            this.btnBusqudaDesordenada.TabIndex = 46;
            this.btnBusqudaDesordenada.Text = "BusquedaDesordenada";
            this.btnBusqudaDesordenada.UseVisualStyleBackColor = true;
            this.btnBusqudaDesordenada.Visible = false;
            this.btnBusqudaDesordenada.Click += new System.EventHandler(this.btnBusqudaDesordenada_Click);
            // 
            // btnBusquedaRecursiva
            // 
            this.btnBusquedaRecursiva.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaRecursiva.Location = new System.Drawing.Point(459, 148);
            this.btnBusquedaRecursiva.Name = "btnBusquedaRecursiva";
            this.btnBusquedaRecursiva.Size = new System.Drawing.Size(160, 31);
            this.btnBusquedaRecursiva.TabIndex = 45;
            this.btnBusquedaRecursiva.Text = "BusquedaRecursiva";
            this.btnBusquedaRecursiva.UseVisualStyleBackColor = true;
            this.btnBusquedaRecursiva.Visible = false;
            this.btnBusquedaRecursiva.Click += new System.EventHandler(this.btnBusquedaRecursiva_Click);
            // 
            // btnEliminarDespuesX
            // 
            this.btnEliminarDespuesX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarDespuesX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDespuesX.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDespuesX.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarDespuesX.Location = new System.Drawing.Point(300, 152);
            this.btnEliminarDespuesX.Name = "btnEliminarDespuesX";
            this.btnEliminarDespuesX.Size = new System.Drawing.Size(148, 31);
            this.btnEliminarDespuesX.TabIndex = 44;
            this.btnEliminarDespuesX.Text = "EliminarDespuesX";
            this.btnEliminarDespuesX.UseVisualStyleBackColor = false;
            this.btnEliminarDespuesX.Visible = false;
            this.btnEliminarDespuesX.Click += new System.EventHandler(this.btnEliminarDespuesX_Click);
            // 
            // btnEliminarAntesX
            // 
            this.btnEliminarAntesX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarAntesX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAntesX.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAntesX.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarAntesX.Location = new System.Drawing.Point(300, 152);
            this.btnEliminarAntesX.Name = "btnEliminarAntesX";
            this.btnEliminarAntesX.Size = new System.Drawing.Size(129, 31);
            this.btnEliminarAntesX.TabIndex = 43;
            this.btnEliminarAntesX.Text = "EliminarAntesX";
            this.btnEliminarAntesX.UseVisualStyleBackColor = false;
            this.btnEliminarAntesX.Visible = false;
            this.btnEliminarAntesX.Click += new System.EventHandler(this.btnEliminarAntesX_Click);
            // 
            // btnEliminarX
            // 
            this.btnEliminarX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarX.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarX.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarX.Location = new System.Drawing.Point(300, 152);
            this.btnEliminarX.Name = "btnEliminarX";
            this.btnEliminarX.Size = new System.Drawing.Size(86, 31);
            this.btnEliminarX.TabIndex = 42;
            this.btnEliminarX.Text = "EliminarX";
            this.btnEliminarX.UseVisualStyleBackColor = false;
            this.btnEliminarX.Visible = false;
            this.btnEliminarX.Click += new System.EventHandler(this.btnEliminarX_Click);
            // 
            // btnInsertarDespuesX
            // 
            this.btnInsertarDespuesX.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarDespuesX.Location = new System.Drawing.Point(325, 188);
            this.btnInsertarDespuesX.Name = "btnInsertarDespuesX";
            this.btnInsertarDespuesX.Size = new System.Drawing.Size(148, 31);
            this.btnInsertarDespuesX.TabIndex = 41;
            this.btnInsertarDespuesX.Text = "InsertarDespuesX";
            this.btnInsertarDespuesX.UseVisualStyleBackColor = true;
            this.btnInsertarDespuesX.Visible = false;
            this.btnInsertarDespuesX.Click += new System.EventHandler(this.btnInsertarDespuesX_Click);
            // 
            // btnInsertarAntesX
            // 
            this.btnInsertarAntesX.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarAntesX.Location = new System.Drawing.Point(325, 188);
            this.btnInsertarAntesX.Name = "btnInsertarAntesX";
            this.btnInsertarAntesX.Size = new System.Drawing.Size(129, 31);
            this.btnInsertarAntesX.TabIndex = 40;
            this.btnInsertarAntesX.Text = "InsertarAntesX";
            this.btnInsertarAntesX.UseVisualStyleBackColor = true;
            this.btnInsertarAntesX.Visible = false;
            this.btnInsertarAntesX.Click += new System.EventHandler(this.btnInsertarAntesX_Click);
            // 
            // btnBusquedaOrdenada
            // 
            this.btnBusquedaOrdenada.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaOrdenada.Location = new System.Drawing.Point(454, 148);
            this.btnBusquedaOrdenada.Name = "btnBusquedaOrdenada";
            this.btnBusquedaOrdenada.Size = new System.Drawing.Size(164, 31);
            this.btnBusquedaOrdenada.TabIndex = 38;
            this.btnBusquedaOrdenada.Text = "Busqueda Ordenada";
            this.btnBusquedaOrdenada.UseVisualStyleBackColor = true;
            this.btnBusquedaOrdenada.Visible = false;
            this.btnBusquedaOrdenada.Click += new System.EventHandler(this.btnBusquedaOrdenada_Click);
            // 
            // btnInsertarFinal
            // 
            this.btnInsertarFinal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarFinal.Location = new System.Drawing.Point(325, 188);
            this.btnInsertarFinal.Name = "btnInsertarFinal";
            this.btnInsertarFinal.Size = new System.Drawing.Size(120, 31);
            this.btnInsertarFinal.TabIndex = 39;
            this.btnInsertarFinal.Text = "InsertarFinal";
            this.btnInsertarFinal.UseVisualStyleBackColor = true;
            this.btnInsertarFinal.Visible = false;
            this.btnInsertarFinal.Click += new System.EventHandler(this.btnInsertarFinal_Click_1);
            // 
            // btnEliminarInicio
            // 
            this.btnEliminarInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarInicio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInicio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarInicio.Location = new System.Drawing.Point(300, 152);
            this.btnEliminarInicio.Name = "btnEliminarInicio";
            this.btnEliminarInicio.Size = new System.Drawing.Size(115, 31);
            this.btnEliminarInicio.TabIndex = 37;
            this.btnEliminarInicio.Text = "EliminarInicio";
            this.btnEliminarInicio.UseVisualStyleBackColor = false;
            this.btnEliminarInicio.Visible = false;
            this.btnEliminarInicio.Click += new System.EventHandler(this.btnEliminarInicio_Click);
            // 
            // btnInsertarInicio
            // 
            this.btnInsertarInicio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarInicio.Location = new System.Drawing.Point(325, 189);
            this.btnInsertarInicio.Name = "btnInsertarInicio";
            this.btnInsertarInicio.Size = new System.Drawing.Size(120, 31);
            this.btnInsertarInicio.TabIndex = 35;
            this.btnInsertarInicio.Text = "InsertarInicio";
            this.btnInsertarInicio.UseVisualStyleBackColor = true;
            this.btnInsertarInicio.Click += new System.EventHandler(this.btnInsertarInicio_Click_1);
            // 
            // btnRecorridoIterativo
            // 
            this.btnRecorridoIterativo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoIterativo.Location = new System.Drawing.Point(455, 147);
            this.btnRecorridoIterativo.Name = "btnRecorridoIterativo";
            this.btnRecorridoIterativo.Size = new System.Drawing.Size(164, 31);
            this.btnRecorridoIterativo.TabIndex = 36;
            this.btnRecorridoIterativo.Text = "Recorrido Iterativo";
            this.btnRecorridoIterativo.UseVisualStyleBackColor = true;
            this.btnRecorridoIterativo.Visible = false;
            this.btnRecorridoIterativo.Click += new System.EventHandler(this.btnRecorridoIterativo_Click);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txtPrecio);
            this.gpbDatos.Controls.Add(this.label4);
            this.gpbDatos.Controls.Add(this.txtCantidad);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.txtNombreProducto);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.txtIdProducto);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Location = new System.Drawing.Point(12, 37);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(273, 206);
            this.gpbDatos.TabIndex = 32;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(154, 156);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(154, 115);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(154, 77);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Producto:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(154, 37);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 22);
            this.txtIdProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Producto:";
            // 
            // gpbReferences
            // 
            this.gpbReferences.Controls.Add(this.txtReferencia);
            this.gpbReferences.Controls.Add(this.txtReferences);
            this.gpbReferences.Location = new System.Drawing.Point(325, 37);
            this.gpbReferences.Name = "gpbReferences";
            this.gpbReferences.Size = new System.Drawing.Size(294, 105);
            this.gpbReferences.TabIndex = 34;
            this.gpbReferences.TabStop = false;
            this.gpbReferences.Visible = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(105, 39);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(100, 24);
            this.txtReferencia.TabIndex = 7;
            // 
            // txtReferences
            // 
            this.txtReferences.AutoSize = true;
            this.txtReferences.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferences.Location = new System.Drawing.Point(66, 16);
            this.txtReferences.Name = "txtReferences";
            this.txtReferences.Size = new System.Drawing.Size(176, 20);
            this.txtReferences.TabIndex = 6;
            this.txtReferences.Text = "Id Producto Referencia";
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(454, 147);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(164, 31);
            this.btnBusquedaAvanzada.TabIndex = 45;
            this.btnBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Visible = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // btnEliminarFInal
            // 
            this.btnEliminarFInal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarFInal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFInal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFInal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarFInal.Location = new System.Drawing.Point(325, 152);
            this.btnEliminarFInal.Name = "btnEliminarFInal";
            this.btnEliminarFInal.Size = new System.Drawing.Size(115, 31);
            this.btnEliminarFInal.TabIndex = 48;
            this.btnEliminarFInal.Text = "EliminarFinal";
            this.btnEliminarFInal.UseVisualStyleBackColor = false;
            this.btnEliminarFInal.Visible = false;
            this.btnEliminarFInal.Click += new System.EventHandler(this.btnEliminarFInal_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(105, 249);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(442, 196);
            this.dgv.TabIndex = 49;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdProducto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NombreProducto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 466);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnEliminarFInal);
            this.Controls.Add(this.btnRecorridoRecursivo);
            this.Controls.Add(this.btnBusquedaRecursiva);
            this.Controls.Add(this.btnBusqudaDesordenada);
            this.Controls.Add(this.btnEliminarDespuesX);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.btnEliminarAntesX);
            this.Controls.Add(this.btnEliminarX);
            this.Controls.Add(this.btnInsertarDespuesX);
            this.Controls.Add(this.btnInsertarAntesX);
            this.Controls.Add(this.btnBusquedaOrdenada);
            this.Controls.Add(this.btnInsertarFinal);
            this.Controls.Add(this.btnEliminarInicio);
            this.Controls.Add(this.btnInsertarInicio);
            this.Controls.Add(this.btnRecorridoIterativo);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.gpbReferences);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.gpbReferences.ResumeLayout(false);
            this.gpbReferences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarAlInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarAlFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarAntesDeXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarDespuesDeCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAntesDeXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDespuesDeXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaOrdenadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDesordenadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaRecursivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoIterativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoRecursivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.Button btnRecorridoRecursivo;
        public System.Windows.Forms.Button btnBusqudaDesordenada;
        public System.Windows.Forms.Button btnBusquedaRecursiva;
        public System.Windows.Forms.Button btnEliminarDespuesX;
        public System.Windows.Forms.Button btnEliminarAntesX;
        public System.Windows.Forms.Button btnEliminarX;
        public System.Windows.Forms.Button btnInsertarDespuesX;
        public System.Windows.Forms.Button btnInsertarAntesX;
        public System.Windows.Forms.Button btnBusquedaOrdenada;
        public System.Windows.Forms.Button btnInsertarFinal;
        public System.Windows.Forms.Button btnEliminarInicio;
        public System.Windows.Forms.Button btnInsertarInicio;
        public System.Windows.Forms.Button btnRecorridoIterativo;
        public System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gpbReferences;
        private System.Windows.Forms.Label txtReferences;
        private System.Windows.Forms.TextBox txtReferencia;
        public System.Windows.Forms.Button btnBusquedaAvanzada;
        public System.Windows.Forms.Button btnEliminarFInal;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

