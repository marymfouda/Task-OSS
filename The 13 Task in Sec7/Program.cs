using System;
namespace task9;
public class task9{
    private static void Main(){
        //num of item more than average
  var arr = new[5]{ 3 , 8 , 5 , 6 , 2};
  float avg;
  int sum =0 ;
  for (int i =0 ; i < arr.Length ; i ++){
    sum = sum + arr [ i ];

  }
  avg = sum / arr.Length;
  int count = 0 
  for ( int i = 0 ; i < arr.Length ; i ++){
    if (arr[i]>=avg){
      count ++;
    }
  }
  Console.WriteLine($"the num more than the avg {count}");

  // //num of item less than average
  // var arr = new[5]{ 3 , 8 , 5 , 6 , 2};
  // float avg;
  // int sum =0 ;
  // for (int i =0 ; i < arr.Length ; i ++){
  //   sum = sum + arr [ i ];

  // }
  // avg = sum / arr.Length;
  // int count = 0 
  // for ( int i = 0 ; i < arr.Length ; i ++){
  //   if (arr[i]<=avg){
  //     count ++;
  //   }
  // }
  // Console.WriteLine($"the num less than the avg {count}");
   




    //   //missing integer
    //   Console.WriteLine("enter the num of array");
    //   int num = Convert.ToInt32(Console.ReadLine());
    //   var arr = new int[num];
    //   for(int i=0 ; i <num ; i ++){
    //     arr[i]=int.parse(Console.ReadLine);
    //   }
    //   Array.sort(arr);
    //   if(arr[0]!=1){
    //     Console.WriteLine("1");
    //   }else{
    //     bool miss = false;
    //     int i=1;
    //     for(i =0 ; i < num ; i ++){
    //       if ((arr[i]==arr[i+1]-1)){
    //         miss = true ;
    //         break;
    //       }
    //     }
    //   }
    //  while (true)
    //  {
    //   Console.WriteLine(arr[i]+1);
    //  }




    // //mean of the max-min value
    // int leng = Convert.ToInt32(Console.ReadLine());
    // var arr = new int [leng];
    // for (int i =0 ; i < leng ; i ++)
    // int max=arr[0];
    // int min = arr[0];
    // for (int i=0 ; i<leng ; i ++){
    //   if(arr[i]>max)max=arr[i];
    //   if(arr[i]<min)min=arr[i];
    // }
    // float average=(min + max )/2;
    // Console.WriteLine($"the average of {min} & {max} = {average}");




      //earlist nearest value from mean 
      // var num = Convert.ToInt32(Console.ReadLine());
      // var arr = new int [num];
      // for (int i = 0 ; i < num ; i++ ){
      //   arr[i]= int.Parse(Console.ReadLine());
      // }
      // int sum =0 ; 
      // for (int i = 0 ; i < arr.Length ; i++){
      //   sum = sum + arr [i];
      // }
      // Console.WriteLine(sum);


    // // is dublicate remove
    // string name = Console.ReadLine();
    // string remdab = "" ;
    // for (int i = 0 ; i < name.Length ; i ++){
    //     if (!remdab.Contains(name[i])){
    //         remdab=remdab+name[i];
    //     }
    // }
    // Console.WriteLine(remdab);

      





        // //is palindrome
        // //abba //i name.Length-1-i
              
        //       string name = Console.ReadLine();
        //       bool pail = true ;
        //       for ( int i = 0 ; i > name.Length/2 ; i ++){
        //          if (name[i] != name[name.Length-1-i]){
        //             pail = false;
        //             break;
        //          }
        //       }
        //       if(pail){
        //          Console.WriteLine("is pail");
        //       }else{
        //          Console.WriteLine("is not pail");
        //       }




        // // last index of a 
        // string name = Console.ReadLine();
        // int index = 0 ;
        // for ( int i = 0 ; i < name.Length ; i ++ ){
        //      if (name[i] =='a'){
        //         index = i;
                
        //     }
        // }
        //  Console.WriteLine(index);
        
         






        // //count of a in string 
        // string name = Console.ReadLine();
        // var count = 0;
        // for ( int i = 0 ; i < name.Length ; i ++){
        //     if (name[i] =='a'){
        //         count ++;
        //     }
        // }
        // Console.WriteLine(count);




        // //reverse string  marym
        // string name = Console.ReadLine();
        // string rev = "";
        // for ( int i = name.Length-1 ; i >=0 ; i--){
        //     rev = rev + name[i];
        // }
        // Console.WriteLine(rev);




        //  //count of non-linear or non-liter
        // var name = Console.ReadLine();
        // int count = 0 ;
        // for ( int i =0 ; i < name.Length ; i ++){
        //     int w = name[i];
        //     if (((w >= 97 && w <= 122)||(w >= 65 && w <= 90))){
        //         count ++;
        //     }
        // }
        // Console.WriteLine(count);
        

    //   //remove all 'a' from string 
    // string name = Console.ReadLine();
    // string name_rema = "" ;
    // for ( int i = 0 ; i < name.Length ; i++){
    //     if (name[i] != 'a'){
    //         name_rema=name_rema+name[i];

    //     }
    // }
    // Console.WriteLine(name_rema);



        //add 0 after each a 
    //   string name_a="";
    //   var name = new string (Console.ReadLine());
    //   for ( int i =0 ; i < name.Length ; i++){
    //     if(name[i]=='a'){
    //         name_a=name_a+name[i]+'0';
    //     }else{
    //         name_a=name_a+name[i]; 
    //     }
    //   }
      
    //     Console.WriteLine($" string after add 0 after char 'a' {name_a}");


    //
    }}