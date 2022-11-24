public class Screen {
    string description;
    int width;
    int height;

    public Screen(string description, int width, int height) {
        this.description = description;
        this.width = width;
        this.height = height;
    }

    public void up() {
        Console.WriteLine(description + " going up");
    }

    public void down() {
        Console.WriteLine(description + " going down");
    }

    public string ToString() {
        return description;
    }
}