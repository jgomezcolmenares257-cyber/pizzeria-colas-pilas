namespace laboratoriPizzeriaCampusExpress
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnPremium;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
        	this.txtCliente = new System.Windows.Forms.TextBox();
        	this.btnNuevoPedido = new System.Windows.Forms.Button();
        	this.btnEntregar = new System.Windows.Forms.Button();
        	this.btnDeshacer = new System.Windows.Forms.Button();
        	this.btnLimpiar = new System.Windows.Forms.Button();
        	this.lstPedidos = new System.Windows.Forms.ListBox();
        	this.lstBitacora = new System.Windows.Forms.ListBox();
        	this.lblEstado = new System.Windows.Forms.Label();
        	this.lblContador = new System.Windows.Forms.Label();
        	this.btnPremium = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// txtCliente
        	// 
        	this.txtCliente.Location = new System.Drawing.Point(18, 18);
        	this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.txtCliente.Name = "txtCliente";
        	this.txtCliente.Size = new System.Drawing.Size(298, 26);
        	this.txtCliente.TabIndex = 0;
        	// 
        	// btnNuevoPedido
        	// 
        	this.btnNuevoPedido.Location = new System.Drawing.Point(330, 15);
        	this.btnNuevoPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.btnNuevoPedido.Name = "btnNuevoPedido";
        	this.btnNuevoPedido.Size = new System.Drawing.Size(150, 35);
        	this.btnNuevoPedido.TabIndex = 1;
        	this.btnNuevoPedido.Text = "Nuevo Pedido";
        	this.btnNuevoPedido.UseVisualStyleBackColor = true;
        	this.btnNuevoPedido.Click += new System.EventHandler(this.BtnNuevoPedido_Click);
        	// 
        	// btnEntregar
        	// 
        	this.btnEntregar.Location = new System.Drawing.Point(489, 15);
        	this.btnEntregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.btnEntregar.Name = "btnEntregar";
        	this.btnEntregar.Size = new System.Drawing.Size(150, 35);
        	this.btnEntregar.TabIndex = 2;
        	this.btnEntregar.Text = "Entregar";
        	this.btnEntregar.UseVisualStyleBackColor = true;
        	this.btnEntregar.Click += new System.EventHandler(this.BtnEntregar_Click);
        	// 
        	// btnDeshacer
        	// 
        	this.btnDeshacer.Location = new System.Drawing.Point(648, 15);
        	this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.btnDeshacer.Name = "btnDeshacer";
        	this.btnDeshacer.Size = new System.Drawing.Size(150, 35);
        	this.btnDeshacer.TabIndex = 3;
        	this.btnDeshacer.Text = "Deshacer";
        	this.btnDeshacer.UseVisualStyleBackColor = true;
        	this.btnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
        	// 
        	// btnLimpiar
        	// 
        	this.btnLimpiar.Location = new System.Drawing.Point(807, 15);
        	this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.btnLimpiar.Name = "btnLimpiar";
        	this.btnLimpiar.Size = new System.Drawing.Size(150, 35);
        	this.btnLimpiar.TabIndex = 4;
        	this.btnLimpiar.Text = "Limpiar todo";
        	this.btnLimpiar.UseVisualStyleBackColor = true;
        	this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
        	// 
        	// lstPedidos
        	// 
        	this.lstPedidos.FormattingEnabled = true;
        	this.lstPedidos.ItemHeight = 20;
        	this.lstPedidos.Location = new System.Drawing.Point(18, 77);
        	this.lstPedidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.lstPedidos.Name = "lstPedidos";
        	this.lstPedidos.Size = new System.Drawing.Size(448, 364);
        	this.lstPedidos.TabIndex = 5;
        	// 
        	// lstBitacora
        	// 
        	this.lstBitacora.FormattingEnabled = true;
        	this.lstBitacora.ItemHeight = 20;
        	this.lstBitacora.Location = new System.Drawing.Point(480, 77);
        	this.lstBitacora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.lstBitacora.Name = "lstBitacora";
        	this.lstBitacora.Size = new System.Drawing.Size(475, 364);
        	this.lstBitacora.TabIndex = 6;
        	// 
        	// lblEstado
        	// 
        	this.lblEstado.AutoSize = true;
        	this.lblEstado.Location = new System.Drawing.Point(18, 485);
        	this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblEstado.Name = "lblEstado";
        	this.lblEstado.Size = new System.Drawing.Size(137, 20);
        	this.lblEstado.TabIndex = 7;
        	this.lblEstado.Text = "Listo para trabajar";
        	// 
        	// lblContador
        	// 
        	this.lblContador.AutoSize = true;
        	this.lblContador.Location = new System.Drawing.Point(18, 523);
        	this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblContador.Name = "lblContador";
        	this.lblContador.Size = new System.Drawing.Size(40, 20);
        	this.lblContador.TabIndex = 8;
        	this.lblContador.Text = "0 | 0";
        	// 
        	// btnPremium
        	// 
        	this.btnPremium.Location = new System.Drawing.Point(311, 480);
        	this.btnPremium.Name = "btnPremium";
        	this.btnPremium.Size = new System.Drawing.Size(294, 63);
        	this.btnPremium.TabIndex = 9;
        	this.btnPremium.Text = "Premium";
        	this.btnPremium.UseVisualStyleBackColor = true;
        	this.btnPremium.Click += new System.EventHandler(this.BtnPremiumClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(975, 569);
        	this.Controls.Add(this.btnPremium);
        	this.Controls.Add(this.lblContador);
        	this.Controls.Add(this.lblEstado);
        	this.Controls.Add(this.lstBitacora);
        	this.Controls.Add(this.lstPedidos);
        	this.Controls.Add(this.btnLimpiar);
        	this.Controls.Add(this.btnDeshacer);
        	this.Controls.Add(this.btnEntregar);
        	this.Controls.Add(this.btnNuevoPedido);
        	this.Controls.Add(this.txtCliente);
        	this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Name = "MainForm";
        	this.Text = "Pizzería Campus Express";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
    }
}