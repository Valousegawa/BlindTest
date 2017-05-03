using System;

namespace Main
{
    partial class form_main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.userControl11 = new Main.UserControlRomain();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(603, 232);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(341, 132);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(219, 150);
            this.userControl11.TabIndex = 1;
            // 
            // form_main
            // 
            this.ClientSize = new System.Drawing.Size(921, 476);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnTest);
            this.Name = "form_main";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button btnTest;
        private UserControlRomain userControl11;
    }
}

