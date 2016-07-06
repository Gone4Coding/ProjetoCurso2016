namespace PrototipoFuncionalClubeDeJudoDragao.Consultas
{
    partial class InscritosRevalidadosGraduacaoLista
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
            this.bt_retroceder = new System.Windows.Forms.Button();
            this.lv_provas = new System.Windows.Forms.ListView();
            this.licFederativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataInscricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataRevalidacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataRevAnterior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bt_retroceder
            // 
            this.bt_retroceder.Location = new System.Drawing.Point(552, 12);
            this.bt_retroceder.Name = "bt_retroceder";
            this.bt_retroceder.Size = new System.Drawing.Size(75, 23);
            this.bt_retroceder.TabIndex = 5;
            this.bt_retroceder.Text = "Retroceder";
            this.bt_retroceder.UseVisualStyleBackColor = true;
            this.bt_retroceder.Click += new System.EventHandler(this.bt_retroceder_Click);
            // 
            // lv_provas
            // 
            this.lv_provas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.licFederativa,
            this.nome,
            this.descricao,
            this.dataInscricao,
            this.dataRevalidacao,
            this.dataRevAnterior});
            this.lv_provas.Location = new System.Drawing.Point(12, 41);
            this.lv_provas.Name = "lv_provas";
            this.lv_provas.Size = new System.Drawing.Size(615, 204);
            this.lv_provas.TabIndex = 4;
            this.lv_provas.UseCompatibleStateImageBehavior = false;
            this.lv_provas.View = System.Windows.Forms.View.Details;
            // 
            // licFederativa
            // 
            this.licFederativa.Text = "Lic. Federativa";
            this.licFederativa.Width = 91;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nome.Width = 123;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            // 
            // dataInscricao
            // 
            this.dataInscricao.Text = "Data de Inscrição";
            this.dataInscricao.Width = 99;
            // 
            // dataRevalidacao
            // 
            this.dataRevalidacao.Text = "Data de Revalidação";
            this.dataRevalidacao.Width = 117;
            // 
            // dataRevAnterior
            // 
            this.dataRevAnterior.Text = "Data de Rev. Anterior";
            this.dataRevAnterior.Width = 119;
            // 
            // InscritosRevalidadosGraduacaoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 261);
            this.Controls.Add(this.bt_retroceder);
            this.Controls.Add(this.lv_provas);
            this.Name = "InscritosRevalidadosGraduacaoLista";
            this.Text = "InscritosRevalidadosGraduacaoLista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_retroceder;
        private System.Windows.Forms.ListView lv_provas;
        private System.Windows.Forms.ColumnHeader licFederativa;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader dataInscricao;
        private System.Windows.Forms.ColumnHeader dataRevalidacao;
        private System.Windows.Forms.ColumnHeader dataRevAnterior;
    }
}