using SessionPlayer.Accelerations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.Twangers
{
    /// <summary>
    /// 加速度から「弾き」の動作に変換するクラス
    /// Twangerは加速度の履歴を持ち、
    /// 履歴中に正規化されたY軸加速度が0以上から0以下になった場合、
    /// 「弾き」が発生したとみなす。
    /// 弾きの強さは履歴中にある正規化されたY軸加速度の最低値と最高値の絶対値となる。
    /// </summary>
    public class SimpleTwanger : ITwanger
    {
        /// <summary>
        /// 加速度の履歴の最大数
        /// </summary>
        private int historySize;        

        /// <summary>
        /// 「弾き」が起こった際に発生するイベント
        /// 「弾き」の強さは0.0～1.0になる
        /// </summary>
        public event Action<double> OnTwang = delegate { };

        /// <summary>
        /// 履歴キュー
        /// </summary>
        private Queue<Acceleration> histories;

        /// <summary>
        /// 既定の加速度の履歴数で構築する
        /// </summary>
        public SimpleTwanger()
            : this(5)
        {
        }

        /// <summary>
        /// 加速度の履歴数を指定して構築する
        /// </summary>
        public SimpleTwanger(int historySize)
        {
            histories = new Queue<Acceleration>();
            this.historySize = historySize;
            this.Initialize();
        }

        /// <summary>
        /// 初期化する
        /// </summary>
        public void Initialize()
        {
            histories.Clear();
        }

        /// <summary>
        /// 加速度を設定する
        /// </summary>
        /// <param name="acceleration">加速度</param>
        public void PushAcceleration(Acceleration acceleration)
        {
            while (histories.Count() > this.historySize)
                histories.Dequeue();
            histories.Enqueue(acceleration);
            CheckCommand();
        }

        /// <summary>
        /// 履歴から「弾き」を判断する
        /// </summary>
        private void CheckCommand()
        {
            bool isStart = false;
            double start = 0;
            double end = 0;
            foreach (Acceleration acl in histories)
            {
                if (!isStart && acl.NormY > 0)
                {
                    if (start < acl.NormY)
                        start = acl.NormY;
                    isStart = true;
                }

                if (isStart && acl.NormY < 0)
                {
                    if (end > acl.NormY)
                        end = acl.NormY;
                }
            }
            if (start > 0 && end < 0)
            {
                double power = start - end;
                if (power > 1.0) power = 1.0;
                if (power < 0.4) return;
                OnTwang(power);
                histories.Clear();
            }
        }
    }
}
