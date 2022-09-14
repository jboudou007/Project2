///////////////////////////////////////////////////////////////////////////////
//
//  Author: Jean Bilong, bilong@etsu.edu
//         
//  Course: CSCI-2210-001 - Data Structures
//  Assignment: Project 2
//  Description: counting the letter 'a' from user input
//    
//  
///////////////////////////////////////////////////////////////////////////////









namespace CountingCharApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string UserInput = Methods.ReadString("Please enter a text: ");

            // char[] UserChars = UserInput.ToCharArray();   //This line is not even nessecary

            Console.WriteLine($"Occurence of letter 'a' equals {Methods.CountWhenFileAndFindA(UserInput)}");









        }
    }
}