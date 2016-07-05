namespace PrototipoFuncionalClubeDeJudoDragao.Listagens
{
    partial class DatasGraduacao
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
            this.dtp_InicioFim = new System.Windows.Forms.DateTimePicker();
            this.gb_Datas.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(187, 67);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 23;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(187, 21);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 22;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
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
            this.gb_Datas.TabIndex = 21;
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
            // DatasGraduacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 108);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.gb_Datas);
            this.Name = "DatasGraduacao";
            this.Text = "Opções de Datas de Graduações";
            this.gb_Datas.ResumeLayout(false);
            this.gb_Datas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox gb_Datas;
        private System.Windows.Forms.Label dataInicio;
        private System.Windows.Forms.Label dataFim;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DateTimePicker dtp_InicioFim;
    }
}