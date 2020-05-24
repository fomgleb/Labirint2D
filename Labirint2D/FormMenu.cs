using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (box_sound.Checked)
            {
                box_music.Checked = false;
                Sound.Sound_on();
                Sound.Play_key();
            }
            else
            {
                Sound.Sound_off();
            }
        }

        private void Box_music_CheckedChanged(object sender, EventArgs e)
        {
            if (box_music.Checked)
            {
                box_sound.Checked = false;
                Sound.Music_on();
                Sound.Play_music();
            }
            else
            {
                Sound.Music_off();
                Sound.Play_music();
            }
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            Start_level1();
        }

        private void Start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Start_level2();
            }
        }

        private void Start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Start_level3();
            }
        }

        private void Start_level3()
        {
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Start_youwin();
            }
        }

        private void Start_youwin()
        {
            Sound.Play_youwin();
            MessageBox.Show("Вы прошли все уровни!");
        }
    }
}
