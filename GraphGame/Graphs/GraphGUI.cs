using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GraphGame.Graphs
{
    class GraphGUI : Graph
    {
        private PictureBox picture;
        private Image image;
        private Graphics graphics;
        private Pen pen;
        private StringFormat stringFormat;

        private const int eps = 2;
        private int topRadius;
        private int edgeWidth;
        public GraphGUI(PictureBox picture, int topRadius, int edgeWidth) : base(picture.Width, picture.Height)
        {
            this.picture = picture;
            this.image = new Bitmap(picture.Width, picture.Height);
            this.topRadius = topRadius;
            this.edgeWidth = edgeWidth;
            graphics = Graphics.FromImage(image);
            pen = Pens.Black;
            stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            View();
        }
        private Brush[] brushesColors =
        {
            Brushes.Red, Brushes.Green, Brushes.Blue,
            Brushes.BlueViolet, Brushes.Purple, Brushes.Yellow,
            Brushes.Orange, Brushes.Pink, Brushes.RoyalBlue,
            Brushes.Honeydew, Brushes.Gray, Brushes.Brown,
        };

        public void ClearChips()
        {
            chipList.Clear();
            View();
        }
        private void DrawTop(Point point, int i = 0, Brush brush = null)
        {
            if (brush == null)
            {
                brush = Brushes.Gray;
            }
            graphics.FillEllipse(brush, point.X - topRadius, point.Y - topRadius, topRadius * 2, topRadius * 2);
            graphics.DrawEllipse(pen, point.X - topRadius, point.Y - topRadius, topRadius * 2, topRadius * 2);
        }
        private void DrawChip(Chip chip, int i = 0)
        {
            Brush brush = Brushes.White;
            if (chip.isBlack)
            {
                brush = Brushes.Brown;
            }
            DrawTop(chip.point, i, brush);
        }
        private void DrawEdge(Point p1, Point p2)
        {
            Pen pen = new Pen(Color.Black, edgeWidth * 2);
            pen.EndCap = LineCap.ArrowAnchor;
            Point p3 = new Point(p2.X, p2.Y);
            p3.X = ((p1.X + p2.X) / 2);
            p3.Y = ((p1.Y + p2.Y) / 2);
            p3.X = ((p2.X + p3.X) / 2);
            p3.Y = ((p2.Y + p3.Y) / 2);
            p3.X = ((p2.X + p3.X) / 2);
            p3.Y = ((p2.Y + p3.Y) / 2);
            graphics.DrawLine(pen, p1, p3);
            pen.Dispose();
        }

        public void View()
        {
            graphics.Clear(Color.White);
            foreach (Tuple<int, int> tuple in edgeList)
            {
                DrawEdge(topList[tuple.Item1], topList[tuple.Item2]);
            }
            int k = 0;
            foreach (Point point in topList)
            {
                DrawTop(point, k);
                int index = chipList.FindIndex(x => x.point == point);
                if (index != -1)
                {
                    DrawChip(chipList[index], k);
                }
                Font font = new Font(FontFamily.GenericSansSerif, 15F, FontStyle.Regular); 
                graphics.DrawString(k++.ToString(), font, Brushes.Black, point, stringFormat);
                font.Dispose();
            }
            picture.Image = image;
        }
        public void Task()
        {
            if (chipList.Count == 0)
            {
                MessageBox.Show("Добавьте белую фишку!");
                return;
            }
            int blackAmount = chipList.Count(c => c.isBlack);
            int whiteAmount = chipList.Count(c => !c.isBlack);
            if (blackAmount > whiteAmount || whiteAmount > blackAmount + 1)
            {
                MessageBox.Show("Стартовая позиция не соответствует правилам игры");
            }
            Solve();
            View();
            bestSolve = null;
        }

        public override bool Add(Point point)
        {
            if (EpsTop(ref point, topRadius * eps))
            {
                return false;
            }
            bool res = base.Add(point);
            if (res)
            {
                View();
            }
            return res;
        }

        public override bool AddChip(int index, bool isBlack)
        {
            if (base.AddChip(index, isBlack))
            {
                View();
                return true;
            }
            return false;
        }

        public override bool DeleteChip(int index)
        {
            if (base.DeleteChip(index))
            {
                View();
                return true;
            }
            return false;
        }

        public override bool Load(string filename)
        {
            bool res = base.Load(filename);
            if (res)
            {
                View();
            }
            return res;
        }
        public override void Clear()
        {
            base.Clear();
            View();
        }
        public override bool Delete(Point point)
        {

            bool res = base.Delete(point);
            if (!res && EpsTop(ref point, topRadius * eps))
            {
                base.Delete(point);
            }
            View();
            return res;
        }
        public override bool Delete(int top)
        {
            bool res = base.Delete(top);
            if (res)
            {
                View();
            }
            return res;
        }
        public override bool Connect(Point top1, Point top2)
        {
            bool res = base.Connect(top1, top2);
            if (res)
            {
                View();
            }
            return res;
        }
        public override bool Connect(int top1, int top2)
        {
            bool res = base.Connect(top1, top2);
            if (res)
            {
                View();
            }
            return res;
        }
        public override bool Disconnect(Point top1, Point top2)
        {
            bool res = base.Disconnect(top1, top2);
            if (res)
            {
                View();
            }
            return res;
        }
        public override bool Disconnect(int top1, int top2)
        {
            bool res = base.Disconnect(top1, top2);
            if (res)
            {
                View();
            }
            return res;
        }
        public bool CheckSolve(int[] colors)
        {
            for (int i = 0; i < topList.Count; i++)
            {
                if (colors[i] == 0)
                {
                    break;
                }
                int index = -1;
                do
                {
                    if (index == edgeList.Count)
                    {
                        break;
                    }
                    index = edgeList.FindIndex(++index, x => x.Item1 == i || x.Item2 == i);
                    if (index != -1)
                    {
                        int top = i == edgeList[index].Item1 ? edgeList[index].Item2 : edgeList[index].Item1;
                        if (colors[i] == colors[top])
                        {
                            return false;
                        }
                    }
                } while (index != -1);
            }
            return true;
        }

        List<Chip> bestSolve;
        public void Solve()
        {
            bool blackMove = chipList.Count % 2 == 0;
            List<Chip> solve = new List<Chip>(chipList);
            TrySolve(solve);
            if (bestSolve == null)
            {
                MessageBox.Show("Стартоая позиция не является выигрышной для белых");
            } else
            {
                MessageBox.Show("Стартовая позиция является выигрышной для белых");
                chipList = bestSolve;
                View();
            }
        }

        private void TrySolve(List<Chip> solve)
        {
            if (bestSolve != null)
            {
                return;
            }
            bool blackMove = solve.Count % 2 == 1;
            bool moved = false;
            foreach (Tuple<int, int> edge in edgeList)
            {
                Chip chipFrom = solve.Find(c => c.point == topList[edge.Item1]);
                Chip chipTo = solve.Find(c => c.point == topList[edge.Item2]);
                if (chipFrom != null && chipTo == null)
                {
                    if (blackMove && !chipFrom.isBlack)
                    {
                        Chip newChip = new Chip(topList[edge.Item2], true);
                        solve.Add(newChip);
                        TrySolve(solve);
                        solve.Remove(newChip);
                        moved = true;
                    } 
                    else if (!blackMove && chipFrom.isBlack)
                    {
                        Chip newChip = new Chip(topList[edge.Item2], false);
                        solve.Add(newChip);
                        TrySolve(solve);
                        solve.Remove(newChip);
                        moved = true;
                    }
                }
            }
            if (!moved)
            {
                if (solve.Count % 2 == 1)
                {
                    bestSolve = new List<Chip>(solve);
                }
            }
        }
    }
}
