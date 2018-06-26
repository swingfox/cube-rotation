using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kinematics
{
    public partial class MainForm : Form
    {
        private int originX = 190;
        private int originY = 110;

        private int inclination = 120;

        private int side = 80;

        private int thetaX = 0;
        private int thetaY = 0;
        private int thetaZ = 0;

        private _3DPoint[] corner = new _3DPoint[8];
        private _3DPoint[] mover = new _3DPoint[8];

        private Point to2D(int x, int y, int z){
            double cos = Math.Cos(inclination);
            double sin = Math.Sin(inclination);

            Point result = new Point();
            result.X = Convert.ToInt32(originX - (x * cos) + (y * cos));
            result.Y = Convert.ToInt32(originY + (x * sin) + (y * sin) - z);
            return result;
        }

        private Point to2D(_3DPoint p)
        {
            return to2D(p.X, p.Y, p.Z);
        }

        private _3DPoint rotX(int deg, _3DPoint p)
        {
            double rad = deg * Math.PI / 180;

            _3DPoint result = new _3DPoint();
            result.X = p.X;
            result.Y = Convert.ToInt32(Math.Cos(rad) * p.Y - Math.Sin(rad) * p.Z);
            result.Z = Convert.ToInt32(Math.Sin(rad) * p.Y + Math.Cos(rad) * p.Z);

            return result;
        }

        private _3DPoint rotY(int deg, _3DPoint p)
        {
            double rad = deg * Math.PI / 180;

            _3DPoint result = new _3DPoint();
            result.X = Convert.ToInt32(Math.Cos(rad) * p.X + Math.Sin(rad) * p.Z);
            result.Y = p.Y;
            result.Z = Convert.ToInt32(Math.Cos(rad) * p.Z - Math.Sin(rad) * p.X);

            return result;
        }

        private _3DPoint rotZ(int deg, _3DPoint p)
        {
            double rad = deg * Math.PI / 180;

            _3DPoint result = new _3DPoint();
            result.X = Convert.ToInt32(Math.Cos(rad) * p.X - Math.Sin(rad) * p.Y);
            result.Y = Convert.ToInt32(Math.Sin(rad) * p.X + Math.Cos(rad) * p.Y);
            result.Z = p.Z;

            return result;
        }
        
        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 8; i++)
            {
                corner[i] = new _3DPoint();
                mover[i] = new _3DPoint();
            }

            corner[0].X = side / 2;
            corner[1].X = side / 2;
            corner[2].X = -side / 2;
            corner[3].X = -side / 2;
            corner[4].X = side / 2;
            corner[5].X = side / 2;
            corner[6].X = -side / 2;
            corner[7].X = -side / 2;

            corner[0].Y = -side / 2;
            corner[1].Y = side / 2;
            corner[2].Y = side / 2;
            corner[3].Y = -side / 2;
            corner[4].Y = -side / 2;
            corner[5].Y = side / 2;
            corner[6].Y = side / 2;
            corner[7].Y = -side / 2;

            corner[0].Z = side / 2;
            corner[1].Z = side / 2;
            corner[2].Z = side / 2;
            corner[3].Z = side / 2;
            corner[4].Z = -side / 2;
            corner[5].Z = -side / 2;
            corner[6].Z = -side / 2;
            corner[7].Z = -side / 2;

            for (int i = 0; i < 8; i++)
            {
                mover[i] = rotX(thetaX, corner[i]);
                mover[i] = rotY(thetaY, mover[i]);
                mover[i] = rotZ(thetaZ, mover[i]);
            }

            pictureCube.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                thetaX += 1;
                thetaY += 2;
                thetaZ += 1;

                if (thetaX >= 360)
                    thetaX = 0;
                if (thetaY >= 360)
                    thetaY = 0;
                if (thetaZ >= 360)
                    thetaZ = 0;

                txtXTheta.Text = Convert.ToString(thetaX);
                txtYTheta.Text = Convert.ToString(thetaY);
                txtZTheta.Text = Convert.ToString(thetaZ);

                trackBarX.Value = thetaX;
                trackBarY.Value = thetaY;
                trackBarZ.Value = thetaZ;

                for (int i = 0; i < 8; i++)
                {
                    mover[i] = rotX(thetaX, corner[i]);
                    mover[i] = rotY(thetaY, mover[i]);
                    mover[i] = rotZ(thetaZ, mover[i]);
                }

                pictureCube.Refresh();
            }
        }

        private void trackBarZ_Scroll(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            thetaZ = trackBarZ.Value;
            txtZTheta.Text = Convert.ToString(thetaZ);

            for (int i = 0; i < 8; i++)
            {
                mover[i] = rotX(thetaX, corner[i]);
                mover[i] = rotY(thetaY, mover[i]);
                mover[i] = rotZ(thetaZ, mover[i]);
            }

            pictureCube.Refresh();
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            thetaY = trackBarY.Value;
            txtYTheta.Text = Convert.ToString(thetaY);

            for (int i = 0; i < 8; i++)
            {
                mover[i] = rotX(thetaX, corner[i]);
                mover[i] = rotY(thetaY, mover[i]);
                mover[i] = rotZ(thetaZ, mover[i]);
            }

            pictureCube.Refresh();
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            thetaX = trackBarX.Value;
            txtXTheta.Text = Convert.ToString(thetaX);

            for (int i = 0; i < 8; i++)
            {
                mover[i] = rotX(thetaX, corner[i]);
                mover[i] = rotY(thetaY, mover[i]);
                mover[i] = rotZ(thetaZ, mover[i]);
            }

            pictureCube.Refresh();
        }

        private void pictureCube_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // x,y,z origin
            g.DrawLine(Pens.Red, to2D(0, 0, 0), to2D(10, 0, 0));
            g.DrawLine(Pens.Blue, to2D(0, 0, 0), to2D(0, 10, 0));
            g.DrawLine(Pens.Green, to2D(0, 0, 0), to2D(0, 0, 10));

            // pink line
            g.DrawLine(Pens.HotPink, to2D(mover[0]), to2D(mover[1]));
            g.DrawLine(Pens.HotPink, to2D(mover[5]), to2D(mover[1]));
            g.DrawLine(Pens.HotPink, to2D(mover[5]), to2D(mover[4]));
            g.DrawLine(Pens.HotPink, to2D(mover[0]), to2D(mover[4]));
            // yellow line
            g.DrawLine(Pens.Yellow, to2D(mover[2]), to2D(mover[3]));
            g.DrawLine(Pens.Yellow, to2D(mover[2]), to2D(mover[6]));
            g.DrawLine(Pens.Yellow, to2D(mover[7]), to2D(mover[3]));
            g.DrawLine(Pens.Yellow, to2D(mover[7]), to2D(mover[6]));
            // old lace line
            g.DrawLine(Pens.OldLace, to2D(mover[1]), to2D(mover[2]));
            g.DrawLine(Pens.OldLace, to2D(mover[0]), to2D(mover[3]));
            g.DrawLine(Pens.OldLace, to2D(mover[4]), to2D(mover[7]));
            g.DrawLine(Pens.OldLace, to2D(mover[6]), to2D(mover[5]));
        }
    }
}
