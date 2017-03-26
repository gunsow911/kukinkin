using SessionPlayer.Accelerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.AirGuitars
{
    /// <summary>
    /// エアギターを表すインターフェイス
    /// </summary>
    public interface IAirGuitar
    {
        /// <summary>
        /// 「グルーヴ」が起きた時のイベント
        /// </summary>
        event Action OnGroovy;

        /// <summary>
        /// 弾きの強さを取得する
        /// </summary>
        int Power { get; }

        /// <summary>
        /// グルーヴ感を取得する
        /// </summary>
        int Groove { get; }

        /// <summary>
        /// 最後の加速度を取得する
        /// </summary>
        Acceleration LastAcceleration { get; }

        /// <summary>
        /// エアギターを初期化する
        /// </summary>
        void Initialize();

        /// <summary>
        /// 加速度を追加する
        /// </summary>
        /// <param name="acceleration">加速度</param>
        void PushAcceleration(Acceleration acceleration);

        /// <summary>
        /// エアギターを動作させる
        /// </summary>
        void Run();
    }
}
