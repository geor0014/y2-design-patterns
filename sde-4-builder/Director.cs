public class Director
{
    public string constructEnglishEmail(EnglishEmailBuilder builder)
    {
        builder.setEmailName("John");
        builder.setEmailOpening("Sir");
        builder.setEmailUniversity("University of California, Berkeley");
        builder.setEmailCompany("Google");
        builder.setEmailContact("123-456-7890");
        builder.setEmailClosing("Sincerely");
        return builder.writeEmail();
    }

    public string constructItalianEmail(ItalianEmailBuilder builder)
    {
        builder.setEmailName("Mario");
        builder.setEmailOpening("Sig.ra");
        builder.setEmailUniversity("Università di Pisa");
        builder.setEmailCompany("Amazon");
        builder.setEmailContact("123-456-7890");
        builder.setEmailClosing("Cordiali saluti");
        return builder.writeEmail();
    }
}