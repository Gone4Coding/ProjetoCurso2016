namespace PrototipoFuncionalClubeDeJudoDragao.Consultas
{
    partial class ClassificacaoDatasProvaLista
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
            this.lv_provas = new System.Windows.Forms.ListView();
            this.bt_retroceder = new System.Windows.Forms.Button();
            this.licFederativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoriaPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoProva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_provas
            // 
            this.lv_provas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.licFederativa,
            this.nome,
            this.classificacao,
            this.categoriaPeso,
            this.tipoProva});
            this.lv_provas.Location = new System.Drawing.Point(12, 43);
            this.lv_provas.Name = "lv_provas";
            this.lv_provas.Size = new System.Drawing.Size(470, 204);
            this.lv_provas.TabIndex = 0;
            this.lv_provas.UseCompatibleStateImageBehavior = false;
            this.lv_provas.View = System.Windows.Forms.View.Details;
            // 
            // bt_retroceder
            // 
            this.bt_retroceder.Location = new System.Drawing.Point(406, 14);
            this.bt_retroceder.Name = "bt_retroceder";
            this.bt_retroceder.Size = new System.Drawing.Size(75, 23);
            this.bt_retroceder.TabIndex = 1;
            this.bt_retroceder.Text = "Retroceder";
            this.bt_retroceder.UseVisualStyleBackColor = true;
            this.bt_retroceder.Click += new System.EventHandler(this.bt_retroceder_Click);
            // 
            // licFederativa
            // 
            this.licFederativa.Text = "Lic. Federativa";
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nome.Width = 123;
            // 
            // classificacao
            // 
            this.classificacao.Text = "Classificação";
            // 
            // categoriaPeso
            // 
            this.categoriaPeso.Text = "Categoria de Peso";
            // 
            // tipoProva
            // 
            this.tipoProva.Text = "Tipo de Prova";
            // 
            // ClassificacaoDatasProvaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 272);
            this.Controls.Add(this.bt_retroceder);
            this.Controls.Add(this.lv_provas);
            this.Name = "ClassificacaoDatasProvaLista";
            this.Text = "Listagem de Classificações Por Prova";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_provas;
        private System.Windows.Forms.Button bt_retroceder;
        private System.Windows.Forms.ColumnHeader licFederativa;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader classificacao;
        private System.Windows.Forms.ColumnHeader categoriaPeso;
        private System.Windows.Forms.ColumnHeader tipoProva;
    }
}