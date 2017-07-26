using NAudio.CoreAudioApi;
using NAudio.Wave;
using SessionPlayer.Accelerations;
using SessionPlayer.AirGuitars;
using SessionPlayer.Groovers;
using SessionPlayer.Twangers;
using SoundTouch;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.MainViews
{
    public class MainPresenter
    {
        private IMainView view;
        private IAirGuitar guiter;

        private WaveOut waveOut;
        private AudioFileReader reader;

        private WaveOut cheer1Out;
        private AudioFileReader cheer1Stream;
        private WaveOut cheer2Out;
        private AudioFileReader cheer2Stream;

        private Random random;

        /// <summary>
        /// プレゼンタの構築
        /// </summary>
        /// <param name="view"></param>
        public MainPresenter(IMainView view)
        {
            this.view = view;
            this.view.FilePath = string.Empty;
            this.view.IsPlayed = false;
            this.waveOut = new WaveOut();
            this.waveOut.Volume = 0.55f;
            this.guiter = new AirGuitar(new SimpleTwanger(), new SimpleGroover());
            this.guiter.OnGroovy += guiter_OnGroovy;

            string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            this.cheer1Out = new WaveOut();
            this.cheer1Stream = new AudioFileReader(@"Resouces\people-stadium-cheer1.mp3");
            this.cheer1Out.Init(this.cheer1Stream);

            this.cheer2Out = new WaveOut();
            this.cheer2Stream = new AudioFileReader(@"Resouces\people-studio-kyaa1.mp3");
            this.cheer2Out.Init(this.cheer2Stream);

            random = new Random();
        }

        private void guiter_OnGroovy()
        {
            Trace.WriteLine("cheer1:" + cheer1Out.PlaybackState.ToString());
            Trace.WriteLine("cheer2:" + cheer2Out.PlaybackState.ToString());
            
            if (cheer1Out.PlaybackState == PlaybackState.Playing) return;
            if (cheer2Out.PlaybackState == PlaybackState.Playing) return;

            int rnd = random.Next(2);
            if (rnd == 0)
            {
                cheer1Out.Stop();
                cheer1Stream.Position = 0;
                cheer1Out.Play();
            }
            else
            {
                cheer2Out.Stop();
                cheer2Stream.Position = 0;
                cheer2Out.Play();
            }
        }

        public void ReadSoundFile(string filepath)
        {
            this.view.FilePath = filepath;
            this.reader = new AudioFileReader(filepath);
            this.waveOut.Init(reader);
        }

        public void Run()
        {
            if (this.reader == null) return;
            if (!this.view.IsPlayed) return;

            this.view.Power = this.guiter.Power;
            this.view.Groove = this.guiter.Groove;
            this.view.Acceleration = this.guiter.LastAcceleration;

            if (this.guiter.Power > 0 ||
                this.guiter.Groove > 0)
                this.waveOut.Play();
            else
                this.waveOut.Pause();

            this.guiter.Run();
        }

        public void TogglePlay()
        {
            if (this.reader == null) return;
            this.view.IsPlayed = !this.view.IsPlayed;
            this.guiter.Initialize();
            this.view.Power = 0;
            this.view.Groove = 0;
            this.waveOut.Pause();
        }

        public void RestartPlay()
        {
            if (this.reader == null) return;
            this.view.IsPlayed = false;
            this.guiter.Initialize();
            this.view.Power = 0;
            this.view.Groove = 0;
            this.waveOut.Stop();
            this.reader.Position = 0;
            Trace.WriteLine("restart");
        }

        public void Receive(int x, int y, int z)
        {
            Acceleration acceleration = new Acceleration(x, y, z);
            this.guiter.PushAcceleration(acceleration);
        }
    }
}
