using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_16_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.TextBox T;
        protected global::System.Web.UI.WebControls.Button b1, b2, b3, b4, b5, b6, b7, b8, b9, b0;
        protected global::System.Web.UI.WebControls.Button add, sub, mul, div, clr, eq;
        static float a, c, d;
        static char b;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b1.Text;
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b2.Text;
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b3.Text;
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b4.Text;
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b5.Text;
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b6.Text;
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b7.Text;
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b8.Text;
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b9.Text;
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            if ((T.Text == "+") || (T.Text == "-") || (T.Text == "*") || (T.Text == "/"))
            {
                T.Text = "";
            }
            T.Text = T.Text + b0.Text;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(T.Text);
            T.Text = "";
            b = '+';
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(T.Text);
            T.Text = "";
            b = '-';
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(T.Text);
            T.Text = "";
            b = '*';
        }

        protected void div_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(T.Text);
            T.Text = "";
            b = '/';
        }

        protected void eql_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(T.Text);
            T.Text = "";
            if (b == '/')
            {
                d = a / c;
                T.Text += d;
                a = d;
            }
            else if (b == '+')
            {
                d = a + c;
                T.Text += d;
                a = d;
            }
            else if (b == '-')
            {
                d = a - c;
                T.Text += d;
                a = d;
            }
            else
            {
                d = a * c;
                T.Text += d;
                a = d;
            }
        }

        protected void clr_Click(object sender, EventArgs e)
        {
            T.Text = "";
        }
    }
}