namespace MusicStore.Models
{
    public enum Signature
    {
        C, D, E, F, G, A, B
    }

    public enum Mode
    {
        Major, Minor
    }

    public class Key
    {
        public Signature Signature { get; set; }
        public Mode Mode { get; set; }
    }
}
