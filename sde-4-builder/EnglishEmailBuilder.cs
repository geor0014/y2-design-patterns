public class EnglishEmailBuilder : IEmailBuilder
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
        if (type == "Sir")
        {
            email += "Dear Mr." + name + ",";
            // add new line
            email += Environment.NewLine;
        }
        else if (type == "Madam")
        {
            email += "Dear Ms." + name + ",";
            email += Environment.NewLine;
        }
        else
        {
            email += "To who it may concern,";
            email += Environment.NewLine;
        }
    }

    public void setEmailUniversity(string university)
    {
        this.university = university;
        email += "My name is " + name + " and I'm a recent graduate of " + university + ".";
        email += Environment.NewLine;
    }

    public void setEmailCompany(string company)
    {
        this.company = company;
        email += "I'm emailing you to ask about a potential interning opportunity at " + company;
        email += " I’d love to learn more about. Please let me know if you have any internships available.";
        email += Environment.NewLine;
    }

    public void setEmailContact(string contact)
    {
        this.contact = contact;
        email += "You can reach me via email or on my cell phone." + contact;
        email += Environment.NewLine;
    }

    public void setEmailClosing(string closing)
    {
        this.closing = closing;
        email += "Thank you so much for your time. I really look forward to hearing from you.";
        email += Environment.NewLine;
    }

    public string writeEmail()
    {
        return email;
    }
}