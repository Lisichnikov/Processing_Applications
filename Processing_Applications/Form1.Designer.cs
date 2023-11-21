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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Golos Text Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(29, 35);
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
            this.confirm_button.Location = new System.Drawing.Point(630, 325);
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
            this.reject_button.Location = new System.Drawing.Point(630, 426);
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
            this.open_button.Location = new System.Drawing.Point(630, 35);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 546);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.reject_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Обработка конкурсных заявок";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button reject_button;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

