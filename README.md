# Dr. Sillystringz's Factory

#### By Michael Burton

#### This application allows user to input Machine objects and Engineer objects in the browser. The  user can then  navigate pages for Machines and Engineers to view details about both. along with having full CRUD funtionallity to update the database. This project explores databases with Many-to-Many relationships

## Technologies Used

* VS Code
* C#
* .NET 5 SDK framwork
* Razor
* MySql
* migrations


### Prerequisites

* .NET 5 SDK
* A text editor like VS Code
* A command line interface like Terminal or GitBash to run and interact with the console app.
[MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)

### Installation

1. Clone this repository: $ git clone https://github.com/Michael-Burton1/DrSillyStringz.git
2. Navigate to the DrSillyStringz directory on your computer
3. Open with your preferred text editor to view the code 
4. Set up Sql Database using MySQL:
    * Make an appsettings.json file in the Factory directory of the project.
    * Add this to your Appsettings.json file


 > {<br>
    > "ConnectionStrings": { <br>
  >  "DefaultConnection": "Server=localhost;Port=3306; database=michael_burton;uid=root;pwd=[YOUR PASSWORD];"<br>
 >   }<br>
  >}

* replace [YOUR PASSWORD] with your MySQL password
Open terminal and run this command with your MySQL password replacing [YOUR PASSWORD] : mysql -uroot -p[YOUR PASSWORD]

5. To run the app:
  * Navigate to the {Factory} directory in your command line
  * Run the command:dotnet restore to restore the dependencies that are listed in {HairSalon.csproj}
  * Run the command: dotnet build   to build the project and its dependencies   
  * To build the data base structure in work bench you will nee to run two commands in your terminal 
  1 dotnet tool install --global dotnet ef (this will instal EF COre tools needed to run ef commands)
  2 dotnet ef migrations add Initial (this will create your migrations dir and you Initial migrations files)
  3 dotnet ef database update (This will build your database from the design in the DesignTimeDbContextFactory file)
  * Finally, run the command: dotnet run   to run the project!(you should be able to see the projcet if you navigate to localhost:5000/ in your browser)
  


## Known Bugs

* No known bugs

## License

_Licensed under the [MIT License](LICENSE)._

## Contact Information

_Michael Burton (micbur1@gmail.com)_