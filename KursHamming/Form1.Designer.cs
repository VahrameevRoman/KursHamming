namespace KursHamming
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.getCodeHammingButton = new System.Windows.Forms.Button();
            this.firstHammingTextBox = new System.Windows.Forms.TextBox();
            this.ErrorStatusTextBox = new System.Windows.Forms.TextBox();
            this.fixCodeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.correctHammingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строка текста в двоичной системе счисления";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(36, 45);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(424, 26);
            this.inputTextBox.TabIndex = 1;
            // 
            // getCodeHammingButton
            // 
            this.getCodeHammingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getCodeHammingButton.Location = new System.Drawing.Point(466, 26);
            this.getCodeHammingButton.Name = "getCodeHammingButton";
            this.getCodeHammingButton.Size = new System.Drawing.Size(271, 45);
            this.getCodeHammingButton.TabIndex = 2;
            this.getCodeHammingButton.Text = "Получить код Хэмминга";
            this.getCodeHammingButton.UseVisualStyleBackColor = true;
            this.getCodeHammingButton.Click += new System.EventHandler(this.getCodeHammingButton_Click);
            // 
            // firstHammingTextBox
            // 
            this.firstHammingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstHammingTextBox.Location = new System.Drawing.Point(36, 126);
            this.firstHammingTextBox.Name = "firstHammingTextBox";
            this.firstHammingTextBox.Size = new System.Drawing.Size(424, 26);
            this.firstHammingTextBox.TabIndex = 3;
            // 
            // ErrorStatusTextBox
            // 
            this.ErrorStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorStatusTextBox.Location = new System.Drawing.Point(36, 225);
            this.ErrorStatusTextBox.Multiline = true;
            this.ErrorStatusTextBox.Name = "ErrorStatusTextBox";
            this.ErrorStatusTextBox.ReadOnly = true;
            this.ErrorStatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorStatusTextBox.Size = new System.Drawing.Size(424, 80);
            this.ErrorStatusTextBox.TabIndex = 4;
            // 
            // fixCodeButton
            // 
            this.fixCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fixCodeButton.Location = new System.Drawing.Point(466, 107);
            this.fixCodeButton.Name = "fixCodeButton";
            this.fixCodeButton.Size = new System.Drawing.Size(271, 45);
            this.fixCodeButton.TabIndex = 5;
            this.fixCodeButton.Text = "Проверить и исправить код";
            this.fixCodeButton.UseVisualStyleBackColor = true;
            this.fixCodeButton.Click += new System.EventHandler(this.fixCodeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код Хэмминга";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Восстановленный текст";
            // 
            // correctHammingTextBox
            // 
            this.correctHammingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctHammingTextBox.Location = new System.Drawing.Point(36, 359);
            this.correctHammingTextBox.Multiline = true;
            this.correctHammingTextBox.Name = "correctHammingTextBox";
            this.correctHammingTextBox.ReadOnly = true;
            this.correctHammingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.correctHammingTextBox.Size = new System.Drawing.Size(424, 80);
            this.correctHammingTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отчет об ошибках";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(663, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Перед проверкой можно внести изменение в отдельный бит кода (имитация ошибки)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 478);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.correctHammingTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fixCodeButton);
            this.Controls.Add(this.ErrorStatusTextBox);
            this.Controls.Add(this.firstHammingTextBox);
            this.Controls.Add(this.getCodeHammingButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Курсовая_ Вахрамеев_Код Хэмминга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button getCodeHammingButton;
        private System.Windows.Forms.TextBox firstHammingTextBox;
        private System.Windows.Forms.TextBox ErrorStatusTextBox;
        private System.Windows.Forms.Button fixCodeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox correctHammingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

