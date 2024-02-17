namespace lab_1
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
            this.Button_SaveStudents = new MaterialSkin.Controls.MaterialButton();
            this.Button_LoadStudents = new MaterialSkin.Controls.MaterialButton();
            this.TextBox_Surname = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBox_Name = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBox_Address = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBox_PhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.Label_CountOfStudents = new MaterialSkin.Controls.MaterialLabel();
            this.Label_StudentsCounter = new MaterialSkin.Controls.MaterialLabel();
            this.MultiLineTextBox_Students = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.Button_AddToList = new MaterialSkin.Controls.MaterialButton();
            this.Button_ClearStudents = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Button_SaveStudents
            // 
            this.Button_SaveStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_SaveStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button_SaveStudents.Depth = 0;
            this.Button_SaveStudents.HighEmphasis = true;
            this.Button_SaveStudents.Icon = null;
            this.Button_SaveStudents.Location = new System.Drawing.Point(397, 355);
            this.Button_SaveStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_SaveStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_SaveStudents.Name = "Button_SaveStudents";
            this.Button_SaveStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button_SaveStudents.Size = new System.Drawing.Size(94, 36);
            this.Button_SaveStudents.TabIndex = 0;
            this.Button_SaveStudents.Text = "Зберегти";
            this.Button_SaveStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button_SaveStudents.UseAccentColor = false;
            this.Button_SaveStudents.UseVisualStyleBackColor = true;
            this.Button_SaveStudents.Click += new System.EventHandler(this.Button_SaveStudents_Click);
            // 
            // Button_LoadStudents
            // 
            this.Button_LoadStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_LoadStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button_LoadStudents.Depth = 0;
            this.Button_LoadStudents.HighEmphasis = true;
            this.Button_LoadStudents.Icon = null;
            this.Button_LoadStudents.Location = new System.Drawing.Point(513, 355);
            this.Button_LoadStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_LoadStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_LoadStudents.Name = "Button_LoadStudents";
            this.Button_LoadStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button_LoadStudents.Size = new System.Drawing.Size(106, 36);
            this.Button_LoadStudents.TabIndex = 1;
            this.Button_LoadStudents.Text = "Загрузити";
            this.Button_LoadStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button_LoadStudents.UseAccentColor = false;
            this.Button_LoadStudents.UseVisualStyleBackColor = true;
            this.Button_LoadStudents.Click += new System.EventHandler(this.Button_LoadStudents_Click);
            // 
            // TextBox_Surname
            // 
            this.TextBox_Surname.AnimateReadOnly = false;
            this.TextBox_Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Surname.Depth = 0;
            this.TextBox_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_Surname.Hint = "Прізвище";
            this.TextBox_Surname.LeadingIcon = null;
            this.TextBox_Surname.Location = new System.Drawing.Point(51, 184);
            this.TextBox_Surname.MaxLength = 50;
            this.TextBox_Surname.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBox_Surname.Multiline = false;
            this.TextBox_Surname.Name = "TextBox_Surname";
            this.TextBox_Surname.Size = new System.Drawing.Size(194, 50);
            this.TextBox_Surname.TabIndex = 2;
            this.TextBox_Surname.Text = "Шуневич";
            this.TextBox_Surname.TrailingIcon = null;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.AnimateReadOnly = false;
            this.TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Name.Depth = 0;
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_Name.Hint = "Ім\'я";
            this.TextBox_Name.LeadingIcon = null;
            this.TextBox_Name.Location = new System.Drawing.Point(51, 128);
            this.TextBox_Name.MaxLength = 50;
            this.TextBox_Name.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBox_Name.Multiline = false;
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(194, 50);
            this.TextBox_Name.TabIndex = 3;
            this.TextBox_Name.Text = "Максим";
            this.TextBox_Name.TrailingIcon = null;
            // 
            // TextBox_Address
            // 
            this.TextBox_Address.AnimateReadOnly = false;
            this.TextBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Address.Depth = 0;
            this.TextBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_Address.Hint = "Адреса";
            this.TextBox_Address.LeadingIcon = null;
            this.TextBox_Address.Location = new System.Drawing.Point(51, 240);
            this.TextBox_Address.MaxLength = 50;
            this.TextBox_Address.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBox_Address.Multiline = false;
            this.TextBox_Address.Name = "TextBox_Address";
            this.TextBox_Address.Size = new System.Drawing.Size(194, 50);
            this.TextBox_Address.TabIndex = 4;
            this.TextBox_Address.Text = "вул. Тернопільська 30";
            this.TextBox_Address.TrailingIcon = null;
            // 
            // TextBox_PhoneNumber
            // 
            this.TextBox_PhoneNumber.AnimateReadOnly = false;
            this.TextBox_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_PhoneNumber.Depth = 0;
            this.TextBox_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBox_PhoneNumber.Hint = "Телефон";
            this.TextBox_PhoneNumber.LeadingIcon = null;
            this.TextBox_PhoneNumber.Location = new System.Drawing.Point(51, 296);
            this.TextBox_PhoneNumber.MaxLength = 50;
            this.TextBox_PhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBox_PhoneNumber.Multiline = false;
            this.TextBox_PhoneNumber.Name = "TextBox_PhoneNumber";
            this.TextBox_PhoneNumber.Size = new System.Drawing.Size(194, 50);
            this.TextBox_PhoneNumber.TabIndex = 5;
            this.TextBox_PhoneNumber.Text = "+380673802728";
            this.TextBox_PhoneNumber.TrailingIcon = null;
            // 
            // Label_CountOfStudents
            // 
            this.Label_CountOfStudents.AutoSize = true;
            this.Label_CountOfStudents.Depth = 0;
            this.Label_CountOfStudents.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Label_CountOfStudents.Location = new System.Drawing.Point(531, 296);
            this.Label_CountOfStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_CountOfStudents.Name = "Label_CountOfStudents";
            this.Label_CountOfStudents.Size = new System.Drawing.Size(151, 19);
            this.Label_CountOfStudents.TabIndex = 6;
            this.Label_CountOfStudents.Text = "Кількість студентів:";
            // 
            // Label_StudentsCounter
            // 
            this.Label_StudentsCounter.Depth = 0;
            this.Label_StudentsCounter.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Label_StudentsCounter.Location = new System.Drawing.Point(688, 296);
            this.Label_StudentsCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Label_StudentsCounter.Name = "Label_StudentsCounter";
            this.Label_StudentsCounter.Size = new System.Drawing.Size(37, 23);
            this.Label_StudentsCounter.TabIndex = 7;
            this.Label_StudentsCounter.Text = "0";
            // 
            // MultiLineTextBox_Students
            // 
            this.MultiLineTextBox_Students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultiLineTextBox_Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultiLineTextBox_Students.Depth = 0;
            this.MultiLineTextBox_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultiLineTextBox_Students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultiLineTextBox_Students.Location = new System.Drawing.Point(296, 129);
            this.MultiLineTextBox_Students.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultiLineTextBox_Students.Name = "MultiLineTextBox_Students";
            this.MultiLineTextBox_Students.ReadOnly = true;
            this.MultiLineTextBox_Students.Size = new System.Drawing.Size(457, 151);
            this.MultiLineTextBox_Students.TabIndex = 8;
            this.MultiLineTextBox_Students.Text = "";
            // 
            // Button_AddToList
            // 
            this.Button_AddToList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_AddToList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button_AddToList.Depth = 0;
            this.Button_AddToList.HighEmphasis = true;
            this.Button_AddToList.Icon = null;
            this.Button_AddToList.Location = new System.Drawing.Point(63, 355);
            this.Button_AddToList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_AddToList.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_AddToList.Name = "Button_AddToList";
            this.Button_AddToList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button_AddToList.Size = new System.Drawing.Size(171, 36);
            this.Button_AddToList.TabIndex = 9;
            this.Button_AddToList.Text = "Додати до списку";
            this.Button_AddToList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button_AddToList.UseAccentColor = false;
            this.Button_AddToList.UseVisualStyleBackColor = true;
            this.Button_AddToList.Click += new System.EventHandler(this.Button_AddToList_Click);
            // 
            // Button_ClearStudents
            // 
            this.Button_ClearStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_ClearStudents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button_ClearStudents.Depth = 0;
            this.Button_ClearStudents.HighEmphasis = true;
            this.Button_ClearStudents.Icon = null;
            this.Button_ClearStudents.Location = new System.Drawing.Point(352, 289);
            this.Button_ClearStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_ClearStudents.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_ClearStudents.Name = "Button_ClearStudents";
            this.Button_ClearStudents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button_ClearStudents.Size = new System.Drawing.Size(165, 36);
            this.Button_ClearStudents.TabIndex = 10;
            this.Button_ClearStudents.Text = "Очистити список";
            this.Button_ClearStudents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button_ClearStudents.UseAccentColor = false;
            this.Button_ClearStudents.UseVisualStyleBackColor = true;
            this.Button_ClearStudents.Click += new System.EventHandler(this.Button_ClearStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_ClearStudents);
            this.Controls.Add(this.Button_AddToList);
            this.Controls.Add(this.MultiLineTextBox_Students);
            this.Controls.Add(this.Label_StudentsCounter);
            this.Controls.Add(this.Label_CountOfStudents);
            this.Controls.Add(this.TextBox_PhoneNumber);
            this.Controls.Add(this.TextBox_Address);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.TextBox_Surname);
            this.Controls.Add(this.Button_LoadStudents);
            this.Controls.Add(this.Button_SaveStudents);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Button_SaveStudents;
        private MaterialSkin.Controls.MaterialButton Button_LoadStudents;
        private MaterialSkin.Controls.MaterialTextBox TextBox_Surname;
        private MaterialSkin.Controls.MaterialTextBox TextBox_Name;
        private MaterialSkin.Controls.MaterialTextBox TextBox_Address;
        private MaterialSkin.Controls.MaterialTextBox TextBox_PhoneNumber;
        private MaterialSkin.Controls.MaterialLabel Label_CountOfStudents;
        private MaterialSkin.Controls.MaterialLabel Label_StudentsCounter;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultiLineTextBox_Students;
        private MaterialSkin.Controls.MaterialButton Button_AddToList;
        private MaterialSkin.Controls.MaterialButton Button_ClearStudents;
    }
}

