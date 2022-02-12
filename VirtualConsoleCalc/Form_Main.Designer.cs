
namespace VirtualConsoleCalc
{
    partial class form_Main
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
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.pictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.ReadOnly = true;
            this.richTextBox_Output.Size = new System.Drawing.Size(535, 222);
            this.richTextBox_Output.TabIndex = 0;
            this.richTextBox_Output.Text = "";
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.listBox_Input);
            this.groupBox_Input.Controls.Add(this.pictureBox_Preview);
            this.groupBox_Input.Controls.Add(this.textBox_B);
            this.groupBox_Input.Controls.Add(this.textBox_A);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 240);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(535, 155);
            this.groupBox_Input.TabIndex = 1;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "Входные данные";
            // 
            // listBox_Input
            // 
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.Items.AddRange(new object[] {
            "<нет действий>",
            "простое сложение чисел",
            "простое умножение чисел",
            "операция в строку",
            "сложение в столбик",
            "умножение в столбик"});
            this.listBox_Input.Location = new System.Drawing.Point(6, 23);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(267, 121);
            this.listBox_Input.TabIndex = 3;
            this.listBox_Input.SelectedIndexChanged += new System.EventHandler(this.listBox_Input_SelectedIndexChanged);
            // 
            // pictureBox_Preview
            // 
            this.pictureBox_Preview.Location = new System.Drawing.Point(362, 89);
            this.pictureBox_Preview.Name = "pictureBox_Preview";
            this.pictureBox_Preview.Size = new System.Drawing.Size(150, 50);
            this.pictureBox_Preview.TabIndex = 2;
            this.pictureBox_Preview.TabStop = false;
            // 
            // textBox_B
            // 
            this.textBox_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_B.Location = new System.Drawing.Point(362, 54);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(167, 29);
            this.textBox_B.TabIndex = 1;
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            // 
            // textBox_A
            // 
            this.textBox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_A.Location = new System.Drawing.Point(362, 19);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(167, 29);
            this.textBox_A.TabIndex = 0;
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(12, 415);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(285, 23);
            this.button_Evaluate.TabIndex = 2;
            this.button_Evaluate.Text = "Вычислить";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(409, 415);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(138, 23);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Очистка";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Evaluate);
            this.Controls.Add(this.groupBox_Input);
            this.Controls.Add(this.richTextBox_Output);
            this.Name = "form_Main";
            this.Text = "Форматный вывод данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.PictureBox pictureBox_Preview;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.Button button_Clear;
    }
}

