namespace PrototipoFuncionalClubeDeJudoDragao.Listagens.Listas
{
    partial class AtletasPorSeguroLista
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.licFederativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataInscricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataRevalidacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cinto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.escalao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bt_retroceder
            // 
            this.bt_retroceder.Location = new System.Drawing.Point(517, 12);
            this.bt_retroceder.Name = "bt_retroceder";
            this.bt_retroceder.Size = new System.Drawing.Size(75, 23);
            this.bt_retroceder.TabIndex = 0;
            this.bt_retroceder.Text = "Retroceder";
            this.bt_retroceder.UseVisualStyleBackColor = true;
            this.bt_retroceder.Click += new System.EventHandler(this.bt_retroceder_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.licFederativa,
            this.nome,
            this.dataInscricao,
            this.dataRevalidacao,
            this.cinto,
            this.escalao});
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 208);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // licFederativa
            // 
            this.licFederativa.Text = "Licença Federativa";
            this.licFederativa.Width = 106;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 119;
            // 
            // dataInscricao
            // 
            this.dataInscricao.Text = "Data de Inscrição";
            this.dataInscricao.Width = 101;
            // 
            // dataRevalidacao
            // 
            this.dataRevalidacao.Text = "Data de Revalidação";
            this.dataRevalidacao.Width = 117;
            // 
            // cinto
            // 
            this.cinto.Text = "Cinto";
            // 
            // escalao
            // 
            this.escalao.Text = "Escalão";
            this.escalao.Width = 72;
            // 
            // AtletasPorSeguroLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_retroceder);
            this.Name = "AtletasPorSeguroLista";
            this.Text = "AtletasPorSeguroLista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_retroceder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader licFederativa;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader dataInscricao;
        private System.Windows.Forms.ColumnHeader dataRevalidacao;
        private System.Windows.Forms.ColumnHeader cinto;
        private System.Windows.Forms.ColumnHeader escalao;
    }
}