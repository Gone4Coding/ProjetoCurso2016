namespace PrototipoFuncionalClubeDeJudoDragao.Listagens
{
    partial class Recebimentos
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
            this.gb_Datas = new System.Windows.Forms.GroupBox();
            this.dataInicio = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.Label();
            this.dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_InicioFim = new System.Windows.Forms.DateTimePicker();
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.rb_tudo = new System.Windows.Forms.RadioButton();
            this.rb_graduacoes = new System.Windows.Forms.RadioButton();
            this.rb_artigos = new System.Windows.Forms.RadioButton();
            this.rb_quotas = new System.Windows.Forms.RadioButton();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_Datas.SuspendLayout();
            this.gb_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Datas
            // 
            this.gb_Datas.Controls.Add(this.dataInicio);
            this.gb_Datas.Controls.Add(this.dataFim);
            this.gb_Datas.Controls.Add(this.dtp_Inicio);
            this.gb_Datas.Controls.Add(this.dtp_InicioFim);
            this.gb_Datas.Location = new System.Drawing.Point(121, 12);
            this.gb_Datas.Name = "gb_Datas";
            this.gb_Datas.Size = new System.Drawing.Size(160, 81);
            this.gb_Datas.TabIndex = 22;
            this.gb_Datas.TabStop = false;
            this.gb_Datas.Text = "Datas";
            // 
            // dataInicio
            // 
            this.dataInicio.AutoSize = true;
            this.dataInicio.Location = new System.Drawing.Point(6, 19);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(34, 13);
            this.dataInicio.TabIndex = 3;
            this.dataInicio.Text = "Início";
            // 
            // dataFim
            // 
            this.dataFim.AutoSize = true;
            this.dataFim.Location = new System.Drawing.Point(6, 45);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(23, 13);
            this.dataFim.TabIndex = 4;
            this.dataFim.Text = "Fim";
            // 
            // dtp_Inicio
            // 
            this.dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Inicio.Location = new System.Drawing.Point(46, 19);
            this.dtp_Inicio.Name = "dtp_Inicio";
            this.dtp_Inicio.Size = new System.Drawing.Size(98, 20);
            this.dtp_Inicio.TabIndex = 6;
            // 
            // dtp_InicioFim
            // 
            this.dtp_InicioFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_InicioFim.Location = new System.Drawing.Point(46, 45);
            this.dtp_InicioFim.Name = "dtp_InicioFim";
            this.dtp_InicioFim.Size = new System.Drawing.Size(98, 20);
            this.dtp_InicioFim.TabIndex = 7;
            // 
            // gb_tipo
            // 
            this.gb_tipo.Controls.Add(this.rb_tudo);
            this.gb_tipo.Controls.Add(this.rb_graduacoes);
            this.gb_tipo.Controls.Add(this.rb_artigos);
            this.gb_tipo.Controls.Add(this.rb_quotas);
            this.gb_tipo.Location = new System.Drawing.Point(12, 12);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(103, 124);
            this.gb_tipo.TabIndex = 25;
            this.gb_tipo.TabStop = false;
            this.gb_tipo.Text = "Tipo";
            // 
            // rb_tudo
            // 
            this.rb_tudo.AutoSize = true;
            this.rb_tudo.Location = new System.Drawing.Point(6, 88);
            this.rb_tudo.Name = "rb_tudo";
            this.rb_tudo.Size = new System.Drawing.Size(50, 17);
            this.rb_tudo.TabIndex = 0;
            this.rb_tudo.TabStop = true;
            this.rb_tudo.Text = "Tudo";
            this.rb_tudo.UseVisualStyleBackColor = true;
            // 
            // rb_graduacoes
            // 
            this.rb_graduacoes.AutoSize = true;
            this.rb_graduacoes.Location = new System.Drawing.Point(6, 65);
            this.rb_graduacoes.Name = "rb_graduacoes";
            this.rb_graduacoes.Size = new System.Drawing.Size(83, 17);
            this.rb_graduacoes.TabIndex = 0;
            this.rb_graduacoes.TabStop = true;
            this.rb_graduacoes.Text = "Graduações";
            this.rb_graduacoes.UseVisualStyleBackColor = true;
            // 
            // rb_artigos
            // 
            this.rb_artigos.AutoSize = true;
            this.rb_artigos.Location = new System.Drawing.Point(6, 42);
            this.rb_artigos.Name = "rb_artigos";
            this.rb_artigos.Size = new System.Drawing.Size(57, 17);
            this.rb_artigos.TabIndex = 0;
            this.rb_artigos.TabStop = true;
            this.rb_artigos.Text = "Artigos";
            this.rb_artigos.UseVisualStyleBackColor = true;
            // 
            // rb_quotas
            // 
            this.rb_quotas.AutoSize = true;
            this.rb_quotas.Location = new System.Drawing.Point(6, 19);
            this.rb_quotas.Name = "rb_quotas";
            this.rb_quotas.Size = new System.Drawing.Size(59, 17);
            this.rb_quotas.TabIndex = 0;
            this.rb_quotas.TabStop = true;
            this.rb_quotas.Text = "Quotas";
            this.rb_quotas.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(202, 113);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 27;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(121, 113);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 26;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // Recebimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.gb_tipo);
            this.Controls.Add(this.gb_Datas);
            this.Name = "Recebimentos";
            this.Text = "Opção de Recebimentos";
            this.gb_Datas.ResumeLayout(false);
            this.gb_Datas.PerformLayout();
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Datas;
        private System.Windows.Forms.Label dataInicio;
        private System.Windows.Forms.Label dataFim;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DateTimePicker dtp_InicioFim;
        private System.Windows.Forms.GroupBox gb_tipo;
        private System.Windows.Forms.RadioButton rb_tudo;
        private System.Windows.Forms.RadioButton rb_graduacoes;
        private System.Windows.Forms.RadioButton rb_artigos;
        private System.Windows.Forms.RadioButton rb_quotas;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
    }
}