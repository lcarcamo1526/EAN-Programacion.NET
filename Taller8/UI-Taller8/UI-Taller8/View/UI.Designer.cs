

using System;
using System.Windows.Forms;
using Taller8.Model;

namespace UI_Taller8
{
    partial class UI
    {

        Moneda currency = new Moneda();
        double valor, tax, tax_btc;
        string currencyOrigin, currencyDestine;

        private void CalcularConversion()
        {

            #region variables

           
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

            //Asigna los resultados 
            LabelOrigen.Text = currencyOrigin;
            LabelDestino.Text = currencyDestine;
            destineValue.Text = "" + conversion;
            bitcoinValue.Text = "" + currency.CalcularConversionBitcoin(currencyDestine, conversion, tax_btc);
            #endregion
        }

        /// <summary>
        /// Reinicia variables, lables y inputs
        /// </summary>
        private void ClearData() {
            valor = tax = tax_btc = 0;
            currencyOrigin = currencyDestine = "";
            taxChange.Text = "";
            btxTax.Text = "";
            destineValue.Text = "";
            bitcoinValue.Text = "";
            OriginValue.Text = "";
            LabelOrigen.Text = "";
            LabelDestino.Text = "";
        }

        /// <summary>
        /// Muestra informacion sobre el autor
        /// </summary>
        private void AboutUs() {
            MessageBox.Show("Luis Carcamo - Github: lcarcamo1526");
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
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
            this.LabelDestino = new System.Windows.Forms.Label();
            this.LabelBitcoin = new System.Windows.Forms.Label();
            this.LabelOrigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // About
            // 
            resources.ApplyResources(this.About, "About");
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.Name = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // OriginValue
            // 
            resources.ApplyResources(this.OriginValue, "OriginValue");
            this.OriginValue.Name = "OriginValue";
            this.OriginValue.TextChanged += new System.EventHandler(this.OriginValue_TextChanged);
            this.OriginValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Feel1
            // 
            resources.ApplyResources(this.Feel1, "Feel1");
            this.Feel1.Checked = true;
            this.Feel1.Name = "Feel1";
            this.Feel1.TabStop = true;
            this.Feel1.UseVisualStyleBackColor = true;
            this.Feel1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Feel2
            // 
            resources.ApplyResources(this.Feel2, "Feel2");
            this.Feel2.Name = "Feel2";
            this.Feel2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // CurrencyOrigin
            // 
            resources.ApplyResources(this.CurrencyOrigin, "CurrencyOrigin");
            this.CurrencyOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyOrigin.FormattingEnabled = true;
            this.CurrencyOrigin.Items.AddRange(new object[] {
            resources.GetString("CurrencyOrigin.Items"),
            resources.GetString("CurrencyOrigin.Items1"),
            resources.GetString("CurrencyOrigin.Items2"),
            resources.GetString("CurrencyOrigin.Items3"),
            resources.GetString("CurrencyOrigin.Items4")});
            this.CurrencyOrigin.Name = "CurrencyOrigin";
            this.CurrencyOrigin.Sorted = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // taxChange
            // 
            resources.ApplyResources(this.taxChange, "taxChange");
            this.taxChange.Name = "taxChange";
            this.taxChange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.taxChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // CurrencyDestine
            // 
            resources.ApplyResources(this.CurrencyDestine, "CurrencyDestine");
            this.CurrencyDestine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyDestine.FormattingEnabled = true;
            this.CurrencyDestine.Items.AddRange(new object[] {
            resources.GetString("CurrencyDestine.Items"),
            resources.GetString("CurrencyDestine.Items1"),
            resources.GetString("CurrencyDestine.Items2"),
            resources.GetString("CurrencyDestine.Items3"),
            resources.GetString("CurrencyDestine.Items4")});
            this.CurrencyDestine.Name = "CurrencyDestine";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // destineValue
            // 
            resources.ApplyResources(this.destineValue, "destineValue");
            this.destineValue.Name = "destineValue";
            this.destineValue.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bitcoinValue
            // 
            resources.ApplyResources(this.bitcoinValue, "bitcoinValue");
            this.bitcoinValue.Name = "bitcoinValue";
            this.bitcoinValue.ReadOnly = true;
            this.bitcoinValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CheckCurrency
            // 
            resources.ApplyResources(this.CheckCurrency, "CheckCurrency");
            this.CheckCurrency.BackColor = System.Drawing.Color.Transparent;
            this.CheckCurrency.Name = "CheckCurrency";
            this.CheckCurrency.UseVisualStyleBackColor = false;
            this.CheckCurrency.Click += new System.EventHandler(this.CheckCurrency_Click);
            // 
            // CleanData
            // 
            resources.ApplyResources(this.CleanData, "CleanData");
            this.CleanData.BackColor = System.Drawing.Color.Transparent;
            this.CleanData.Name = "CleanData";
            this.CleanData.UseVisualStyleBackColor = false;
            this.CleanData.Click += new System.EventHandler(this.CleanData_Click);
            // 
            // Exit
            // 
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Name = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btxTax
            // 
            resources.ApplyResources(this.btxTax, "btxTax");
            this.btxTax.Name = "btxTax";
            this.btxTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btxTax_KeyPress);
            // 
            // LabelDestino
            // 
            resources.ApplyResources(this.LabelDestino, "LabelDestino");
            this.LabelDestino.Name = "LabelDestino";
            // 
            // LabelBitcoin
            // 
            resources.ApplyResources(this.LabelBitcoin, "LabelBitcoin");
            this.LabelBitcoin.Name = "LabelBitcoin";
            // 
            // LabelOrigen
            // 
            resources.ApplyResources(this.LabelOrigen, "LabelOrigen");
            this.LabelOrigen.Name = "LabelOrigen";
            // 
            // UI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelOrigen);
            this.Controls.Add(this.LabelBitcoin);
            this.Controls.Add(this.LabelDestino);
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
        private Label LabelDestino;
        private Label LabelBitcoin;
        private Label LabelOrigen;
    }
}

