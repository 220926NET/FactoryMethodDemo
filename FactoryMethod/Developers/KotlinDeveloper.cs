class KotlinDeveloper : IDeveloper
{

    private string _name;

 


    public KotlinDeveloper(string name)
    {
     

        _name = name;
    }


    public string writeCode()
    {
        return "Writing kotlin code";
    }

}