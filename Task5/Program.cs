using System ;
namespace task5;
public class task5{
    private static void Main(){
      Console.WriteLine("Enter a String : ");
      var rev = new string ("");
      var name = new string (Console.ReadLine());
      for ( int i =name.Length - 1 ; i >=0 ; i--){
      rev = rev + name [i];
      }
      Console.WriteLine(rev);
      }

    }

/*
var name = "marym";
var name = new string ("a");
var name = new string ('c' , 5); //ccccc
var num =(int) 'c'; //99  a-z 97-122
A-Z 65-90
string name = marym;
------------------------------
  var name = "marym";
        Console.WriteLine(name);
        var num = (int) 'c';
        Console.WriteLine(num);
        var ret = new string ('c' , 4);
        Console.WriteLine(ret);
*/