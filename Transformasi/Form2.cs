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
    public partial class Form2 : Form
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

        static HurufAksen hurufAaksen = new HurufAksen();
        static HurufAksen hurufBaksen = new HurufAksen();
        static HurufAksen hurufCaksen = new HurufAksen();
        static HurufAksen hurufDaksen = new HurufAksen();
        static HurufAksen hurufEaksen = new HurufAksen();
        static HurufAksen hurufFaksen = new HurufAksen();
        static HurufAksen hurufGaksen = new HurufAksen();
        static HurufAksen hurufHaksen = new HurufAksen();
        static HurufAksen hurufIaksen = new HurufAksen();
        static HurufAksen hurufJaksen = new HurufAksen();
        static HurufAksen hurufKaksen = new HurufAksen();
        static HurufAksen hurufLaksen = new HurufAksen();
        static HurufAksen hurufMaksen = new HurufAksen();
        static HurufAksen hurufNaksen = new HurufAksen();
        static HurufAksen hurufOaksen = new HurufAksen();
        static HurufAksen hurufPaksen = new HurufAksen();
        static HurufAksen hurufQaksen = new HurufAksen();
        static HurufAksen hurufRaksen = new HurufAksen();
        static HurufAksen hurufSaksen = new HurufAksen();
        static HurufAksen hurufTaksen = new HurufAksen();
        static HurufAksen hurufUaksen = new HurufAksen();
        static HurufAksen hurufVaksen = new HurufAksen();
        static HurufAksen hurufWaksen = new HurufAksen();
        static HurufAksen hurufXaksen = new HurufAksen();
        static HurufAksen hurufYaksen = new HurufAksen();
        static HurufAksen hurufZaksen = new HurufAksen();

        Huruf[] hurufKum = { hurufA, hurufB, hurufC, hurufD, hurufE, hurufF, hurufG, hurufH, hurufI, hurufJ, hurufK, hurufL, hurufM, hurufN, hurufO, hurufP, hurufQ, hurufR, hurufS, hurufT, hurufU, hurufV, hurufW, hurufX, hurufY, hurufZ };
        HurufAksen[] hurufAksen = { hurufAaksen, hurufBaksen, hurufCaksen, hurufDaksen, hurufEaksen, hurufFaksen, hurufGaksen, hurufHaksen, hurufIaksen, hurufJaksen, hurufKaksen, hurufLaksen, hurufMaksen, hurufNaksen, hurufOaksen, hurufPaksen, hurufQaksen, hurufRaksen, hurufSaksen, hurufTaksen, hurufUaksen, hurufVaksen, hurufWaksen, hurufXaksen, hurufYaksen, hurufZaksen };
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

        private double XAksenRev2(double angle, int x, int y)
        {
            return ((x * Math.Round(Math.Cos(DegreeToRadian(angle)), 2)) - (y * Math.Round(Math.Sin(DegreeToRadian(angle)), 2)));
        }

        private double YAksenRev2(double angle, int x, int y)
        {
            return ((x * Math.Round(Math.Sin(DegreeToRadian(angle)), 2)) + (y * Math.Round(Math.Cos(DegreeToRadian(angle)), 2)));
        }

        private double XAksenSea2(double angle, int x, int y)
        {
            return ((x * Math.Round(Math.Cos(DegreeToRadian(angle * -1.0)), 2)) - (y * Math.Round(Math.Sin(DegreeToRadian(angle * -1.0)), 2)));
        }

        private double YAksenSea2(double angle, int x, int y)
        {
            return ((x * Math.Round(Math.Sin(DegreeToRadian(angle * -1.0)), 2)) + (y * Math.Round(Math.Cos(DegreeToRadian(angle * -1.0)), 2)));
        }


        public String rumus()
        {
            String rumus = "";
            String dik = "Diketahui : \r\n";
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

            if ((radioButton1.Checked == true) && (radioButton2.Checked == false))
            {
                dik += "\r\nα = " + textBox5.Text + "°\r\nO = (0, 0)\r\nRotasi = Searah jarum jam\r\n\r\n";
            }
            else if ((radioButton1.Checked == false) && (radioButton2.Checked == true))
            {
                dik += "\r\nα = " + textBox5.Text + "°\r\nO = (0, 0)\r\nRotasi = Berlawanan arah jarum jam\r\n\r\n";
            }

            String rumusRot = "P' (x cos α - y sin α,  x sin α + y cos α)\r\n► Untuk rotasi searah jarum jam, sudut diberi tanda negatif (–)\r\n► Untuk rotasi berlawanan arah jarum jam, sudut diberi tanda positif (+)\r\n\r\n";
            String jawab = "\r\nJawab :\r\n";
            for (int i = 0; i < labelHuruf.Length; i++)
            {
                if (hurufKum[i].getEn() == 1)
                {
                    jawab += labelHuruf[i].Text;
                    jawab += " = ( ";
                    jawab += hurufKum[i].getX() + ", ";
                    jawab += hurufKum[i].getY();
                    jawab += " ) \t --->\t";
                    jawab += labelHuruf[i].Text + "' = (" + XAksenSea2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY()) + ", " + YAksenSea2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY()) + ")\r\n";
                    jawab += labelHuruf[i].Text + "' = (x cos α - y sin α,  x sin α + y cos α)";
                    if ((radioButton1.Checked == true) && (radioButton2.Checked == false))
                    {
                        jawab += "\r\n" + labelHuruf[i].Text + "' = (" + hurufKum[i].getX() + " cos -" + textBox5.Text + "° - " + hurufKum[i].getY() + " sin -" + textBox5.Text + "° , " + hurufKum[i].getX() + " sin -" + textBox5.Text + "° + " + hurufKum[i].getY() + " cos -" + textBox5.Text + "°)";
                        jawab += "\r\n" + labelHuruf[i].Text + "' = (" + hurufKum[i].getX() + " * " + Math.Round(Math.Cos(DegreeToRadian(double.Parse(textBox5.Text) * -1.0)), 2) + " - " + hurufKum[i].getY() + " * " + Math.Round(Math.Sin(DegreeToRadian(double.Parse(textBox5.Text) * -1.0)), 2) + " , " + hurufKum[i].getX() + " * " + Math.Round(Math.Sin(DegreeToRadian(double.Parse(textBox5.Text) * -1.0)), 2) + " + " + hurufKum[i].getY() + " * " + Math.Round(Math.Cos(DegreeToRadian(double.Parse(textBox5.Text) * -1.0)), 2) + ")";
                        jawab += "\r\n" + labelHuruf[i].Text + "' = (" + XAksenSea2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY()) + ", " + YAksenSea2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY()) + ")\r\n";
                    }
                    else if ((radioButton1.Checked == false) && (radioButton2.Checked == true))
                    {
                        jawab += "\r\n" + labelHuruf[i].Text + "' = (" + hurufKum[i].getX() + " cos " + textBox5.Text + "° - " + hurufKum[i].getY() + " sin " + textBox5.Text + "° , " + hurufKum[i].getX() + " sin " + textBox5.Text + "° + " + hurufKum[i].getY() + " cos " + textBox5.Text + "°)";
                        jawab += "\r\n" + labelHuruf[i].Text + "' = (" + hurufKum[i].getX() + " * " + Math.Round(Math.Cos(DegreeToRadian(double.Parse(textBox5.Text))), 2) + " - " + hurufKum[i].getY() + " * " + Math.Round(Math.Sin(DegreeToRadian(double.Parse(textBox5.Text))), 2) + " , " + hurufKum[i].getX() + " * " + Math.Round(Math.Sin(DegreeToRadian(double.Parse(textBox5.Text))), 2) + " + " + hurufKum[i].getY() + " * " + Math.Round(Math.Cos(DegreeToRadian(double.Parse(textBox5.Text))), 2) + ")";
                        jawab += "\r\n" + labelHuruf[i].Text + "' = (" + XAksenRev2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY()) + ", " + YAksenRev2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY()) + ")\r\n";
                    }
                    jawab += "\r\n";
                }

            }
            rumus = rumusRot + dik + jawab;
            return rumus;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            int huruf = comboBox2.SelectedIndex;
            double xAksen = 0;
            double yAksen = 0;
            for (int i = 0; i < hurufKum.Length; i++)
            {
                if (hurufKum[i].getEn() == 1)
                {
                    labelHurufAksen[i].Text = labelHuruf[i].Text + "'";
                    if ((radioButton1.Checked == true)&&(radioButton2.Checked == false))
                    {
                        xAksen = XAksenSea2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY());
                        yAksen = YAksenSea2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY());
                        hurufAksen[i].setX(xAksen);
                        hurufAksen[i].setY(yAksen);
                        labelHurufAksen[i].Visible = false;
                        labelHurufAksen[i].Location = new Point(328, 320);
                        labelHurufAksen[i].Location = new Point((int)(labelHurufAksen[i].Location.X + (22 * hurufAksen[i].getX())), (int)(labelHurufAksen[i].Location.Y - (22 * hurufAksen[i].getY())));
                        labelHurufAksen[i].Visible = true;
                        titikAksen[i].Visible = false;
                        titikAksen[i].Location = new Point(348, 332);
                        titikAksen[i].Location = new Point((int)(titikAksen[i].Location.X + (22 * hurufAksen[i].getX())), (int)(titikAksen[i].Location.Y - (22 * hurufAksen[i].getY())));
                        titikAksen[i].Visible = true;
                        titikAksen[i].BringToFront();

                        conXAksen[con] = titikAksen[i].Location.X + 5;
                        conYAksen[con] = titikAksen[i].Location.Y + 5;
                        con++;

                        if (gambarIn == true)
                        {
                            pictGambarAksen.Visible = true;
                            Image flip = (Bitmap)Bitmap.FromFile(pictGambar.ImageLocation);
                            pictGambarAksen.Image = flip;
                            labelHurufAksen[25].Location = new Point(labelHurufAksen[25].Location.X - 5, labelHurufAksen[25].Location.Y);
                            pictGambarAksen.BringToFront();
                            pictGambarAksen.BackColor = label65.ForeColor;
                            pictGambarAksen.Padding = new Padding(2);
                            if ((int)textBox5.Value == 90 || (int)textBox5.Value == -270)
                            {
                                pictGambarAksen.Size = new Size(22 * (int)nmGambarT.Value, 22 * (int)nmGambarL.Value);
                                int xGambar = (int)(nmGambarL.Value) - 1;
                                pictGambarAksen.Location = new Point(355, 314);
                                pictGambarAksen.Location = new Point(pictGambarAksen.Location.X+(22*(int)nmGambarY.Value), pictGambarAksen.Location.Y - (22 * ((((int)(nmGambarX.Value)+(int)nmGambarL.Value)*-1) + xGambar)));
                                flip.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                pictGambarAksen.Image = flip;
                            }
                            else if ((int)textBox5.Value == 180 || (int)textBox5.Value == -180)
                            {
                                pictGambarAksen.Size = pictGambar.Size;
                                int xGambar = (int)(nmGambarT.Value) - 1;
                                int xGambarAksen = ((int)nmGambarX.Value + (int)nmGambarL.Value) * -1;
                                int yGambarAksen = ((int)nmGambarY.Value + (int)nmGambarT.Value) * -1;
                                pictGambarAksen.Location = new Point(355, 314);
                                pictGambarAksen.Location = new Point(pictGambarAksen.Location.X + (22 * xGambarAksen), pictGambarAksen.Location.Y - (22 * (yGambarAksen + xGambar)));
                                flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                pictGambarAksen.Image = flip;
                            }
                            else if ((int)textBox5.Value == 270 || (int)textBox5.Value == -90)
                            {
                                pictGambarAksen.Size = new Size(22 * (int)nmGambarT.Value, 22 * (int)nmGambarL.Value);
                                int xGambar = (int)(nmGambarL.Value) - 1;
                                int xGambarAksen = ((int)nmGambarY.Value + (int)nmGambarT.Value) * -1;
                                int yGambarAksen = (int)nmGambarX.Value;
                                pictGambarAksen.Location = new Point(355, 314);
                                pictGambarAksen.Location = new Point(pictGambarAksen.Location.X + (22 * xGambarAksen), pictGambarAksen.Location.Y - (22 * (yGambarAksen + xGambar)));
                                flip.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                pictGambarAksen.Image = flip;
                                labelHurufAksen[25].Location = new Point(labelHurufAksen[25].Location.X + 30, labelHurufAksen[25].Location.Y);
                            }
                            else
                            {
                                MessageBox.Show("Derajat harus 90, 180, 270, -90. -180, atau -270.");
                                pictGambarAksen.Visible = false;
                            }
                        }

                    }
                    else if ((radioButton1.Checked == false) && (radioButton2.Checked == true))
                    {
                        xAksen = XAksenRev2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY());
                        yAksen = YAksenRev2(double.Parse(textBox5.Text), hurufKum[i].getX(), hurufKum[i].getY());
                        hurufAksen[i].setX(xAksen);
                        hurufAksen[i].setY(yAksen);
                        labelHurufAksen[i].Visible = false;
                        labelHurufAksen[i].Location = new Point(328, 320);
                        labelHurufAksen[i].Location = new Point((int)(labelHurufAksen[i].Location.X + (22 * hurufAksen[i].getX())), (int)(labelHurufAksen[i].Location.Y - (22 * hurufAksen[i].getY())));
                        labelHurufAksen[i].Visible = true;
                        titikAksen[i].Visible = false;
                        titikAksen[i].Location = new Point(348, 332);
                        titikAksen[i].Location = new Point((int)(titikAksen[i].Location.X + (22 * hurufAksen[i].getX())), (int)(titikAksen[i].Location.Y - (22 * hurufAksen[i].getY())));
                        titikAksen[i].Visible = true;
                        titikAksen[i].BringToFront();

                        conXAksen[con] = titikAksen[i].Location.X + 5;
                        conYAksen[con] = titikAksen[i].Location.Y + 5;
                        con++;

                        if (gambarIn == true)
                        {
                            pictGambarAksen.Visible = true;
                            Image flip = (Bitmap)Bitmap.FromFile(pictGambar.ImageLocation);
                            pictGambarAksen.Image = flip;
                            labelHurufAksen[25].Location = new Point(labelHurufAksen[25].Location.X - 5, labelHurufAksen[25].Location.Y);
                            pictGambarAksen.BringToFront();
                            pictGambarAksen.BackColor = label65.ForeColor;
                            pictGambarAksen.Padding = new Padding(2);
                            if ((int)textBox5.Value == 270 || (int)textBox5.Value == -90)
                            {
                                pictGambarAksen.Size = new Size(22 * (int)nmGambarT.Value, 22 * (int)nmGambarL.Value);
                                int xGambar = (int)(nmGambarL.Value) - 1;
                                pictGambarAksen.Location = new Point(355, 314);
                                pictGambarAksen.Location = new Point(pictGambarAksen.Location.X + (22 * (int)nmGambarY.Value), pictGambarAksen.Location.Y - (22 * ((((int)(nmGambarX.Value) + (int)nmGambarL.Value) * -1) + xGambar)));
                                flip.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                pictGambarAksen.Image = flip;
                            }
                            else if ((int)textBox5.Value == 180 || (int)textBox5.Value == -180)
                            {
                                pictGambarAksen.Size = pictGambar.Size;
                                int xGambar = (int)(nmGambarT.Value) - 1;
                                int xGambarAksen = ((int)nmGambarX.Value + (int)nmGambarL.Value) * -1;
                                int yGambarAksen = ((int)nmGambarY.Value + (int)nmGambarT.Value) * -1;
                                pictGambarAksen.Location = new Point(355, 314);
                                pictGambarAksen.Location = new Point(pictGambarAksen.Location.X + (22 * xGambarAksen), pictGambarAksen.Location.Y - (22 * (yGambarAksen + xGambar)));
                                flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                pictGambarAksen.Image = flip;
                            }
                            else if ((int)textBox5.Value == -270 || (int)textBox5.Value == 90)
                            {
                                pictGambarAksen.Size = new Size(22 * (int)nmGambarT.Value, 22 * (int)nmGambarL.Value);
                                int xGambar = (int)(nmGambarL.Value) - 1;
                                int xGambarAksen = ((int)nmGambarY.Value + (int)nmGambarT.Value) * -1;
                                int yGambarAksen = (int)nmGambarX.Value;
                                pictGambarAksen.Location = new Point(355, 314);
                                pictGambarAksen.Location = new Point(pictGambarAksen.Location.X + (22 * xGambarAksen), pictGambarAksen.Location.Y - (22 * (yGambarAksen + xGambar)));
                                flip.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                pictGambarAksen.Image = flip;
                                labelHurufAksen[25].Location = new Point(labelHurufAksen[25].Location.X + 30, labelHurufAksen[25].Location.Y);
                            }else
                            {
                                MessageBox.Show("Derajat harus 90, 180, 270, -90. -180, atau -270.");
                                pictGambarAksen.Visible = false;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Pilih Tipe Rotasi");
                    }

                    
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

        private void btnRumus_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.groupBox1.Text = "Rotasi";
            form6.label3.Visible = false;
            form6.label4.Visible = true;
            form6.label2.Text = "P'(x', y')";
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
            pictGambar.BringToFront();
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
