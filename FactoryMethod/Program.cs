
buildJavaTicketSystem();

buildCScharpWebApp();



static void buildJavaTicketSystem()
{
    CitiBank citiBank = new CitiBank(DeveloperFactory.getDeveloper("java"));
    Console.WriteLine(citiBank.buildApp());
}

static void buildCScharpWebApp()
{
    CitiBank citiBank = new CitiBank(DeveloperFactory.getDeveloper("csharp"));
    Console.WriteLine(citiBank.buildApp());
}


buildMobileApp();

static void buildMobileApp()
{
    CitiBank citiBank = new CitiBank(DeveloperFactory.getDeveloper("kotlin"));
    Console.WriteLine(citiBank.buildApp());
}


