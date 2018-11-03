using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab1.Program;

namespace Lab1
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelFuchsia.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelLime.MouseDown += panelColor_MouseDown;
            panelMaroon.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        IAircraft fighter = null;
        private event fighterDelegate eventAddFighter;

        private void Draw()
        {
            if (fighter != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxfighter.Width, pictureBoxfighter.Height);
                Graphics gr = Graphics.FromImage(bmp);
                fighter.SetPosition(5, 55, pictureBoxfighter.Width, pictureBoxfighter.Height);
                fighter.Draw(gr);
                pictureBoxfighter.Image = bmp;
            }
        }

        public void AddEvent(fighterDelegate ev)
        {
            if (eventAddFighter == null)
            {
                eventAddFighter = new fighterDelegate(ev);
            }
            else
            {
                eventAddFighter += ev;
            }
        }

        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);

        }

        private void labelFighter_MouseDown(object sender, MouseEventArgs e)
        {
            labelFighter.DoDragDrop(labelFighter.Text, DragDropEffects.Move | DragDropEffects.Copy);

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Plane":
                    fighter = new Plane(11000, 2450, Color.Green, true, true);
                    break;
                case "Fighter":
                    fighter = new Fighter(11000, 2450, Color.Black, Color.Gray, true, true, true, true, true);

                    break;
            }
            Draw();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (fighter != null)
            {
                fighter.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (fighter != null)
            {
                if (fighter is Fighter)
                {
                    (fighter as Fighter).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddFighter?.Invoke(fighter);
            Close();
        }
    }
}
