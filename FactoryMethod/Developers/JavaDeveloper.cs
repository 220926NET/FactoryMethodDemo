

class JavaDeveloper : IDeveloper
{

 
    private string _name;
    public JavaDeveloper(string name)
    {
      
        _name = name;
    }

    public string writeCode()
    {

        return "Writing Java Code";
    }
}