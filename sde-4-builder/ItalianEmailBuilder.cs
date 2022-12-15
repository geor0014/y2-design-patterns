public class ItalianEmailBuilder : IEmailBuilder
{
    private string email = "";
    private string name = "";
    private string university = "";
    private string company = "";
    private string contact = "";
    private string closing = "";

    public void setEmailName(string name)
    {
        this.name = name;
    }

    public void setEmailOpening(string type)
    {
        if (type == "Sig")
        {
            email += "Gentile Sig." + name + ",";
            // add new line
            email += Environment.NewLine;

        }
        else if (type == "Sig.ra")
        {
            email += "Gentile Sig.ra" + name + ",";
            email += Environment.NewLine;
        }
        else
        {
            email += "A chi di dovere,";
            email += Environment.NewLine;
        }
    }

    public void setEmailUniversity(string university)
    {
        this.university = university;
        email += "Mi chiamo " + name + " e sono un recente laureato di " + university + ".";
        email += Environment.NewLine;
    }

    public void setEmailCompany(string company)
    {
        this.company = company;
        email += "Vi scrivo per chiedere se avete delle opportunità di stage presso " + company;
        email += " Mi piacerebbe saperne di più. Vi prego di dirmi se avete degli stage disponibili.";
        email += Environment.NewLine;
    }

    public void setEmailContact(string contact)
    {
        this.contact = contact;
        email += "Potete raggiungermi via email o sul mio cellulare." + contact;
        email += Environment.NewLine;
    }

    public void setEmailClosing(string closing)
    {
        this.closing = closing;
        email += "Grazie mille per il vostro tempo. Spero di sentire da voi a breve.";
        email += Environment.NewLine;
    }

    public string writeEmail()
    {
        return email;
    }
}