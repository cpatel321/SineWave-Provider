using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace SineGenerator
{
    public class SoundGenerator
    {
        private IWavePlayer player;
        private readonly SineWaveProvider sineProvider;
        private bool isInitialized;

        public SoundGenerator()
        {
            sineProvider = new SineWaveProvider();
        }

        public void GenerateSound(double frequency)
        {
            if (frequency < 20) // threshold for generating sound
            {
                StopSound();
                return;
            }

            if (!isInitialized)
            {
                InitializePlayer();
            }

            sineProvider.Frequency = frequency;
        }

        private void InitializePlayer()
        {
            var waveOutEvent = new WaveOutEvent
            {
                NumberOfBuffers = 2,
                DesiredLatency = 100
            };
            player = waveOutEvent;
            player.Init(new SampleToWaveProvider(sineProvider));
            player.Play();
            isInitialized = true;
        }

        private void StopSound()
        {
            player?.Stop();
        }
    }
}
