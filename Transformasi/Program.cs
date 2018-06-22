using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformasi
{
    class Huruf
    {
        private int x, y,en;
        private double xDil, yDil;
        
        public void setX(int x2)
        {
            x = x2;
        }

        public void setY(int y2)
        {
            y = y2;
        }

        public void setXDil(double x2)
        {
            xDil = x2;
        }

        public void setYDil(double y2)
        {
            yDil = y2;
        }

        public void setEn(int en2)
        {
            en = en2;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public double getXDil()
        {
            return xDil;
        }

        public double getYDil()
        {
            return yDil;
        }

        public int getEn()
        {
            return en;
        }
    }


    class HurufAksen
    {
        private double x, y;
        private int en;
        private double xDil, yDil;

        public void setX(double x2)
        {
            x = x2;
        }

        public void setY(double y2)
        {
            y = y2;
        }

        public void setXDil(double x2)
        {
            xDil = x2;
        }

        public void setYDil(double y2)
        {
            yDil = y2;
        }

        public void setEn(int en2)
        {
            en = en2;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public double getXDil()
        {
            return xDil;
        }

        public double getYDil()
        {
            return yDil;
        }

        public int getEn()
        {
            return en;
        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form5());
        }
    }
}
