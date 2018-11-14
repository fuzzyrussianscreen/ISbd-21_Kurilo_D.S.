using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Parking<T> where T: class, IAircraft
    {

        private Dictionary<int, T> _places;

        private int _maxCount;

        private int PictureWidth { get; set; }

        private int PictureHeight { get; set; }

        private int _placeSizeWidth = 260;

        private int _placeSizeHeight = 120;

        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        public static int operator +(Parking<T> p, T fighter)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {   
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, fighter);
                    p._places[i].SetPosition(5 + i / 4 * p._placeSizeWidth + 5,
                     i % 4 * p._placeSizeHeight + 60, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;  
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T fighter = p._places[index];
                p._places.Remove(index);
                return fighter;
            }
            return null;
        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].Draw(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            Pen pen2 = new Pen(Color.White, 3);
            Brush brush = new SolidBrush(Color.Gray);
            
            g.FillRectangle(brush, 0, 0, (_maxCount / 4) * _placeSizeWidth+10, 600);
            for (int i = 0; i < _maxCount / 4; i++)
            {
                for (int j = 0; j < 5; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + 120, j * _placeSizeHeight);
                    g.DrawLine(pen2, i * _placeSizeWidth + 80, j * _placeSizeHeight + 60, i * _placeSizeWidth + 190, j * _placeSizeHeight + 60);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 480);
                g.DrawLine(pen2, i * _placeSizeWidth+190, 60, i * _placeSizeWidth+190, 540);
                g.DrawLine(pen2, i * _placeSizeWidth, 540, i * _placeSizeWidth + 260, 540);
            }
        }

        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 4 * _placeSizeWidth + 15, ind % 4 * _placeSizeHeight + 60, PictureWidth, PictureHeight);
                }
            }
        }
    }
}
