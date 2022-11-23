public class ConsoleReader {
    public String readLine() {
        try {
            // get the input from the user
            var line = Console.ReadLine();
            return line;
        }
        catch( Exception e ) {
            return "Please, give me a valid input";
        }
    }
}