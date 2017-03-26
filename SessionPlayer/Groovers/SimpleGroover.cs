using SessionPlayer.Accelerations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.Groovers
{
    public class SimpleGroover : IGroover
    {
        /// <summary>
        /// 「グルーヴ」が起こった際に発生するイベント
        /// </summary>
        public event Action OnGroove = delegate { };

        /// <summary>
        /// 加速度の履歴の最大数
        /// </summary>
        private int historySize;        

        /// <summary>
        /// 履歴キュー
        /// </summary>
        private Queue<Acceleration> histories;

        /// <summary>
        /// 既定の加速度の履歴数で構築する
        /// </summary>
        public SimpleGroover()
            : this(5)
        {
        }

        /// <summary>
        /// 加速度の履歴数を指定して構築する
        /// </summary>
        public SimpleGroover(int historySize)
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
        /// 履歴から「グルーヴ」を判断する
        /// </summary>
        private void CheckCommand()
        {
            bool isShakuriUp = true; // しゃくりアップ
            bool isJaan = true; // ジャーン！
            foreach (Acceleration history in histories)
            {
                // しゃくりアップはエアギターを立てる
                if (!(history.NormY > 0.80 && history.NormY < 1))
                {
                    isShakuriUp = false;
                    break;
                }
            }

            foreach (Acceleration history in histories)
            {
                // ジャーン！は弾いたまま伸ばす
                if (!(history.NormY > -0.65 && history.NormY < -0.40))
                {
                    isJaan = false;
                    break;
                }
            }

            if (isShakuriUp || isJaan)
                this.OnGroove();          
        }

    }
}
