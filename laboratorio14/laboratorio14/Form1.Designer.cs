namespace laboratorio14
{
    partial class FrmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tsbNuevo = new Button();
            tsbGuardar = new Button();
            tsbCancelar = new Button();
            tsbEliminar = new Button();
            label1 = new Label();
            tstId = new TextBox();
            tsbBuscar = new Button();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // tsbNuevo
            // 
            tsbNuevo.BackColor = SystemColors.ButtonHighlight;
            tsbNuevo.BackgroundImage = Properties.Resources.nuevo;
            tsbNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            tsbNuevo.Location = new Point(12, 12);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(27, 27);
            tsbNuevo.TabIndex = 0;
            tsbNuevo.UseVisualStyleBackColor = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.BackgroundImage = Properties.Resources.guardar;
            tsbGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbGuardar.Location = new Point(45, 12);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Size = new Size(27, 27);
            tsbGuardar.TabIndex = 1;
            tsbGuardar.UseVisualStyleBackColor = true;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.BackgroundImage = Properties.Resources.eliminar;
            tsbCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbCancelar.Location = new Point(78, 12);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(27, 27);
            tsbCancelar.TabIndex = 2;
            tsbCancelar.UseVisualStyleBackColor = true;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.BackgroundImage = Properties.Resources.cancelar;
            tsbEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbEliminar.Location = new Point(111, 12);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(27, 27);
            tsbEliminar.TabIndex = 3;
            tsbEliminar.UseVisualStyleBackColor = true;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 18);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 4;
            label1.Text = "Buscar por ID:";
            // 
            // tstId
            // 
            tstId.Location = new Point(253, 15);
            tstId.Name = "tstId";
            tstId.Size = new Size(164, 23);
            tstId.TabIndex = 5;
            // 
            // tsbBuscar
            // 
            tsbBuscar.BackgroundImage = Properties.Resources.buscar1;
            tsbBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            tsbBuscar.Location = new Point(423, 11);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(27, 27);
            tsbBuscar.TabIndex = 6;
            tsbBuscar.UseVisualStyleBackColor = true;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 96);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(34, 124);
            txtId.Name = "txtId";
            txtId.Size = new Size(148, 23);
            txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(226, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 23);
            txtNombre.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 96);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 214);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 11;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 214);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(34, 243);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(148, 23);
            txtPrecio.TabIndex = 13;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(226, 243);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(163, 23);
            txtStock.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(34, 322);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 49);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(tsbBuscar);
            Controls.Add(tstId);
            Controls.Add(label1);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbNuevo);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tsbNuevo;
        private Button tsbGuardar;
        private Button tsbCancelar;
        private Button tsbEliminar;
        private Label label1;
        private TextBox tstId;
        private Button tsbBuscar;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnSalir;
    }
}
