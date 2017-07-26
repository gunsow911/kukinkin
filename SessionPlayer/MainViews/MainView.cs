using NAudio.CoreAudioApi;
using NAudio.Wave;
using SessionPlayer.Accelerations;
using SessionPlayer.Splitters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionPlayer.MainViews
{
    public partial class MainView : Form, IMainView
    {
        /// <summary>
        /// プレゼンタ
        /// </summary>
        private MainPresenter presenter;

        /// <summary>
        /// シリアルポートから来るデータの分割クラス
        /// </summary>
        private MessageSplitter splitter;

        /// <summary>
        /// ファイルパスを取得設定する
        /// </summary>
        public string FilePath
        {
            get { return this.textBoxFilepath.Text; }
            set { this.textBoxFilepath.Text = value; }
        }

        /// <summary>
        /// 演奏中かどうか取得設定する
        /// </summary>
        public bool IsPlayed
        {
            get { return isPlayed; }
            set
            {
                isPlayed = value;
                if (isPlayed)
                {
                    buttonPlay.Text = "停止";
                    buttonPortUpdate.Enabled = false;
                    buttonRef.Enabled = false;
                }
                else
                {
                    buttonPlay.Text = "再生";
                    buttonPortUpdate.Enabled = true;
                    buttonRef.Enabled = true;
                }
            }
        }
        private bool isPlayed;

        /// <summary>
        /// 加速度を取得設定する
        /// </summary>
        public Acceleration Acceleration
        {
            get 
            {
                return this.acceleration;
            }
            set
            {
                this.acceleration = value;
                if (value == null) return;
                this.labelAccelationlX.Text = "X：" + value.NormX.ToString();
                this.labelAccelationlY.Text = "Y：" + value.NormY.ToString();
                this.labelAccelationlZ.Text = "Z：" + value.NormZ.ToString();
            }
        }
        private Acceleration acceleration;

        /// <summary>
        /// 弾く力を取得設定する
        /// </summary>
        public int Power {
            get { return this.progressBarPower.Value; }
            set { this.progressBarPower.Value = value; }
        }

        /// <summary>
        /// グルーヴ感を取得設定する
        /// </summary>
        public int Groove {
            get { return this.progressBarGroove.Value;}
            set { this.progressBarGroove.Value = value; }            
        }

        public MainView()
        {
            this.InitializeComponent();
            this.presenter = new MainPresenter(this);
            this.splitter = new MessageSplitter();
            this.splitter.OnMessage += splitter_OnMessage;
            this.UpdatePorts();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "MP3ファイル(*.mp3)|*.mp3;";
                ofd.Title = "開くファイルを選択してください";
                ofd.RestoreDirectory = true;
                //ダイアログを表示する
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.presenter.ReadSoundFile(ofd.FileName);
                }         
            }

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.serialPort.IsOpen) this.serialPort.Open();
                this.presenter.TogglePlay();
            }
            catch (IOException)
            {
                MessageBox.Show("利用できるポートが見つかりませんでした。");
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            this.presenter.RestartPlay();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.presenter.Run();
        }

        private void serialPortTwe_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string receivedData = this.serialPort.ReadExisting();
            this.splitter.Add(receivedData);            
        }

        private void splitter_OnMessage(Dictionary<string, string> obj)
        {
            if (obj.ContainsKey("ts")) return;

            string strX, strY, strZ;
            obj.TryGetValue("x", out strX);
            obj.TryGetValue("y", out strY);
            obj.TryGetValue("z", out strZ);
            if (strX == null || strY == null || strZ == null) return;

            int x = int.Parse(strX);
            int y = int.Parse(strY);
            int z = int.Parse(strZ);
            this.presenter.Receive(x, y, z);
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void buttonPortUpdate_Click(object sender, EventArgs e)
        {
            this.UpdatePorts();
        }

        private void UpdatePorts()
        {
            this.comboBoxSerialPorts.Items.Clear();
            this.comboBoxSerialPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxSerialPorts.Items.Count == 0) return;
            serialPort.PortName = (string)comboBoxSerialPorts.Items[0];
            comboBoxSerialPorts.SelectedItem = (string)comboBoxSerialPorts.Items[0];
        }

        private void comboBoxSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = (string)comboBoxSerialPorts.SelectedItem;
        }
    }
}
