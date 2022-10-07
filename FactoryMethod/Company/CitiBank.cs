class CitiBank
{

    private IDeveloper _developer;

    public CitiBank(IDeveloper developer)
    {
        _developer = developer;
    }

    public string buildApp()
    {

        return _developer.writeCode();
    }

}