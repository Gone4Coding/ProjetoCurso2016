namespace PrototipoFuncionalClubeDeJudoDragao.Listagens.Listas
{
    partial class ParticipacoesPorLicencaLista
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
            this.SuspendLayout();
            // 
            // bt_retroceder
            // 
            this.bt_retroceder.Location = new System.Drawing.Point(280, 12);
            this.bt_retroceder.Name = "bt_retroceder";
            this.bt_retroceder.Size = new System.Drawing.Size(75, 23);
            this.bt_retroceder.TabIndex = 0;
            this.bt_retroceder.Text = "Retroceder";
            this.bt_retroceder.UseVisualStyleBackColor = true;
            this.bt_retroceder.Click += new System.EventHandler(this.bt_retroceder_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 174);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ParticipacoesPorLicencaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 231);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_retroceder);
            this.Name = "ParticipacoesPorLicencaLista";
            this.Text = "ParticipacoesPorLicencaLista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_retroceder;
        private System.Windows.Forms.ListView listView1;
    }
}