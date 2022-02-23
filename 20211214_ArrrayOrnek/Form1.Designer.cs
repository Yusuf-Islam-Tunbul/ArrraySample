
namespace _20211214_ArrrayOrnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.show_button = new System.Windows.Forms.Button();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.display_listbox = new System.Windows.Forms.ListBox();
            this.random_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(12, 12);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 34);
            this.show_button.TabIndex = 0;
            this.show_button.Text = "SHOW";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(12, 52);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(248, 22);
            this.input_textbox.TabIndex = 1;
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(185, 12);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(75, 34);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "ENTER";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // display_listbox
            // 
            this.display_listbox.FormattingEnabled = true;
            this.display_listbox.ItemHeight = 16;
            this.display_listbox.Location = new System.Drawing.Point(12, 80);
            this.display_listbox.Name = "display_listbox";
            this.display_listbox.Size = new System.Drawing.Size(248, 164);
            this.display_listbox.TabIndex = 2;
            // 
            // random_button
            // 
            this.random_button.Location = new System.Drawing.Point(93, 12);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(86, 34);
            this.random_button.TabIndex = 3;
            this.random_button.Text = "RANDOM";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.random_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 264);
            this.Controls.Add(this.random_button);
            this.Controls.Add(this.display_listbox);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.show_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.ListBox display_listbox;
        private System.Windows.Forms.Button random_button;
    }
}

