﻿
namespace CombatTracker
{
    partial class CombatTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombatTracker));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Val = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_Unconcious = new System.Windows.Forms.Button();
            this.btn_Stunned = new System.Windows.Forms.Button();
            this.btn_Restrained = new System.Windows.Forms.Button();
            this.btn_Prone = new System.Windows.Forms.Button();
            this.btn_Poisoned = new System.Windows.Forms.Button();
            this.btn_Petrified = new System.Windows.Forms.Button();
            this.btn_Paralyzed = new System.Windows.Forms.Button();
            this.btn_Invisible = new System.Windows.Forms.Button();
            this.btn_Incapacitated = new System.Windows.Forms.Button();
            this.btn_Grappled = new System.Windows.Forms.Button();
            this.btn_Frightened = new System.Windows.Forms.Button();
            this.btn_Deaf = new System.Windows.Forms.Button();
            this.btn_Charmed = new System.Windows.Forms.Button();
            this.btn_Blinded = new System.Windows.Forms.Button();
            this.btn_Kill = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Heal = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Dmg = new System.Windows.Forms.Button();
            this.col_Init = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Init,
            this.col_Name,
            this.col_HP,
            this.col_Status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(667, 333);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // tb_Val
            // 
            this.tb_Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Val.Location = new System.Drawing.Point(499, 12);
            this.tb_Val.Name = "tb_Val";
            this.tb_Val.Size = new System.Drawing.Size(156, 20);
            this.tb_Val.TabIndex = 18;
            this.tb_Val.TabStop = false;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Location = new System.Drawing.Point(626, 193);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(25, 25);
            this.button14.TabIndex = 34;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btn_Unconcious
            // 
            this.btn_Unconcious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Unconcious.Image = global::CombatTracker.Properties.Resources.zzz_sleep_symbol;
            this.btn_Unconcious.Location = new System.Drawing.Point(595, 193);
            this.btn_Unconcious.Name = "btn_Unconcious";
            this.btn_Unconcious.Size = new System.Drawing.Size(25, 25);
            this.btn_Unconcious.TabIndex = 33;
            this.btn_Unconcious.UseVisualStyleBackColor = true;
            this.btn_Unconcious.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Stunned
            // 
            this.btn_Stunned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stunned.Image = global::CombatTracker.Properties.Resources.flashbang;
            this.btn_Stunned.Location = new System.Drawing.Point(563, 193);
            this.btn_Stunned.Name = "btn_Stunned";
            this.btn_Stunned.Size = new System.Drawing.Size(25, 25);
            this.btn_Stunned.TabIndex = 32;
            this.btn_Stunned.UseVisualStyleBackColor = true;
            this.btn_Stunned.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Restrained
            // 
            this.btn_Restrained.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restrained.Image = global::CombatTracker.Properties.Resources.rope;
            this.btn_Restrained.Location = new System.Drawing.Point(531, 193);
            this.btn_Restrained.Name = "btn_Restrained";
            this.btn_Restrained.Size = new System.Drawing.Size(25, 25);
            this.btn_Restrained.TabIndex = 31;
            this.btn_Restrained.UseVisualStyleBackColor = true;
            this.btn_Restrained.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Prone
            // 
            this.btn_Prone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Prone.Image = global::CombatTracker.Properties.Resources.no_racism;
            this.btn_Prone.Location = new System.Drawing.Point(499, 193);
            this.btn_Prone.Name = "btn_Prone";
            this.btn_Prone.Size = new System.Drawing.Size(25, 25);
            this.btn_Prone.TabIndex = 30;
            this.btn_Prone.UseVisualStyleBackColor = true;
            this.btn_Prone.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Poisoned
            // 
            this.btn_Poisoned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Poisoned.Image = global::CombatTracker.Properties.Resources.poison;
            this.btn_Poisoned.Location = new System.Drawing.Point(626, 162);
            this.btn_Poisoned.Name = "btn_Poisoned";
            this.btn_Poisoned.Size = new System.Drawing.Size(25, 25);
            this.btn_Poisoned.TabIndex = 29;
            this.btn_Poisoned.UseVisualStyleBackColor = true;
            this.btn_Poisoned.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Petrified
            // 
            this.btn_Petrified.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Petrified.Image = global::CombatTracker.Properties.Resources.granite;
            this.btn_Petrified.Location = new System.Drawing.Point(595, 162);
            this.btn_Petrified.Name = "btn_Petrified";
            this.btn_Petrified.Size = new System.Drawing.Size(25, 25);
            this.btn_Petrified.TabIndex = 28;
            this.btn_Petrified.UseVisualStyleBackColor = true;
            this.btn_Petrified.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Paralyzed
            // 
            this.btn_Paralyzed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Paralyzed.Image = global::CombatTracker.Properties.Resources.thunder;
            this.btn_Paralyzed.Location = new System.Drawing.Point(563, 162);
            this.btn_Paralyzed.Name = "btn_Paralyzed";
            this.btn_Paralyzed.Size = new System.Drawing.Size(25, 25);
            this.btn_Paralyzed.TabIndex = 27;
            this.btn_Paralyzed.UseVisualStyleBackColor = true;
            this.btn_Paralyzed.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Invisible
            // 
            this.btn_Invisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Invisible.Image = global::CombatTracker.Properties.Resources.invisibility;
            this.btn_Invisible.Location = new System.Drawing.Point(531, 162);
            this.btn_Invisible.Name = "btn_Invisible";
            this.btn_Invisible.Size = new System.Drawing.Size(25, 25);
            this.btn_Invisible.TabIndex = 26;
            this.btn_Invisible.UseVisualStyleBackColor = true;
            this.btn_Invisible.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Incapacitated
            // 
            this.btn_Incapacitated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Incapacitated.Image = global::CombatTracker.Properties.Resources.forbidden;
            this.btn_Incapacitated.Location = new System.Drawing.Point(499, 162);
            this.btn_Incapacitated.Name = "btn_Incapacitated";
            this.btn_Incapacitated.Size = new System.Drawing.Size(25, 25);
            this.btn_Incapacitated.TabIndex = 25;
            this.btn_Incapacitated.UseVisualStyleBackColor = true;
            this.btn_Incapacitated.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Grappled
            // 
            this.btn_Grappled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Grappled.Image = global::CombatTracker.Properties.Resources.hello;
            this.btn_Grappled.Location = new System.Drawing.Point(627, 131);
            this.btn_Grappled.Name = "btn_Grappled";
            this.btn_Grappled.Size = new System.Drawing.Size(25, 25);
            this.btn_Grappled.TabIndex = 24;
            this.btn_Grappled.UseVisualStyleBackColor = true;
            this.btn_Grappled.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Frightened
            // 
            this.btn_Frightened.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Frightened.Image = global::CombatTracker.Properties.Resources.black_cat;
            this.btn_Frightened.Location = new System.Drawing.Point(595, 131);
            this.btn_Frightened.Name = "btn_Frightened";
            this.btn_Frightened.Size = new System.Drawing.Size(25, 25);
            this.btn_Frightened.TabIndex = 23;
            this.btn_Frightened.UseVisualStyleBackColor = true;
            this.btn_Frightened.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Deaf
            // 
            this.btn_Deaf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Deaf.Image = global::CombatTracker.Properties.Resources.deaf;
            this.btn_Deaf.Location = new System.Drawing.Point(563, 131);
            this.btn_Deaf.Name = "btn_Deaf";
            this.btn_Deaf.Size = new System.Drawing.Size(25, 25);
            this.btn_Deaf.TabIndex = 22;
            this.btn_Deaf.UseVisualStyleBackColor = true;
            this.btn_Deaf.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Charmed
            // 
            this.btn_Charmed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Charmed.Image = global::CombatTracker.Properties.Resources.love;
            this.btn_Charmed.Location = new System.Drawing.Point(531, 131);
            this.btn_Charmed.Name = "btn_Charmed";
            this.btn_Charmed.Size = new System.Drawing.Size(25, 25);
            this.btn_Charmed.TabIndex = 21;
            this.btn_Charmed.UseVisualStyleBackColor = true;
            this.btn_Charmed.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Blinded
            // 
            this.btn_Blinded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Blinded.Image = global::CombatTracker.Properties.Resources.hide;
            this.btn_Blinded.Location = new System.Drawing.Point(499, 131);
            this.btn_Blinded.Name = "btn_Blinded";
            this.btn_Blinded.Size = new System.Drawing.Size(25, 25);
            this.btn_Blinded.TabIndex = 20;
            this.btn_Blinded.UseVisualStyleBackColor = true;
            this.btn_Blinded.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Kill
            // 
            this.btn_Kill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kill.Image = global::CombatTracker.Properties.Resources.skull;
            this.btn_Kill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kill.Location = new System.Drawing.Point(499, 67);
            this.btn_Kill.Name = "btn_Kill";
            this.btn_Kill.Size = new System.Drawing.Size(156, 23);
            this.btn_Kill.TabIndex = 19;
            this.btn_Kill.TabStop = false;
            this.btn_Kill.Text = "Kill / Ressurect";
            this.btn_Kill.UseVisualStyleBackColor = true;
            this.btn_Kill.Click += new System.EventHandler(this.btn_Kill_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.Image = global::CombatTracker.Properties.Resources.remove;
            this.btn_Remove.Location = new System.Drawing.Point(580, 263);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 26);
            this.btn_Remove.TabIndex = 13;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Image = global::CombatTracker.Properties.Resources.add;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(499, 263);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 26);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Image = global::CombatTracker.Properties.Resources.undo;
            this.btn_Reset.Location = new System.Drawing.Point(580, 295);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 26);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Heal
            // 
            this.btn_Heal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Heal.Image = global::CombatTracker.Properties.Resources.healing;
            this.btn_Heal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Heal.Location = new System.Drawing.Point(580, 38);
            this.btn_Heal.Name = "btn_Heal";
            this.btn_Heal.Size = new System.Drawing.Size(75, 23);
            this.btn_Heal.TabIndex = 17;
            this.btn_Heal.TabStop = false;
            this.btn_Heal.Text = "Heal";
            this.btn_Heal.UseVisualStyleBackColor = true;
            this.btn_Heal.Click += new System.EventHandler(this.btn_Heal_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Modify.Image = global::CombatTracker.Properties.Resources.edit;
            this.btn_Modify.Location = new System.Drawing.Point(499, 295);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 26);
            this.btn_Modify.TabIndex = 14;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Dmg
            // 
            this.btn_Dmg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dmg.Image = global::CombatTracker.Properties.Resources.swords;
            this.btn_Dmg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dmg.Location = new System.Drawing.Point(499, 38);
            this.btn_Dmg.Name = "btn_Dmg";
            this.btn_Dmg.Size = new System.Drawing.Size(75, 23);
            this.btn_Dmg.TabIndex = 16;
            this.btn_Dmg.TabStop = false;
            this.btn_Dmg.Text = "Damage";
            this.btn_Dmg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dmg.UseVisualStyleBackColor = true;
            this.btn_Dmg.Click += new System.EventHandler(this.btn_Dmg_Click);
            // 
            // col_Init
            // 
            this.col_Init.HeaderText = "Initiative";
            this.col_Init.Name = "col_Init";
            this.col_Init.ReadOnly = true;
            this.col_Init.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            this.col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_HP
            // 
            this.col_HP.HeaderText = "HP";
            this.col_HP.Name = "col_HP";
            this.col_HP.ReadOnly = true;
            this.col_HP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Status
            // 
            this.col_Status.HeaderText = "Status";
            this.col_Status.Name = "col_Status";
            this.col_Status.ReadOnly = true;
            this.col_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CombatTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 333);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btn_Unconcious);
            this.Controls.Add(this.btn_Stunned);
            this.Controls.Add(this.btn_Restrained);
            this.Controls.Add(this.btn_Prone);
            this.Controls.Add(this.btn_Poisoned);
            this.Controls.Add(this.btn_Petrified);
            this.Controls.Add(this.btn_Paralyzed);
            this.Controls.Add(this.btn_Invisible);
            this.Controls.Add(this.btn_Incapacitated);
            this.Controls.Add(this.btn_Grappled);
            this.Controls.Add(this.btn_Frightened);
            this.Controls.Add(this.btn_Deaf);
            this.Controls.Add(this.btn_Charmed);
            this.Controls.Add(this.btn_Blinded);
            this.Controls.Add(this.btn_Kill);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Val);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Heal);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Dmg);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CombatTracker";
            this.Text = "Combat Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Val;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Heal;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Dmg;
        private System.Windows.Forms.Button btn_Kill;
        private System.Windows.Forms.Button btn_Blinded;
        private System.Windows.Forms.Button btn_Charmed;
        private System.Windows.Forms.Button btn_Deaf;
        private System.Windows.Forms.Button btn_Frightened;
        private System.Windows.Forms.Button btn_Grappled;
        private System.Windows.Forms.Button btn_Incapacitated;
        private System.Windows.Forms.Button btn_Invisible;
        private System.Windows.Forms.Button btn_Paralyzed;
        private System.Windows.Forms.Button btn_Petrified;
        private System.Windows.Forms.Button btn_Poisoned;
        private System.Windows.Forms.Button btn_Prone;
        private System.Windows.Forms.Button btn_Restrained;
        private System.Windows.Forms.Button btn_Stunned;
        private System.Windows.Forms.Button btn_Unconcious;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Init;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HP;
        private System.Windows.Forms.DataGridViewImageColumn col_Status;
    }
}

