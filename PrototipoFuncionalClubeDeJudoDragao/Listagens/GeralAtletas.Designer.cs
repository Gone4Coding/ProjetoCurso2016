namespace PrototipoFuncionalClubeDeJudoDragao.Listagens
{
    partial class GeralAtletas
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
            this.gb_codigoAtleta = new System.Windows.Forms.GroupBox();
            this.tb_codigoAtletaFim = new System.Windows.Forms.TextBox();
            this.tb_codigoAtletaInicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_tipoSituacao = new System.Windows.Forms.GroupBox();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_naoRevalidados = new System.Windows.Forms.RadioButton();
            this.rb_inscritosRevalidados = new System.Windows.Forms.RadioButton();
            this.gb_codigoAtleta.SuspendLayout();
            this.gb_tipoSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(171, 68);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 22;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(171, 22);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 21;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // gb_codigoAtleta
            // 
            this.gb_codigoAtleta.Controls.Add(this.tb_codigoAtletaFim);
            this.gb_codigoAtleta.Controls.Add(this.tb_codigoAtletaInicio);
            this.gb_codigoAtleta.Controls.Add(this.label2);
            this.gb_codigoAtleta.Controls.Add(this.label1);
            this.gb_codigoAtleta.Location = new System.Drawing.Point(12, 12);
            this.gb_codigoAtleta.Name = "gb_codigoAtleta";
            this.gb_codigoAtleta.Size = new System.Drawing.Size(141, 86);
            this.gb_codigoAtleta.TabIndex = 23;
            this.gb_codigoAtleta.TabStop = false;
            this.gb_codigoAtleta.Text = "Código de Atletas";
            // 
            // tb_codigoAtletaFim
            // 
            this.tb_codigoAtletaFim.Location = new System.Drawing.Point(57, 53);
            this.tb_codigoAtletaFim.Name = "tb_codigoAtletaFim";
            this.tb_codigoAtletaFim.Size = new System.Drawing.Size(62, 20);
            this.tb_codigoAtletaFim.TabIndex = 24;
            // 
            // tb_codigoAtletaInicio
            // 
            this.tb_codigoAtletaInicio.Location = new System.Drawing.Point(57, 17);
            this.tb_codigoAtletaInicio.Name = "tb_codigoAtletaInicio";
            this.tb_codigoAtletaInicio.Size = new System.Drawing.Size(62, 20);
            this.tb_codigoAtletaInicio.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Início";
            // 
            // gb_tipoSituacao
            // 
            this.gb_tipoSituacao.Controls.Add(this.rb_todos);
            this.gb_tipoSituacao.Controls.Add(this.rb_naoRevalidados);
            this.gb_tipoSituacao.Controls.Add(this.rb_inscritosRevalidados);
            this.gb_tipoSituacao.Location = new System.Drawing.Point(12, 104);
            this.gb_tipoSituacao.Name = "gb_tipoSituacao";
            this.gb_tipoSituacao.Size = new System.Drawing.Size(158, 93);
            this.gb_tipoSituacao.TabIndex = 24;
            this.gb_tipoSituacao.TabStop = false;
            this.gb_tipoSituacao.Text = "Por Tipo de Situação";
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(20, 65);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 25;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_naoRevalidados
            // 
            this.rb_naoRevalidados.AutoSize = true;
            this.rb_naoRevalidados.Location = new System.Drawing.Point(20, 42);
            this.rb_naoRevalidados.Name = "rb_naoRevalidados";
            this.rb_naoRevalidados.Size = new System.Drawing.Size(107, 17);
            this.rb_naoRevalidados.TabIndex = 25;
            this.rb_naoRevalidados.TabStop = true;
            this.rb_naoRevalidados.Text = "Não Revalidados";
            this.rb_naoRevalidados.UseVisualStyleBackColor = true;
            // 
            // rb_inscritosRevalidados
            // 
            this.rb_inscritosRevalidados.AutoSize = true;
            this.rb_inscritosRevalidados.Location = new System.Drawing.Point(20, 19);
            this.rb_inscritosRevalidados.Name = "rb_inscritosRevalidados";
            this.rb_inscritosRevalidados.Size = new System.Drawing.Size(134, 17);
            this.rb_inscritosRevalidados.TabIndex = 25;
            this.rb_inscritosRevalidados.TabStop = true;
            this.rb_inscritosRevalidados.Text = "Inscritos / Revalidados";
            this.rb_inscritosRevalidados.UseVisualStyleBackColor = true;
            // 
            // GeralAtletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 210);
            this.Controls.Add(this.gb_tipoSituacao);
            this.Controls.Add(this.gb_codigoAtleta);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_ok);
            this.Name = "GeralAtletas";
            this.Text = "Opção Geral de Atletas";
            this.gb_codigoAtleta.ResumeLayout(false);
            this.gb_codigoAtleta.PerformLayout();
            this.gb_tipoSituacao.ResumeLayout(false);
            this.gb_tipoSituacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox gb_codigoAtleta;
        private System.Windows.Forms.TextBox tb_codigoAtletaFim;
        private System.Windows.Forms.TextBox tb_codigoAtletaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_tipoSituacao;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_naoRevalidados;
        private System.Windows.Forms.RadioButton rb_inscritosRevalidados;
    }
}