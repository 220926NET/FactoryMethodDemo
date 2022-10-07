
class CSharpDeveloper : IDeveloper
{

    private string _name;

    
    public CSharpDeveloper(string name)
    {
     
        _name = name;
    }


    public string writeCode()
    {

        return "Writing code in csharp.";
    }
}