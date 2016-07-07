namespace PrototipoFuncionalClubeDeJudoDragao.Actualizações
{
    partial class ProcurarAtleta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.gb_opcoes = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rb_porNumero = new System.Windows.Forms.RadioButton();
            this.rb_porNome = new System.Windows.Forms.RadioButton();
            this.rb_porLicFederativa = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gb_opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(197, 81);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(197, 46);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 3;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // gb_opcoes
            // 
            this.gb_opcoes.Controls.Add(this.rb_porLicFederativa);
            this.gb_opcoes.Controls.Add(this.radioButton4);
            this.gb_opcoes.Controls.Add(this.rb_porNumero);
            this.gb_opcoes.Controls.Add(this.rb_porNome);
            this.gb_opcoes.Location = new System.Drawing.Point(13, 13);
            this.gb_opcoes.Name = "gb_opcoes";
            this.gb_opcoes.Size = new System.Drawing.Size(178, 93);
            this.gb_opcoes.TabIndex = 4;
            this.gb_opcoes.TabStop = false;
            this.gb_opcoes.Text = "Opções";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 62);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton1";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rb_porNumero
            // 
            this.rb_porNumero.AutoSize = true;
            this.rb_porNumero.Location = new System.Drawing.Point(6, 39);
            this.rb_porNumero.Name = "rb_porNumero";
            this.rb_porNumero.Size = new System.Drawing.Size(81, 17);
            this.rb_porNumero.TabIndex = 0;
            this.rb_porNumero.TabStop = true;
            this.rb_porNumero.Text = "Por Número";
            this.rb_porNumero.UseVisualStyleBackColor = true;
            // 
            // rb_porNome
            // 
            this.rb_porNome.AutoSize = true;
            this.rb_porNome.Location = new System.Drawing.Point(7, 16);
            this.rb_porNome.Name = "rb_porNome";
            this.rb_porNome.Size = new System.Drawing.Size(72, 17);
            this.rb_porNome.TabIndex = 0;
            this.rb_porNome.TabStop = true;
            this.rb_porNome.Text = "Por Nome";
            this.rb_porNome.UseVisualStyleBackColor = true;
            // 
            // rb_porLicFederativa
            // 
            this.rb_porLicFederativa.AutoSize = true;
            this.rb_porLicFederativa.Location = new System.Drawing.Point(7, 62);
            this.rb_porLicFederativa.Name = "rb_porLicFederativa";
            this.rb_porLicFederativa.Size = new System.Drawing.Size(135, 17);
            this.rb_porLicFederativa.TabIndex = 0;
            this.rb_porLicFederativa.TabStop = true;
            this.rb_porLicFederativa.Text = "Por Licença Federativa";
            this.rb_porLicFederativa.UseVisualStyleBackColor = true;
            // 
            // ProcurarAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.gb_opcoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_cancelar);
            this.Name = "ProcurarAtleta";
            this.Text = "Opçoes de Pesquisa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_opcoes.ResumeLayout(false);
            this.gb_opcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gb_opcoes;
        private System.Windows.Forms.RadioButton rb_porLicFederativa;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rb_porNumero;
        private System.Windows.Forms.RadioButton rb_porNome;
    }
}