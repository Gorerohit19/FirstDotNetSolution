using CatalogLib;
using OrderProcessingLib;
using CRMLib;
using MySqlConnectivityLib;

Product p1 = new Product();
p1.Id=1;
p1.Title="Apple";
p1.Discription="IPhone 14pro";
p1.UnitPrice=129000;
p1.StokeAvailable=100;
p1.ImageURL="http://AppleStore.com/Iphone/Iphone14pro.jpg";

Order o1 = new Order();
o1.OrderId=14;
o1.OrderDate=new DateTime(2022,12,08);
o1.CustomerName="Rohit Gore";
o1.TotalAmount=130000;
o1.Status="Approved";

Customer c1 = new Customer();
c1.Id = 19;
c1.FirstName = "Rohit";
c1.LastName = "Gore";
c1.ContactNumber = "7378982802";
c1.Email = "gore.rohit@gmail.com";


Console.WriteLine(p1.Id+" "+p1.Title+" "+p1.Discription+" "+p1.UnitPrice+" "+p1.StokeAvailable+" "+p1.ImageURL);
Console.WriteLine(o1.OrderDate+" "+o1.CustomerName+" "+o1.TotalAmount+" "+o1.Status);
Console.WriteLine(c1.Id+" "+c1.FirstName+" "+c1.LastName+" "+c1.ContactNumber+" "+c1.Email);

/*
//Creating Table 
//DAL.CreateTable();
//Insrting Info in Table
DAL.Insert("Apple","Iphone 14",129000);
DAL.Insert("Samsung","S22 Ultra",100000);
DAL.Insert("Vivo","X32",89000);
*/

/*
//Showing All Mobiles in Table
DAL.ShowAllMobiles();
*/

/*
//Updating info in id = 3
DAL.Update(3,"Moto G","Edge",20000);
*/
//Deleting row from Table
//DAL.Delete(3);

//Showing Mobile by its id
DAL.ShowMobileById(1);

//