namespace ConcecionariaConADOdesconectado
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
            this.dgvAutosDisponibles = new System.Windows.Forms.DataGridView();
            this.btbConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAutosVendidos = new System.Windows.Forms.DataGridView();
            this.btbDesconectar = new System.Windows.Forms.Button();
            this.btbAñadirAutomovil = new System.Windows.Forms.Button();
            this.btbAñadirCliente = new System.Windows.Forms.Button();
            this.btbVenderAuto = new System.Windows.Forms.Button();
            this.lblEstadoDeConexion = new System.Windows.Forms.Label();
            this.dgvHistorialCompletos = new System.Windows.Forms.DataGridView();
            this.btbCompletoHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompletos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutosDisponibles
            // 
            this.dgvAutosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosDisponibles.Location = new System.Drawing.Point(12, 29);
            this.dgvAutosDisponibles.Name = "dgvAutosDisponibles";
            this.dgvAutosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutosDisponibles.Size = new System.Drawing.Size(368, 279);
            this.dgvAutosDisponibles.TabIndex = 0;
            // 
            // btbConectar
            // 
            this.btbConectar.Location = new System.Drawing.Point(1006, 547);
            this.btbConectar.Name = "btbConectar";
            this.btbConectar.Size = new System.Drawing.Size(174, 84);
            this.btbConectar.TabIndex = 1;
            this.btbConectar.Text = "Conectar";
            this.btbConectar.UseVisualStyleBackColor = true;
            this.btbConectar.Click += new System.EventHandler(this.btbConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Automoviles a la venta";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 352);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(368, 279);
            this.dgvClientes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de Autos vendidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de Clientes registrados";
            // 
            // dgvAutosVendidos
            // 
            this.dgvAutosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosVendidos.Location = new System.Drawing.Point(423, 352);
            this.dgvAutosVendidos.Name = "dgvAutosVendidos";
            this.dgvAutosVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutosVendidos.Size = new System.Drawing.Size(368, 279);
            this.dgvAutosVendidos.TabIndex = 6;
            // 
            // btbDesconectar
            // 
            this.btbDesconectar.Location = new System.Drawing.Point(815, 547);
            this.btbDesconectar.Name = "btbDesconectar";
            this.btbDesconectar.Size = new System.Drawing.Size(174, 84);
            this.btbDesconectar.TabIndex = 7;
            this.btbDesconectar.Text = "Desconectar";
            this.btbDesconectar.UseVisualStyleBackColor = true;
            this.btbDesconectar.Click += new System.EventHandler(this.btbDesconectar_Click);
            // 
            // btbAñadirAutomovil
            // 
            this.btbAñadirAutomovil.Location = new System.Drawing.Point(423, 29);
            this.btbAñadirAutomovil.Name = "btbAñadirAutomovil";
            this.btbAñadirAutomovil.Size = new System.Drawing.Size(174, 101);
            this.btbAñadirAutomovil.TabIndex = 8;
            this.btbAñadirAutomovil.Text = "Añadir Automovil";
            this.btbAñadirAutomovil.UseVisualStyleBackColor = true;
            this.btbAñadirAutomovil.Click += new System.EventHandler(this.btbAñadirAutomovil_Click);
            // 
            // btbAñadirCliente
            // 
            this.btbAñadirCliente.Location = new System.Drawing.Point(617, 29);
            this.btbAñadirCliente.Name = "btbAñadirCliente";
            this.btbAñadirCliente.Size = new System.Drawing.Size(174, 101);
            this.btbAñadirCliente.TabIndex = 9;
            this.btbAñadirCliente.Text = "Registrar Cliente";
            this.btbAñadirCliente.UseVisualStyleBackColor = true;
            this.btbAñadirCliente.Click += new System.EventHandler(this.btbAñadirCliente_Click);
            // 
            // btbVenderAuto
            // 
            this.btbVenderAuto.Location = new System.Drawing.Point(423, 166);
            this.btbVenderAuto.Name = "btbVenderAuto";
            this.btbVenderAuto.Size = new System.Drawing.Size(368, 101);
            this.btbVenderAuto.TabIndex = 10;
            this.btbVenderAuto.Text = "Vender Auto";
            this.btbVenderAuto.UseVisualStyleBackColor = true;
            this.btbVenderAuto.Click += new System.EventHandler(this.btbVenderAuto_Click);
            // 
            // lblEstadoDeConexion
            // 
            this.lblEstadoDeConexion.AutoSize = true;
            this.lblEstadoDeConexion.Location = new System.Drawing.Point(930, 518);
            this.lblEstadoDeConexion.Name = "lblEstadoDeConexion";
            this.lblEstadoDeConexion.Size = new System.Drawing.Size(138, 13);
            this.lblEstadoDeConexion.TabIndex = 11;
            this.lblEstadoDeConexion.Text = "Estado de conexion = False";
            // 
            // dgvHistorialCompletos
            // 
            this.dgvHistorialCompletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCompletos.Location = new System.Drawing.Point(815, 136);
            this.dgvHistorialCompletos.Name = "dgvHistorialCompletos";
            this.dgvHistorialCompletos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialCompletos.Size = new System.Drawing.Size(368, 358);
            this.dgvHistorialCompletos.TabIndex = 12;
            // 
            // btbCompletoHistorial
            // 
            this.btbCompletoHistorial.Location = new System.Drawing.Point(815, 29);
            this.btbCompletoHistorial.Name = "btbCompletoHistorial";
            this.btbCompletoHistorial.Size = new System.Drawing.Size(365, 101);
            this.btbCompletoHistorial.TabIndex = 13;
            this.btbCompletoHistorial.Text = "Ver Hitorial De Autos Completos";
            this.btbCompletoHistorial.UseVisualStyleBackColor = true;
            this.btbCompletoHistorial.Click += new System.EventHandler(this.btbCompletoHistorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 660);
            this.Controls.Add(this.btbCompletoHistorial);
            this.Controls.Add(this.dgvHistorialCompletos);
            this.Controls.Add(this.lblEstadoDeConexion);
            this.Controls.Add(this.btbVenderAuto);
            this.Controls.Add(this.btbAñadirCliente);
            this.Controls.Add(this.btbAñadirAutomovil);
            this.Controls.Add(this.btbDesconectar);
            this.Controls.Add(this.dgvAutosVendidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbConectar);
            this.Controls.Add(this.dgvAutosDisponibles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutosDisponibles;
        private System.Windows.Forms.Button btbConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAutosVendidos;
        private System.Windows.Forms.Button btbDesconectar;
        private System.Windows.Forms.Button btbAñadirAutomovil;
        private System.Windows.Forms.Button btbAñadirCliente;
        private System.Windows.Forms.Button btbVenderAuto;
        private System.Windows.Forms.Label lblEstadoDeConexion;
        private System.Windows.Forms.DataGridView dgvHistorialCompletos;
        private System.Windows.Forms.Button btbCompletoHistorial;
    }
}

