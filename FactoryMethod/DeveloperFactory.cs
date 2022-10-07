static class DeveloperFactory
{

    static public IDeveloper getDeveloper(string developerNeeded)
    {
        if (developerNeeded == "java")
        {
            return new JavaDeveloper("john");
        }
        if (developerNeeded == "csharp")
        {
            return new CSharpDeveloper("Kyle");
        }

        if (developerNeeded == "kotlin")
        {
            return new KotlinDeveloper("Eddie");
        }

        return null;



    }
}