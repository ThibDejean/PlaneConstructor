namespace PlaneConstructor.View
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.L_DO = new System.Windows.Forms.Label();
            this.L_cost = new System.Windows.Forms.Label();
            this.L_Costpres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Charger Poignée Gaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(148, 66);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(584, 308);
            this.treeView1.TabIndex = 1;
            // 
            // L_DO
            // 
            this.L_DO.AutoSize = true;
            this.L_DO.Location = new System.Drawing.Point(786, 55);
            this.L_DO.Name = "L_DO";
            this.L_DO.Size = new System.Drawing.Size(35, 13);
            this.L_DO.TabIndex = 2;
            this.L_DO.Text = "label1";
            // 
            // L_cost
            // 
            this.L_cost.AutoSize = true;
            this.L_cost.Location = new System.Drawing.Point(789, 104);
            this.L_cost.Name = "L_cost";
            this.L_cost.Size = new System.Drawing.Size(35, 13);
            this.L_cost.TabIndex = 3;
            this.L_cost.Text = "label1";
            // 
            // L_Costpres
            // 
            this.L_Costpres.AutoSize = true;
            this.L_Costpres.Location = new System.Drawing.Point(792, 163);
            this.L_Costpres.Name = "L_Costpres";
            this.L_Costpres.Size = new System.Drawing.Size(35, 13);
            this.L_Costpres.TabIndex = 4;
            this.L_Costpres.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 443);
            this.Controls.Add(this.L_Costpres);
            this.Controls.Add(this.L_cost);
            this.Controls.Add(this.L_DO);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label L_DO;
        private System.Windows.Forms.Label L_cost;
        private System.Windows.Forms.Label L_Costpres;
    }
}

