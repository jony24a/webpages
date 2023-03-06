namespace Proyecto_Final
{
    partial class Pago
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
            this.TxtFecPed = new System.Windows.Forms.TextBox();
            this.TxtFecEsp = new System.Windows.Forms.TextBox();
            this.TxtFecEnt = new System.Windows.Forms.TextBox();
            this.TxtCom = new System.Windows.Forms.TextBox();
            this.TxtCli = new System.Windows.Forms.TextBox();
            this.TxtCodPed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnPago = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.cliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEst = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFecPed
            // 
            this.TxtFecPed.Location = new System.Drawing.Point(521, 443);
            this.TxtFecPed.Name = "TxtFecPed";
            this.TxtFecPed.Size = new System.Drawing.Size(257, 20);
            this.TxtFecPed.TabIndex = 69;
            // 
            // TxtFecEsp
            // 
            this.TxtFecEsp.Location = new System.Drawing.Point(520, 473);
            this.TxtFecEsp.Name = "TxtFecEsp";
            this.TxtFecEsp.Size = new System.Drawing.Size(257, 20);
            this.TxtFecEsp.TabIndex = 68;
            // 
            // TxtFecEnt
            // 
            this.TxtFecEnt.Location = new System.Drawing.Point(520, 502);
            this.TxtFecEnt.Name = "TxtFecEnt";
            this.TxtFecEnt.Size = new System.Drawing.Size(257, 20);
            this.TxtFecEnt.TabIndex = 67;
            // 
            // TxtCom
            // 
            this.TxtCom.Location = new System.Drawing.Point(520, 559);
            this.TxtCom.Name = "TxtCom";
            this.TxtCom.Size = new System.Drawing.Size(257, 20);
            this.TxtCom.TabIndex = 65;
            // 
            // TxtCli
            // 
            this.TxtCli.Location = new System.Drawing.Point(521, 589);
            this.TxtCli.Name = "TxtCli";
            this.TxtCli.Size = new System.Drawing.Size(257, 20);
            this.TxtCli.TabIndex = 64;
            // 
            // TxtCodPed
            // 
            this.TxtCodPed.Location = new System.Drawing.Point(521, 414);
            this.TxtCodPed.Name = "TxtCodPed";
            this.TxtCodPed.Size = new System.Drawing.Size(257, 20);
            this.TxtCodPed.TabIndex = 62;
            this.TxtCodPed.TextChanged += new System.EventHandler(this.TxtCodCli_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Codigo Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Comentarios:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha Entregada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fecha Esperada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fecha Pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Codigo Pedido:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(204, 551);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(168, 54);
            this.BtnSalir.TabIndex = 47;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(204, 414);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(168, 54);
            this.BtnMostrar.TabIndex = 46;
            this.BtnMostrar.Text = "Mostrar Datos";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(204, 480);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(168, 54);
            this.BtnInsertar.TabIndex = 45;
            this.BtnInsertar.Text = "Insertar Datos";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(14, 480);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(168, 54);
            this.BtnModificar.TabIndex = 44;
            this.BtnModificar.Text = "Modificar Datos";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(14, 551);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(168, 54);
            this.BtnCerrar.TabIndex = 43;
            this.BtnCerrar.Text = "Borrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConexion
            // 
            this.BtnConexion.Location = new System.Drawing.Point(14, 414);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(168, 54);
            this.BtnConexion.TabIndex = 42;
            this.BtnConexion.Text = "Conectar Tabla";
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.BtnConexion_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(628, 12);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(168, 54);
            this.BtnCliente.TabIndex = 41;
            this.BtnCliente.Text = "CLIENTE";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnPago
            // 
            this.BtnPago.Location = new System.Drawing.Point(14, 16);
            this.BtnPago.Name = "BtnPago";
            this.BtnPago.Size = new System.Drawing.Size(168, 54);
            this.BtnPago.TabIndex = 40;
            this.BtnPago.Text = "PAGO";
            this.BtnPago.UseVisualStyleBackColor = true;
            this.BtnPago.Click += new System.EventHandler(this.BtnPago_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(14, 91);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(782, 298);
            this.DGV.TabIndex = 39;
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(327, 15);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(180, 55);
            this.cliente.TabIndex = 38;
            this.cliente.Text = "Pedido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Estado:";
            // 
            // TxtEst
            // 
            this.TxtEst.Location = new System.Drawing.Point(521, 531);
            this.TxtEst.Name = "TxtEst";
            this.TxtEst.Size = new System.Drawing.Size(257, 20);
            this.TxtEst.TabIndex = 66;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(812, 654);
            this.Controls.Add(this.TxtFecPed);
            this.Controls.Add(this.TxtFecEsp);
            this.Controls.Add(this.TxtFecEnt);
            this.Controls.Add(this.TxtEst);
            this.Controls.Add(this.TxtCom);
            this.Controls.Add(this.TxtCli);
            this.Controls.Add(this.TxtCodPed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.BtnPago);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.cliente);
            this.Name = "Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtFecPed;
        private System.Windows.Forms.TextBox TxtFecEsp;
        private System.Windows.Forms.TextBox TxtFecEnt;
        private System.Windows.Forms.TextBox TxtCom;
        private System.Windows.Forms.TextBox TxtCli;
        private System.Windows.Forms.TextBox TxtCodPed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConexion;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnPago;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEst;
    }
}