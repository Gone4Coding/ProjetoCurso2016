namespace PrototipoFuncionalClubeDeJudoDragao.Listagens
{
    partial class RecebimentoEntidades
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
            this.rb_subsidios = new System.Windows.Forms.RadioButton();
            this.rb_taxasGraduacoes = new System.Windows.Forms.RadioButton();
            this.rb_taxasFiliacao = new System.Windows.Forms.RadioButton();
            this.rb_taxaInscRevalidacao = new System.Windows.Forms.RadioButton();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.rb_tudo = new System.Windows.Forms.RadioButton();
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
            this.gb_Datas.Location = new System.Drawing.Point(181, 12);
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
            this.gb_tipo.Controls.Add(this.rb_subsidios);
            this.gb_tipo.Controls.Add(this.rb_taxasGraduacoes);
            this.gb_tipo.Controls.Add(this.rb_taxasFiliacao);
            this.gb_tipo.Controls.Add(this.rb_taxaInscRevalidacao);
            this.gb_tipo.Location = new System.Drawing.Point(12, 12);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(163, 135);
            this.gb_tipo.TabIndex = 25;
            this.gb_tipo.TabStop = false;
            this.gb_tipo.Text = "Tipo";
            // 
            // rb_subsidios
            // 
            this.rb_subsidios.AutoSize = true;
            this.rb_subsidios.Location = new System.Drawing.Point(6, 88);
            this.rb_subsidios.Name = "rb_subsidios";
            this.rb_subsidios.Size = new System.Drawing.Size(72, 17);
            this.rb_subsidios.TabIndex = 0;
            this.rb_subsidios.TabStop = true;
            this.rb_subsidios.Text = "Subsídios";
            this.rb_subsidios.UseVisualStyleBackColor = true;
            // 
            // rb_taxasGraduacoes
            // 
            this.rb_taxasGraduacoes.AutoSize = true;
            this.rb_taxasGraduacoes.Location = new System.Drawing.Point(6, 65);
            this.rb_taxasGraduacoes.Name = "rb_taxasGraduacoes";
            this.rb_taxasGraduacoes.Size = new System.Drawing.Size(115, 17);
            this.rb_taxasGraduacoes.TabIndex = 0;
            this.rb_taxasGraduacoes.TabStop = true;
            this.rb_taxasGraduacoes.Text = "Taxas Graduações";
            this.rb_taxasGraduacoes.UseVisualStyleBackColor = true;
            // 
            // rb_taxasFiliacao
            // 
            this.rb_taxasFiliacao.AutoSize = true;
            this.rb_taxasFiliacao.Location = new System.Drawing.Point(6, 42);
            this.rb_taxasFiliacao.Name = "rb_taxasFiliacao";
            this.rb_taxasFiliacao.Size = new System.Drawing.Size(93, 17);
            this.rb_taxasFiliacao.TabIndex = 0;
            this.rb_taxasFiliacao.TabStop = true;
            this.rb_taxasFiliacao.Text = "Taxas Filiação";
            this.rb_taxasFiliacao.UseVisualStyleBackColor = true;
            // 
            // rb_taxaInscRevalidacao
            // 
            this.rb_taxaInscRevalidacao.AutoSize = true;
            this.rb_taxaInscRevalidacao.Location = new System.Drawing.Point(6, 19);
            this.rb_taxaInscRevalidacao.Name = "rb_taxaInscRevalidacao";
            this.rb_taxaInscRevalidacao.Size = new System.Drawing.Size(151, 17);
            this.rb_taxaInscRevalidacao.TabIndex = 0;
            this.rb_taxaInscRevalidacao.TabStop = true;
            this.rb_taxaInscRevalidacao.Text = "Taxas Insc. / Revalidação";
            this.rb_taxaInscRevalidacao.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(266, 99);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 27;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(181, 99);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 26;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // rb_tudo
            // 
            this.rb_tudo.AutoSize = true;
            this.rb_tudo.Location = new System.Drawing.Point(6, 111);
            this.rb_tudo.Name = "rb_tudo";
            this.rb_tudo.Size = new System.Drawing.Size(50, 17);
            this.rb_tudo.TabIndex = 0;
            this.rb_tudo.TabStop = true;
            this.rb_tudo.Text = "Tudo";
            this.rb_tudo.UseVisualStyleBackColor = true;
            // 
            // RecebimentoEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 161);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.gb_tipo);
            this.Controls.Add(this.gb_Datas);
            this.Name = "RecebimentoEntidades";
            this.Text = "Opção de Recebimento de Entidades";
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
        private System.Windows.Forms.RadioButton rb_subsidios;
        private System.Windows.Forms.RadioButton rb_taxasGraduacoes;
        private System.Windows.Forms.RadioButton rb_taxasFiliacao;
        private System.Windows.Forms.RadioButton rb_taxaInscRevalidacao;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.RadioButton rb_tudo;
    }
}