namespace GetUserName
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetUserName = new System.Windows.Forms.Button();
            this.lblGetUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetUserName
            // 
            this.btnGetUserName.Location = new System.Drawing.Point(12, 34);
            this.btnGetUserName.Name = "btnGetUserName";
            this.btnGetUserName.Size = new System.Drawing.Size(75, 23);
            this.btnGetUserName.TabIndex = 0;
            this.btnGetUserName.Text = "Получить!";
            this.btnGetUserName.UseVisualStyleBackColor = true;
            this.btnGetUserName.Click += new System.EventHandler(this.btnGetUserName_Click);
            // 
            // lblGetUserName
            // 
            this.lblGetUserName.AutoSize = true;
            this.lblGetUserName.Location = new System.Drawing.Point(93, 39);
            this.lblGetUserName.Name = "lblGetUserName";
            this.lblGetUserName.Size = new System.Drawing.Size(170, 13);
            this.lblGetUserName.TabIndex = 1;
            this.lblGetUserName.Text = "Получение имени пользователя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 95);
            this.Controls.Add(this.lblGetUserName);
            this.Controls.Add(this.btnGetUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetUserName;
        private System.Windows.Forms.Label lblGetUserName;
    }
}

