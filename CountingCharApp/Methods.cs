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








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharApp
{
    public class Methods
    {
        /// <summary>
        /// ReadString method to take user input as a string
        /// </summary>
        /// <param name="promptUser">string promptUser</param>
        /// <returns>string</returns>
        public static string ReadString(string promptUser)  //Method to read the user input (string)
        {
            string value = "";
            Console.Write(promptUser);
            string? valueStr = Console.ReadLine();
            if (valueStr != null)
            {
                value = valueStr.Trim();

            }
            return value;

        }
        /// <summary>
        /// Count the letter "a" from a string using that string as parameter and returns the occurence of letter "a" 
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>int</returns>

        public static int CountTheLetterA(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    count++;
                }
            }
            return count;




        }

        /// <summary>
        /// Count the letter 'a' from string entered by the user. If the input is like a file path then the method will open the file if it exists
        /// then count the letter 'a' and return the result as an integer
        /// 
        /// </summary>
        /// <param name="input"> string </param>
        /// <returns> int </returns>
        

        public static int CountWhenFileAndFindA(string input)
        {
            // This regular expression miraculously works. No matter where your file is

            string pattern = @"(^([a-z]|[A-Z]):(?=\\(?![\0-\37<>:""/\\|?*])|\/(?![\0-\37<>:""/\\|?*])|$)|^\\(?=[\\\/][^\0-\37<>:""    
               /\\|?*]+)|^(?=(\\|\/)$)|^\.(?=(\\|\/)$)|^\.\.(?=(\\|\/)$)|^(?=(\\|\/)[^\0-\37<>:""/\\|?*]+)|^\.(?=(\\|\/)[^\0-\37<>:""
               /\\|?*]+)|^\.\.(?=(\\|\/)[^\0-\37<>:""/\\|?*]+))((\\|\/)[^\0-\37<>:""/\\|?*]+|(\\|\/)$)*()$"; // found this regular expression on stackOverflow https://stackoverflow.com/questions/6416065/c-sharp-regex-for-file-paths-e-g-c-test-test-exe



            if (input != pattern && !File.Exists(input)) // if input is not like a path and the file does not exist 
            {
               return CountTheLetterA(input); // then count the occurence of letter 'a' from the invalid path entered by the user
                
            }
            try // if the file exists
            {
                

                string? line;
                StreamReader sr = new (input);  //Open the file
                line = sr.ReadToEnd();          //Read the file from beginning to end 
                sr.Close();                     //close the file
                return CountTheLetterA(line);   // then count the number of time the letter a was found
            }

            catch(Exception ex)                 //catch any exceptions
            {
                Console.WriteLine(ex.Message);  
            }


            return -1;                          //Not sure why i put -1
        }
    }
}
