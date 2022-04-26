using NetCoreAudio;

namespace Noah.PrutProject {

    public class FartPlayer {

        private Player _SoundPlayer;
        private string _SoundFile;

        public FartPlayer(string soundFile) {
            _SoundPlayer = new Player();
            _SoundFile = soundFile;
        }

        public void Play() {
            _SoundPlayer.Stop();
            _SoundPlayer.Play(_SoundFile);
        }
    }
}