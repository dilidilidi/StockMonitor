using System;
using System.Media;
using System.Windows.Forms;

namespace StockMonitor.Utils
{
    public static class SoundUtil
    {
        //判断是否可以播放，默认为可以播放
        public static Boolean Playable = true;
        //判断是否正在播放，默认为没有播放
        public static Boolean IsPlaying = false;
        //播放器
        public static SoundPlayer SndPlayer;

        //开始播放
        public static void StartPlaySound(String fileStr)
        {
            if (!Playable) return;
            if (IsPlaying) return;
            SndPlayer = new SoundPlayer(Application.StartupPath + @fileStr);
            SndPlayer.PlayLooping();
            IsPlaying = true;
        }
    }
}
