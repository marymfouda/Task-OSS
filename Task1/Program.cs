//for section-1 of c#
using System;
namespace marym;
public class marym{
    private static void Main(){
        Console.WriteLine("please enter your name ? ");
        var name = Console.ReadLine();
        Console.WriteLine(name);
        Console.WriteLine("please enter your age ? ");
        var age=Convert.ToInt32(Console.ReadLine());
        if(age >= 20){
              Console.WriteLine(age+1);
        }else{
            Console.WriteLine(age);
        }
    }
}
//variable 
// var  anyVariable var name=1; type{int}
// int int32 num ---- double --- shortnum_1
//casting 
/*
int num = 1;
short num_1 = (short)num;
int + int = int 
*/

