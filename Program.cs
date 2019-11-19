using System;

namespace _3_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now we're talking about loops.  There are several types:
            //DO
            //WHILE
            //FOR
            //several others dealing with collections - we'll touch on those later
            
            //By and large you'll see for and while loops the most.  Know that do's exist, but I honestly don't think
            //I've used them professionally and so rarely see them in existing code bases... bah, honestly, just know
            //they exist.

            //all loops do what they sound like, they will loop the same code a determined amount of times
        
            Console.WriteLine("Starting WhileLoops-----------------------------------------");
            WhileLoops();
            Console.WriteLine("Ending WhileLoops-----------------------------------------");
            Console.WriteLine("Starting WhileLoopEvenOdd-----------------------------------------");
            WhileLoopEvenOdd();
            Console.WriteLine("Ending WhileLoopEvenOdd-----------------------------------------");
            Console.WriteLine("Starting WhileLoopReverseString-----------------------------------------");
            WhileLoopReverseString();
            Console.WriteLine("Ending WhileLoopReverseString-----------------------------------------");
            Console.WriteLine("Starting ForLoops-----------------------------------------");
            ForLoops();
            Console.WriteLine("Ending ForLoops-----------------------------------------");
            Console.WriteLine("Starting ForLoopReverseString-----------------------------------------");
            ForLoopReverseString();
            Console.WriteLine("Ending ForLoopReverseString-----------------------------------------");
            Console.WriteLine("Starting NestedLoops-----------------------------------------");
            NestedLoops();
            Console.WriteLine("Ending NestedLoops-----------------------------------------");
        }

        static void WhileLoops(){
            /* While loops are built this way:
               while (<boolean-expression>){
                   <code-that-you-want-executed-if-earlier-expression-is-true>
               }
            */

            //this simple example, we are creating a loop value, name is not important
            int loopValue = 0;
            //immediately the while loop evaluates if our loop value is less than 5
            while(loopValue < 5)
            {
                //if loopValue IS less than 5, we will execute the next two statements
                Console.WriteLine("Current loopValue: " + loopValue);
                //finally, AND THIS IS IMPORTANT, we increment loopValue by 1.  If we don't have a way of changing
                //the evaluation, we will be stuck in an "infinite loop"  and you need to be careful that your loops
                //will end or terminate in some way.
                loopValue = loopValue + 1;
            }

            Console.WriteLine("loopValue has met it's condition and exited the while loop.");
        }

        static void WhileLoopEvenOdd()
        {
            //Create a while loop that will loop 10 times and only output odd numbers.
        }

        static void WhileLoopReverseString()
        {
            //For the sake of practice, given this string city, write a while loop to reverse his order.
            //A little help, strings are just character arrays. For instance, city[3] will give you the 4th 
            //character in the string which in this case would be "d", it will also return a character instead of
            //a string, so city[3].ToString() will turn that character type to a string type.

            string city = "London";
            
        }

        static void ForLoops()
        {
            /*
            For loops are very similar to while loops but are a bit more of a short hand approach.
            With while loops, you generally setup your loop variable external to the loop and within
            the body of the loop you modify the variable.
            With a for loop, everything is contained and stuctured like so:

            for(<instantiate-loop-variable>; <loop-condition>; <loop-variable-modifier>){
                <body-of-loop>
            }
            */

            //this for loop does EXACTLY what the while loop in the first example does.
            //Notice that the loop setup is all contained in the syntax of the for loop.
            //Yes, you CAN modify loopValue within the body of the for loop, but after
            //each iteration, the for loop will still modify the loopvalue based on 
            //what you told it
            for(int loopValue = 0; loopValue < 5; loopValue++){
                Console.WriteLine("For loopValue is " + loopValue);
            }

            Console.WriteLine("For loopValue is complete");
        }

        static void ForLoopReverseString()
        {
            //again, just practicing, reverse this string but use a for loop this time
            string state = "Alabama";

        }

        static void NestedLoops(){
            /*
                See what you can do with this.  This is one of those eye rolling academic / interview type questions.
                It serves no purpose other than tesing your ability to write loops and think logically.

                Output a pyramid of numbers like so:
                        1
                       2 2
                      3 3 3
                     4 4 4 4 
            
                Output up to the number 4, but have your logic written in such a way that if you were to give it any number, it would handle it
            */
        }

        static void DoLoops(){

        }

        static void ContinueAndBreak()
        {

        }
    }
}
