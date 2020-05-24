using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormLevel1 : Form
    {
        int left_boxes;

        public FormLevel1()
        {
            InitializeComponent();
        }

        private void Start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);//чтобы курсор очутился посреди кнопки старт
            Cursor.Position = PointToScreen(point);// PointToScreen нужен чтобы курсор появился не относительно екрана, а относительно формы
            Sound.Play_click();
            left_boxes = 5;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            label_wall.Visible = true;

        }

        private void Finish_game()
        {
            Sound.Play_fail();
            DialogResult dr = MessageBox.Show("Вы проиграли, ещё раз?", "Сообщение",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Start_game();
            else
                DialogResult = DialogResult.Abort;
        }

        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            Start_game();
        }

        private void Label_finish_MouseEnter(object sender, EventArgs e)
        {
            if (left_boxes == 0)
            {
                DialogResult = DialogResult.OK; // Когда переходим на финиш, игра завершается
            }
        }

        private void Label4_MouseEnter(object sender, EventArgs e)
        {
            Finish_game();
        }

        private void Label_box1_MouseEnter(object sender, EventArgs e)
        {
            Sound.Play_key();
            left_boxes--;
            ((Label)sender).Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label_wall.Visible = !label_wall.Visible;
        }

        private void Label_wall_MouseEnter(object sender, EventArgs e)
        {
            Finish_game();
        }
    }
}
