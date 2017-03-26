using SessionPlayer.Accelerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.Twangers
{
    /// <summary>
    /// 加速度をエアギターの「弾き」の動作に変換するインターフェイス
    /// </summary>
    public interface ITwanger
    {
        /// <summary>
        /// 「弾き」が起こった際に発生するイベント
        /// 「弾き」の強さは0.0～1.0になる
        /// </summary>
        event Action<double> OnTwang;

        /// <summary>
        /// 初期化する
        /// </summary>
        void Initialize();

        /// <summary>
        /// 加速度を追加する
        /// </summary>
        /// <param name="acceleration">加速度</param>
        void PushAcceleration(Acceleration acceleration);
    }
}
