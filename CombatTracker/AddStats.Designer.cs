
namespace CombatTracker
{
    partial class AddStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStats));
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Init = new System.Windows.Forms.TextBox();
            this.lb_Init = new System.Windows.Forms.Label();
            this.tb_PF = new System.Windows.Forms.TextBox();
            this.lb_PF = new System.Windows.Forms.Label();
            this.btn_Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(62, 26);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(38, 13);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome:";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(65, 42);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(100, 20);
            this.tb_Nome.TabIndex = 1;
            // 
            // tb_Init
            // 
            this.tb_Init.Location = new System.Drawing.Point(65, 82);
            this.tb_Init.Name = "tb_Init";
            this.tb_Init.Size = new System.Drawing.Size(100, 20);
            this.tb_Init.TabIndex = 2;
            // 
            // lb_Init
            // 
            this.lb_Init.AutoSize = true;
            this.lb_Init.Location = new System.Drawing.Point(62, 66);
            this.lb_Init.Name = "lb_Init";
            this.lb_Init.Size = new System.Drawing.Size(51, 13);
            this.lb_Init.TabIndex = 2;
            this.lb_Init.Text = "Iniziativa:";
            // 
            // tb_PF
            // 
            this.tb_PF.Location = new System.Drawing.Point(65, 121);
            this.tb_PF.Name = "tb_PF";
            this.tb_PF.Size = new System.Drawing.Size(100, 20);
            this.tb_PF.TabIndex = 3;
            // 
            // lb_PF
            // 
            this.lb_PF.AutoSize = true;
            this.lb_PF.Location = new System.Drawing.Point(62, 105);
            this.lb_PF.Name = "lb_PF";
            this.lb_PF.Size = new System.Drawing.Size(60, 13);
            this.lb_PF.TabIndex = 4;
            this.lb_PF.Text = "Punti ferita:";
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(65, 153);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(100, 23);
            this.btn_Done.TabIndex = 4;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // Aggiungi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.tb_PF);
            this.Controls.Add(this.lb_PF);
            this.Controls.Add(this.tb_Init);
            this.Controls.Add(this.lb_Init);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aggiungi";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Combat Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Init;
        private System.Windows.Forms.Label lb_Init;
        private System.Windows.Forms.TextBox tb_PF;
        private System.Windows.Forms.Label lb_PF;
        private System.Windows.Forms.Button btn_Done;
    }
}