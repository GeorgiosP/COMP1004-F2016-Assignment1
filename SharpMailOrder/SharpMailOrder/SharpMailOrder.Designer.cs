namespace SharpMailOrder
{
    partial class SharpMailOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpMailOrder));
            this.LanguageBox = new System.Windows.Forms.GroupBox();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoPicutreBox = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.EmployeeHoursWorked = new System.Windows.Forms.Label();
            this.EmployeeTotalSales = new System.Windows.Forms.Label();
            this.EmployeeSalesBonus = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeHoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeTotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeSalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.LanguageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicutreBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguageBox
            // 
            this.LanguageBox.Controls.Add(this.FrenchRadioButton);
            this.LanguageBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageBox.Location = new System.Drawing.Point(262, 12);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(200, 99);
            this.LanguageBox.TabIndex = 0;
            this.LanguageBox.TabStop = false;
            this.LanguageBox.Text = "Language";
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(25, 57);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(95, 24);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(25, 27);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(85, 24);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // LogoPicutreBox
            // 
            this.LogoPicutreBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicutreBox.Image")));
            this.LogoPicutreBox.Location = new System.Drawing.Point(10, 12);
            this.LogoPicutreBox.Name = "LogoPicutreBox";
            this.LogoPicutreBox.Size = new System.Drawing.Size(234, 180);
            this.LogoPicutreBox.TabIndex = 1;
            this.LogoPicutreBox.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(66, 448);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(351, 448);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(213, 448);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 4;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Location = new System.Drawing.Point(48, 222);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(115, 17);
            this.EmployeeName.TabIndex = 5;
            this.EmployeeName.Text = "Employee Name:";
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Location = new System.Drawing.Point(48, 255);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(91, 17);
            this.EmployeeID.TabIndex = 6;
            this.EmployeeID.Text = "Employee ID:";
            this.EmployeeID.Click += new System.EventHandler(this.EmployeeID_Click);
            // 
            // EmployeeHoursWorked
            // 
            this.EmployeeHoursWorked.AutoSize = true;
            this.EmployeeHoursWorked.Location = new System.Drawing.Point(56, 296);
            this.EmployeeHoursWorked.Name = "EmployeeHoursWorked";
            this.EmployeeHoursWorked.Size = new System.Drawing.Size(99, 17);
            this.EmployeeHoursWorked.TabIndex = 7;
            this.EmployeeHoursWorked.Text = "Hours Worked";
            this.EmployeeHoursWorked.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmployeeTotalSales
            // 
            this.EmployeeTotalSales.AutoSize = true;
            this.EmployeeTotalSales.Location = new System.Drawing.Point(56, 324);
            this.EmployeeTotalSales.Name = "EmployeeTotalSales";
            this.EmployeeTotalSales.Size = new System.Drawing.Size(79, 17);
            this.EmployeeTotalSales.TabIndex = 8;
            this.EmployeeTotalSales.Text = "Total Sales";
            // 
            // EmployeeSalesBonus
            // 
            this.EmployeeSalesBonus.AutoSize = true;
            this.EmployeeSalesBonus.Location = new System.Drawing.Point(56, 352);
            this.EmployeeSalesBonus.Name = "EmployeeSalesBonus";
            this.EmployeeSalesBonus.Size = new System.Drawing.Size(91, 17);
            this.EmployeeSalesBonus.TabIndex = 9;
            this.EmployeeSalesBonus.Text = "Sales Bonus:";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(213, 227);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(169, 22);
            this.EmployeeNameTextBox.TabIndex = 10;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(213, 255);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(169, 22);
            this.EmployeeIdTextBox.TabIndex = 11;
            // 
            // EmployeeHoursWorkedTextBox
            // 
            this.EmployeeHoursWorkedTextBox.Location = new System.Drawing.Point(213, 291);
            this.EmployeeHoursWorkedTextBox.Name = "EmployeeHoursWorkedTextBox";
            this.EmployeeHoursWorkedTextBox.Size = new System.Drawing.Size(213, 22);
            this.EmployeeHoursWorkedTextBox.TabIndex = 12;
            // 
            // EmployeeTotalSalesTextBox
            // 
            this.EmployeeTotalSalesTextBox.Location = new System.Drawing.Point(213, 319);
            this.EmployeeTotalSalesTextBox.Name = "EmployeeTotalSalesTextBox";
            this.EmployeeTotalSalesTextBox.Size = new System.Drawing.Size(213, 22);
            this.EmployeeTotalSalesTextBox.TabIndex = 13;
            // 
            // EmployeeSalesBonusTextBox
            // 
            this.EmployeeSalesBonusTextBox.Location = new System.Drawing.Point(213, 347);
            this.EmployeeSalesBonusTextBox.Name = "EmployeeSalesBonusTextBox";
            this.EmployeeSalesBonusTextBox.Size = new System.Drawing.Size(213, 22);
            this.EmployeeSalesBonusTextBox.TabIndex = 14;
            // 
            // SharpMailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 483);
            this.Controls.Add(this.EmployeeSalesBonusTextBox);
            this.Controls.Add(this.EmployeeTotalSalesTextBox);
            this.Controls.Add(this.EmployeeHoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeeSalesBonus);
            this.Controls.Add(this.EmployeeTotalSales);
            this.Controls.Add(this.EmployeeHoursWorked);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.LogoPicutreBox);
            this.Controls.Add(this.LanguageBox);
            this.Name = "SharpMailOrder";
            this.Text = "Sales Bonus";
            this.LanguageBox.ResumeLayout(false);
            this.LanguageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicutreBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LanguageBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.PictureBox LogoPicutreBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label EmployeeHoursWorked;
        private System.Windows.Forms.Label EmployeeTotalSales;
        private System.Windows.Forms.Label EmployeeSalesBonus;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.TextBox EmployeeHoursWorkedTextBox;
        private System.Windows.Forms.TextBox EmployeeTotalSalesTextBox;
        private System.Windows.Forms.TextBox EmployeeSalesBonusTextBox;
    }
}

