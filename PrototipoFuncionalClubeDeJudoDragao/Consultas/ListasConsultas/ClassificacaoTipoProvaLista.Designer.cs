namespace PrototipoFuncionalClubeDeJudoDragao.Consultas
{
    partial class ClassificacaoTipoProvaLista
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
            this.LicFederativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.escalao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prova = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lugar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataProva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bt_retroceder
            // 
            this.bt_retroceder.Location = new System.Drawing.Point(697, 12);
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
            this.dataProva,
            this.LicFederativa,
            this.nome,
            this.escalao,
            this.prova,
            this.tipo,
            this.lugar,
            this.peso,
            this.nomeCidade});
            this.listView1.Location = new System.Drawing.Point(12, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 202);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LicFederativa
            // 
            this.LicFederativa.Text = "Licença Federativa";
            this.LicFederativa.Width = 105;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 125;
            // 
            // escalao
            // 
            this.escalao.Text = "Escalão";
            this.escalao.Width = 94;
            // 
            // prova
            // 
            this.prova.Text = "Prova";
            this.prova.Width = 87;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            // 
            // lugar
            // 
            this.lugar.Text = "Lugar";
            this.lugar.Width = 43;
            // 
            // peso
            // 
            this.peso.Text = "Peso";
            this.peso.Width = 38;
            // 
            // nomeCidade
            // 
            this.nomeCidade.Text = "Nome da Cidade";
            this.nomeCidade.Width = 120;
            // 
            // dataProva
            // 
            this.dataProva.Text = "Data de Prova";
            this.dataProva.Width = 82;
            // 
            // ClassificacaoTipoProvaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_retroceder);
            this.Name = "ClassificacaoTipoProvaLista";
            this.Text = "Lista de Classificações Por Data / ProvaLista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_retroceder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader dataProva;
        private System.Windows.Forms.ColumnHeader LicFederativa;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader escalao;
        private System.Windows.Forms.ColumnHeader prova;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader lugar;
        private System.Windows.Forms.ColumnHeader peso;
        private System.Windows.Forms.ColumnHeader nomeCidade;
    }
}