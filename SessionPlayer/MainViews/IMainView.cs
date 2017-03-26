using NAudio.CoreAudioApi;
using NAudio.Wave;
using SessionPlayer.Accelerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.MainViews
{
    public interface IMainView
    {
        /// <summary>
        /// ファイルパスを取得設定する
        /// </summary>
        string FilePath { get; set; }

        /// <summary>
        /// 再生中かどうか取得設定する
        /// </summary>
        bool IsPlayed { get; set; }

        /// <summary>
        /// 3軸の加速度を取得設定する
        /// </summary>
        Acceleration Acceleration { get; set; }

        /// <summary>
        /// 強さを取得設定する
        /// </summary>
        int Power{ get; set; }

        /// <summary>
        /// グルーヴ感を取得設定する
        /// </summary>
        int Groove { get; set; }
    }
}
