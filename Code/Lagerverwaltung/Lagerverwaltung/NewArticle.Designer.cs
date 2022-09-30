namespace Lagerverwaltung
{
    partial class NewArticle
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_variant = new System.Windows.Forms.TextBox();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.textBox_room = new System.Windows.Forms.TextBox();
            this.textBox_shelf = new System.Windows.Forms.TextBox();
            this.textBox_Part = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(110, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 23);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_variant
            // 
            this.textBox_variant.Location = new System.Drawing.Point(110, 41);
            this.textBox_variant.Name = "textBox_variant";
            this.textBox_variant.Size = new System.Drawing.Size(100, 23);
            this.textBox_variant.TabIndex = 2;
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(110, 70);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(100, 23);
            this.textBox_Count.TabIndex = 3;
            // 
            // textBox_room
            // 
            this.textBox_room.Location = new System.Drawing.Point(110, 99);
            this.textBox_room.Name = "textBox_room";
            this.textBox_room.Size = new System.Drawing.Size(100, 23);
            this.textBox_room.TabIndex = 4;
            // 
            // textBox_shelf
            // 
            this.textBox_shelf.Location = new System.Drawing.Point(110, 128);
            this.textBox_shelf.Name = "textBox_shelf";
            this.textBox_shelf.Size = new System.Drawing.Size(100, 23);
            this.textBox_shelf.TabIndex = 5;
            // 
            // textBox_Part
            // 
            this.textBox_Part.Location = new System.Drawing.Point(110, 157);
            this.textBox_Part.Name = "textBox_Part";
            this.textBox_Part.Size = new System.Drawing.Size(100, 23);
            this.textBox_Part.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Variante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Anzahl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Raum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fach";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(135, 186);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 12;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // NewArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 221);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Part);
            this.Controls.Add(this.textBox_shelf);
            this.Controls.Add(this.textBox_room);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_variant);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Name = "NewArticle";
            this.Text = "NewArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_name;
        private TextBox textBox_variant;
        private TextBox textBox_Count;
        private TextBox textBox_room;
        private TextBox textBox_shelf;
        private TextBox textBox_Part;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_ok;
    }
}