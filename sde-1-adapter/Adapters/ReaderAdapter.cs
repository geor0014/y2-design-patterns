public class ReaderAdapter: BooleanAnswer {
    private ConsoleReader reader;
    // array of valid answers
    private string[] validAnswers = new string[] { "true", "yes", "oh yeah", "great", "sure", "love to", "of course", "always", "never done otherwise" };
    public ReaderAdapter(ConsoleReader reader) {
        this.reader = reader;
    }
    public bool readLine() {
        try {
            // get the input from the user
            var line = reader.readLine();
            return validAnswers.Contains(line);
        }
        catch( Exception e ) {
            return false;
        }
    }
}