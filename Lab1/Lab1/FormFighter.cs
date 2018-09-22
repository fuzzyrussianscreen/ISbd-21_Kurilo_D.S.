using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormFighter : Form
    {
        private Fighter fighter;

        public FormFighter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxFighter.Width, pictureBoxFighter.Height);
            Graphics gr = Graphics.FromImage(bmp);
            fighter.DrawCar(gr);
            pictureBoxFighter.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            fighter = new Fighter (rnd.Next(300, 500), rnd.Next(1000, 2000), Color.Black,
           Color.Gray, true, true, true);
            fighter.SetPosition(rnd.Next(50, 150), rnd.Next(50, 150), pictureBoxFighter.Width,
           pictureBoxFighter.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    fighter.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    fighter.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    fighter.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    fighter.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
