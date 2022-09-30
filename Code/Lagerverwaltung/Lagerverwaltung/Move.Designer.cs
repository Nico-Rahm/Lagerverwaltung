namespace Lagerverwaltung
{
    partial class Move
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
            this.textBox_room = new System.Windows.Forms.TextBox();
            this.textBox_shelf = new System.Windows.Forms.TextBox();
            this.textBox_part = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_room
            // 
            this.textBox_room.Location = new System.Drawing.Point(93, 12);
            this.textBox_room.Name = "textBox_room";
            this.textBox_room.Size = new System.Drawing.Size(100, 23);
            this.textBox_room.TabIndex = 0;
            // 
            // textBox_shelf
            // 
            this.textBox_shelf.Location = new System.Drawing.Point(93, 41);
            this.textBox_shelf.Name = "textBox_shelf";
            this.textBox_shelf.Size = new System.Drawing.Size(100, 23);
            this.textBox_shelf.TabIndex = 1;
            // 
            // textBox_part
            // 
            this.textBox_part.Location = new System.Drawing.Point(93, 70);
            this.textBox_part.Name = "textBox_part";
            this.textBox_part.Size = new System.Drawing.Size(100, 23);
            this.textBox_part.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fach";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(118, 99);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 6;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 138);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_part);
            this.Controls.Add(this.textBox_shelf);
            this.Controls.Add(this.textBox_room);
            this.Name = "Move";
            this.Text = "Move";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_room;
        private TextBox textBox_shelf;
        private TextBox textBox_part;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_ok;
    }
}