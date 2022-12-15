void makeEmail()
{
    Director conductor = new Director();
    EnglishEmailBuilder englishBuilder = new EnglishEmailBuilder();
    ItalianEmailBuilder italianBuilder = new ItalianEmailBuilder();

    string englishEmail = conductor.constructEnglishEmail(englishBuilder);
    string italianEmail = conductor.constructItalianEmail(italianBuilder);

    // print emails to console
    Console.WriteLine(englishEmail);
    Console.WriteLine(italianEmail);

}

// Output:
makeEmail();