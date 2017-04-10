using NAudio.Dsp;
using NAudio.Wave;
using SessionPlayer.Accelerations;
using SessionPlayer.Groovers;
using SessionPlayer.Twangers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.AirGuitars
{
    /// <summary>
    /// エアギターを表すクラス
    /// </summary>
    public class AirGuitar : IAirGuitar
    {
        /// <summary>
        /// 「グルーヴ」が起きた時のイベント
        /// </summary>
        public event Action OnGroovy = delegate { };

        /// <summary>
        /// 「弾き」の動作を表すインターフェイス
        /// </summary>
        private ITwanger twanger;

        /// <summary>
        /// 「グルーヴ」の動作を表すインターフェイス
        /// </summary>
        private IGroover groover;

        /// <summary>
        /// 弾きの強さを取得する
        /// </summary>
        public int Power { get; private set; }

        /// <summary>
        /// グルーヴ感を取得する
        /// </summary>
        public int Groove { get; private set; }

        /// <summary>
        /// 最後の加速度を取得する
        /// </summary>
        public Acceleration LastAcceleration
        {
            get { return this.lastAcceleration; }
        }
        private Acceleration lastAcceleration;

        /// <summary>
        /// エアギターを構築する
        /// </summary>
        public AirGuitar(ITwanger twanger, IGroover groover)
        {
            this.twanger = twanger;
            this.groover = groover;
            this.twanger.OnTwang += twanger_OnTwang;
            this.groover.OnGroove += groover_OnGroove;
            Initialize();
        }

        /// <summary>
        /// エアギターを初期化する
        /// </summary>
        public void Initialize()
        {
            this.Power = 0;
            this.Groove = 0;
            this.twanger.Initialize();
            this.groover.Initialize();
        }

        /// <summary>
        /// 加速度を追加する
        /// </summary>
        /// <param name="acceleration">加速度</param>
        public void PushAcceleration(Acceleration acceleration)
        {
            this.twanger.PushAcceleration(acceleration);
            this.groover.PushAcceleration(acceleration);
            this.lastAcceleration = acceleration;
        }

        /// <summary>
        /// エアギターを動作させる
        /// </summary>
        public void Run()
        {
            if (this.Power > 0) this.Power -= 2;
            if (this.Groove > 0) this.Groove -= 2;
            if (this.Power < 0) this.Power = 0;
            if (this.Groove < 0) this.Groove = 0;
        }

        /// <summary>
        /// 弾いた際のイベント
        /// </summary>
        /// <param name="power">弾きの強さ(0.0～1.0)</param>
        private void twanger_OnTwang(double power)
        {
            Trace.WriteLine("Twang!!:" + power);
            int prevPower = this.Power;
            this.Power = (int)(75 * power) + 25;
            // 前の弾きの強さよりも弱い場合は無視
            if (this.Power < prevPower) this.Power = prevPower;
        }

        /// <summary>
        /// グルーヴが起こった際のイベント
        /// </summary>
        /// <param name="power">グルーヴの強さ</param>
        private void groover_OnGroove()
        {
            this.Groove = 100;
            this.OnGroovy();
        }
    }
}
