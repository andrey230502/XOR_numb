namespace XOR_numb
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.labelP_Hex = new System.Windows.Forms.Label();
            this.label_Key_Hex = new System.Windows.Forms.Label();
            this.labelC_HEX = new System.Windows.Forms.Label();
            this.textBoxP_Hex = new System.Windows.Forms.TextBox();
            this.textBoxKey_Hex = new System.Windows.Forms.TextBox();
            this.textBoxC_Hex = new System.Windows.Forms.TextBox();
            this.textBoxC_Dec = new System.Windows.Forms.TextBox();
            this.textBoxKey_Dec = new System.Windows.Forms.TextBox();
            this.textBoxP_Dec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelP_Dec = new System.Windows.Forms.Label();
            this.textBoxC_R = new System.Windows.Forms.TextBox();
            this.textBoxKey_R = new System.Windows.Forms.TextBox();
            this.textBoxP_R = new System.Windows.Forms.TextBox();
            this.labelC_R = new System.Windows.Forms.Label();
            this.labelKet_R = new System.Windows.Forms.Label();
            this.labelP_R = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "C =";
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(218, 136);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 20);
            this.textBox_P.TabIndex = 3;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(218, 169);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 20);
            this.textBox_Key.TabIndex = 4;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(218, 205);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 20);
            this.textBox_C.TabIndex = 5;
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(192, 15);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(100, 49);
            this.button_XOR.TabIndex = 6;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(192, 73);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 23);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Прибрати";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // labelP_Hex
            // 
            this.labelP_Hex.AutoSize = true;
            this.labelP_Hex.Location = new System.Drawing.Point(12, 15);
            this.labelP_Hex.Name = "labelP_Hex";
            this.labelP_Hex.Size = new System.Drawing.Size(48, 13);
            this.labelP_Hex.TabIndex = 8;
            this.labelP_Hex.Text = "P_Hex =";
            // 
            // label_Key_Hex
            // 
            this.label_Key_Hex.AutoSize = true;
            this.label_Key_Hex.Location = new System.Drawing.Point(1, 48);
            this.label_Key_Hex.Name = "label_Key_Hex";
            this.label_Key_Hex.Size = new System.Drawing.Size(56, 13);
            this.label_Key_Hex.TabIndex = 9;
            this.label_Key_Hex.Text = "Key_Hex=";
            // 
            // labelC_HEX
            // 
            this.labelC_HEX.AutoSize = true;
            this.labelC_HEX.Location = new System.Drawing.Point(12, 84);
            this.labelC_HEX.Name = "labelC_HEX";
            this.labelC_HEX.Size = new System.Drawing.Size(48, 13);
            this.labelC_HEX.TabIndex = 10;
            this.labelC_HEX.Text = "C_Hex =";
            // 
            // textBoxP_Hex
            // 
            this.textBoxP_Hex.Location = new System.Drawing.Point(67, 15);
            this.textBoxP_Hex.Name = "textBoxP_Hex";
            this.textBoxP_Hex.Size = new System.Drawing.Size(100, 20);
            this.textBoxP_Hex.TabIndex = 11;
            // 
            // textBoxKey_Hex
            // 
            this.textBoxKey_Hex.Location = new System.Drawing.Point(67, 44);
            this.textBoxKey_Hex.Name = "textBoxKey_Hex";
            this.textBoxKey_Hex.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey_Hex.TabIndex = 12;
            // 
            // textBoxC_Hex
            // 
            this.textBoxC_Hex.Location = new System.Drawing.Point(66, 77);
            this.textBoxC_Hex.Name = "textBoxC_Hex";
            this.textBoxC_Hex.Size = new System.Drawing.Size(100, 20);
            this.textBoxC_Hex.TabIndex = 13;
            // 
            // textBoxC_Dec
            // 
            this.textBoxC_Dec.Location = new System.Drawing.Point(66, 198);
            this.textBoxC_Dec.Name = "textBoxC_Dec";
            this.textBoxC_Dec.Size = new System.Drawing.Size(100, 20);
            this.textBoxC_Dec.TabIndex = 19;
            // 
            // textBoxKey_Dec
            // 
            this.textBoxKey_Dec.Location = new System.Drawing.Point(67, 165);
            this.textBoxKey_Dec.Name = "textBoxKey_Dec";
            this.textBoxKey_Dec.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey_Dec.TabIndex = 18;
            // 
            // textBoxP_Dec
            // 
            this.textBoxP_Dec.Location = new System.Drawing.Point(67, 136);
            this.textBoxP_Dec.Name = "textBoxP_Dec";
            this.textBoxP_Dec.Size = new System.Drawing.Size(100, 20);
            this.textBoxP_Dec.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "C_Dec =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Key_Dec=";
            // 
            // labelP_Dec
            // 
            this.labelP_Dec.AutoSize = true;
            this.labelP_Dec.Location = new System.Drawing.Point(12, 136);
            this.labelP_Dec.Name = "labelP_Dec";
            this.labelP_Dec.Size = new System.Drawing.Size(49, 13);
            this.labelP_Dec.TabIndex = 14;
            this.labelP_Dec.Text = "P_Dec =";
            // 
            // textBoxC_R
            // 
            this.textBoxC_R.Location = new System.Drawing.Point(314, 12);
            this.textBoxC_R.Name = "textBoxC_R";
            this.textBoxC_R.Size = new System.Drawing.Size(100, 20);
            this.textBoxC_R.TabIndex = 25;
            // 
            // textBoxKey_R
            // 
            this.textBoxKey_R.Location = new System.Drawing.Point(314, 44);
            this.textBoxKey_R.Name = "textBoxKey_R";
            this.textBoxKey_R.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey_R.TabIndex = 24;
            // 
            // textBoxP_R
            // 
            this.textBoxP_R.Location = new System.Drawing.Point(314, 77);
            this.textBoxP_R.Name = "textBoxP_R";
            this.textBoxP_R.Size = new System.Drawing.Size(100, 20);
            this.textBoxP_R.TabIndex = 23;
            // 
            // labelC_R
            // 
            this.labelC_R.AutoSize = true;
            this.labelC_R.Location = new System.Drawing.Point(420, 15);
            this.labelC_R.Name = "labelC_R";
            this.labelC_R.Size = new System.Drawing.Size(48, 13);
            this.labelC_R.TabIndex = 22;
            this.labelC_R.Text = "= C_Hex";
            // 
            // labelKet_R
            // 
            this.labelKet_R.AutoSize = true;
            this.labelKet_R.Location = new System.Drawing.Point(419, 47);
            this.labelKet_R.Name = "labelKet_R";
            this.labelKet_R.Size = new System.Drawing.Size(59, 13);
            this.labelKet_R.TabIndex = 21;
            this.labelKet_R.Text = "= Key_Hex";
            // 
            // labelP_R
            // 
            this.labelP_R.AutoSize = true;
            this.labelP_R.Location = new System.Drawing.Point(419, 80);
            this.labelP_R.Name = "labelP_R";
            this.labelP_R.Size = new System.Drawing.Size(48, 13);
            this.labelP_R.TabIndex = 20;
            this.labelP_R.Text = "= P_Hex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxC_R);
            this.Controls.Add(this.textBoxKey_R);
            this.Controls.Add(this.textBoxP_R);
            this.Controls.Add(this.labelC_R);
            this.Controls.Add(this.labelKet_R);
            this.Controls.Add(this.labelP_R);
            this.Controls.Add(this.textBoxC_Dec);
            this.Controls.Add(this.textBoxKey_Dec);
            this.Controls.Add(this.textBoxP_Dec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelP_Dec);
            this.Controls.Add(this.textBoxC_Hex);
            this.Controls.Add(this.textBoxKey_Hex);
            this.Controls.Add(this.textBoxP_Hex);
            this.Controls.Add(this.labelC_HEX);
            this.Controls.Add(this.label_Key_Hex);
            this.Controls.Add(this.labelP_Hex);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_XOR);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label labelP_Hex;
        private System.Windows.Forms.Label label_Key_Hex;
        private System.Windows.Forms.Label labelC_HEX;
        private System.Windows.Forms.TextBox textBoxP_Hex;
        private System.Windows.Forms.TextBox textBoxKey_Hex;
        private System.Windows.Forms.TextBox textBoxC_Hex;
        private System.Windows.Forms.TextBox textBoxC_Dec;
        private System.Windows.Forms.TextBox textBoxKey_Dec;
        private System.Windows.Forms.TextBox textBoxP_Dec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelP_Dec;
        private System.Windows.Forms.TextBox textBoxC_R;
        private System.Windows.Forms.TextBox textBoxKey_R;
        private System.Windows.Forms.TextBox textBoxP_R;
        private System.Windows.Forms.Label labelC_R;
        private System.Windows.Forms.Label labelKet_R;
        private System.Windows.Forms.Label labelP_R;
    }
}

