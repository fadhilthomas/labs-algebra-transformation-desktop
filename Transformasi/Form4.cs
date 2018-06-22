using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Transformasi
{
    public partial class Form4 : Form
    {
        static Huruf hurufA = new Huruf();
        static Huruf hurufB = new Huruf();
        static Huruf hurufC = new Huruf();
        static Huruf hurufD = new Huruf();
        static Huruf hurufE = new Huruf();
        static Huruf hurufF = new Huruf();
        static Huruf hurufG = new Huruf();
        static Huruf hurufH = new Huruf();
        static Huruf hurufI = new Huruf();
        static Huruf hurufJ = new Huruf();
        static Huruf hurufK = new Huruf();
        static Huruf hurufL = new Huruf();
        static Huruf hurufM = new Huruf();
        static Huruf hurufN = new Huruf();
        static Huruf hurufO = new Huruf();
        static Huruf hurufP = new Huruf();
        static Huruf hurufQ = new Huruf();
        static Huruf hurufR = new Huruf();
        static Huruf hurufS = new Huruf();
        static Huruf hurufT = new Huruf();
        static Huruf hurufU = new Huruf();
        static Huruf hurufV = new Huruf();
        static Huruf hurufW = new Huruf();
        static Huruf hurufX = new Huruf();
        static Huruf hurufY = new Huruf();
        static Huruf hurufZ = new Huruf();

        static Huruf hurufAaksen = new Huruf();
        static Huruf hurufBaksen = new Huruf();
        static Huruf hurufCaksen = new Huruf();
        static Huruf hurufDaksen = new Huruf();
        static Huruf hurufEaksen = new Huruf();
        static Huruf hurufFaksen = new Huruf();
        static Huruf hurufGaksen = new Huruf();
        static Huruf hurufHaksen = new Huruf();
        static Huruf hurufIaksen = new Huruf();
        static Huruf hurufJaksen = new Huruf();
        static Huruf hurufKaksen = new Huruf();
        static Huruf hurufLaksen = new Huruf();
        static Huruf hurufMaksen = new Huruf();
        static Huruf hurufNaksen = new Huruf();
        static Huruf hurufOaksen = new Huruf();
        static Huruf hurufPaksen = new Huruf();
        static Huruf hurufQaksen = new Huruf();
        static Huruf hurufRaksen = new Huruf();
        static Huruf hurufSaksen = new Huruf();
        static Huruf hurufTaksen = new Huruf();
        static Huruf hurufUaksen = new Huruf();
        static Huruf hurufVaksen = new Huruf();
        static Huruf hurufWaksen = new Huruf();
        static Huruf hurufXaksen = new Huruf();
        static Huruf hurufYaksen = new Huruf();
        static Huruf hurufZaksen = new Huruf();

        Huruf[] hurufKum = { hurufA, hurufB, hurufC, hurufD, hurufE, hurufF, hurufG, hurufH, hurufI, hurufJ, hurufK, hurufL, hurufM, hurufN, hurufO, hurufP, hurufQ, hurufR, hurufS, hurufT, hurufU, hurufV, hurufW, hurufX, hurufY, hurufZ };
        Huruf[] hurufAksen = { hurufAaksen, hurufBaksen, hurufCaksen, hurufDaksen, hurufEaksen, hurufFaksen, hurufGaksen, hurufHaksen, hurufIaksen, hurufJaksen, hurufKaksen, hurufLaksen, hurufMaksen, hurufNaksen, hurufOaksen, hurufPaksen, hurufQaksen, hurufRaksen, hurufSaksen, hurufTaksen, hurufUaksen, hurufVaksen, hurufWaksen, hurufXaksen, hurufYaksen, hurufZaksen };
        PictureBox[] titik = new PictureBox[26];
        PictureBox[] titikAksen = new PictureBox[26];
        Label[] labelHuruf = new Label[26];
        Label[] labelHurufAksen = new Label[26];

        private double DegreeToRadian(double angle)
        {
            return angle * (Math.PI / 180.0);
        }

        private double RadiantoDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private int XAksenRev(double angle, int x, int y)
        {
            return (int)((x * Math.Round(Math.Cos(DegreeToRadian(angle)),2)) - (y * Math.Round(Math.Sin(DegreeToRadian(angle)))));
        }

        private int YAksenRev(double angle, int x, int y)
        {
            return (int)((x * Math.Round(Math.Sin(DegreeToRadian(angle)))) + (y * Math.Round(Math.Cos(DegreeToRadian(angle)))));
        }

        private int XAksenSea(double angle, int x, int y)
        {
            return (int)((x * Math.Round(Math.Cos(DegreeToRadian(angle * -1.0)))) - (y * Math.Round(Math.Sin(DegreeToRadian(angle * -1.0)))));
        }

        private int YAksenSea(double angle, int x, int y)
        {
            return (int)((x * Math.Round(Math.Sin(DegreeToRadian(angle * -1.0)))) + (y * Math.Round(Math.Cos(DegreeToRadian(angle * -1.0)))));
        }

        private double xAksenDil(int a, int b, double k, int x, int y)
        {
            return a + (k * (x - a));
        }

        private double yAksenDil(int a, int b, double k, int x, int y)
        {
            return b + (k * (y - b));
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnBuat;
            comboBox2.SelectedIndex = 0;
            for (int i = 0; i < titik.Length; i++)
            {
                titik[i] = (PictureBox)Controls.Find("pictureBox" + (i + 1).ToString(), true)[0];
            }
            for (int i = 0; i < labelHuruf.Length; i++)
            {
                labelHuruf[i] = (Label)Controls.Find("label" + (i + 13).ToString(), true)[0];
            }

            for (int i = 0; i < titikAksen.Length; i++)
            {
                titikAksen[i] = (PictureBox)Controls.Find("pictureBox" + (i + 27).ToString(), true)[0];
            }
            for (int i = 0; i < labelHurufAksen.Length; i++)
            {
                labelHurufAksen[i] = (Label)Controls.Find("label" + (i + 40).ToString(), true)[0];
            }
        }


        int[] conX = new int[26];
        int[] conY = new int[26];
        int[] conXAksen = new int[26];
        int[] conYAksen = new int[26];
        int con = 0;
        Point[] pt = new Point[26];
        int[] xPt = new int[26];
        int[] yPt = new int[26];
        Point[] ptAksen = new Point[26];
        int[] xPtAksen = new int[26];
        int[] yPtAksen = new int[26];

        private void btnBuat_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem!=null)
            {
                int huruf = comboBox2.SelectedIndex;
                int x = int.Parse(textBox4.Text);
                int y = int.Parse(textBox3.Text);
                if (hurufKum[huruf].getEn() == 0)
                {
                    hurufKum[huruf].setX(x);
                    hurufKum[huruf].setY(y);
                    labelHuruf[huruf].Text = comboBox2.SelectedItem.ToString();
                    labelHuruf[huruf].Location = new Point(328, 320);
                    labelHuruf[huruf].Visible = true;
                    labelHuruf[huruf].Location = new Point(labelHuruf[huruf].Location.X + (22 * x), labelHuruf[huruf].Location.Y - (22 * y));
                    titik[huruf].Location = new Point(348, 332);
                    titik[huruf].Visible = true;
                    titik[huruf].BringToFront();
                    titik[huruf].Location = new Point(titik[huruf].Location.X + (22 * x), titik[huruf].Location.Y - (22 * y));
                    hurufKum[huruf].setEn(1);
                    
                    conX[con] = titik[huruf].Location.X + 5;
                    conY[con] = titik[huruf].Location.Y + 5;
                    con++;

                    comboBox2.SelectedIndex = (huruf + 1);

                }
                else
                {
                    MessageBox.Show("Titik sudah dibuat !");
                }
            }
            else
            {
                MessageBox.Show("Pilih huruf !");
            }
        }

        private void btnTerapkan_Click(object sender, EventArgs e)
        {
            Array.Clear(pt, 0, 26);
            Array.Clear(ptAksen, 0, 26);
            Array.Clear(xPt, 0, 26);
            Array.Clear(xPtAksen, 0, 26);
            Array.Clear(yPt, 0, 26);
            Array.Clear(yPtAksen, 0, 26);
            con = 0;
            double xAksen = 0;
            double yAksen = 0;
            for (int i = 0; i < hurufKum.Length; i++)
            {
                if (hurufKum[i].getEn() == 1)
                {
                    labelHurufAksen[i].Text = labelHuruf[i].Text + "'";
                    xAksen = xAksenDil(int.Parse(textBox7.Text), int.Parse(textBox8.Text), double.Parse(textBox6.Text), hurufKum[i].getX(), hurufKum[i].getY());
                    yAksen = yAksenDil(int.Parse(textBox7.Text), int.Parse(textBox8.Text), double.Parse(textBox6.Text), hurufKum[i].getX(), hurufKum[i].getY());
                    hurufAksen[i].setXDil(xAksen);
                    hurufAksen[i].setYDil(yAksen);
                    labelHurufAksen[i].Visible = false;
                    labelHurufAksen[i].Location = new Point(328, 320);
                    labelHurufAksen[i].Location = new Point(labelHurufAksen[i].Location.X + (int)(22 * hurufAksen[i].getXDil()), labelHurufAksen[i].Location.Y - (int)(22 * hurufAksen[i].getYDil()));
                    labelHurufAksen[i].BringToFront();
                    labelHurufAksen[i].Visible = true;
                    titikAksen[i].Visible = false;
                    titikAksen[i].Location = new Point(348, 332);
                    titikAksen[i].Location = new Point(titikAksen[i].Location.X + (int)(22 * hurufAksen[i].getXDil()), titikAksen[i].Location.Y - (int)(22 * hurufAksen[i].getYDil()));
                    titikAksen[i].Visible = true;
                    titikAksen[i].BringToFront();

                    conXAksen[con] = titikAksen[i].Location.X + 5;
                    conYAksen[con] = titikAksen[i].Location.Y + 5;
                    con++;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                xPt[i] = conX[i];
                yPt[i] = conY[i];
                xPtAksen[i] = conXAksen[i];
                yPtAksen[i] = conYAksen[i];
                if ((conX[i] == 0) && (conY[i] == 0))
                {
                    xPt[i] = xPt[0];
                    yPt[i] = yPt[0];
                    xPtAksen[i] = xPtAksen[0];
                    yPtAksen[i] = yPtAksen[0];
                    break;
                }
            }

            groupBox1.Invalidate();

            if (gambarIn == true)
            {
                double xGambar = ((double)(nmGambarT.Value)*(double)(textBox6.Value)) - 1;
                pictGambarAksen.Visible = true;
                pictGambarAksen.ImageLocation = pictGambar.ImageLocation;
                pictGambarAksen.Size = pictGambar.Size;
                pictGambarAksen.Size = new Size((int)((double)(textBox6.Value)*pictGambarAksen.Size.Width),(int)((double)(textBox6.Value)*pictGambarAksen.Size.Height));
                pictGambarAksen.Location = new Point(355, 314);
                pictGambarAksen.Location = new Point(pictGambarAksen.Location.X + (int)(22 * hurufAksen[25].getXDil()), pictGambarAksen.Location.Y - (int)(22 * (hurufAksen[25].getYDil() + xGambar)));
                pictGambarAksen.BringToFront();
                pictGambarAksen.BackColor = label65.ForeColor;
                pictGambarAksen.Padding = new Padding(2);
                labelHurufAksen[25].Location = new Point(labelHurufAksen[25].Location.X - 5, labelHurufAksen[25].Location.Y);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            con = 0;
            Array.Clear(pt, 0, 26);
            Array.Clear(ptAksen, 0, 26);
            Array.Clear(xPt, 0, 26);
            Array.Clear(xPtAksen, 0, 26);
            Array.Clear(yPt, 0, 26);
            Array.Clear(yPtAksen, 0, 26);
            Array.Clear(conX, 0, 26);
            Array.Clear(conXAksen, 0, 26);
            Array.Clear(conYAksen, 0, 26);
            Array.Clear(conY, 0, 26);
            groupBox1.Invalidate();
            for (int i = 0; i < hurufKum.Length; i++)
            {
                hurufKum[i].setEn(0);
                labelHurufAksen[i].Visible = false;
                labelHuruf[i].Visible = false;
                titikAksen[i].Visible = false;
                titik[i].Visible = false;
            }

            pictGambar.Visible = false;
            pictGambarAksen.Visible = false;
            gambarIn = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    btnReset.PerformClick();
                    this.Hide();
                    var form5 = new Form5();
                    form5.ShowDialog();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 3);
            float[] dashValues = { 2, 3, 2, 3 };
            Pen pAksen = new Pen(Color.FromArgb(0, 162, 232), 5);
            pAksen.DashPattern = dashValues;
            Graphics graphics = e.Graphics;
            for (int i = 0; i < pt.Length - 1; i++)
            {
                if (xPt[i + 1] != 0)
                {
                    pt[i] = new Point(xPt[i], yPt[i]);
                    pt[i + 1] = new Point(xPt[i + 1], yPt[i + 1]);
                    ptAksen[i] = new Point(xPtAksen[i], yPtAksen[i]);
                    ptAksen[i + 1] = new Point(xPtAksen[i + 1], yPtAksen[i + 1]);
                    graphics.DrawLine(p, pt[i], pt[i + 1]);
                    graphics.DrawLine(pAksen, ptAksen[i], ptAksen[i + 1]);
                }
            }
            graphics.Dispose();
        }

        public String rumus()
        {
            String rumus = "";
            String dik = "Diketahui : \r\n";
            int a = int.Parse(textBox7.Text);
            int b = int.Parse(textBox8.Text);
            double k = double.Parse(textBox6.Text);
            for (int i = 0; i < labelHuruf.Length; i++)
            {
                if (hurufKum[i].getEn() == 1)
                {
                    dik += labelHuruf[i].Text;
                    dik += " = ( ";
                    dik += hurufKum[i].getX() + ", ";
                    dik += hurufKum[i].getY();
                    dik += " )   ";
                }
            }

            dik += "\r\nP = ( a, b ) --> ( " + textBox7.Text + ", " + textBox8.Text + " )";
            dik += "\r\nk = " + textBox6.Text;

            String jawab = "\r\n\r\nJawab :\r\n";
            for (int i = 0; i < labelHuruf.Length; i++)
            {
                if (hurufKum[i].getEn() == 1)
                {
                    jawab += labelHuruf[i].Text;
                    jawab += " = ( ";
                    jawab += hurufKum[i].getX() + ", ";
                    jawab += hurufKum[i].getY();
                    jawab += " ) \t --->\t";
                    jawab += labelHuruf[i].Text + "' = (" + hurufAksen[i].getXDil() + ", " + hurufAksen[i].getYDil() + ")\r\n";
                    jawab += labelHuruf[i].Text + "' = ( a + k ( x - a ), b + k ( y - b ))";
                    jawab += "\r\n" + labelHuruf[i].Text + "' = (" + a + " + " + k + " ( " + hurufKum[i].getX() + " - " + a + " ), " + b + " + " + k + " ( " + hurufKum[i].getY() + " - " + b + " ))";
                    jawab += "\r\n" + labelHuruf[i].Text + "' = (" + a + " + " + k + " ( " + (hurufKum[i].getX() - a) + " ), " + b + " + " + k + " ( " + (hurufKum[i].getY() - b) + " ))";
                    jawab += "\r\n" + labelHuruf[i].Text + "' = (" + a + " + " + (k * (hurufKum[i].getX() - a)) + ", " + b + " + " + (k * (hurufKum[i].getY() - b)) + " )";
                    jawab += "\r\n" + labelHuruf[i].Text + "' = (" + hurufAksen[i].getXDil() + ", " + hurufAksen[i].getYDil() + ")\r\n";
                    jawab += "\r\n";
                }

            }
            rumus = dik + jawab;
            return rumus;
        }

        private void btnRumus_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.groupBox1.Text = "Dilatasi";
            form6.label3.Text="P, k";
            form6.label3.Location = new Point(form6.label3.Location.X + 15, form6.label3.Location.Y);
            form6.label2.Text = "P' (a+k(x-a), b+k(y-b))";
            form6.textBox1.Text = rumus();
            form6.ShowDialog();
        }


        private void btGambarBuka_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictGambar.ImageLocation = openFileDialog1.FileName;
            pictGambar.Visible = true;

        }

        bool gambarIn = false;
        private void btGambarTerapkan_Click(object sender, EventArgs e)
        {
            int xGambar = (int)(nmGambarT.Value) - 1;
            pictGambar.Size = new Size(22 * (int)nmGambarL.Value, 22 * (int)nmGambarT.Value);
            pictGambar.Location = new Point(355, 314);
            pictGambar.Location = new Point(pictGambar.Location.X + (22 * (int)nmGambarX.Value), pictGambar.Location.Y - (22 * ((int)(nmGambarY.Value) + xGambar)));
            hurufKum[25].setX((int)nmGambarX.Value);
            hurufKum[25].setY((int)nmGambarY.Value);
            hurufKum[25].setEn(1);
            titik[25].Location = new Point(348, 332);
            titik[25].Location = new Point(titik[25].Location.X + (22 * (int)nmGambarX.Value), titik[25].Location.Y - (22 * (int)nmGambarY.Value));
            titik[25].Visible = true;
            labelHuruf[25].Location = new Point(328, 320);
            labelHuruf[25].Location = new Point(labelHuruf[25].Location.X + (22 * (int)nmGambarX.Value), labelHuruf[25].Location.Y - (22 * (int)nmGambarY.Value));
            labelHuruf[25].Text = "im";
            labelHuruf[25].Visible = true;
            pictGambar.BringToFront();
            gambarIn = true;
        }
    }
}
