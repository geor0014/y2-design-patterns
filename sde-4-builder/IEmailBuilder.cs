public interface IEmailBuilder
{
    public void setEmailName(string name);
    public void setEmailOpening(string type);
    public void setEmailUniversity(string university);
    public void setEmailCompany(string company);
    public void setEmailContact(string contact);
    public void setEmailClosing(string closing);
    public string writeEmail();
}