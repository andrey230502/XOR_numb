using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOR_numb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP_Hex = textBoxP_Hex.Text;
            int intP_Hex  = Convert.ToInt32(strP_Hex, 16); // 16-система Р
           
            textBoxP_R.Text = strP_Hex;

            string strKey_Hex = textBoxKey_Hex.Text;
            int intKey_Hex = Convert.ToInt32(strKey_Hex, 16); // 16-система Ключа
            textBoxKey_R.Text = strKey_Hex;

            int intC_Hex = intP_Hex ^ intKey_Hex;
            string strC_Hex = Convert.ToString(intC_Hex, 16); // Шифратор

            textBoxC_Hex.Text = strC_Hex;
            textBoxC_R.Text = strC_Hex;

            textBoxP_Dec.Text = Convert.ToString(intP_Hex, 10); //
            textBoxKey_Dec.Text = Convert.ToString(intKey_Hex, 10);
            textBoxC_Dec.Text = Convert.ToString(intC_Hex, 10);

            textBox_P.Text = Convert.ToString(intP_Hex, 2); //
            textBox_Key.Text = Convert.ToString(intKey_Hex, 2);
            textBox_C.Text = Convert.ToString(intC_Hex, 2);

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBoxC_Hex.Text = "";
            textBoxKey_Hex.Text = "";
            textBoxP_Hex.Text = "";

            textBoxC_Dec.Text = "";
            textBoxKey_Dec.Text = "";
            textBoxP_Dec.Text = "";

            textBox_C.Text = "";
            textBox_Key.Text = "";
            textBox_P.Text = "";

            textBoxC_R.Text = "";
            textBoxKey_R.Text = "";
            textBoxP_R.Text = "";
        }
    }
}
