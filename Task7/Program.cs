//last index of a 
using System;
namespace task7;
public class task7{
    private static void Main(){
        var name = new string (" maryam fouda ");
        for ( int i = name.Length-1 ; i >=0 ; i--){
            if (name[i] == 'a'){
                Console.WriteLine(i);
                break;
            }
        }
    }
}
