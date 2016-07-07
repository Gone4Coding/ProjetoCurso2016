namespace PrototipoFuncionalClubeDeJudoDragao.Listagens.Listas
{
    partial class TotaisPontosLista
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.bt_retroceder = new System.Windows.Forms.Button();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.graduacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pontos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licFederativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.licFederativa,
            this.nome,
            this.graduacao,
            this.pontos});
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // bt_retroceder
            // 
            this.bt_retroceder.Location = new System.Drawing.Point(305, 12);
            this.bt_retroceder.Name = "bt_retroceder";
            this.bt_retroceder.Size = new System.Drawing.Size(75, 23);
            this.bt_retroceder.TabIndex = 1;
            this.bt_retroceder.Text = "Retroceder";
            this.bt_retroceder.UseVisualStyleBackColor = true;
            this.bt_retroceder.Click += new System.EventHandler(this.bt_retroceder_Click);
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 129;
            // 
            // graduacao
            // 
            this.graduacao.Text = "Graduação";
            this.graduacao.Width = 70;
            // 
            // pontos
            // 
            this.pontos.Text = "Pontos";
            // 
            // licFederativa
            // 
            this.licFederativa.Text = "Licença Federativa";
            this.licFederativa.Width = 104;
            // 
            // TotaisPontosLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 159);
            this.Controls.Add(this.bt_retroceder);
            this.Controls.Add(this.listView1);
            this.Name = "TotaisPontosLista";
            this.Text = "Listagem de Totais de Pontos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader licFederativa;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader graduacao;
        private System.Windows.Forms.ColumnHeader pontos;
        private System.Windows.Forms.Button bt_retroceder;
    }
}