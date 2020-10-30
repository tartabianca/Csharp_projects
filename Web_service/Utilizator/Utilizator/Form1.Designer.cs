namespace Utilizator
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ok_update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.update_shop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.update_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.update_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.update_prod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.update_id = new System.Windows.Forms.TextBox();
            this.ok_insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_shop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insert_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insert_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insert_prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lidl",
            "Profi",
            "Penny",
            "Kaufland"});
            this.comboBox1.Location = new System.Drawing.Point(32, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(33, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 202);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.SystemColors.Control;
            this.insert.Location = new System.Drawing.Point(175, 175);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(86, 31);
            this.insert.TabIndex = 2;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.RoyalBlue;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.Control;
            this.update.Location = new System.Drawing.Point(175, 213);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 30);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.Control;
            this.delete.Location = new System.Drawing.Point(175, 250);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 30);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ok_insert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.insert_shop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.insert_price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.insert_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.insert_prod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insert_id);
            this.groupBox1.Location = new System.Drawing.Point(276, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ok_update);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.update_shop);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.update_price);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.update_no);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.update_prod);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.update_id);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 244);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // ok_update
            // 
            this.ok_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.ok_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_update.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_update.ForeColor = System.Drawing.SystemColors.Control;
            this.ok_update.Location = new System.Drawing.Point(86, 204);
            this.ok_update.Name = "ok_update";
            this.ok_update.Size = new System.Drawing.Size(86, 26);
            this.ok_update.TabIndex = 6;
            this.ok_update.Text = "Update";
            this.ok_update.UseVisualStyleBackColor = false;
            this.ok_update.Click += new System.EventHandler(this.ok_update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Magazin";
            // 
            // update_shop
            // 
            this.update_shop.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_shop.Location = new System.Drawing.Point(109, 162);
            this.update_shop.Name = "update_shop";
            this.update_shop.Size = new System.Drawing.Size(133, 29);
            this.update_shop.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pret:";
            // 
            // update_price
            // 
            this.update_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_price.Location = new System.Drawing.Point(108, 124);
            this.update_price.Name = "update_price";
            this.update_price.Size = new System.Drawing.Size(133, 29);
            this.update_price.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Numar:";
            // 
            // update_no
            // 
            this.update_no.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_no.Location = new System.Drawing.Point(108, 88);
            this.update_no.Name = "update_no";
            this.update_no.Size = new System.Drawing.Size(133, 29);
            this.update_no.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Produs:";
            // 
            // update_prod
            // 
            this.update_prod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_prod.Location = new System.Drawing.Point(108, 53);
            this.update_prod.Name = "update_prod";
            this.update_prod.Size = new System.Drawing.Size(133, 29);
            this.update_prod.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Id:";
            // 
            // update_id
            // 
            this.update_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_id.Location = new System.Drawing.Point(108, 18);
            this.update_id.Name = "update_id";
            this.update_id.Size = new System.Drawing.Size(133, 29);
            this.update_id.TabIndex = 0;
            // 
            // ok_insert
            // 
            this.ok_insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.ok_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok_insert.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_insert.ForeColor = System.Drawing.SystemColors.Control;
            this.ok_insert.Location = new System.Drawing.Point(86, 204);
            this.ok_insert.Name = "ok_insert";
            this.ok_insert.Size = new System.Drawing.Size(73, 26);
            this.ok_insert.TabIndex = 6;
            this.ok_insert.Text = "Insert";
            this.ok_insert.UseVisualStyleBackColor = false;
            this.ok_insert.Click += new System.EventHandler(this.ok_insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Magazin";
            // 
            // insert_shop
            // 
            this.insert_shop.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_shop.Location = new System.Drawing.Point(109, 162);
            this.insert_shop.Name = "insert_shop";
            this.insert_shop.Size = new System.Drawing.Size(133, 29);
            this.insert_shop.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pret:";
            // 
            // insert_price
            // 
            this.insert_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_price.Location = new System.Drawing.Point(108, 124);
            this.insert_price.Name = "insert_price";
            this.insert_price.Size = new System.Drawing.Size(133, 29);
            this.insert_price.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numar:";
            // 
            // insert_no
            // 
            this.insert_no.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_no.Location = new System.Drawing.Point(108, 88);
            this.insert_no.Name = "insert_no";
            this.insert_no.Size = new System.Drawing.Size(133, 29);
            this.insert_no.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produs:";
            // 
            // insert_prod
            // 
            this.insert_prod.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_prod.Location = new System.Drawing.Point(108, 53);
            this.insert_prod.Name = "insert_prod";
            this.insert_prod.Size = new System.Drawing.Size(133, 29);
            this.insert_prod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // insert_id
            // 
            this.insert_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_id.Location = new System.Drawing.Point(108, 18);
            this.insert_id.Name = "insert_id";
            this.insert_id.Size = new System.Drawing.Size(133, 29);
            this.insert_id.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(554, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ok_insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox insert_shop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insert_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox insert_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insert_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insert_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ok_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox update_shop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox update_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox update_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox update_prod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox update_id;
    }
}

