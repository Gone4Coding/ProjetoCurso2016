namespace PrototipoFuncionalClubeDeJudoDragao.Utilitarios
{
    partial class AlteracaoCodigoSituacao
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
            this.gb_importante = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_situacoes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_anterior = new System.Windows.Forms.TextBox();
            this.tb_atual = new System.Windows.Forms.TextBox();
            this.bt_executar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.gb_importante.SuspendLayout();
            this.gb_situacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_importante
            // 
            this.gb_importante.Controls.Add(this.label1);
            this.gb_importante.Location = new System.Drawing.Point(12, 12);
            this.gb_importante.Name = "gb_importante";
            this.gb_importante.Size = new System.Drawing.Size(288, 63);
            this.gb_importante.TabIndex = 0;
            this.gb_importante.TabStop = false;
            this.gb_importante.Text = "Importante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esta opção vai alterar o Código de Situação dos Atletas.\r\nPara Continuar indique " +
    "os Códigos e Prima Executar.\r\nPara abandonar Prima Cancelar.\r\n";
            // 
            // gb_situacoes
            // 
            this.gb_situacoes.Controls.Add(this.tb_atual);
            this.gb_situacoes.Controls.Add(this.tb_anterior);
            this.gb_situacoes.Controls.Add(this.label3);
            this.gb_situacoes.Controls.Add(this.label2);
            this.gb_situacoes.Location = new System.Drawing.Point(12, 81);
            this.gb_situacoes.Name = "gb_situacoes";
            this.gb_situacoes.Size = new System.Drawing.Size(120, 100);
            this.gb_situacoes.TabIndex = 1;
            this.gb_situacoes.TabStop = false;
            this.gb_situacoes.Text = "Situações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anterior";
            // 
            // tb_anterior
            // 
            this.tb_anterior.Location = new System.Drawing.Point(55, 22);
            this.tb_anterior.Name = "tb_anterior";
            this.tb_anterior.Size = new System.Drawing.Size(49, 20);
            this.tb_anterior.TabIndex = 2;
            // 
            // tb_atual
            // 
            this.tb_atual.Location = new System.Drawing.Point(55, 55);
            this.tb_atual.Name = "tb_atual";
            this.tb_atual.Size = new System.Drawing.Size(49, 20);
            this.tb_atual.TabIndex = 2;
            // 
            // bt_executar
            // 
            this.bt_executar.Location = new System.Drawing.Point(163, 96);
            this.bt_executar.Name = "bt_executar";
            this.bt_executar.Size = new System.Drawing.Size(75, 23);
            this.bt_executar.TabIndex = 2;
            this.bt_executar.Text = "Executar";
            this.bt_executar.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(163, 136);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 2;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // AlteracaoCodigoSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 192);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_executar);
            this.Controls.Add(this.gb_situacoes);
            this.Controls.Add(this.gb_importante);
            this.Name = "AlteracaoCodigoSituacao";
            this.Text = "Opção de Alterações";
            this.gb_importante.ResumeLayout(false);
            this.gb_importante.PerformLayout();
            this.gb_situacoes.ResumeLayout(false);
            this.gb_situacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_importante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_situacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_atual;
        private System.Windows.Forms.TextBox tb_anterior;
        private System.Windows.Forms.Button bt_executar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}