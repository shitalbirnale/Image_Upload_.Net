# Image_Upload_.Net

In Image Upload Project you have to make configuration of sql server connection which is used in project
we had to do this because i not implemented project using Entity Framework so we had to do this manually.

the steps to configure connection of database
1)open project solution->open App_Data->open images.mdf->it will open images.mdf in sql server right click on it ->goes to 
properties->copy connection String
2)open DAL->DBManager ->replace connection string to old .
Example:
old one:-
     public static String constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shital\source\repos\YouFrame\YouFrame\App_Data\Images.mdf;Integrated Security=True";
  
  New one:paste the copied string into double quote.
         public static String constring = @"Paste_here";
   save it.
   and Run the Application.
   
     
