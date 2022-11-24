public class Tuner {
    string description;
    Amplifier amplifier;
    double frequency;

    public Tuner(string description, Amplifier amplifier) {
        this.description = description;
        this.amplifier = amplifier;
    }

    public void on() {
        Console.WriteLine(description + " on");
    }

    public void off() {
        Console.WriteLine(description + " off");
    }

    public void setFrequency(double frequency) {
        Console.WriteLine(description + " setting frequency to " + frequency);
        this.frequency = frequency;
    }

    public void setAm() {
        Console.WriteLine(description + " setting AM mode");
    }

    public void setFm() {
        Console.WriteLine(description + " setting FM mode");
    }

    public string ToString() {
        return description;
    }
}