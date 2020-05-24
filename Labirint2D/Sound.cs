using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Labirint2D
{
    static class Sound
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail);
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.sound_key);
        static SoundPlayer sound_youwin = new SoundPlayer(Properties.Resources.sound_youwin);
        static SoundPlayer music = new SoundPlayer(Properties.Resources.music);
        static SoundPlayer sound_click = new SoundPlayer(Properties.Resources.sound_click);
        static bool sound_enabled = true;
        static bool music_enabled = false;

        public static void Music_on()
        {
            music_enabled = true;
        }

        public static void Music_off()
        {
            music_enabled = false;
        }

        public static void Sound_on()
        {
            sound_enabled = true;
        }

        public static void Sound_off()
        {
            sound_enabled = false;
        }

        public static void Play_fail()
        {
            if (sound_enabled)
                sound_fail.Play();
        }
        public static void Play_key()
        {
            if (sound_enabled)
                sound_key.Play();
        }
        public static void Play_youwin()
        {
            if (sound_enabled)
                sound_youwin.Play();
        }
        public static void Play_click()
        {
            if (sound_enabled)
                sound_click.Play();
        }
        public static void Play_music()
        {
            if (music_enabled)
                music.Play();
            else
                music.Stop();
        }

    }
}
