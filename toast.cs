using System;
using System.Threading

class Program {
    static void Main(string[] args){
        Console.WriteLine("Wecome to the Choose your Toast Adventure");

        // STEP 1
        Console.WriteLine("You wake up to the smell of freshly baked bread. Your day is off to a great start! Do you:\n1. Make toast\n2. Make an omelet instead");
        string _choiceOne = Console.ReadLine();

        if (_choiceOne = 1){
            makeToast();
        }
        else if (_choiceOne = 2){
            makeOmelet();
        }
        else{
            // STEP 1
        }
    }
}


// how to set up running
// how to go back a step 
// how to end program