using MySql.Data.MySqlClient;
namespace MySqlConnectivityLib;
public static class DAL
{
  public static string conStr = "server=localhost;uid=root;password=Rohit@7378;database=demo1";
  
  public static bool CreateTable(){
    bool status = false;
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = conStr;

    try{
        string query = "create table mobiles(mobileId int not null primary key auto_increment,"+
                        "mobileCompany varchar(20),"+
                        "modelName varchar(20),"+
                        "price decimal(10,2)"+
                        ")";
        Console.WriteLine(query);
        con.Open();
        MySqlCommand cmd = new MySqlCommand(query, con);
        cmd.ExecuteNonQuery();
        status = true;
    }
    catch(Exception e){
        Console.WriteLine("Exception = "+e.Message);
    }
    finally{
        con.Close();
    }
    return status;
  }

  public static bool Insert(string mobileCompany, string modelName, double price){
    bool status = false;
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = conStr;
    try{
        string query = "insert into mobiles (mobileCompany, modelName, price) values ('"+mobileCompany+"','"+modelName+"','"+price+"')";
        Console.WriteLine(query);
        con.Open();
        MySqlCommand cmd = new MySqlCommand(query, con);
        cmd.ExecuteNonQuery();
        status = true;
    }
    catch(Exception e){
        Console.WriteLine("Exception = "+e.Message);
    }
    finally{
        con.Close();
    }
    return status;
  }

  public static bool Update(int id, string mobileCompany,string modelName, double price){
    bool status = false;
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = conStr;
    try{
        string query = "update mobiles set mobileCompany='"+mobileCompany+"',"+
                            "modelName='"+modelName+"',"+
                            "price="+price+
                            " where mobileId="+id;
        Console.WriteLine(query);
        MySqlCommand cmd = new MySqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        status = true;
    }
    catch(Exception e){
        Console.WriteLine("Exception = "+e.Message);
    }
    finally{
        con.Close();
    }
    return status;
  }
   public static bool Delete(int id){
    bool status = false;
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = conStr;
    try{
        string query = "Delete from mobiles where mobileId="+id;
        Console.WriteLine(query);
        MySqlCommand cmd = new MySqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        status=true;
    }
    catch(Exception e){
        Console.WriteLine("Exception = "+e.Message);
    }
    finally{
        con.Close();
    }
    return status;
   }

   public static void ShowAllMobiles(){
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = conStr;
    try{
        string query ="select * from mobiles";
        Console.WriteLine(query);
        MySqlCommand cmd = new MySqlCommand(query, con);
        con.Open();
        MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read()){
                Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]);
            }
            rdr.Close();
        
    }
    catch(Exception e){
        Console.WriteLine("Exception ="+e.Message);
    }
    finally{
        con.Close();
    }
   }

   public static void ShowMobileById(int id){
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conStr;
        try{
             con.Open();
            string query = "select * from mobiles where mobileId="+id;
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read()){
               Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]); 
               status = true;
            }
            rdr.Close();
        }
        catch(Exception e){
            Console.WriteLine("Exception = "+e.Message);
        }
        finally{
            con.Close();
        }
   }
}
