using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace GraphGame.Graphs
{
    class Graph
    {
        private int maxX;
        private int maxY;
        protected List<Point> topList;
        protected List<Tuple<int, int>> edgeList;
        protected List<Chip> chipList;

        public int Count
        {
            get
            {
                return topList.Count;
            }
        }

        public Graph(int maxX, int maxY)
        {
            this.maxX = maxX;
            this.maxY = maxY;
            topList = new List<Point>();
            edgeList = new List<Tuple<int, int>>();
            chipList = new List<Chip>();
        }
        protected bool EpsTop(ref Point point, int eps)
        {
            foreach (Point topPoint in topList)
            {
                if (Math.Abs(topPoint.X - point.X) <= eps && Math.Abs(topPoint.Y - point.Y) <= eps)
                {
                    point = topPoint;
                    return true;
                }
            }
            return false;
        }
        protected void ChangeIndexes(int index)
        {
            for (int i = 0; i < edgeList.Count; i++)
            {
                if (edgeList[i].Item1 > index)
                {
                    int k = edgeList[i].Item1 - 1;
                    edgeList[i] = new Tuple<int, int>(k, edgeList[i].Item2);
                }
                if (edgeList[i].Item2 > index)
                {
                    int k = edgeList[i].Item2 - 1;
                    edgeList[i] = new Tuple<int, int>(edgeList[i].Item1, k);
                }
            }
        }
        public virtual bool Add(Point point)
        {
            if (topList.Contains(point) || point.X > maxX || point.Y > maxY)
            {
                return false;
            }
            topList.Add(point);
            return true;
        }
        public virtual bool AddChip(Chip chip)
        {
            if (topList.FindIndex(x => x == chip.point) != -1 && chipList.FindIndex(x => x.point == chip.point) == -1)
            {
                chipList.Add(chip);
                return true;
            }
            return false;
        }

        private Chip chipOfTop(int index)
        {
            return chipList.Find(c => topList[index] == c.point);
        }

        public virtual bool AddChip(int index, bool isBlack)
        {
            if (topList.Count <= index)
            {
                return false;
            }
            if (chipList.Count == 0 && !isBlack)
            {
                chipList.Add(new Chip(topList[index], isBlack));
                return true;
            }
            if (chipList.FindIndex(c => c.point == topList[index]) != -1)
            {
                return false;
            }
            int blackCount = chipList.Count(c => c.isBlack);
            int whiteCount = chipList.Count(c => !c.isBlack);
            if ((isBlack && blackCount != whiteCount - 1) || (!isBlack && blackCount != whiteCount))
            {
                return false;
            }
            if (chipList.Count > 0)
            {
                foreach (Tuple<int, int> edge in edgeList)
                {
                    if (index != edge.Item2)
                    {
                        continue;
                    }
                    Chip chipFrom = chipOfTop(edge.Item1);
                    Chip chipTo = chipOfTop(edge.Item2);
                    if (chipFrom != null && chipTo == null)
                    {
                        if (chipFrom.isBlack != isBlack)
                        {
                            chipList.Add(new Chip(topList[index], isBlack));
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public virtual bool DeleteChip(int index)
        {
            if (topList.Count <= index)
            {
                return false;
            }
            int chipIndex = chipList.FindIndex(c => c.point == topList[index]);
            if (chipIndex != -1)
            {
                chipList.RemoveAt(chipIndex);
                return true;
            }
            return false;
        }

        public virtual bool DeleteChip(Chip chip)
        {
            if (topList.FindIndex(x => x == chip.point) != -1)
            {
                int index = chipList.FindIndex(x => x.point == chip.point);
                if (index != -1)
                {
                    chipList.RemoveAt(index);
                    return true;
                }
            }
            return false;
        }

        public virtual bool Delete(Point point)
        {
            int index = topList.FindIndex(x => x == point);
            if (index != -1)
            {
                topList.RemoveAt(index);
                edgeList.RemoveAll(x => x.Item1 == index || x.Item2 == index);
                chipList.RemoveAll(x => x.point == point);
                ChangeIndexes(index);
                return true;
            }
            return false;
        }
        public virtual bool Delete(int top)
        {
            return Delete(topList[top]);
        }
        public virtual bool Connect(Point top1, Point top2)
        {
            int num1 = topList.FindIndex(x => x == top1);
            int num2 = topList.FindIndex(x => x == top2);
            Tuple<int, int> edge1 = new Tuple<int, int>(num1, num2);
            if (edgeList.Contains(edge1))
            {
                return false;
            }
            edgeList.Add(edge1);
            return true;
        }
        public virtual bool Connect(int top1, int top2)
        {
            return Connect(topList[top1], topList[top2]);
        }
        public virtual bool Disconnect(Point top1, Point top2)
        {
            int num1 = topList.FindIndex(x => x == top1);
            int num2 = topList.FindIndex(x => x == top2);
            Tuple<int, int> edge1 = new Tuple<int, int>(num1, num2);
            if (edgeList.Contains(edge1))
            {
                edgeList.Remove(edge1);
                return true;
            }
            return false;
        }
        public virtual bool Disconnect(int top1, int top2)
        {
            return Disconnect(topList[top1], topList[top2]);
        }
        public virtual bool Load(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string tempStr = sr.ReadLine();
            int num;
            if (!(Int32.TryParse(tempStr, out num) && num > 0))
            {
                Clear();
                return false;
            }
            for (int i = 0; i < num; i++)
            {
                tempStr = sr.ReadLine().Trim();
                string[] strings = tempStr.Split(' ');
                int x;
                int y;
                if (!(strings.Length > 1 && Int32.TryParse(strings[0], out x) && Int32.TryParse(strings[1], out y)))
                {
                    continue;
                }
                Add(new Point(x, y));
            }
            tempStr = sr.ReadLine();
            if (!(Int32.TryParse(tempStr, out num) && num >= 0))
            {
                Clear();
                return false;
            }
            for (int i = 0; i < num; i++)
            {
                tempStr = sr.ReadLine().Trim();
                string[] strings = tempStr.Split(' ');
                int top1;
                int top2;
                if (!(strings.Length > 0 && Int32.TryParse(strings[0], out top1) && Int32.TryParse(strings[1], out top2) &&
                    top1 <= topList.Count && top2 <= topList.Count && top1 >= 0 && top2 >= 0))
                {
                    continue;
                }
                Connect(top1, top2);
            }
            sr.Dispose();
            return true;
        }
        public virtual void Clear()
        {
            edgeList.Clear();
            topList.Clear();
        }

        public virtual void Save(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(topList.Count);
            foreach (Point p in topList)
            {
                sw.WriteLine(p.X + " " + p.Y);
            }
            sw.WriteLine(edgeList.Count);
            foreach(Tuple<int, int> tuple in edgeList)
            {
                sw.WriteLine(tuple.Item1 + " " + tuple.Item2);
            }
            sw.Dispose();
        }
    }
}
