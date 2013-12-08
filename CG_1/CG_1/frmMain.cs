using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_1
{
    public partial class FrmMain : Form
    {
        Graphics _gr;
        Bitmap _bmp;

        Color _linePointColor = Color.Indigo;
        Color _lineColor = Color.Maroon;
        Color _poligonPointColor = Color.MediumBlue;
        Color _poligonLineColor = Color.RoyalBlue;

        List<Point> _poligonPoints = new List<Point>(); 
        List<Point> _linePoints = new List<Point>();
        List<Point> _resultPoligonPoints = new List<Point>();

        public FrmMain()
        {
            InitializeComponent();
            _bmp = new Bitmap(pbMain.Width, pbMain.Height);
            _gr = Graphics.FromImage(_bmp);
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (_poligonPoints.Count != 0)
            {
                _bmp = new Bitmap(pbMain.Width, pbMain.Height);
                _gr = Graphics.FromImage(_bmp);
                Rabbi();
                ClearAllLists(_poligonPoints, _linePoints, _resultPoligonPoints);
            }
        }

        private void Rabbi()
        {
            Point[] poligPoint = new Point[_poligonPoints.Count];
            int i = 0;
            foreach (var poligonPoint in _poligonPoints)
            {
                poligPoint[i] = poligonPoint;
                i++;
            }
            Point[] linePoints = new Point[2];
            linePoints[0] = _linePoints[0];
            linePoints[1] = _linePoints[1];
            Sutherland_Hodgman sh = new Sutherland_Hodgman();
            _resultPoligonPoints = sh.leftCircumcision(poligPoint,linePoints,_poligonPoints.Count);

            if (_resultPoligonPoints.Count != 0)
            {
                BmpCleanup(_gr, Color.White);
                ReDrawAll();
            }
        }

        private void RefreshBmp(PictureBox pb,Bitmap bmp)
        {
            pb.Image = bmp;
        }

        private void DrawLine(Point startPoint, Point endPoint, Color color)
        {
            double lineLength = Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
            double YStep = (endPoint.Y - startPoint.Y) / lineLength;
            double XStep = (endPoint.X - startPoint.X) / lineLength;
            double curX = startPoint.X;
            double curY = startPoint.Y;
            while (Math.Abs(curX - endPoint.X) > 0.5 || Math.Abs(curY - endPoint.Y) > 0.5)
            {
                _bmp.SetPixel(Convert.ToInt32(curX), Convert.ToInt32(curY), color);
                curX += XStep;
                curY += YStep;
            }
            RefreshBmp(pbMain,_bmp);
        }
        
        private void pbMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbLine.Checked)
            {
                if (_linePoints.Count != 2)
                {
                    _linePoints.Add(e.Location);
                    DrawPoint(e.Location, _linePointColor);
                }
                else
                {
                    DrawPoint(_linePoints[0],Color.White);
                    _linePoints.RemoveAt(0);
                    _linePoints.Add(e.Location);
                    DrawPoint(e.Location, _linePointColor);
                }
            }
            else
            {
                _poligonPoints.Add(e.Location);
                DrawPoint(e.Location, _poligonPointColor);
            }
        }

        private void DrawPoint(Point point, Color color)
        {
            _gr.DrawRectangle(new Pen(color,2),point.X,point.Y,2,2);
            RefreshBmp(pbMain, _bmp);
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            tsslMouseCoord.Text = "X: " + e.Location.X + " Y: " + e.Location.Y;
        }

        private void ClearAllLists(List<Point> poligonPoints,List<Point> linePoints,List<Point> resultPoligonPoints )
        {
            poligonPoints.Clear();
            linePoints.Clear();
            resultPoligonPoints.Clear();
        }

        private void DrawAllLinePoints()
        {
            foreach (Point linePoint in _linePoints)
                DrawPoint(linePoint, _linePointColor);
        }

        private void DrawAllPoligonPoints()
        {
            foreach (Point poligonPoint in _poligonPoints)
                DrawPoint(poligonPoint, _poligonPointColor);
        }

        private void CreatePoligon_Click(object sender, EventArgs e)
        {
            if (rbLine.Checked && _linePoints.Count == 2)
            {
                BmpCleanup(_gr, Color.White);
                DrawAllLinePoints();
                DrawLine(_linePoints[0], _linePoints[1], _lineColor);
                if (_poligonPoints.Count > 2)
                {
                    DrawAllPoligonPoints();

                    var p1 = _poligonPoints[0];
                    for (int i = 1; i <= _poligonPoints.Count - 1; i++)
                    {
                        DrawLine(p1, _poligonPoints[i], _poligonLineColor);
                        p1 = _poligonPoints[i];
                    }
                    DrawLine(_poligonPoints[0], p1, _poligonLineColor);
                }
            }
            else
            {
                if (_poligonPoints.Count > 2)
                {
                    var p1 = _poligonPoints[0];
                    for (int i = 1; i <= _poligonPoints.Count - 1; i++)
                    {
                        DrawLine(p1, _poligonPoints[i], _poligonLineColor);
                        p1 = _poligonPoints[i];
                    }
                    DrawLine(_poligonPoints[0], p1, _poligonLineColor);
                }
            }
        }

        private void ReDrawAll()
        {
            DrawAllLinePoints();

            DrawLine(_linePoints[0],_linePoints[1],_lineColor);

            DrawAllPoligonPoints();
            
            var p1 = _resultPoligonPoints[0];
            for (int i = 1; i <= _resultPoligonPoints.Count - 1; i++)
            {
                DrawLine(p1, _resultPoligonPoints[i], _poligonLineColor);
                p1 = _resultPoligonPoints[i];
            }

            DrawLine(_resultPoligonPoints[0],p1,_poligonLineColor);
        }

        private void BmpCleanup(Graphics gr, Color color)
        {
            gr.Clear(color);
            RefreshBmp(pbMain,_bmp);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BmpCleanup(_gr,Color.White);
            ClearAllLists(_poligonPoints,_linePoints,_resultPoligonPoints);
        }
    }
}
