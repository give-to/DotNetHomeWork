using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeWork7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int n;
        double leng;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = new Pen(Color.Black,1);
        double startX;
        double startY;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {            
            n = Int32.Parse(tbN.Text);
            
            leng = Double.Parse(tbLeng.Text);
           
            per1 = Double.Parse(tbPer1.Text);
            
            per2 = Double.Parse(tbPer2.Text);
            
            th1 = Double.Parse(tbTh1.Text) * Math.PI / 180;
            
            th2 = Double.Parse(tbTh2.Text) * Math.PI / 180;
           
            startX = (this.Left + this.Right) / 2;
            startY = this.Bottom;
            
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }

            drawCayleyTree(n = 10, 250, 300, leng = 100, -Math.PI / 2);
        }

        private void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);


        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen,(int)x0,(int)y0,(int)x1,(int)y1);
        }
        
        private void Form1_Activated(object sender, EventArgs e)
        {
            startX = (this.Left+this.Right)/ 2;
            startY = this.Bottom;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog ColorForm = new ColorDialog();
            if (ColorForm.ShowDialog() == DialogResult.OK)
            {
                Color GetColor = ColorForm.Color;
                //GetColor就是用户选择的颜色，接下来就可以使用该颜色了
                pen.Color = GetColor;
            }
        }
    }
}
