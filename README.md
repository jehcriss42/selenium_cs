# selenium_cs
Practice using selenium and C#

 *1) Prerequisite:*
   
    C# by Microsoft
    PackSharp by Carlos Kidman
    Vs Code

*2) Setting Up:*

    Open the Command Palette for each of these commands:

    PackSharp: Create New Project > select Class Library > call the Project "Framework"
    PackSharp: Create New Project > select Class Library > call the Project "Royale"
    PackSharp: Create New Project > select NUnit 3 Test Project > call the Project "Royale.Tests"
    PackSharp: Create New Project > select Solution File > call the Project "StatsRoyale"

    Add the Projects to the Solution. Run these commands in the Terminal:

        $ dotnet sln add Framework
        $ dotnet sln add Royale
        $ dotnet sln add Royale.Tests
    
    Install Selenium NuGet (package) with PackSharp

    Open Command Palette > select PackSharp: Bootstrap Selenium > add to Royale.Tests, our Test Project

    If you open the Royale.Tests.csproj file, you will see that Selenium packages have been added
    You will also see a _drivers directory is added at the Workspace root

    Build the Solution so we know everything is working

        $ dotnet build

    Run the Tests

        $ dotnet test

*Reference*

Based on: https://github.com/ElSnoMan/from-scripting-to-framework

From Scripting to Framework with Selenium and C# - Test automation University