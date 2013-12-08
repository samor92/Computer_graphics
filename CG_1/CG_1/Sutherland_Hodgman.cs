using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG_1
{
    internal class Sutherland_Hodgman
    {
        private myPoint GetIntersection(Point line1BeginPoint, Point line1EndPoint, Point line2BeginPoint,
            Point line2EndPoint)
        {
            double Ua = (double) ((line2EndPoint.X - line2BeginPoint.X)*(line1BeginPoint.Y - line2BeginPoint.Y) -
                                  (line2EndPoint.Y - line2BeginPoint.Y)*(line1BeginPoint.X - line2BeginPoint.X))/
                        ((line2EndPoint.Y - line2BeginPoint.Y)*(line1EndPoint.X - line1BeginPoint.X) -
                         (line2EndPoint.X - line2BeginPoint.X)*(line1EndPoint.Y - line1BeginPoint.Y));

            //double Ub = (double) ((line1EndPoint.X - line1BeginPoint.X)*(line1BeginPoint.Y - line2BeginPoint.Y) -
            //                      (line1EndPoint.Y - line1BeginPoint.Y)*(line1BeginPoint.X - line2BeginPoint.X))/
            //            ((line2EndPoint.Y - line2BeginPoint.Y)*(line1EndPoint.X - line1BeginPoint.X) -
            //             (line2EndPoint.X - line2BeginPoint.X)*(line1EndPoint.Y - line1BeginPoint.Y));

            double x = line1BeginPoint.X + Ua*(line1EndPoint.X - line1BeginPoint.X);
            double y = line1BeginPoint.Y + Ua*(line1EndPoint.Y - line1BeginPoint.Y);

            if (Math.Min(line1BeginPoint.X, line1EndPoint.X) <= x && Math.Max(line1BeginPoint.X, line1EndPoint.X) >= x)
                return new myPoint {X = (int) x, Y = (int) y, IsOnSegment = true};
            else return new myPoint {X = (int) x, Y = (int) y, IsOnSegment = false};
        }

        //Значение CheckPoint = 0, если точка b лежит на прямой, проходящей через точки a и c.
        //CheckPoint > 0, если точка b находится справа от прямой.
        //CheckPoint < 0, если точка b находится слева от прямой.
        private int CheckPoint(Point a, Point b, Point c)
        {
            return (b.X - a.X)*(b.Y - c.Y) - (b.Y - a.Y)*(b.X - c.X);
        }

        // leftBorder - массив вершин левой границы
        // src - массив вершин исходного полигона
        //   n - число вершин исходного полигона
        // функция возвращает число вершин результата
        public List<Point> leftCircumcision(Point[] src, Point[] leftBorder, int n)
        {
            List<Point> resultList = new List<Point>();
            Point p1, p2;
            Point borderPoint1 = leftBorder[0];
            Point borderPoint2 = leftBorder[1];

            if (borderPoint1.X > borderPoint2.X || borderPoint1.Y > borderPoint2.Y)
            {
                var tmp = borderPoint1;
                borderPoint1 = borderPoint2;
                borderPoint2 = tmp;
            }

            for (int i = 0; i < n; i++)
            {
                p1 = src[i];
                p2 = src[(i + 1)%n];

                if (CheckPoint(borderPoint1, p1, borderPoint2) >= 0)
                {
                    // если начало лежит в области
                    resultList.Add(p1); // добавляем начало
                }
                // если ребро пересекает границу
                // добавляем точку пересечения
                //ищем точку пересечения
                var tmp = GetIntersection(p1, p2, borderPoint1, borderPoint2);
                //если она принадлежит отрезку, то добавляем её
                if (tmp.X > Math.Min(p1.X, p2.X) && tmp.X < Math.Max(p1.X, p2.X) && tmp.IsOnSegment)
                    resultList.Add(new Point((int) tmp.X, (int) tmp.Y));
            }
            return resultList;
        }

    }
}
