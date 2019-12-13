namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.buttonSeven = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.Gray;
            this.buttonSeven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.Location = new System.Drawing.Point(5, 123);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(60, 60);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.TabStop = false;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.ButtonClick);
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textResult.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textResult.ForeColor = System.Drawing.Color.White;
            this.textResult.Location = new System.Drawing.Point(5, 29);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(245, 32);
            this.textResult.TabIndex = 20;
            this.textResult.TabStop = false;
            this.textResult.Text = "0";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.Gray;
            this.buttonFour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.Location = new System.Drawing.Point(5, 184);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(60, 60);
            this.buttonFour.TabIndex = 22;
            this.buttonFour.TabStop = false;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.Gray;
            this.buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOne.FlatAppearance.BorderSize = 0;
            this.buttonOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(5, 246);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(60, 60);
            this.buttonOne.TabIndex = 23;
            this.buttonOne.TabStop = false;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.Gray;
            this.buttonZero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonZero.FlatAppearance.BorderSize = 0;
            this.buttonZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.Location = new System.Drawing.Point(5, 308);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(60, 60);
            this.buttonZero.TabIndex = 24;
            this.buttonZero.TabStop = false;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.Gray;
            this.buttonTwo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTwo.FlatAppearance.BorderSize = 0;
            this.buttonTwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.Location = new System.Drawing.Point(66, 246);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(60, 60);
            this.buttonTwo.TabIndex = 27;
            this.buttonTwo.TabStop = false;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.Gray;
            this.buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.Location = new System.Drawing.Point(66, 184);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(60, 60);
            this.buttonFive.TabIndex = 26;
            this.buttonFive.TabStop = false;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.Gray;
            this.buttonEight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.Location = new System.Drawing.Point(66, 123);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(60, 60);
            this.buttonEight.TabIndex = 25;
            this.buttonEight.TabStop = false;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.Gray;
            this.buttonPoint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPoint.FlatAppearance.BorderSize = 0;
            this.buttonPoint.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.Location = new System.Drawing.Point(66, 308);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(60, 60);
            this.buttonPoint.TabIndex = 32;
            this.buttonPoint.TabStop = false;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.Gray;
            this.buttonThree.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonThree.FlatAppearance.BorderSize = 0;
            this.buttonThree.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.Location = new System.Drawing.Point(128, 246);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(60, 60);
            this.buttonThree.TabIndex = 31;
            this.buttonThree.TabStop = false;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.Gray;
            this.buttonSix.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.Location = new System.Drawing.Point(128, 184);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(60, 60);
            this.buttonSix.TabIndex = 30;
            this.buttonSix.TabStop = false;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.Gray;
            this.buttonNine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.Location = new System.Drawing.Point(128, 123);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(60, 60);
            this.buttonNine.TabIndex = 29;
            this.buttonNine.TabStop = false;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.ButtonClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Gray;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(190, 308);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 60);
            this.buttonPlus.TabIndex = 36;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Gray;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(190, 246);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMinus.TabIndex = 35;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.Gray;
            this.buttonMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMultiplication.FlatAppearance.BorderSize = 0;
            this.buttonMultiplication.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplication.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(190, 184);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(60, 60);
            this.buttonMultiplication.TabIndex = 34;
            this.buttonMultiplication.TabStop = false;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.Gray;
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDivision.FlatAppearance.BorderSize = 0;
            this.buttonDivision.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(190, 123);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(60, 60);
            this.buttonDivision.TabIndex = 33;
            this.buttonDivision.TabStop = false;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.OperatorClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Gray;
            this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(128, 308);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(60, 60);
            this.buttonEqual.TabIndex = 40;
            this.buttonEqual.TabStop = false;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(190, 56);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 60);
            this.buttonClear.TabIndex = 38;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClearEntry.FlatAppearance.BorderSize = 0;
            this.buttonClearEntry.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonClearEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClearEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEntry.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntry.Location = new System.Drawing.Point(128, 56);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(60, 60);
            this.buttonClearEntry.TabIndex = 37;
            this.buttonClearEntry.TabStop = false;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.ButtonClearEntry_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("OCR A Extended", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(5, 56);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(121, 60);
            this.buttonRemove.TabIndex = 41;
            this.buttonRemove.TabStop = false;
            this.buttonRemove.Text = "←";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.BackspaceClick);
            // 
            // historyTextBox
            // 
            this.historyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.historyTextBox.Location = new System.Drawing.Point(5, 3);
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.Size = new System.Drawing.Size(245, 20);
            this.historyTextBox.TabIndex = 42;
            this.historyTextBox.TabStop = false;
            this.historyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "label1";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(254, 372);
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButtonsKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox historyTextBox;
        private System.Windows.Forms.Label label1;
    }
}

