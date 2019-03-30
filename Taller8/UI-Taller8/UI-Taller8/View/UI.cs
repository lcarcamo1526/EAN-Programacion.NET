using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI_Taller8 {
    public partial class UI : Form {
        public UI() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
        }

        private void label5_Click(object sender, EventArgs e) {
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e) {
        }

        private void label9_Click(object sender, EventArgs e) {
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
        }

        private void CheckCurrency_Click(object sender, EventArgs e)
        {
            CalcularConversion();
        }

        private void OriginValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CleanData_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutUs();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}