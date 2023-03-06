namespace Proyecto_Final
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
            this.cliente = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BtnPago = new System.Windows.Forms.Button();
            this.BtnPedido = new System.Windows.Forms.Button();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCodCli = new System.Windows.Forms.TextBox();
            this.TxtDir2 = new System.Windows.Forms.TextBox();
            this.TxtDir1 = new System.Windows.Forms.TextBox();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtApeCon = new System.Windows.Forms.TextBox();
            this.TxtNomCon = new System.Windows.Forms.TextBox();
            this.TxtNomCli = new System.Windows.Forms.TextBox();
            this.TxtCodPos = new System.Windows.Forms.TextBox();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.TxtReg = new System.Windows.Forms.TextBox();
            this.TxtCiu = new System.Windows.Forms.TextBox();
            this.TxtCodEmp = new System.Windows.Forms.TextBox();
            this.TxtLimCre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(453, 22);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(180, 55);
            this.cliente.TabIndex = 0;
            this.cliente.Text = "Cliente";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 87);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(1053, 298);
            this.DGV.TabIndex = 1;
            // 
            // BtnPago
            // 
            this.BtnPago.Location = new System.Drawing.Point(12, 12);
            this.BtnPago.Name = "BtnPago";
            this.BtnPago.Size = new System.Drawing.Size(168, 54);
            this.BtnPago.TabIndex = 2;
            this.BtnPago.Text = "PAGO";
            this.BtnPago.UseVisualStyleBackColor = true;
            this.BtnPago.Click += new System.EventHandler(this.BtnPago_Click);
            // 
            // BtnPedido
            // 
            this.BtnPedido.Location = new System.Drawing.Point(897, 12);
            this.BtnPedido.Name = "BtnPedido";
            this.BtnPedido.Size = new System.Drawing.Size(168, 54);
            this.BtnPedido.TabIndex = 3;
            this.BtnPedido.Text = "PEDIDO";
            this.BtnPedido.UseVisualStyleBackColor = true;
            this.BtnPedido.Click += new System.EventHandler(this.BtnPedido_Click);
            // 
            // BtnConexion
            // 
            this.BtnConexion.Location = new System.Drawing.Point(12, 410);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(168, 54);
            this.BtnConexion.TabIndex = 4;
            this.BtnConexion.Text = "Conectar Tabla";
            this.BtnConexion.UseVisualStyleBackColor = true;
            this.BtnConexion.Click += new System.EventHandler(this.TxtConexion_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(12, 547);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(168, 54);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Borrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(12, 476);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(168, 54);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar Datos";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(202, 476);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(168, 54);
            this.BtnInsertar.TabIndex = 7;
            this.BtnInsertar.Text = "Insertar Datos";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(202, 410);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(168, 54);
            this.BtnMostrar.TabIndex = 8;
            this.BtnMostrar.Text = "Mostrar Datos";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(202, 547);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(168, 54);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre Contacto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido Contacto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Direccion 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(723, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Direccion 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 526);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(723, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Ciudad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(723, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Region:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(723, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Pais:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(723, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Codigo Postal:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(723, 554);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Codigo Empleado Ventas:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(723, 584);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Limite Credito:";
            // 
            // TxtCodCli
            // 
            this.TxtCodCli.Location = new System.Drawing.Point(513, 410);
            this.TxtCodCli.Name = "TxtCodCli";
            this.TxtCodCli.Size = new System.Drawing.Size(190, 20);
            this.TxtCodCli.TabIndex = 24;
            // 
            // TxtDir2
            // 
            this.TxtDir2.Location = new System.Drawing.Point(818, 410);
            this.TxtDir2.Name = "TxtDir2";
            this.TxtDir2.Size = new System.Drawing.Size(247, 20);
            this.TxtDir2.TabIndex = 25;
            // 
            // TxtDir1
            // 
            this.TxtDir1.Location = new System.Drawing.Point(484, 581);
            this.TxtDir1.Name = "TxtDir1";
            this.TxtDir1.Size = new System.Drawing.Size(219, 20);
            this.TxtDir1.TabIndex = 26;
            // 
            // TxtFax
            // 
            this.TxtFax.Location = new System.Drawing.Point(484, 551);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(219, 20);
            this.TxtFax.TabIndex = 27;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(484, 523);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(219, 20);
            this.TxtTel.TabIndex = 28;
            // 
            // TxtApeCon
            // 
            this.TxtApeCon.Location = new System.Drawing.Point(513, 494);
            this.TxtApeCon.Name = "TxtApeCon";
            this.TxtApeCon.Size = new System.Drawing.Size(190, 20);
            this.TxtApeCon.TabIndex = 29;
            // 
            // TxtNomCon
            // 
            this.TxtNomCon.Location = new System.Drawing.Point(513, 465);
            this.TxtNomCon.Name = "TxtNomCon";
            this.TxtNomCon.Size = new System.Drawing.Size(190, 20);
            this.TxtNomCon.TabIndex = 30;
            // 
            // TxtNomCli
            // 
            this.TxtNomCli.Location = new System.Drawing.Point(513, 439);
            this.TxtNomCli.Name = "TxtNomCli";
            this.TxtNomCli.Size = new System.Drawing.Size(190, 20);
            this.TxtNomCli.TabIndex = 31;
            // 
            // TxtCodPos
            // 
            this.TxtCodPos.Location = new System.Drawing.Point(818, 523);
            this.TxtCodPos.Name = "TxtCodPos";
            this.TxtCodPos.Size = new System.Drawing.Size(247, 20);
            this.TxtCodPos.TabIndex = 32;
            // 
            // TxtPais
            // 
            this.TxtPais.Location = new System.Drawing.Point(817, 494);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(248, 20);
            this.TxtPais.TabIndex = 33;
            // 
            // TxtReg
            // 
            this.TxtReg.Location = new System.Drawing.Point(817, 468);
            this.TxtReg.Name = "TxtReg";
            this.TxtReg.Size = new System.Drawing.Size(248, 20);
            this.TxtReg.TabIndex = 34;
            // 
            // TxtCiu
            // 
            this.TxtCiu.Location = new System.Drawing.Point(817, 439);
            this.TxtCiu.Name = "TxtCiu";
            this.TxtCiu.Size = new System.Drawing.Size(248, 20);
            this.TxtCiu.TabIndex = 35;
            // 
            // TxtCodEmp
            // 
            this.TxtCodEmp.Location = new System.Drawing.Point(881, 551);
            this.TxtCodEmp.Name = "TxtCodEmp";
            this.TxtCodEmp.Size = new System.Drawing.Size(184, 20);
            this.TxtCodEmp.TabIndex = 36;
            // 
            // TxtLimCre
            // 
            this.TxtLimCre.Location = new System.Drawing.Point(818, 581);
            this.TxtLimCre.Name = "TxtLimCre";
            this.TxtLimCre.Size = new System.Drawing.Size(248, 20);
            this.TxtLimCre.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1081, 665);
            this.Controls.Add(this.TxtLimCre);
            this.Controls.Add(this.TxtCodEmp);
            this.Controls.Add(this.TxtCiu);
            this.Controls.Add(this.TxtReg);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.TxtCodPos);
            this.Controls.Add(this.TxtNomCli);
            this.Controls.Add(this.TxtNomCon);
            this.Controls.Add(this.TxtApeCon);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtFax);
            this.Controls.Add(this.TxtDir1);
            this.Controls.Add(this.TxtDir2);
            this.Controls.Add(this.TxtCodCli);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.BtnPedido);
            this.Controls.Add(this.BtnPago);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.cliente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button BtnPago;
        private System.Windows.Forms.Button BtnPedido;
        private System.Windows.Forms.Button BtnConexion;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCodCli;
        private System.Windows.Forms.TextBox TxtDir2;
        private System.Windows.Forms.TextBox TxtDir1;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtApeCon;
        private System.Windows.Forms.TextBox TxtNomCon;
        private System.Windows.Forms.TextBox TxtNomCli;
        private System.Windows.Forms.TextBox TxtCodPos;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.TextBox TxtReg;
        private System.Windows.Forms.TextBox TxtCiu;
        private System.Windows.Forms.TextBox TxtCodEmp;
        private System.Windows.Forms.TextBox TxtLimCre;
    }
}

