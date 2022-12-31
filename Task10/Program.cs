using System;
namespace oop;
public class number{
    public int x1;
    public int  f;
    //public string name;
    //constractor with overloading
    public number(int v1 , int v2 ){
        this.x1=v1;
        this.f=v2;
        //name=c;
    }
    public int sub(){
        return (this.x1 - this.f);
    }
     public void show(){
        //method
        Console.WriteLine("int NUMBER "+ this.x1 +" float num "+this.f);
     }
}
public class oop{
    private static void Main(){
        //constractor put intial value to variable
        number obj1 = new number(12 , 8 );
        obj1.sub();
        
        Console.WriteLine(obj1.sub());

    }
}

/*
        n1.show();
        n1.x1=12;
        n1.x2=14;
        n1.show();
        
        n2.name="marym";
        Console.WriteLine(n1.show);
        Console.WriteLine(n1.x2);
        Console.WriteLine(n2.name);

        //constractor
    public number(){
        x1=7;
        x2=6;
        name="marym";

*/

        //Console.WriteLine("Welcom oop?");
        //n1--> object in class
        //number --> class--- defined className object = new classname();
        //finish class and object
        //constractor ===> put initial value to variable
        //we can put more than one constractor
        //we can use class without instractor
        //this & method
        //this is defined any object