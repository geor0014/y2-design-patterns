
        ConsoleReader reader = new ConsoleReader();
        ConsoleWriter writer = new ConsoleWriter();

        // ask questions
        string question = "Do you like eating vegetables?";

        string good = "You're a healthy person!";
        string bad = "Maybe you should try to eat some carrots";

        // ask question to user
        writer.write(question);

        // read response
        BooleanAnswer improvedReader = new ReaderAdapter(reader);
        bool ans1 = improvedReader.readLine();

        if (ans1) {
            writer.write(good);
        } else {
            writer.write(bad);
        }