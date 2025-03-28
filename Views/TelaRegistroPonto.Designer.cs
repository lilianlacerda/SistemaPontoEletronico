namespace SistemaPontoEletronico.Views
{
    partial class TelaRegistroPonto
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
            this.components = new System.ComponentModel.Container();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblTempoTrabalhado = new System.Windows.Forms.Label();
            this.horaAtual = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(131, 128);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(110, 34);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(284, 128);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(112, 34);
            this.btnSaida.TabIndex = 1;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Location = new System.Drawing.Point(141, 246);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(57, 13);
            this.lblHoraAtual.TabIndex = 2;
            this.lblHoraAtual.Text = "Hora Atual";
            // 
            // lblTempoTrabalhado
            // 
            this.lblTempoTrabalhado.AutoSize = true;
            this.lblTempoTrabalhado.Location = new System.Drawing.Point(290, 246);
            this.lblTempoTrabalhado.Name = "lblTempoTrabalhado";
            this.lblTempoTrabalhado.Size = new System.Drawing.Size(97, 13);
            this.lblTempoTrabalhado.TabIndex = 3;
            this.lblTempoTrabalhado.Text = "Tempo Trabalhado";
            // 
            // TelaRegistroPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 413);
            this.Controls.Add(this.lblTempoTrabalhado);
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRegistroPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRegistroPonto";
            this.Load += new System.EventHandler(this.TelaRegistroPonto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Label lblTempoTrabalhado;
        private System.Windows.Forms.Timer horaAtual;
    }
}