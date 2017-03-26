using SessionPlayer.Accelerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.Groovers
{
    /// <summary>
    /// 加速度をエアギターの「グルーヴ」の動作に変換するインターフェイス
    /// </summary>
    public interface IGroover
    {
        /// <summary>
        /// 「グルーヴ」が起こった際に発生するイベント
        /// </summary>
        event Action OnGroove;

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
