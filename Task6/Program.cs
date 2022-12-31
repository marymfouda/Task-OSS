using System ;
namespace Task6;
public class task6{
    private static void Main(){
        //count a in string number
        Console.WriteLine("Please enter a string : "); 
        var name = new string (Console.ReadLine());
        int count = 0;
        for(int i =0 ; i < name.Length ; i++){
            if (name[i]=='a'){
                count++;
            }
        }
    Console.WriteLine("Count A : "+ count);
    }

}
