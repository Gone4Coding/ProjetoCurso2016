namespace PrototipoFuncionalClubeDeJudoDragao.Consultas
{
    partial class ClassificacaoDatasProva
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
            this.gb_DataProva = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_cancelarG = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_DataProva.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DataProva
            // 
            this.gb_DataProva.Controls.Add(this.label6);
            this.gb_DataProva.Controls.Add(this.dtp_Inicio);
            this.gb_DataProva.Controls.Add(this.label4);
            this.gb_DataProva.Controls.Add(this.label3);
            this.gb_DataProva.Location = new System.Drawing.Point(12, 12);
            this.gb_DataProva.Name = "gb_DataProva";
            this.gb_DataProva.Size = new System.Drawing.Size(167, 63);
            this.gb_DataProva.TabIndex = 27;
            this.gb_DataProva.TabStop = false;
            this.gb_DataProva.Text = "Data da Prova";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-428, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Início";
            // 
            // dtp_Inicio
            // 
            this.dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Inicio.Location = new System.Drawing.Point(51, 25);
            this.dtp_Inicio.Name = "dtp_Inicio";
            this.dtp_Inicio.Size = new System.Drawing.Size(99, 20);
            this.dtp_Inicio.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-176, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Início";
            // 
            // bt_cancelarG
            // 
            this.bt_cancelarG.Location = new System.Drawing.Point(197, 52);
            this.bt_cancelarG.Name = "bt_cancelarG";
            this.bt_cancelarG.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelarG.TabIndex = 29;
            this.bt_cancelarG.Text = "Cancelar";
            this.bt_cancelarG.UseVisualStyleBackColor = true;
            this.bt_cancelarG.Click += new System.EventHandler(this.bt_cancelarG_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(197, 12);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 30;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // ClassificacaoDatasProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 92);
            this.Controls.Add(this.bt_cancelarG);
            this.Controls.Add(this.gb_DataProva);
            this.Controls.Add(this.bt_ok);
            this.Name = "ClassificacaoDatasProva";
            this.Text = "Opções de Classificção por Prova";
            this.gb_DataProva.ResumeLayout(false);
            this.gb_DataProva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DataProva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_cancelarG;
        private System.Windows.Forms.Button bt_ok;
    }
}