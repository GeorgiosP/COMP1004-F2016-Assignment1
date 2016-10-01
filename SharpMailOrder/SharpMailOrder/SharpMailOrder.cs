/* The C# Mail Order sales bonus form 
    by Georgios Psarakis
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SharpMailOrder
{
    public partial class SharpMailOrder : Form
    {
        public SharpMailOrder()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void LanguageBox_Enter(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        private void ResetEmployeeTotalSalesTextBox()
        {
            EmployeeTotalSalesTextBox.Focus();
            EmployeeTotalSalesTextBox.Text = " ";
            EmployeeTotalSalesTextBox.SelectAll();
        }
        private void CalculateTotal()
        {
            const double SalesBonusPercent = .02;
            double SalesTotal, BonusAmount, Total, TotalMonthsHours, TotalBonusAmount, SalesBonus,TotalHours;
     
            try
            {
                TotalHours = Convert.ToDouble(EmployeeHoursWorkedTextBox.Text);
                if (TotalHours > 168)
                {
                    MessageBox.Show("The hours worked cannot be greater then 168 hours");

                }
                else
                {

                    //Calculate employee's hours worked in a month
                    TotalMonthsHours = (Convert.ToDouble(TotalHours)) / 160;
                    //Calculate total bonus amount
                    TotalBonusAmount = (Convert.ToDouble(EmployeeTotalSalesTextBox.Text)) * SalesBonusPercent;
                    //Determine value of sales bonus
                    SalesBonus = TotalMonthsHours * TotalBonusAmount;

                    EmployeeSalesBonusTextBox.Text = SalesBonus.ToString("C2");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                EmployeeTotalSalesTextBox.Focus();
                EmployeeTotalSalesTextBox.SelectAll();
                ResetEmployeeTotalSalesTextBox();
                ResetEmployeeHoursWorked();
            }
        }
        private void ResetEmployeeHoursWorked()
        {
            EmployeeHoursWorkedTextBox.Focus();
            EmployeeHoursWorkedTextBox.Text = "";
            EmployeeHoursWorkedTextBox.SelectAll();
        }

    

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear all of the form's text fields
            
            EmployeeSalesBonusTextBox.Clear();
            EmployeeNameTextBox.Clear();
            EmployeeIdTextBox.Clear();
            EmployeeTotalSalesTextBox.Clear();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Message box for printing form
            MessageBox.Show("Your form is printing...");
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            //Change language of form to French
            EmployeeHoursWorked.Text = "Heures Travaillées:";
            EmployeeID.Text = "ID de l'employé:";
            EmployeeTotalSales.Text = "Ventes totales:"; 
            EmployeeSalesBonus.Text = "Bonus de vente:";
            EmployeeName.Text = "Nom de l'employé:";

            LanguageBox.Text = "La Langue";

            CalculateButton.Text = "Calculer";
            PrintButton.Text = "Impression";
            ClearButton.Text = "Effacer"; 


           }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Change language of form to English
            EmployeeName.Text = "Employee Name:";
            EmployeeID.Text = "Employee ID:";
            EmployeeHoursWorked.Text = "Hours Worked:";
            EmployeeSalesBonus.Text = "Sales Bonus:";
            EmployeeTotalSales.Text = "Total Sales:";

            LanguageBox.Text = "Language";
            CalculateButton.Text = "Calculate";
            PrintButton.Text = "Print";
            ClearButton.Text = "Clear";
        
        }
    }
}
