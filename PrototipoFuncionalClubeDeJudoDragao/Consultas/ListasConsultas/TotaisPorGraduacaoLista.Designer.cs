﻿namespace PrototipoFuncionalClubeDeJudoDragao.Consultas
{
    partial class TotaisPorGraduacaoLista
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
            this.graduacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bt_retroceder
            // 
            this.bt_retroceder.Location = new System.Drawing.Point(81, 12);
            this.bt_retroceder.Name = "bt_retroceder";
            this.bt_retroceder.Size = new System.Drawing.Size(75, 23);
            this.bt_retroceder.TabIndex = 3;
            this.bt_retroceder.Text = "Retroceder";
            this.bt_retroceder.UseVisualStyleBackColor = true;
            this.bt_retroceder.Click += new System.EventHandler(this.bt_retroceder_Click);
            // 
            // lv_provas
            // 
            this.lv_provas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.graduacao,
            this.total});
            this.lv_provas.Location = new System.Drawing.Point(12, 44);
            this.lv_provas.Name = "lv_provas";
            this.lv_provas.Size = new System.Drawing.Size(144, 204);
            this.lv_provas.TabIndex = 2;
            this.lv_provas.UseCompatibleStateImageBehavior = false;
            this.lv_provas.View = System.Windows.Forms.View.Details;
            // 
            // graduacao
            // 
            this.graduacao.Text = "Graduação";
            this.graduacao.Width = 90;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 44;
            // 
            // TotaisPorGraduacaoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 284);
            this.Controls.Add(this.bt_retroceder);
            this.Controls.Add(this.lv_provas);
            this.Name = "TotaisPorGraduacaoLista";
            this.Text = "TotaisPorGraduacaoLista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_retroceder;
        private System.Windows.Forms.ListView lv_provas;
        private System.Windows.Forms.ColumnHeader graduacao;
        private System.Windows.Forms.ColumnHeader total;
    }
}