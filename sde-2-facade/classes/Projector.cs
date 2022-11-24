public class Projector {
    string description;
    DvdPlayer dvdPlayer;

    public Projector(string description, DvdPlayer dvdPlayer) {
        this.description = description;
        this.dvdPlayer = dvdPlayer;
    }

    public void on() {
        Console.WriteLine(description + " on");
    }

    public void off() {
        Console.WriteLine(description + " off");
    }

    public void wideScreenMode() {
        Console.WriteLine(description + " in widescreen mode (16x9 aspect ratio)");
    }

    public void tvMode() {
        Console.WriteLine(description + " in tv mode (4x3 aspect ratio)");
    }
    
    public string ToString() {
        return description;
    }
}