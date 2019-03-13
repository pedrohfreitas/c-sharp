# c-sharp
Linguagem e seus Recursos C#


# NETCORE CLI Commands

dotnet new sln --name <SOLUTION_NAME> 
Ex.: dotnet new sln --name C-Sharp

dotnet new console --name <PROJECT_NAME> 
Ex.: dotnet new console --name Thread

dotnet sln <SOLUTION_NAME> add <PROJECT_NAME>
Ex.: dotnet sln .\DesignPatterns.sln add .\Thread\Thread.csproj

dotnet run --project <PROJECT_NAME> 
Ex.: dotnet run --project .\Thread\Thread\Thread.csproj