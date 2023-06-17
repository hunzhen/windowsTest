using System;

namespace windowsTest
{

    public partial class Form1 : Form
    {
        #region
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label2.Text = "label2";
            Controls.Add(label2);
        }

        int labell_text_num = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            Label k = sender as Label;
            string[] s = { "Click Me", "Are You Sure", "?" };
            k.Text = s[labell_text_num++];
            labell_text_num %= 3;
        }
        #endregion

        double[] fList = new double[10];
        int listLong = 0;

        private void show()
        {
            //label2.Text = fList[0].ToString();  //int i
            label2.Text = "�����������:\n";
            foreach (double i in fList)
            {
                if (i != 0)
                    label2.Text += i.ToString() + "\n";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox k = sender as TextBox;
            if (e.KeyChar == '\r')   //��ⰴ�µļ��ǲ��ǻس�
            {
                //ɾ��ĩβ�س�
                k.Text = k.Text.Replace("\r", "");
                //ת����double��ֵ
                try//�����
                {
                    fList[listLong++] = double.Parse(k.Text);   //convert.ToDouble(k.Text)
                }
                catch (Exception ex)
                {

                }
                //����ַ���
                k.Text = "";
                show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show();
            double max = -100;
            foreach (double i in fList)
            {
                if (i > max)
                    max = i;
            }
            label1.Text = "���Ϊ" + max.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox k = sender as TextBox;
            k.ForeColor = Color.Black;
            k.Text = "";
        }
    }
}