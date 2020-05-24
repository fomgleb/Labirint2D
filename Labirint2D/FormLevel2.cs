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
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
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
        }

        private void Finish_game()
        {
            label_door.Visible = true;
            label_key.Visible = true;
            Sound.Play_fail();
            DialogResult dr = MessageBox.Show("Вы проиграли, ещё раз?", "Сообщение",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Start_game();
            else
                DialogResult = DialogResult.Abort;
        }

        

        private void Label14_MouseEnter(object sender, EventArgs e)
        {
            Finish_game();
        }

        private void Label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
            Sound.Play_key();
        }

        private void Label16_MouseEnter(object sender, EventArgs e)
        {
            if (label_key.Visible)
            {
                Finish_game();
            }
            else
            {
                label_door.Visible = false;
                Sound.Play_key();
            }
        }

        private void Label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            Start_game();
        }
    }
}
