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
    public partial class FormLevel3 : Form
    {
        private int left_boxes;

        public FormLevel3()
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
            left_boxes = 17;
            Label_wall1.Visible = true;
            Label_wall2.Visible = false;
            Label_wall3.Visible = true;
            Label_onner1.Text = "Выкл";
            Label_onner1.BackColor = Color.Red;
            Label_onner2.Text = "Выкл";
            Label_onner2.BackColor = Color.Red;
            Label_Onner_wall1.Visible = false;
            Label_Onner_wall4.Visible = false;
            Label_Onner_wall2.Visible = true;
            Label_Onner_wall3.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
            label_key.Visible = true;
            label_door.Visible = true;
        }

        private void Finish_game()
        {
            Sound.Play_fail();
            DialogResult dr = MessageBox.Show("Вы проиграли, ещё раз?", "Сообщение",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Start_game();
            }
            else
                DialogResult = DialogResult.Abort;
        }

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            Start_game();
        }

        private void Label27_MouseEnter(object sender, EventArgs e)
        {
            Sound.Play_key();
            left_boxes--;
            ((Label)sender).Visible = false;
        }

        private void Label_wall1_MouseEnter(object sender, EventArgs e)
        {
            Finish_game();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Label_wall1.Visible = !Label_wall1.Visible;
            Label_wall2.Visible = !Label_wall2.Visible;
            Label_wall3.Visible = !Label_wall3.Visible;
        }

        private void Label_onner1_MouseEnter(object sender, EventArgs e)
        {
            
            if (Label_onner1.Text == "Выкл")
            {
                Label_onner1.BackColor = Color.Green;
                Label_onner1.Text = "Вкл";
                Label_Onner_wall1.Visible = true;
                Label_Onner_wall3.Visible = false;
            }
            else
            {
                Label_onner1.BackColor = Color.Red;
                Label_onner1.Text = "Выкл";
                Label_Onner_wall1.Visible = false;
                Label_Onner_wall3.Visible = true;
            }
        }

        private void Label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
            Sound.Play_key();
        }

        private void Label_door_MouseEnter(object sender, EventArgs e)
        {
            if (label_key.Visible)
            {
                Finish_game();
            }
            else
            {
                Sound.Play_key();
                label_door.Visible = false;
            }
        }

        private void Label_onner2_MouseEnter(object sender, EventArgs e)
        {
            if (Label_onner2.Text == "Выкл")
            {
                Label_onner2.BackColor = Color.Green;
                Label_onner2.Text = "Вкл";
                Label_Onner_wall4.Visible = true;
                Label_Onner_wall2.Visible = false;
            }
            else
            {
                Label_onner2.BackColor = Color.Red;
                Label_onner2.Text = "Выкл";
                Label_Onner_wall4.Visible = false;
                Label_Onner_wall2.Visible = true;
            }
        }

        private void Label_finish_MouseEnter(object sender, EventArgs e)
        {
            if (left_boxes == 0)
                DialogResult = DialogResult.OK;
        }
    }
}
