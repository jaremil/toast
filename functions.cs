using System;
using System.Threading

public class loadingAnimation {
    public void Cooking() {
        int counter = 0;
        while (true)
        {
            Console.Write("\b| Cooking");
            Thread.Sleep(200);
            Console.Write("\b/ Cooking");
            Thread.Sleep(200);
            Console.Write("\b- Cooking");
            Thread.Sleep(200);
            Console.Write("\b\\Cooking");
            Thread.Sleep(200);

            counter++;
            if (counter % 4 == 0)
            {
                Console.Write("\b| Cooking");
                counter = 0;
            }
        }
    }
}

public class makeToast : loadingAnimation {
        // STEP 2
        Console.WriteLine("In the kitchen, you find two types of bread. Which one do you choose?\n1. White bread\n2. Whole grain bread");
        string _choiceTwo = Console.ReadLine();

        if (_choiceTwo = 1){

            // STEP 5
            Console.WriteLine("You place a slice of white bread in the toaster, and wait.");
            // animation Cooking... 
            Cooking();

            // STEP 7
            Console.WriteLine("It turns out great! Now it's time to choose a spread:\n1. Add butter\n2. Add orange marmalade");
            string _choiceFour = Console.ReadLine();

            if (_choiceFour = 1){

                // STEP 9 
                Console.WriteLine("Your toast tastes boring because it is boring.");

                // END
                break;
            }
            else if((_choiceFour = 2)){

                // STEP 10
                Console.WriteLine("Orange you glad you choose marmalade?");

                //END
                break;
        
            }
            else{

                //STEP 7
                
            }
        }
        else if (_choiceTwo= 2){

            // STEP 6
            Console.WriteLine("You place a slice of whole grain bread in the toaster, and wait.");
            // animation Cooking...
            Cooking();  

            // STEP 8
            Console.WriteLine("It's a little over toasted. Now it's time to choose a spread:\n1. Add butter peanut\n2. Add raspberry jam");
            string _choiceFive = Console.ReadLine();

            if (_choiceFive = 1){

                // STEP 11
                Console.WriteLine("You should feel lucky! All the people who are gluten intolerant or allergic to peanuts are jealous of you.");

                // END
                break;

            }
            else if (_choiceFive = 2){

                // STEP 12
                Console.WriteLine("Congratulations! This is the perfect piece of toast.");

                // END
                break;

            }
        }
        else{

            // STEP 8


        }
    }

public class makeOmelet : loadingAnimation {
    // STEP 3
    Console.WriteLine("You prepare your ingredients and put them in a pan.");
    // animation Cooking... 
    Cooking();

    // STEP 4
    Console.WriteLine("Your omelet burns.\n1. Make toast\n2. Make another omelet");
    string _choiceThree = Console.ReadLine();

    if (_choiceThree = 1){
        makeToast
    }
    else if (_choiceThree = 2){

        // STEP 3
        Console.WriteLine("You prepare your ingredients and put them in a pan.");
        // animation Cooking... 
        Cooking();

        // STEP 4

    }
    else{
        // STEP 4
    }
}