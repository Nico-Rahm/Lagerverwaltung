namespace Lagerverwaltung
{
    partial class Storemanagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_id = new System.Windows.Forms.RadioButton();
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.button_search = new System.Windows.Forms.Button();
            this.button_take = new System.Windows.Forms.Button();
            this.button_store = new System.Windows.Forms.Button();
            this.button_move = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suchen nach ...";
            // 
            // radioButton_id
            // 
            this.radioButton_id.AutoSize = true;
            this.radioButton_id.Location = new System.Drawing.Point(12, 27);
            this.radioButton_id.Name = "radioButton_id";
            this.radioButton_id.Size = new System.Drawing.Size(36, 19);
            this.radioButton_id.TabIndex = 2;
            this.radioButton_id.TabStop = true;
            this.radioButton_id.Text = "ID";
            this.radioButton_id.UseVisualStyleBackColor = true;
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Location = new System.Drawing.Point(12, 52);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(57, 19);
            this.radioButton_name.TabIndex = 3;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.Text = "Name";
            this.radioButton_name.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(671, 12);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(90, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Suche";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_take
            // 
            this.button_take.Location = new System.Drawing.Point(794, 12);
            this.button_take.Name = "button_take";
            this.button_take.Size = new System.Drawing.Size(75, 23);
            this.button_take.TabIndex = 5;
            this.button_take.Text = "Auslagern";
            this.button_take.UseVisualStyleBackColor = true;
            this.button_take.Click += new System.EventHandler(this.button_take_Click);
            // 
            // button_store
            // 
            this.button_store.Location = new System.Drawing.Point(794, 70);
            this.button_store.Name = "button_store";
            this.button_store.Size = new System.Drawing.Size(75, 23);
            this.button_store.TabIndex = 6;
            this.button_store.Text = "Einlagern";
            this.button_store.UseVisualStyleBackColor = true;
            this.button_store.Click += new System.EventHandler(this.button_store_Click);
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(794, 41);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(75, 23);
            this.button_move.TabIndex = 7;
            this.button_move.Text = "Verlegen";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Artikel,
            this.Variante,
            this.Anzahl,
            this.Raum,
            this.Regal,
            this.Fach});
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(749, 361);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Artikel
            // 
            this.Artikel.HeaderText = "Artikel";
            this.Artikel.Name = "Artikel";
            this.Artikel.ReadOnly = true;
            // 
            // Variante
            // 
            this.Variante.HeaderText = "Variante";
            this.Variante.Name = "Variante";
            this.Variante.ReadOnly = true;
            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            // 
            // Raum
            // 
            this.Raum.HeaderText = "Raum";
            this.Raum.Name = "Raum";
            this.Raum.ReadOnly = true;
            // 
            // Regal
            // 
            this.Regal.HeaderText = "Regal";
            this.Regal.Name = "Regal";
            this.Regal.ReadOnly = true;
            // 
            // Fach
            // 
            this.Fach.HeaderText = "Fach";
            this.Fach.Name = "Fach";
            this.Fach.ReadOnly = true;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(105, 13);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(560, 23);
            this.textBox_search.TabIndex = 9;
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(794, 99);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(75, 23);
            this.button_new.TabIndex = 10;
            this.button_new.Text = "Neu";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // Storagemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.button_store);
            this.Controls.Add(this.button_take);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.radioButton_name);
            this.Controls.Add(this.radioButton_id);
            this.Controls.Add(this.label1);
            this.Name = "Storagemanagement";
            this.Text = "Lagerverwaltung";
            this.Load += new System.EventHandler(this.Storemagemanagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private RadioButton radioButton_id;
        private RadioButton radioButton_name;
        private Button button_search;
        private Button button_take;
        private Button button_store;
        private Button button_move;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Artikel;
        private DataGridViewTextBoxColumn Variante;
        private DataGridViewTextBoxColumn Anzahl;
        private DataGridViewTextBoxColumn Raum;
        private DataGridViewTextBoxColumn Regal;
        private DataGridViewTextBoxColumn Fach;
        private TextBox textBox_search;
        private Button button_new;
    }
}