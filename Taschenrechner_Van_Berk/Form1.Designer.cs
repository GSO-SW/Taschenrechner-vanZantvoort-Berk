namespace Taschenrechner_Van_Berk
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.TextBox();
            this.btn_sieben = new System.Windows.Forms.Button();
            this.btn_neun = new System.Windows.Forms.Button();
            this.btn_acht = new System.Windows.Forms.Button();
            this.btn_vier = new System.Windows.Forms.Button();
            this.btn_fünf = new System.Windows.Forms.Button();
            this.btn_sechs = new System.Windows.Forms.Button();
            this.btn_eins = new System.Windows.Forms.Button();
            this.btn_zwei = new System.Windows.Forms.Button();
            this.btn_drei = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Negativ = new System.Windows.Forms.Button();
            this.btn_punkt = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_mal = new System.Windows.Forms.Button();
            this.btn_geteilt = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_klammerauf = new System.Windows.Forms.Button();
            this.btn_klammerzu = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.Rechnunglable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Display.Enabled = false;
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(260, 80);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // btn_sieben
            // 
            this.btn_sieben.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sieben.Location = new System.Drawing.Point(12, 108);
            this.btn_sieben.Name = "btn_sieben";
            this.btn_sieben.Size = new System.Drawing.Size(57, 42);
            this.btn_sieben.TabIndex = 1;
            this.btn_sieben.Text = "7";
            this.btn_sieben.UseVisualStyleBackColor = true;
            this.btn_sieben.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_neun
            // 
            this.btn_neun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_neun.Location = new System.Drawing.Point(138, 108);
            this.btn_neun.Name = "btn_neun";
            this.btn_neun.Size = new System.Drawing.Size(57, 42);
            this.btn_neun.TabIndex = 2;
            this.btn_neun.Text = "9";
            this.btn_neun.UseVisualStyleBackColor = true;
            this.btn_neun.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_acht
            // 
            this.btn_acht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_acht.Location = new System.Drawing.Point(75, 108);
            this.btn_acht.Name = "btn_acht";
            this.btn_acht.Size = new System.Drawing.Size(57, 42);
            this.btn_acht.TabIndex = 3;
            this.btn_acht.Text = "8";
            this.btn_acht.UseVisualStyleBackColor = true;
            this.btn_acht.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_vier
            // 
            this.btn_vier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_vier.Location = new System.Drawing.Point(12, 156);
            this.btn_vier.Name = "btn_vier";
            this.btn_vier.Size = new System.Drawing.Size(57, 42);
            this.btn_vier.TabIndex = 4;
            this.btn_vier.Text = "4";
            this.btn_vier.UseVisualStyleBackColor = true;
            this.btn_vier.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_fünf
            // 
            this.btn_fünf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_fünf.Location = new System.Drawing.Point(75, 156);
            this.btn_fünf.Name = "btn_fünf";
            this.btn_fünf.Size = new System.Drawing.Size(57, 42);
            this.btn_fünf.TabIndex = 5;
            this.btn_fünf.Text = "5";
            this.btn_fünf.UseVisualStyleBackColor = true;
            this.btn_fünf.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_sechs
            // 
            this.btn_sechs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_sechs.Location = new System.Drawing.Point(138, 156);
            this.btn_sechs.Name = "btn_sechs";
            this.btn_sechs.Size = new System.Drawing.Size(57, 42);
            this.btn_sechs.TabIndex = 6;
            this.btn_sechs.Text = "6";
            this.btn_sechs.UseVisualStyleBackColor = true;
            this.btn_sechs.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_eins
            // 
            this.btn_eins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_eins.Location = new System.Drawing.Point(12, 204);
            this.btn_eins.Name = "btn_eins";
            this.btn_eins.Size = new System.Drawing.Size(57, 42);
            this.btn_eins.TabIndex = 7;
            this.btn_eins.Text = "1";
            this.btn_eins.UseVisualStyleBackColor = true;
            this.btn_eins.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_zwei
            // 
            this.btn_zwei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_zwei.Location = new System.Drawing.Point(75, 204);
            this.btn_zwei.Name = "btn_zwei";
            this.btn_zwei.Size = new System.Drawing.Size(57, 42);
            this.btn_zwei.TabIndex = 8;
            this.btn_zwei.Text = "2";
            this.btn_zwei.UseVisualStyleBackColor = true;
            this.btn_zwei.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_drei
            // 
            this.btn_drei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_drei.Location = new System.Drawing.Point(138, 204);
            this.btn_drei.Name = "btn_drei";
            this.btn_drei.Size = new System.Drawing.Size(57, 42);
            this.btn_drei.TabIndex = 9;
            this.btn_drei.Text = "3";
            this.btn_drei.UseVisualStyleBackColor = true;
            this.btn_drei.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_0.Location = new System.Drawing.Point(12, 252);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(57, 42);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_Negativ
            // 
            this.btn_Negativ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Negativ.Location = new System.Drawing.Point(138, 252);
            this.btn_Negativ.Name = "btn_Negativ";
            this.btn_Negativ.Size = new System.Drawing.Size(57, 42);
            this.btn_Negativ.TabIndex = 11;
            this.btn_Negativ.Text = "(-)";
            this.btn_Negativ.UseVisualStyleBackColor = true;
            this.btn_Negativ.Click += new System.EventHandler(this.btn_Negativ_Click);
            // 
            // btn_punkt
            // 
            this.btn_punkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_punkt.Location = new System.Drawing.Point(75, 252);
            this.btn_punkt.Name = "btn_punkt";
            this.btn_punkt.Size = new System.Drawing.Size(57, 42);
            this.btn_punkt.TabIndex = 12;
            this.btn_punkt.Text = ",";
            this.btn_punkt.UseVisualStyleBackColor = true;
            this.btn_punkt.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_plus.Location = new System.Drawing.Point(201, 108);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 42);
            this.btn_plus.TabIndex = 13;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_minus.Location = new System.Drawing.Point(201, 156);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 42);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // btn_mal
            // 
            this.btn_mal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_mal.Location = new System.Drawing.Point(201, 204);
            this.btn_mal.Name = "btn_mal";
            this.btn_mal.Size = new System.Drawing.Size(75, 42);
            this.btn_mal.TabIndex = 15;
            this.btn_mal.Text = "*";
            this.btn_mal.UseVisualStyleBackColor = true;
            this.btn_mal.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // btn_geteilt
            // 
            this.btn_geteilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_geteilt.Location = new System.Drawing.Point(201, 252);
            this.btn_geteilt.Name = "btn_geteilt";
            this.btn_geteilt.Size = new System.Drawing.Size(75, 42);
            this.btn_geteilt.TabIndex = 16;
            this.btn_geteilt.Text = "/";
            this.btn_geteilt.UseVisualStyleBackColor = true;
            this.btn_geteilt.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(201, 300);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 90);
            this.btn_enter.TabIndex = 17;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_klammerauf
            // 
            this.btn_klammerauf.Enabled = false;
            this.btn_klammerauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_klammerauf.Location = new System.Drawing.Point(12, 300);
            this.btn_klammerauf.Name = "btn_klammerauf";
            this.btn_klammerauf.Size = new System.Drawing.Size(57, 42);
            this.btn_klammerauf.TabIndex = 18;
            this.btn_klammerauf.Text = "(";
            this.btn_klammerauf.UseVisualStyleBackColor = true;
            this.btn_klammerauf.Click += new System.EventHandler(this.btn_klammerauf_Click);
            // 
            // btn_klammerzu
            // 
            this.btn_klammerzu.Enabled = false;
            this.btn_klammerzu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_klammerzu.Location = new System.Drawing.Point(12, 348);
            this.btn_klammerzu.Name = "btn_klammerzu";
            this.btn_klammerzu.Size = new System.Drawing.Size(57, 42);
            this.btn_klammerzu.TabIndex = 19;
            this.btn_klammerzu.Text = ")";
            this.btn_klammerzu.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_del.Location = new System.Drawing.Point(75, 300);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(57, 90);
            this.btn_del.TabIndex = 20;
            this.btn_del.Text = "<---";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(138, 300);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(57, 90);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Rechnunglable
            // 
            this.Rechnunglable.AutoSize = true;
            this.Rechnunglable.BackColor = System.Drawing.SystemColors.Menu;
            this.Rechnunglable.Location = new System.Drawing.Point(26, 15);
            this.Rechnunglable.Name = "Rechnunglable";
            this.Rechnunglable.Size = new System.Drawing.Size(0, 13);
            this.Rechnunglable.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 395);
            this.Controls.Add(this.Rechnunglable);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_klammerzu);
            this.Controls.Add(this.btn_klammerauf);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_geteilt);
            this.Controls.Add(this.btn_mal);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_punkt);
            this.Controls.Add(this.btn_Negativ);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_drei);
            this.Controls.Add(this.btn_zwei);
            this.Controls.Add(this.btn_eins);
            this.Controls.Add(this.btn_sechs);
            this.Controls.Add(this.btn_fünf);
            this.Controls.Add(this.btn_vier);
            this.Controls.Add(this.btn_acht);
            this.Controls.Add(this.btn_neun);
            this.Controls.Add(this.btn_sieben);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button btn_sieben;
        private System.Windows.Forms.Button btn_neun;
        private System.Windows.Forms.Button btn_acht;
        private System.Windows.Forms.Button btn_vier;
        private System.Windows.Forms.Button btn_fünf;
        private System.Windows.Forms.Button btn_sechs;
        private System.Windows.Forms.Button btn_eins;
        private System.Windows.Forms.Button btn_zwei;
        private System.Windows.Forms.Button btn_drei;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Negativ;
        private System.Windows.Forms.Button btn_punkt;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_mal;
        private System.Windows.Forms.Button btn_geteilt;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_klammerauf;
        private System.Windows.Forms.Button btn_klammerzu;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label Rechnunglable;
    }
}

