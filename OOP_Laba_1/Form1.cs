using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool alg = true;
        bool trig = false;
        bool exp = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void algebraic_Click(object sender, EventArgs e)
        {
            alg = true;
            trig = false;
            exp = false;

            real1.Visible = alg;
            real1.Enabled = alg;
            label2.Visible = alg;
            imagine1.Visible = alg;
            imagine1.Enabled = alg;
            label3.Visible = alg;
            real2.Visible = alg;
            real2.Enabled = alg;
            label5.Visible = alg;
            imagine2.Visible = alg;
            imagine2.Enabled = alg;
            label6.Visible = alg;

            label27.Visible = exp;
            label26.Visible = exp;
            exp1.Visible = exp;
            exp1.Enabled = exp;
            label25.Visible = exp;
            label24.Visible = exp;
            exp2.Visible = exp;
            exp2.Enabled = exp;
            exp_mod1.Visible = exp;
            exp_mod1.Enabled = exp;
            exp_mod2.Visible = exp;
            exp_mod2.Enabled = exp;

            modul_1.Visible = trig;
            modul_1.Enabled = trig;
            label20.Visible = trig;
            trigenometric_11.Visible = trig;
            trigenometric_11.Enabled = trig;
            label19.Visible = trig;
            trigenometric_12.Visible = trig;
            trigenometric_12.Enabled = trig;
            label18.Visible = trig;
            modul_2.Visible = trig;
            modul_2.Enabled = trig;
            trigenometric_21.Visible = trig;
            trigenometric_21.Enabled = trig;
            label23.Visible = trig;
            label22.Visible = trig;
            trigenometric_22.Visible = trig;
            trigenometric_22.Enabled = trig;
            label21.Visible = trig;
        }

        private void Trigenometric_Click(object sender, EventArgs e)
        {
            alg = false;
            trig = true;
            exp = false;

            real1.Visible = alg;
            real1.Enabled = alg;
            label2.Visible = alg;
            imagine1.Visible = alg;
            imagine1.Enabled = alg;
            label3.Visible = alg;
            real2.Visible = alg;
            real2.Enabled = alg;
            label5.Visible = alg;
            imagine2.Visible = alg;
            imagine2.Enabled = alg;
            label6.Visible = alg;

            label27.Visible = exp;
            label26.Visible = exp;
            exp1.Visible = exp;
            exp1.Enabled = exp;
            label25.Visible = exp;
            label24.Visible = exp;
            exp2.Visible = exp;
            exp2.Enabled = exp;
            exp_mod1.Visible = exp;
            exp_mod1.Enabled = exp;
            exp_mod2.Visible = exp;
            exp_mod2.Enabled = exp;

            modul_1.Visible = trig;
            modul_1.Enabled = trig;
            label20.Visible = trig;
            trigenometric_11.Visible = trig;
            trigenometric_11.Enabled = trig;
            label19.Visible = trig;
            trigenometric_12.Visible = trig;
            trigenometric_12.Enabled = trig;
            label18.Visible = trig;
            modul_2.Visible = trig;
            modul_2.Enabled = trig;
            trigenometric_21.Visible = trig;
            trigenometric_21.Enabled = trig;
            label23.Visible = trig;
            label22.Visible = trig;
            trigenometric_22.Visible = trig;
            trigenometric_22.Enabled = trig;
            label21.Visible = trig;
        }

        private void exoponenian_Click(object sender, EventArgs e)
        {
            alg = false;
            trig = false;
            exp = true;


            real1.Visible = alg;
            real1.Enabled = alg;
            label2.Visible = alg;
            imagine1.Visible = alg;
            imagine1.Enabled = alg;
            label3.Visible = alg;
            real2.Visible = alg;
            real2.Enabled = alg;
            label5.Visible = alg;
            imagine2.Visible = alg;
            imagine2.Enabled = alg;
            label6.Visible = alg;

            label27.Visible = exp;
            label26.Visible = exp;
            exp1.Visible = exp;
            exp1.Enabled = exp;
            label25.Visible = exp;
            label24.Visible = exp;
            exp2.Visible = exp;
            exp2.Enabled = exp;
            exp_mod1.Visible = exp;
            exp_mod1.Enabled = exp;
            exp_mod2.Visible = exp;
            exp_mod2.Enabled = exp;

            modul_1.Visible = trig;
            modul_1.Enabled = trig;
            label20.Visible = trig;
            trigenometric_11.Visible = trig;
            trigenometric_11.Enabled = trig;
            label19.Visible = trig;
            trigenometric_12.Visible = trig;
            trigenometric_12.Enabled = trig;
            label18.Visible = trig;
            modul_2.Visible = trig;
            modul_2.Enabled = trig;
            trigenometric_21.Visible = trig;
            trigenometric_21.Enabled = trig;
            label23.Visible = trig;
            label22.Visible = trig;
            trigenometric_22.Visible = trig;
            trigenometric_22.Enabled = trig;
            label21.Visible = trig;
        }

        private void operator_plus_Click(object sender, EventArgs e)
        {
            if (alg)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(real1.Text, out a1) | !double.TryParse(real2.Text, out a2) | !double.TryParse(imagine1.Text, out b1) | !double.TryParse(imagine2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }
                
                Complex com1 = new Complex(a1, b1, 1);
                Complex com2 = new Complex(a2, b2, 1);
                Complex res = com1 + com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (trig)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(modul_1.Text, out a1) | !double.TryParse(modul_2.Text, out a2) | !double.TryParse(trigenometric_11.Text, out b1) | !double.TryParse(trigenometric_12.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

               

                Complex com1 = new Complex(a1, b1, 2);
                Complex com2 = new Complex(a2, b2, 2);
                Complex res = com1 + com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (exp)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(exp_mod1.Text, out a1) | !double.TryParse(exp_mod2.Text, out a2) | !double.TryParse(exp1.Text, out b1) | !double.TryParse(exp2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 3);
                Complex com2 = new Complex(a2, b2, 3);
                Complex res = com1 + com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
        }

        private void operator_minus_Click(object sender, EventArgs e)
        {
            if (alg)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(real1.Text, out a1) | !double.TryParse(real2.Text, out a2) | !double.TryParse(imagine1.Text, out b1) | !double.TryParse(imagine2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 1);
                Complex com2 = new Complex(a2, b2, 1);
                Complex res = com1 - com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (trig)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(modul_1.Text, out a1) | !double.TryParse(modul_2.Text, out a2) | !double.TryParse(trigenometric_11.Text, out b1) | !double.TryParse(trigenometric_12.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 2);
                Complex com2 = new Complex(a2, b2, 2);
                Complex res = com1 - com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (exp)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(exp_mod1.Text, out a1) | !double.TryParse(exp_mod2.Text, out a2) | !double.TryParse(exp1.Text, out b1) | !double.TryParse(exp2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 2);
                Complex com2 = new Complex(a2, b2, 2);
                Complex res = com1 - com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
        }

        private void operator_multiplication_Click(object sender, EventArgs e)
        {
            if (alg)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(real1.Text, out a1) | !double.TryParse(real2.Text, out a2) | !double.TryParse(imagine1.Text, out b1) | !double.TryParse(imagine2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 1);
                Complex com2 = new Complex(a2, b2, 1);
                Complex res = com1 * com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (trig)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(modul_1.Text, out a1) | !double.TryParse(modul_2.Text, out a2) | !double.TryParse(trigenometric_11.Text, out b1) | !double.TryParse(trigenometric_12.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 2);
                Complex com2 = new Complex(a2, b2, 2);
                Complex res = com1 * com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (exp)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(exp_mod1.Text, out a1) | !double.TryParse(exp_mod2.Text, out a2) | !double.TryParse(exp1.Text, out b1) | !double.TryParse(exp2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 2);
                Complex com2 = new Complex(a2, b2, 2);
                Complex res = com1 * com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
        }

        private void operator_divide_Click(object sender, EventArgs e)
        {
            if (alg)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(real1.Text, out a1) | !double.TryParse(real2.Text, out a2) | !double.TryParse(imagine1.Text, out b1) | !double.TryParse(imagine2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 1);
                Complex com2 = new Complex(a2, b2, 1);
                Complex res = com1 / com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (trig)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(modul_1.Text, out a1) | !double.TryParse(modul_2.Text, out a2) | !double.TryParse(trigenometric_11.Text, out b1) | !double.TryParse(trigenometric_12.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 2);
                Complex com2 = new Complex(a2, b2, 2);
                Complex res = com1 / com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (exp)
            {
                double a1, a2, b1, b2;
                if (!double.TryParse(exp_mod1.Text, out a1) | !double.TryParse(exp_mod2.Text, out a2) | !double.TryParse(exp1.Text, out b1) | !double.TryParse(exp2.Text, out b2))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 2);
                Complex com2 = new Complex(a2, b2, 2);
                Complex res = com1 / com2;
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alg)
            {
                double a1, b1;
                int n;
                if (!double.TryParse(real1.Text, out a1) | !double.TryParse(imagine1.Text, out b1) | !int.TryParse(pow_count.Text, out n))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 1);
                Complex res = new Complex();
                res = Complex.Pow(com1, n);
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
            if (trig)
            {
                double a1, b1;
                int n;
                if (!double.TryParse(modul_1.Text, out a1) | !double.TryParse(trigenometric_11.Text, out b1) | !int.TryParse(sq_count.Text, out n))
                {
                    Form2 newForm = new Form2();
                    newForm.Show();
                }

                Complex com1 = new Complex(a1, b1, 1);
                Complex res = new Complex();
                res = Complex.sq(com1, n);
                real_res.Text = res.get_real().ToString();
                imagin_res.Text = res.get_img().ToString();
                modul_res.Text = res.get_modul().ToString();
                trigenometric_res1.Text = res.get_phi().ToString();
                trigenometric_res2.Text = res.get_phi().ToString();
                exp_modul_res.Text = res.get_modul().ToString();
                exp_res.Text = res.get_phi().ToString();
            }
        }
       
    }
}
