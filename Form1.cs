using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decimal_tape
{
    public partial class Form1 : Form
    {
        private DecimalString decimalString1;
        private DecimalString decimalString2;
        private StringBase baseString;
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsDecimalStringValid(DecimalString ds)
        {
            return ds.GetLength() != 1;
        }

        private void btnCreateBaseString_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBaseStringInput.Text))
            {
                baseString = new StringBase();
            }
            else if (txtBaseStringInput.Text.Length == 1)
            {
                baseString = new StringBase(txtBaseStringInput.Text[0]);
            }
            else
            {
                baseString = new StringBase(txtBaseStringInput.Text);
            }

            UpdateBaseStringInfo();
        }

        private void UpdateBaseStringInfo()
        {
            lblBaseStringContent.Text = $"Вміст: {baseString.ToString()}";
            lblBaseStringLength.Text = $"Довжина (байти): {baseString.GetLength()}";
        }

        private void btnClearBaseString_Click(object sender, EventArgs e)
        {
            if (baseString != null)
            {
                baseString.Clear();
                UpdateBaseStringInfo();
            }
        }

        private void btnCreateDecimalString1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecimalString1.Text))
            {
                decimalString1 = new DecimalString();
            }
            else
            {
                decimalString1 = new DecimalString(txtDecimalString1.Text);
            }

            UpdateDecimalString1Info();
        }

        private void UpdateDecimalString1Info()
        {
            lblDecimalString1Content.Text = $"Вміст: {decimalString1.ToString()}";
            lblDecimalString1Length.Text = $"Довжина (байти): {decimalString1.GetLength()}";
        }

        private void btnCreateDecimalString2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecimalString2.Text))
            {
                decimalString2 = new DecimalString();
            }
            else
            {
                decimalString2 = new DecimalString(txtDecimalString2.Text);
            }

            UpdateDecimalString2Info();
        }

        private void UpdateDecimalString2Info()
        {
            lblDecimalString2Content.Text = $"Вміст: {decimalString2.ToString()}";
            lblDecimalString2Length.Text = $"Довжина (байти): {decimalString2.GetLength()}";
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (decimalString1 == null || decimalString2 == null)
            {
                MessageBox.Show("Спочатку створіть обидві десяткові стрічки!");
                return;
            }

            if (!IsDecimalStringValid(decimalString1) || !IsDecimalStringValid(decimalString2))
            {
                MessageBox.Show("Одна або обидві стрічки мають невалідне значення!");
                return;
            }

            if (decimalString1 > decimalString2)
            {
                MessageBox.Show("Перша стрічка більша за другу");
            }
            else if (decimalString1 < decimalString2)
            {
                MessageBox.Show("Перша стрічка менша за другу");
            }
            else
            {
                MessageBox.Show("Стрічки рівні");
            }
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            if (decimalString1 == null || decimalString2 == null)
            {
                MessageBox.Show("Спочатку створіть обидві десяткові стрічки!");
                return;
            }

            if (!IsDecimalStringValid(decimalString1) || !IsDecimalStringValid(decimalString2))
            {
                MessageBox.Show("Одна або обидві стрічки мають невалідне значення!");
                return;
            }

            DecimalString result = decimalString1 - decimalString2;
            MessageBox.Show($"Різниця: {result.ToString()}");
        }

        private void btnCreateFromNumber_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberInput.Text, out int number))
            {
                decimalString1 = new DecimalString(number);
                UpdateDecimalString1Info();
                txtDecimalString1.Text = decimalString1.ToString();
            }
            else
            {
                MessageBox.Show("Введіть коректне ціле число!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
