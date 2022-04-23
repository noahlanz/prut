namespace Noah.PrutProject {

    public class FartPlayer {
        private System.Media.SoundPlayer _MediaPlayer;
        public FartPlayer(string soundFile) {
            _MediaPlayer = new System.Media.SoundPlayer(soundFile);
        }

        public void Play() {
            _MediaPlayer.PlaySync();
        }
    }
}