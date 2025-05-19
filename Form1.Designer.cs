namespace Decimal_tape
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
            this.grpBaseString = new System.Windows.Forms.GroupBox();
            this.lblBaseStringLength = new System.Windows.Forms.Label();
            this.lblBaseStringContent = new System.Windows.Forms.Label();
            this.btnClearBaseString = new System.Windows.Forms.Button();
            this.btnCreateBaseString = new System.Windows.Forms.Button();
            this.txtBaseStringInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDecimalString1 = new System.Windows.Forms.GroupBox();
            this.lblDecimalString1Length = new System.Windows.Forms.Label();
            this.lblDecimalString1Content = new System.Windows.Forms.Label();
            this.btnCreateDecimalString1 = new System.Windows.Forms.Button();
            this.txtDecimalString1 = new System.Windows.Forms.TextBox();
            this.grpDecimalString2 = new System.Windows.Forms.GroupBox();
            this.lblDecimalString2Length = new System.Windows.Forms.Label();
            this.lblDecimalString2Content = new System.Windows.Forms.Label();
            this.btnCreateDecimalString2 = new System.Windows.Forms.Button();
            this.txtDecimalString2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnDifference = new System.Windows.Forms.Button();
            this.grpCreateFromNumber = new System.Windows.Forms.GroupBox();
            this.btnCreateFromNumber = new System.Windows.Forms.Button();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.grpBaseString.SuspendLayout();
            this.grpDecimalString1.SuspendLayout();
            this.grpDecimalString2.SuspendLayout();
            this.grpCreateFromNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBaseString
            // 
            this.grpBaseString.Controls.Add(this.lblBaseStringLength);
            this.grpBaseString.Controls.Add(this.lblBaseStringContent);
            this.grpBaseString.Controls.Add(this.btnClearBaseString);
            this.grpBaseString.Controls.Add(this.btnCreateBaseString);
            this.grpBaseString.Controls.Add(this.txtBaseStringInput);
            this.grpBaseString.Controls.Add(this.label1);
            this.grpBaseString.Location = new System.Drawing.Point(12, 12);
            this.grpBaseString.Name = "grpBaseString";
            this.grpBaseString.Size = new System.Drawing.Size(360, 174);
            this.grpBaseString.TabIndex = 0;
            this.grpBaseString.TabStop = false;
            this.grpBaseString.Text = "Базова стрічка";
            // 
            // lblBaseStringLength
            // 
            this.lblBaseStringLength.AutoSize = true;
            this.lblBaseStringLength.Location = new System.Drawing.Point(6, 134);
            this.lblBaseStringLength.Name = "lblBaseStringLength";
            this.lblBaseStringLength.Size = new System.Drawing.Size(128, 16);
            this.lblBaseStringLength.TabIndex = 5;
            this.lblBaseStringLength.Text = "Довжина (байти): 0";
            // 
            // lblBaseStringContent
            // 
            this.lblBaseStringContent.AutoSize = true;
            this.lblBaseStringContent.Location = new System.Drawing.Point(6, 110);
            this.lblBaseStringContent.Name = "lblBaseStringContent";
            this.lblBaseStringContent.Size = new System.Drawing.Size(48, 16);
            this.lblBaseStringContent.TabIndex = 4;
            this.lblBaseStringContent.Text = "Вміст: ";
            // 
            // btnClearBaseString
            // 
            this.btnClearBaseString.Location = new System.Drawing.Point(6, 84);
            this.btnClearBaseString.Name = "btnClearBaseString";
            this.btnClearBaseString.Size = new System.Drawing.Size(120, 23);
            this.btnClearBaseString.TabIndex = 3;
            this.btnClearBaseString.Text = "Очистити стрічку";
            this.btnClearBaseString.UseVisualStyleBackColor = true;
            this.btnClearBaseString.Click += new System.EventHandler(this.btnClearBaseString_Click);
            // 
            // btnCreateBaseString
            // 
            this.btnCreateBaseString.Location = new System.Drawing.Point(240, 55);
            this.btnCreateBaseString.Name = "btnCreateBaseString";
            this.btnCreateBaseString.Size = new System.Drawing.Size(110, 23);
            this.btnCreateBaseString.TabIndex = 2;
            this.btnCreateBaseString.Text = "Створити";
            this.btnCreateBaseString.UseVisualStyleBackColor = true;
            this.btnCreateBaseString.Click += new System.EventHandler(this.btnCreateBaseString_Click);
            // 
            // txtBaseStringInput
            // 
            this.txtBaseStringInput.Location = new System.Drawing.Point(6, 56);
            this.txtBaseStringInput.Name = "txtBaseStringInput";
            this.txtBaseStringInput.Size = new System.Drawing.Size(220, 22);
            this.txtBaseStringInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть стрічку:";
            // 
            // grpDecimalString1
            // 
            this.grpDecimalString1.Controls.Add(this.lblDecimalString1Length);
            this.grpDecimalString1.Controls.Add(this.lblDecimalString1Content);
            this.grpDecimalString1.Controls.Add(this.btnCreateDecimalString1);
            this.grpDecimalString1.Controls.Add(this.txtDecimalString1);
            this.grpDecimalString1.Location = new System.Drawing.Point(12, 192);
            this.grpDecimalString1.Name = "grpDecimalString1";
            this.grpDecimalString1.Size = new System.Drawing.Size(360, 120);
            this.grpDecimalString1.TabIndex = 1;
            this.grpDecimalString1.TabStop = false;
            this.grpDecimalString1.Text = "Десяткова стрічка 1";
            // 
            // lblDecimalString1Length
            // 
            this.lblDecimalString1Length.AutoSize = true;
            this.lblDecimalString1Length.Location = new System.Drawing.Point(6, 80);
            this.lblDecimalString1Length.Name = "lblDecimalString1Length";
            this.lblDecimalString1Length.Size = new System.Drawing.Size(128, 16);
            this.lblDecimalString1Length.TabIndex = 3;
            this.lblDecimalString1Length.Text = "Довжина (байти): 0";
            // 
            // lblDecimalString1Content
            // 
            this.lblDecimalString1Content.AutoSize = true;
            this.lblDecimalString1Content.Location = new System.Drawing.Point(6, 60);
            this.lblDecimalString1Content.Name = "lblDecimalString1Content";
            this.lblDecimalString1Content.Size = new System.Drawing.Size(48, 16);
            this.lblDecimalString1Content.TabIndex = 2;
            this.lblDecimalString1Content.Text = "Вміст: ";
            // 
            // btnCreateDecimalString1
            // 
            this.btnCreateDecimalString1.Location = new System.Drawing.Point(240, 30);
            this.btnCreateDecimalString1.Name = "btnCreateDecimalString1";
            this.btnCreateDecimalString1.Size = new System.Drawing.Size(110, 23);
            this.btnCreateDecimalString1.TabIndex = 1;
            this.btnCreateDecimalString1.Text = "Створити";
            this.btnCreateDecimalString1.UseVisualStyleBackColor = true;
            this.btnCreateDecimalString1.Click += new System.EventHandler(this.btnCreateDecimalString1_Click);
            // 
            // txtDecimalString1
            // 
            this.txtDecimalString1.Location = new System.Drawing.Point(6, 30);
            this.txtDecimalString1.Name = "txtDecimalString1";
            this.txtDecimalString1.Size = new System.Drawing.Size(220, 22);
            this.txtDecimalString1.TabIndex = 0;
            // 
            // grpDecimalString2
            // 
            this.grpDecimalString2.Controls.Add(this.lblDecimalString2Length);
            this.grpDecimalString2.Controls.Add(this.lblDecimalString2Content);
            this.grpDecimalString2.Controls.Add(this.btnCreateDecimalString2);
            this.grpDecimalString2.Controls.Add(this.txtDecimalString2);
            this.grpDecimalString2.Location = new System.Drawing.Point(12, 318);
            this.grpDecimalString2.Name = "grpDecimalString2";
            this.grpDecimalString2.Size = new System.Drawing.Size(360, 120);
            this.grpDecimalString2.TabIndex = 2;
            this.grpDecimalString2.TabStop = false;
            this.grpDecimalString2.Text = "Десяткова стрічка 2";
            // 
            // lblDecimalString2Length
            // 
            this.lblDecimalString2Length.AutoSize = true;
            this.lblDecimalString2Length.Location = new System.Drawing.Point(6, 80);
            this.lblDecimalString2Length.Name = "lblDecimalString2Length";
            this.lblDecimalString2Length.Size = new System.Drawing.Size(128, 16);
            this.lblDecimalString2Length.TabIndex = 3;
            this.lblDecimalString2Length.Text = "Довжина (байти): 0";
            // 
            // lblDecimalString2Content
            // 
            this.lblDecimalString2Content.AutoSize = true;
            this.lblDecimalString2Content.Location = new System.Drawing.Point(6, 60);
            this.lblDecimalString2Content.Name = "lblDecimalString2Content";
            this.lblDecimalString2Content.Size = new System.Drawing.Size(48, 16);
            this.lblDecimalString2Content.TabIndex = 2;
            this.lblDecimalString2Content.Text = "Вміст: ";
            // 
            // btnCreateDecimalString2
            // 
            this.btnCreateDecimalString2.Location = new System.Drawing.Point(240, 30);
            this.btnCreateDecimalString2.Name = "btnCreateDecimalString2";
            this.btnCreateDecimalString2.Size = new System.Drawing.Size(110, 23);
            this.btnCreateDecimalString2.TabIndex = 1;
            this.btnCreateDecimalString2.Text = "Створити";
            this.btnCreateDecimalString2.UseVisualStyleBackColor = true;
            this.btnCreateDecimalString2.Click += new System.EventHandler(this.btnCreateDecimalString2_Click);
            // 
            // txtDecimalString2
            // 
            this.txtDecimalString2.Location = new System.Drawing.Point(6, 30);
            this.txtDecimalString2.Name = "txtDecimalString2";
            this.txtDecimalString2.Size = new System.Drawing.Size(220, 22);
            this.txtDecimalString2.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(422, 190);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(150, 40);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Порівняти стрічки";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnDifference
            // 
            this.btnDifference.Location = new System.Drawing.Point(422, 240);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(150, 40);
            this.btnDifference.TabIndex = 4;
            this.btnDifference.Text = "Обчислити різницю";
            this.btnDifference.UseVisualStyleBackColor = true;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // grpCreateFromNumber
            // 
            this.grpCreateFromNumber.Controls.Add(this.btnCreateFromNumber);
            this.grpCreateFromNumber.Controls.Add(this.txtNumberInput);
            this.grpCreateFromNumber.Location = new System.Drawing.Point(400, 30);
            this.grpCreateFromNumber.Name = "grpCreateFromNumber";
            this.grpCreateFromNumber.Size = new System.Drawing.Size(200, 132);
            this.grpCreateFromNumber.TabIndex = 5;
            this.grpCreateFromNumber.TabStop = false;
            this.grpCreateFromNumber.Text = "Створити десяткову стрічку з числа";
            // 
            // btnCreateFromNumber
            // 
            this.btnCreateFromNumber.Location = new System.Drawing.Point(10, 78);
            this.btnCreateFromNumber.Name = "btnCreateFromNumber";
            this.btnCreateFromNumber.Size = new System.Drawing.Size(180, 30);
            this.btnCreateFromNumber.TabIndex = 1;
            this.btnCreateFromNumber.Text = "Створити";
            this.btnCreateFromNumber.UseVisualStyleBackColor = true;
            this.btnCreateFromNumber.Click += new System.EventHandler(this.btnCreateFromNumber_Click);
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Location = new System.Drawing.Point(10, 42);
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.Size = new System.Drawing.Size(180, 22);
            this.txtNumberInput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpCreateFromNumber);
            this.Controls.Add(this.btnDifference);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.grpDecimalString2);
            this.Controls.Add(this.grpDecimalString1);
            this.Controls.Add(this.grpBaseString);
            this.Name = "Form1";
            this.Text = "Десяткова стрічка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBaseString.ResumeLayout(false);
            this.grpBaseString.PerformLayout();
            this.grpDecimalString1.ResumeLayout(false);
            this.grpDecimalString1.PerformLayout();
            this.grpDecimalString2.ResumeLayout(false);
            this.grpDecimalString2.PerformLayout();
            this.grpCreateFromNumber.ResumeLayout(false);
            this.grpCreateFromNumber.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox grpBaseString;
        private System.Windows.Forms.Label lblBaseStringLength;
        private System.Windows.Forms.Label lblBaseStringContent;
        private System.Windows.Forms.Button btnClearBaseString;
        private System.Windows.Forms.Button btnCreateBaseString;
        private System.Windows.Forms.TextBox txtBaseStringInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDecimalString1;
        private System.Windows.Forms.Label lblDecimalString1Length;
        private System.Windows.Forms.Label lblDecimalString1Content;
        private System.Windows.Forms.Button btnCreateDecimalString1;
        private System.Windows.Forms.TextBox txtDecimalString1;
        private System.Windows.Forms.GroupBox grpDecimalString2;
        private System.Windows.Forms.Label lblDecimalString2Length;
        private System.Windows.Forms.Label lblDecimalString2Content;
        private System.Windows.Forms.Button btnCreateDecimalString2;
        private System.Windows.Forms.TextBox txtDecimalString2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.GroupBox grpCreateFromNumber;
        private System.Windows.Forms.Button btnCreateFromNumber;
        private System.Windows.Forms.TextBox txtNumberInput;
        #endregion
    }
}

