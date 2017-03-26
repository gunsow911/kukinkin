using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.Accelerations
{
    /// <summary>
    /// 3軸加速度を表すクラス
    /// </summary>
    public class Acceleration
    {
        /// <summary>
        /// XYZ加速度から構築する
        /// </summary>
        /// <param name="x">X軸加速度</param>
        /// <param name="y">Y軸加速度</param>
        /// <param name="z">Z軸加速度</param>
        public Acceleration(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;

            Length = Math.Sqrt((x * x) + (y * y) + (z * z));
            NormX = X / Length;
            NormY = Y / Length;
            NormZ = Z / Length;
        }

        /// <summary>
        /// X軸加速度を取得する
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// Y軸加速度を取得する
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// Z軸加速度を取得する
        /// </summary>
        public int Z { get; private set; }

        /// <summary>
        /// 正規化されたX軸加速度を取得する
        /// </summary>
        public double NormX { get; private set; }

        /// <summary>
        /// 正規化されたY軸加速度を取得する
        /// </summary>
        public double NormY { get; private set; }

        /// <summary>
        /// 正規化されたZ軸加速度を取得する
        /// </summary>
        public double NormZ { get; private set; }

        /// <summary>
        /// ベクトルの長さを取得する
        /// </summary>
        public double Length { get; private set; }

    }
}
