using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BASAMAK_AYIRMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Değişkenler

        int x1=0,x2=0,x3=3;

        string k = ".";

        string f;

        #endregion
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            foreach (char b in textBox1.Text)
            {
                x1++;
                x2++;
            }

            if (x1 % x3 == 0)
            {
                x1 = 0;

                x3 = x3 + 4;
                f = textBox1.Text.Insert(x2, k);
                textBox1.Text = f;


               textBox1.SelectionStart = textBox1.Text.Length;
               textBox1.Focus();

               // yukarıdaki iki satırlık kodun yaptığı işlemi tek başına aşağıdaki
               // açıklama satırı içindeki kodda yapabilir. amacımız imleci textboxın son 
               // karakterine focuslamak.

               //SendKeys.Send("^{END}"); 
                
                x2= 0;

            }
               
            else
            {
                x1 = 0;
                x2 = 0;
            }
             
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
