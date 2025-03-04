namespace _2ritvv
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTransitions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(12, 12);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(504, 26);
            this.txtWord.TabIndex = 0;
            this.txtWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCheck.Location = new System.Drawing.Point(12, 45);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(504, 32);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResult.Location = new System.Drawing.Point(86, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(21, 20);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "...";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "alphabet: A B C D\r\nexamples of palindromes: \r\nABBA DDDD EDDE ABCCBA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxTransitions
            // 
            this.tbxTransitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTransitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxTransitions.Location = new System.Drawing.Point(214, 119);
            this.tbxTransitions.Multiline = true;
            this.tbxTransitions.Name = "tbxTransitions";
            this.tbxTransitions.ReadOnly = true;
            this.tbxTransitions.Size = new System.Drawing.Size(302, 129);
            this.tbxTransitions.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 261);
            this.Controls.Add(this.tbxTransitions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtWord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(544, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTransitions;
    }
}

