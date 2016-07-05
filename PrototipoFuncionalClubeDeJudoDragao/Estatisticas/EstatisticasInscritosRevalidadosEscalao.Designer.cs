namespace PrototipoFuncionalClubeDeJudoDragao.Estatisticas
{
    partial class EstatisticasInscritosRevalidadosEscalao
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
            this.gb_Tipo = new System.Windows.Forms.GroupBox();
            this.tipoInscritos = new System.Windows.Forms.RadioButton();
            this.tipoTodos = new System.Windows.Forms.RadioButton();
            this.tipoRevalidados = new System.Windows.Forms.RadioButton();
            this.gb_Datas = new System.Windows.Forms.GroupBox();
            this.dataInicio = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.Label();
            this.dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fim = new System.Windows.Forms.DateTimePicker();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_Tipo.SuspendLayout();
            this.gb_Datas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Tipo
            // 
            this.gb_Tipo.Controls.Add(this.tipoInscritos);
            this.gb_Tipo.Controls.Add(this.tipoTodos);
            this.gb_Tipo.Controls.Add(this.tipoRevalidados);
            this.gb_Tipo.Location = new System.Drawing.Point(178, 12);
            this.gb_Tipo.Name = "gb_Tipo";
            this.gb_Tipo.Size = new System.Drawing.Size(117, 100);
            this.gb_Tipo.TabIndex = 19;
            this.gb_Tipo.TabStop = false;
            this.gb_Tipo.Text = "Tipo";
            // 
            // tipoInscritos
            // 
            this.tipoInscritos.AutoSize = true;
            this.tipoInscritos.Location = new System.Drawing.Point(6, 19);
            this.tipoInscritos.Name = "tipoInscritos";
            this.tipoInscritos.Size = new System.Drawing.Size(64, 17);
            this.tipoInscritos.TabIndex = 11;
            this.tipoInscritos.TabStop = true;
            this.tipoInscritos.Text = "Inscritos";
            this.tipoInscritos.UseVisualStyleBackColor = true;
            // 
            // tipoTodos
            // 
            this.tipoTodos.AutoSize = true;
            this.tipoTodos.Location = new System.Drawing.Point(6, 65);
            this.tipoTodos.Name = "tipoTodos";
            this.tipoTodos.Size = new System.Drawing.Size(55, 17);
            this.tipoTodos.TabIndex = 12;
            this.tipoTodos.TabStop = true;
            this.tipoTodos.Text = "Todos";
            this.tipoTodos.UseVisualStyleBackColor = true;
            // 
            // tipoRevalidados
            // 
            this.tipoRevalidados.AutoSize = true;
            this.tipoRevalidados.Location = new System.Drawing.Point(6, 42);
            this.tipoRevalidados.Name = "tipoRevalidados";
            this.tipoRevalidados.Size = new System.Drawing.Size(84, 17);
            this.tipoRevalidados.TabIndex = 13;
            this.tipoRevalidados.TabStop = true;
            this.tipoRevalidados.Text = "Revalidados";
            this.tipoRevalidados.UseVisualStyleBackColor = true;
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
            this.gb_Datas.TabIndex = 20;
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
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(97, 99);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 18;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(12, 99);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 17;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // EstatisticasInscritosRevalidadosEscalao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 137);
            this.Controls.Add(this.gb_Tipo);
            this.Controls.Add(this.gb_Datas);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_ok);
            this.Name = "EstatisticasInscritosRevalidadosEscalao";
            this.Text = "Opção de Estatísticas por Escalao";
            this.gb_Tipo.ResumeLayout(false);
            this.gb_Tipo.PerformLayout();
            this.gb_Datas.ResumeLayout(false);
            this.gb_Datas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Tipo;
        private System.Windows.Forms.RadioButton tipoInscritos;
        private System.Windows.Forms.RadioButton tipoTodos;
        private System.Windows.Forms.RadioButton tipoRevalidados;
        private System.Windows.Forms.GroupBox gb_Datas;
        private System.Windows.Forms.Label dataInicio;
        private System.Windows.Forms.Label dataFim;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DateTimePicker dtp_Fim;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
    }
}