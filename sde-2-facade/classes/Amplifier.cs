public class Amplifier {
    string description;
    Tuner tuner;
    DvdPlayer dvd;
    CdPlayer cd;

    public Amplifier(string description) {
        this.description = description;
    }

    public void on() {
        Console.WriteLine(description + " on");
    }

    public void off() {
        Console.WriteLine(description + " off");
    }

    public void setStereoSound() {
        Console.WriteLine(description + " stereo mode on");
    }

    public void setSurroundSound() {
        Console.WriteLine(description + " surround sound on (5 speakers, 1 subwoofer)");
    }

    public void setVolume(int level) {
        Console.WriteLine(description + " setting volume to " + level);
    }

    public void setTuner(Tuner tuner) {
        Console.WriteLine(description + " setting tuner to " + dvd);
        this.tuner = tuner;
    }

    public void setDvd(DvdPlayer dvd) {
        Console.WriteLine(description + " setting DVD player to " + dvd);
        this.dvd = dvd;
    }

    public void setCd(CdPlayer cd) {
        Console.WriteLine(description + " setting CD player to " + cd);
        this.cd = cd;
    }

    public string ToString() {
        return description;
    }
}