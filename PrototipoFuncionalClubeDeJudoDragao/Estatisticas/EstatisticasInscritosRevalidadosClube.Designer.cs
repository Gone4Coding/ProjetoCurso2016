namespace PrototipoFuncionalClubeDeJudoDragao.Estatisticas
{
    partial class EstatisticasInscritosRevalidadosClube
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_Datas = new System.Windows.Forms.GroupBox();
            this.dataInicio = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.Label();
            this.dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fim = new System.Windows.Forms.DateTimePicker();
            this.gb_clubes = new System.Windows.Forms.GroupBox();
            this.tb_clubesFim = new System.Windows.Forms.TextBox();
            this.tb_clubesInicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Datas.SuspendLayout();
            this.gb_clubes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(146, 141);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 27;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(146, 112);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 26;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // gb_Datas
            // 
            this.gb_Datas.Controls.Add(this.dataInicio);
            this.gb_Datas.Controls.Add(this.dataFim);
            this.gb_Datas.Controls.Add(this.dtp_Inicio);
            this.gb_Datas.Controls.Add(this.dtp_Fim);
            this.gb_Datas.Location = new System.Drawing.Point(12, 12);
            this.gb_Datas.Name = "gb_Datas";
            this.gb_Datas.Size = new System.Drawing.Size(160, 81);
            this.gb_Datas.TabIndex = 25;
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
            // dtp_Fim
            // 
            this.dtp_Fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fim.Location = new System.Drawing.Point(46, 45);
            this.dtp_Fim.Name = "dtp_Fim";
            this.dtp_Fim.Size = new System.Drawing.Size(98, 20);
            this.dtp_Fim.TabIndex = 7;
            // 
            // gb_clubes
            // 
            this.gb_clubes.Controls.Add(this.tb_clubesFim);
            this.gb_clubes.Controls.Add(this.tb_clubesInicio);
            this.gb_clubes.Controls.Add(this.label1);
            this.gb_clubes.Controls.Add(this.label2);
            this.gb_clubes.Location = new System.Drawing.Point(12, 99);
            this.gb_clubes.Name = "gb_clubes";
            this.gb_clubes.Size = new System.Drawing.Size(128, 81);
            this.gb_clubes.TabIndex = 28;
            this.gb_clubes.TabStop = false;
            this.gb_clubes.Text = "Clubes";
            // 
            // tb_clubesFim
            // 
            this.tb_clubesFim.Location = new System.Drawing.Point(46, 42);
            this.tb_clubesFim.Name = "tb_clubesFim";
            this.tb_clubesFim.Size = new System.Drawing.Size(62, 20);
            this.tb_clubesFim.TabIndex = 10;
            // 
            // tb_clubesInicio
            // 
            this.tb_clubesInicio.Location = new System.Drawing.Point(46, 16);
            this.tb_clubesInicio.Name = "tb_clubesInicio";
            this.tb_clubesInicio.Size = new System.Drawing.Size(62, 20);
            this.tb_clubesInicio.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fim";
            // 
            // EstatisticasInscritosRevalidadosClube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 193);
            this.Controls.Add(this.gb_clubes);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.gb_Datas);
            this.Name = "EstatisticasInscritosRevalidadosClube";
            this.Text = "Opção de Estatisticas por Clube";
            this.gb_Datas.ResumeLayout(false);
            this.gb_Datas.PerformLayout();
            this.gb_clubes.ResumeLayout(false);
            this.gb_clubes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox gb_Datas;
        private System.Windows.Forms.Label dataInicio;
        private System.Windows.Forms.Label dataFim;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DateTimePicker dtp_Fim;
        private System.Windows.Forms.GroupBox gb_clubes;
        private System.Windows.Forms.TextBox tb_clubesFim;
        private System.Windows.Forms.TextBox tb_clubesInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}