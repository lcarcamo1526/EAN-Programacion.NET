

using System;
using System.Windows.Forms;
using Taller8.Model;

namespace UI_Taller8
{
    partial class UI
    {

        Moneda currency = new Moneda();


        private void CalcularConversion()
        {

            #region variables

            double valor, tax, tax_btc;
            string currencyOrigin, currencyDestine;
            currencyDestine = currencyOrigin = "";

            #endregion

            #region Tasa de cambio - Dolar

            Double.TryParse(OriginValue.Text, out valor);
            if (valor == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de su moneda");
            }
            else
            {
                currency.Valor = valor;
            }

            #endregion

            #region Moneda de origen
            if (CurrencyOrigin.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione moneda de origen");
            }
            else
            {
                currencyOrigin = CurrencyOrigin.SelectedItem.ToString();
                currency.Nombre = currencyOrigin;
            }
            #endregion

            #region Moneda de destino
            if (currency.Nombre == currencyDestine)
            {
                MessageBox.Show("La moneda de origen y de destino no pueden ser las mismas");

            }
            else if (CurrencyDestine.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleciona una moneda de  destino");
            }
            else { currencyDestine = (string)CurrencyDestine.SelectedItem; }


            #endregion


            #region Conversion de monedas
            // Intenta castear la tasa de cambio de string a double
            double.TryParse(taxChange.Text, out tax);
            if (tax == 0)
            {
                MessageBox.Show("Por favor ingresa una tasa valida");
            }
            var conversion = currency.CalcularConversionMoneda(Feel1.Checked, tax);
            double.TryParse(btxTax.Text, out tax_btc);
            if (tax_btc == 0)
            {
                MessageBox.Show("Por favor ingrese una tasa de Bitcoin");
            }


            destineValue.Text = "" + conversion;
            bitcoinValue.Text = "" + currency.CalcularConversionBitcoin(currencyDestine, conversion, tax_btc);
            #endregion
        }

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
            this.label1 = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Button();
            this.OriginValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Feel1 = new System.Windows.Forms.RadioButton();
            this.Feel2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrencyOrigin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.taxChange = new System.Windows.Forms.TextBox();
            this.CurrencyDestine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.destineValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bitcoinValue = new System.Windows.Forms.TextBox();
            this.CheckCurrency = new System.Windows.Forms.Button();
            this.CleanData = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btxTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion de Monedas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.Font = new System.Drawing.Font("Arial", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(420, 234);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(113, 31);
            this.About.TabIndex = 1;
            this.About.Text = "Acerca de";
            this.About.UseVisualStyleBackColor = false;
            // 
            // OriginValue
            // 
            this.OriginValue.Location = new System.Drawing.Point(160, 99);
            this.OriginValue.Name = "OriginValue";
            this.OriginValue.Size = new System.Drawing.Size(144, 20);
            this.OriginValue.TabIndex = 2;
            this.OriginValue.TextChanged += new System.EventHandler(this.OriginValue_TextChanged);
            this.OriginValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Moneda destino";
            // 
            // Feel1
            // 
            this.Feel1.AutoSize = true;
            this.Feel1.Checked = true;
            this.Feel1.Location = new System.Drawing.Point(190, 245);
            this.Feel1.Name = "Feel1";
            this.Feel1.Size = new System.Drawing.Size(114, 19);
            this.Feel1.TabIndex = 5;
            this.Feel1.TabStop = true;
            this.Feel1.Text = "Origen - Destino";
            this.Feel1.UseVisualStyleBackColor = true;
            this.Feel1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Feel2
            // 
            this.Feel2.AutoSize = true;
            this.Feel2.Location = new System.Drawing.Point(190, 276);
            this.Feel2.Name = "Feel2";
            this.Feel2.Size = new System.Drawing.Size(114, 19);
            this.Feel2.TabIndex = 6;
            this.Feel2.Text = "Destino - Origen";
            this.Feel2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion Conversion";
            // 
            // CurrencyOrigin
            // 
            this.CurrencyOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyOrigin.FormattingEnabled = true;
            this.CurrencyOrigin.Items.AddRange(new object[] {
            "Dolares",
            "Euros",
            "Pesos",
            "Yenes",
            "Yuanes"});
            this.CurrencyOrigin.Location = new System.Drawing.Point(160, 135);
            this.CurrencyOrigin.Name = "CurrencyOrigin";
            this.CurrencyOrigin.Size = new System.Drawing.Size(144, 21);
            this.CurrencyOrigin.Sorted = true;
            this.CurrencyOrigin.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Moneda origen";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tasa de cambio";
            // 
            // taxChange
            // 
            this.taxChange.Location = new System.Drawing.Point(160, 208);
            this.taxChange.Name = "taxChange";
            this.taxChange.Size = new System.Drawing.Size(144, 20);
            this.taxChange.TabIndex = 10;
            this.taxChange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.taxChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // CurrencyDestine
            // 
            this.CurrencyDestine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyDestine.FormattingEnabled = true;
            this.CurrencyDestine.Items.AddRange(new object[] {
            "Dolares",
            "Yenes",
            "Yuanes",
            "Euros",
            "Pesos"});
            this.CurrencyDestine.Location = new System.Drawing.Point(160, 176);
            this.CurrencyDestine.Name = "CurrencyDestine";
            this.CurrencyDestine.Size = new System.Drawing.Size(144, 21);
            this.CurrencyDestine.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resultado de Conversion";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // destineValue
            // 
            this.destineValue.Location = new System.Drawing.Point(549, 79);
            this.destineValue.Name = "destineValue";
            this.destineValue.ReadOnly = true;
            this.destineValue.Size = new System.Drawing.Size(144, 20);
            this.destineValue.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor destino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor bitcoin";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bitcoinValue
            // 
            this.bitcoinValue.Location = new System.Drawing.Point(549, 116);
            this.bitcoinValue.Name = "bitcoinValue";
            this.bitcoinValue.ReadOnly = true;
            this.bitcoinValue.Size = new System.Drawing.Size(144, 20);
            this.bitcoinValue.TabIndex = 16;
            this.bitcoinValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CheckCurrency
            // 
            this.CheckCurrency.BackColor = System.Drawing.Color.Transparent;
            this.CheckCurrency.Font = new System.Drawing.Font("Arial", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCurrency.Location = new System.Drawing.Point(420, 168);
            this.CheckCurrency.Name = "CheckCurrency";
            this.CheckCurrency.Size = new System.Drawing.Size(113, 31);
            this.CheckCurrency.TabIndex = 18;
            this.CheckCurrency.Text = "Calcular";
            this.CheckCurrency.UseVisualStyleBackColor = false;
            this.CheckCurrency.Click += new System.EventHandler(this.CheckCurrency_Click);
            // 
            // CleanData
            // 
            this.CleanData.BackColor = System.Drawing.Color.Transparent;
            this.CleanData.Font = new System.Drawing.Font("Arial", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanData.Location = new System.Drawing.Point(580, 165);
            this.CleanData.Name = "CleanData";
            this.CleanData.Size = new System.Drawing.Size(113, 31);
            this.CleanData.TabIndex = 19;
            this.CleanData.Text = "Limpiar";
            this.CleanData.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Arial", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(580, 236);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 31);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tasa Bitcoin";
            // 
            // btxTax
            // 
            this.btxTax.Location = new System.Drawing.Point(160, 313);
            this.btxTax.Name = "btxTax";
            this.btxTax.Size = new System.Drawing.Size(144, 20);
            this.btxTax.TabIndex = 22;
            this.btxTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btxTax_KeyPress);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 366);
            this.Controls.Add(this.btxTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CleanData);
            this.Controls.Add(this.CheckCurrency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bitcoinValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.destineValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CurrencyDestine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taxChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CurrencyOrigin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Feel2);
            this.Controls.Add(this.Feel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OriginValue);
            this.Controls.Add(this.About);
            this.Controls.Add(this.label1);
            this.Name = "UI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.TextBox OriginValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Feel1;
        private System.Windows.Forms.RadioButton Feel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CurrencyOrigin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox taxChange;
        private System.Windows.Forms.ComboBox CurrencyDestine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox destineValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bitcoinValue;
        private System.Windows.Forms.Button CheckCurrency;
        private System.Windows.Forms.Button CleanData;
        private System.Windows.Forms.Button Exit;
        private Label label10;
        private TextBox btxTax;
    }
}

