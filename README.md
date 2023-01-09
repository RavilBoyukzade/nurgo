# nurgo
The Nurgo website represents a company that delivers cars from Europe to Azerbaijan. 
FrontEnd was written for this site using technologies such as HTML, CSS, JavaScript, JQuery. We also used the technology of adding icons through FontAwesome and working with elements on the page using Bootstrap.
After that, I started to develop the backend structure of the site.
Initially, I chose the codefirst system and created a separate structure where I placed all the Database models, Then I connected them to the main project using dotnet migration. Then I created a separate admin panel structure for the site and also reconnected it with the repositories created for the database.
The whole project uses asp.net core 3.1 technology.

To get acquainted with the project you should:
1. download the repository and have Azur or Microsoft server installed on your computer, you can use any other one.

2.delete the Migrations folder from the project named Repository.

3.Initiate the database for the project with the following command
a) dotnet ef --startup-project .\Nurgo\Nurgo.cproj migrations add InitialCreate -p .\Repository\Repository.cproj
b)dotnet ef --startup-project .\Nurgo\Nurgo.cproj database update -p .\Repository\Repository.cproj
