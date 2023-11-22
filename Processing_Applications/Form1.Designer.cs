namespace Processing_Applications
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.reject_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Golos Text Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(27, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(579, 475);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.Transparent;
            this.confirm_button.BackgroundImage = global::Processing_Applications.Properties.Resources.green;
            this.confirm_button.FlatAppearance.BorderSize = 0;
            this.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_button.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_button.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirm_button.Location = new System.Drawing.Point(628, 322);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(273, 84);
            this.confirm_button.TabIndex = 3;
            this.confirm_button.Text = "Принять";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // reject_button
            // 
            this.reject_button.BackColor = System.Drawing.Color.Transparent;
            this.reject_button.BackgroundImage = global::Processing_Applications.Properties.Resources.red;
            this.reject_button.FlatAppearance.BorderSize = 0;
            this.reject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reject_button.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reject_button.ForeColor = System.Drawing.Color.Firebrick;
            this.reject_button.Location = new System.Drawing.Point(628, 423);
            this.reject_button.Name = "reject_button";
            this.reject_button.Size = new System.Drawing.Size(273, 84);
            this.reject_button.TabIndex = 2;
            this.reject_button.Text = "Отклонить";
            this.reject_button.UseVisualStyleBackColor = false;
            this.reject_button.Click += new System.EventHandler(this.reject_button_Click);
            // 
            // open_button
            // 
            this.open_button.BackColor = System.Drawing.Color.Transparent;
            this.open_button.BackgroundImage = global::Processing_Applications.Properties.Resources.yellow;
            this.open_button.FlatAppearance.BorderSize = 0;
            this.open_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_button.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_button.ForeColor = System.Drawing.Color.Goldenrod;
            this.open_button.Location = new System.Drawing.Point(628, 32);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(273, 84);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "Открыть файл";
            this.open_button.UseVisualStyleBackColor = false;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 562);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.confirm_button);
            this.tabPage1.Controls.Add(this.open_button);
            this.tabPage1.Controls.Add(this.reject_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные конкурсанта";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа конкурсанта";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Processing_Applications.Properties.Resources.yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(627, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 472);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Processing_Applications.Properties.Resources.green;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(627, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "Принять";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Processing_Applications.Properties.Resources.red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Golos Text DemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Firebrick;
            this.button3.Location = new System.Drawing.Point(627, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 84);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отклонить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 564);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Обработка конкурсных заявок";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button reject_button;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

