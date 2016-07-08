namespace PrototipoFuncionalClubeDeJudoDragao.Actualizacoes.Fichas
{
    partial class FichaClassificacoes
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
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.licFederativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoriaPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipoProva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtp_dataRevalidacao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_clube = new System.Windows.Forms.ComboBox();
            this.cb_escalao = new System.Windows.Forms.ComboBox();
            this.cb_graduacao = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.pb_fotoAtleta = new System.Windows.Forms.PictureBox();
            this.tb_licFederativa = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAtleta)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(174, 410);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 23);
            this.bt_eliminar.TabIndex = 83;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            // 
            // bt_alterar
            // 
            this.bt_alterar.Location = new System.Drawing.Point(93, 410);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_alterar.TabIndex = 84;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(12, 410);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 85;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.licFederativa,
            this.data,
            this.descricao,
            this.classificacao,
            this.categoriaPeso,
            this.tipoProva});
            this.listView1.Location = new System.Drawing.Point(12, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(619, 205);
            this.listView1.TabIndex = 82;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // licFederativa
            // 
            this.licFederativa.Text = "Licença Federativa";
            this.licFederativa.Width = 105;
            // 
            // data
            // 
            this.data.Text = "Data da Prova";
            this.data.Width = 84;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.Width = 162;
            // 
            // classificacao
            // 
            this.classificacao.Text = "Classificação";
            this.classificacao.Width = 77;
            // 
            // categoriaPeso
            // 
            this.categoriaPeso.Text = "Categoria de Peso";
            this.categoriaPeso.Width = 101;
            // 
            // tipoProva
            // 
            this.tipoProva.Text = "Tipo de Prova";
            this.tipoProva.Width = 83;
            // 
            // dtp_dataRevalidacao
            // 
            this.dtp_dataRevalidacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataRevalidacao.Location = new System.Drawing.Point(307, 173);
            this.dtp_dataRevalidacao.Name = "dtp_dataRevalidacao";
            this.dtp_dataRevalidacao.Size = new System.Drawing.Size(95, 20);
            this.dtp_dataRevalidacao.TabIndex = 80;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 81;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(208, 179);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 13);
            this.label26.TabIndex = 78;
            this.label26.Text = "Data Revalidação";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Data Inscrição";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 149);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 76;
            this.label20.Text = "Clube";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 77;
            this.label18.Text = "Escalão";
            // 
            // cb_clube
            // 
            this.cb_clube.FormattingEnabled = true;
            this.cb_clube.Items.AddRange(new object[] {
            "Branco - 6º Kyu",
            "Branco/Amarelo",
            "Amarelo - 5º Kyu",
            "Amarelo/Laranja",
            "Laranja - 4º Kyu",
            "Laranja/Verde",
            "Verde - 3º Kyu",
            "Verde/Azul",
            "Azul - 2º Kyu",
            "Castanho - 1º Kyu",
            "Negro - 1º Dan",
            "Negro - 2º Dan",
            "Negro - 3º Dan",
            "Negro - 4º Dan",
            "Negro - 5º Dan",
            "Branco/Vermelho - 6º Dan",
            "Branco/Vermelho - 7º Dan",
            "Branco/Vermelho - 8º Dan",
            "Vermelho - 9º Dan",
            "Branco - 10º Dan"});
            this.cb_clube.Location = new System.Drawing.Point(107, 146);
            this.cb_clube.Name = "cb_clube";
            this.cb_clube.Size = new System.Drawing.Size(201, 21);
            this.cb_clube.TabIndex = 73;
            // 
            // cb_escalao
            // 
            this.cb_escalao.FormattingEnabled = true;
            this.cb_escalao.Items.AddRange(new object[] {
            "Branco - 6º Kyu",
            "Branco/Amarelo",
            "Amarelo - 5º Kyu",
            "Amarelo/Laranja",
            "Laranja - 4º Kyu",
            "Laranja/Verde",
            "Verde - 3º Kyu",
            "Verde/Azul",
            "Azul - 2º Kyu",
            "Castanho - 1º Kyu",
            "Negro - 1º Dan",
            "Negro - 2º Dan",
            "Negro - 3º Dan",
            "Negro - 4º Dan",
            "Negro - 5º Dan",
            "Branco/Vermelho - 6º Dan",
            "Branco/Vermelho - 7º Dan",
            "Branco/Vermelho - 8º Dan",
            "Vermelho - 9º Dan",
            "Branco - 10º Dan"});
            this.cb_escalao.Location = new System.Drawing.Point(107, 119);
            this.cb_escalao.Name = "cb_escalao";
            this.cb_escalao.Size = new System.Drawing.Size(121, 21);
            this.cb_escalao.TabIndex = 74;
            // 
            // cb_graduacao
            // 
            this.cb_graduacao.FormattingEnabled = true;
            this.cb_graduacao.Items.AddRange(new object[] {
            "Branco - 6º Kyu",
            "Branco/Amarelo",
            "Amarelo - 5º Kyu",
            "Amarelo/Laranja",
            "Laranja - 4º Kyu",
            "Laranja/Verde",
            "Verde - 3º Kyu",
            "Verde/Azul",
            "Azul - 2º Kyu",
            "Castanho - 1º Kyu",
            "Negro - 1º Dan",
            "Negro - 2º Dan",
            "Negro - 3º Dan",
            "Negro - 4º Dan",
            "Negro - 5º Dan",
            "Branco/Vermelho - 6º Dan",
            "Branco/Vermelho - 7º Dan",
            "Branco/Vermelho - 8º Dan",
            "Vermelho - 9º Dan",
            "Branco - 10º Dan"});
            this.cb_graduacao.Location = new System.Drawing.Point(107, 92);
            this.cb_graduacao.Name = "cb_graduacao";
            this.cb_graduacao.Size = new System.Drawing.Size(121, 21);
            this.cb_graduacao.TabIndex = 75;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 95);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 13);
            this.label28.TabIndex = 72;
            this.label28.Text = "Graduação";
            // 
            // pb_fotoAtleta
            // 
            this.pb_fotoAtleta.Location = new System.Drawing.Point(531, 22);
            this.pb_fotoAtleta.Name = "pb_fotoAtleta";
            this.pb_fotoAtleta.Size = new System.Drawing.Size(100, 133);
            this.pb_fotoAtleta.TabIndex = 71;
            this.pb_fotoAtleta.TabStop = false;
            // 
            // tb_licFederativa
            // 
            this.tb_licFederativa.Location = new System.Drawing.Point(329, 22);
            this.tb_licFederativa.Name = "tb_licFederativa";
            this.tb_licFederativa.Size = new System.Drawing.Size(74, 20);
            this.tb_licFederativa.TabIndex = 68;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(107, 66);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(401, 20);
            this.tb_nome.TabIndex = 69;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(107, 22);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 20);
            this.textBox6.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Licença Federativa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Nº Registo";
            // 
            // FichaClassificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 452);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtp_dataRevalidacao);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cb_clube);
            this.Controls.Add(this.cb_escalao);
            this.Controls.Add(this.cb_graduacao);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.pb_fotoAtleta);
            this.Controls.Add(this.tb_licFederativa);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "FichaClassificacoes";
            this.Text = "FichaClassificacoes";
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAtleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader licFederativa;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader classificacao;
        private System.Windows.Forms.ColumnHeader categoriaPeso;
        private System.Windows.Forms.ColumnHeader tipoProva;
        private System.Windows.Forms.DateTimePicker dtp_dataRevalidacao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_clube;
        private System.Windows.Forms.ComboBox cb_escalao;
        private System.Windows.Forms.ComboBox cb_graduacao;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pb_fotoAtleta;
        private System.Windows.Forms.TextBox tb_licFederativa;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}