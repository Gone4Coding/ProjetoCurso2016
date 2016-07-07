namespace PrototipoFuncionalClubeDeJudoDragao.Listagens
{
    partial class TotaisPontos
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_Datas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Datas
            // 
            this.gb_Datas.Controls.Add(this.dataInicio);
            this.gb_Datas.Controls.Add(this.dataFim);
            this.gb_Datas.Controls.Add(this.dtp_Inicio);
            this.gb_Datas.Controls.Add(this.dtp_InicioFim);
            this.gb_Datas.Location = new System.Drawing.Point(12, 12);
            this.gb_Datas.Name = "gb_Datas";
            this.gb_Datas.Size = new System.Drawing.Size(160, 81);
            this.gb_Datas.TabIndex = 29;
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
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(178, 50);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 33;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(178, 21);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 32;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // TotaisPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.gb_Datas);
            this.Name = "TotaisPontos";
            this.Text = "Opção de Totais de Pontos";
            this.gb_Datas.ResumeLayout(false);
            this.gb_Datas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Datas;
        private System.Windows.Forms.Label dataInicio;
        private System.Windows.Forms.Label dataFim;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DateTimePicker dtp_InicioFim;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
    }
}