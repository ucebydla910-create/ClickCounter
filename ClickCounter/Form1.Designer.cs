namespace ClickCounter
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
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.3F);
            this.lblCounter.Location = new System.Drawing.Point(386, 148);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(35, 38);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "0";
            this.lblCounter.Click += new System.EventHandler(this.lblCounter_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(234, 245);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(113, 35);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "кликни на меня";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(481, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblCounter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Счётчик кликов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnReset;
    }
}

