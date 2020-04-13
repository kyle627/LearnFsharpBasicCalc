//Kyle Evangelisto
// 4/8/2020
open System

//Bootup statements
Console.WriteLine("Calculator Booting. . .")

Console.WriteLine("Choose an opperation by entering in the appropriate value:")
Console.WriteLine("\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division")
//Gather requested operation from user
let input = Console.ReadLine() //gets the selected operation from the user
//get numerical values from the user
Console.WriteLine("Enter in 2 numerical values:")
let num1 = Console.ReadLine() //read in number 1
let num2 = Console.ReadLine() //read in number 2
let N1 : double = double num1  //double
let N2 : double = double num2  //double


(*Operations*)
let add x y = x + y //basic add
let sub x y = x - y //basic subtract
let mult x y = x * y //basic multiply
let div x y = x / y  //basic divide

    //I know how to add logic here to account for a /0 error but I just cant get it to work
    //Ill revisit this later

(*Opperations*)

match input with
|"1"-> printfn("The result is: %f")(add N1 N2)
|"2"-> printfn("The result is: %f")(sub N1 N2 )
|"3"-> printfn("The result is: %f")(mult N1 N2 )
|"4"-> printfn("The result is: %f")(div  N1 N2)


        
    





