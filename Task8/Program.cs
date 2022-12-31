using System;
namespace task7;
public class task7{
    private static void Main(){
        var name = new string ("marym magdy fouda");
        var dell = new string ("");
        for ( int i = 0 ; i < name.Length ; i++){
            if (name[i] != 'a'){
                dell = dell+ name[i];
            }
        }
        Console.WriteLine(dell);
    }
    }