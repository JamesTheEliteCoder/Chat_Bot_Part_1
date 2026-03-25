using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Chat_Bot_Poe_Part_1
{
    internal class methods
    {

        //method to play greeting 
        public void PlayGreeting()
        {
            Console.Beep(1000, 500);
            Console.WriteLine("This beep represents the bot greeting you.");
            PrintDivider();
            Console.WriteLine();
            
        }

        public void DisplayLogo()
        {

            Console.WriteLine("                                     ███████╗████████╗ █████╗ ███╗   ██╗██████╗  █████╗ ");
            Console.WriteLine("                                     ██╔════╝╚══██╔══╝██╔══██╗████╗  ██║██╔══██╗██╔══██╗");
            Console.WriteLine("                                     █████╗     ██║   ███████║██╔██╗ ██║██║  ██║███████║");
            Console.WriteLine("                                     ██╔══╝     ██║   ██╔══██║██║╚██╗██║██║  ██║██╔══██║");
            Console.WriteLine("                                     ███████╗   ██║   ██║  ██║██║ ╚████║██████╔╝██║  ██║");
            Console.WriteLine("                                     ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚═╝  ╚═╝");

            Console.WriteLine();

            Console.WriteLine("                                     ███████╗███████╗ ██████╗██╗   ██╗██████╗ ███████╗");
            Console.WriteLine("                                     ██╔════╝██╔════╝██╔════╝██║   ██║██╔══██╗██╔════╝");
            Console.WriteLine("                                     ███████╗█████╗  ██║     ██║   ██║██████╔╝█████╗  ");
            Console.WriteLine("                                     ╚════██║██╔══╝  ██║     ██║   ██║██╔══██╗██╔══╝  ");
            Console.WriteLine("                                     ███████║███████╗╚██████╗╚██████╔╝██║  ██║███████╗");
            Console.WriteLine("                                     ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝");

            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                                         WELCOME                       ");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();


        } //method end >>DisplayLogo

        public static string BotName;


        public void AskName()
        {
            PrintDivider();
            TypeText("What is your name? ");
            PrintDivider();
            string Name = Console.ReadLine();
            PrintDivider();

            TypeText("Welcome to the Etanda Secure Cybersecurity Awareness Chat Bot " + Name+ "!");
            TypeText("What would you like to call me? ");
            PrintDivider();
            //Console.WriteLine();

            string BotName = Console.ReadLine();
            //Console.WriteLine();

            PrintDivider();
            TypeText("Great Name choice! I like the sound of " + BotName+ " already :)");
            TypeText("(Type 'exit' to exit the program anytime).");
           // Console.WriteLine();

        }


        

        // method to animate typing and change the colour of bot text
        public void TypeText(string message, int lineWidth = 80, ConsoleColor color = ConsoleColor.Cyan)
        {
            //Steps to change font color and text animations
            // first set the text color for the bot text
            Console.ForegroundColor = color;

            
            int currentLineLength = 0;

            //  then loop through each character in the message
            foreach (char c in message)
            {
                // followed by printing the character
                Console.Write(c);
                currentLineLength++;

                // if the current line is longer than allowed width, move to a new line
                if (currentLineLength >= lineWidth && c == '.')
                {
                    Console.WriteLine();
                    currentLineLength = 0;
                }

                // animation for the pauses in between punctuation
                if (c == '.' || c == '!' || c == '?')
                    Thread.Sleep(200); // pause longer after sentence-ending punctuation
                else if (c == ',')
                    Thread.Sleep(120); // pause jut enough for comma
                else
                    Thread.Sleep(10);  // then normal speed for other characters
            } // end of foreach


            Console.WriteLine();
            Console.ResetColor();
        } // end of TypeText



        public void InvokeChat()
        {

            bool askedHowAreYou = false;

            while (true)
            {

                if (!askedHowAreYou)
                {
                    PrintDivider();
                    TypeText("How are you?");
                    PrintDivider();
                    askedHowAreYou = true;
                }
                   
                string Input = Console.ReadLine().ToLower().Trim();

                if (Input == "exit")
                {
                   // Console.WriteLine();
                    PrintDivider();
                    TypeText("Remember to stay safe online! Goodbye.");
                    PrintDivider();
                    break;
                } 
                else if(Input.Contains("how are you"))
                {   
                    //Console.WriteLine();
                    PrintDivider();
                    TypeText("Glad to hear it!");
                    TypeText("I'm running quite securely and ready to help!");
                   // Console.WriteLine();
                    TypeText("Try asking me questions like:");
                    TypeText("1)  What is your purpose?");
                    TypeText("2)  How can I stay safe while browsing the internet?");
                    TypeText("3)  How can I detect phishing threats?");
                    TypeText("4)  Can you give me tips on creating a strong password?");
                    PrintDivider(); 
                   // Console.WriteLine();
                    
                   
                    

                }
                else if(Input.Contains("good") || Input.Contains("fine") || Input.Contains("great") || Input.Contains("wonderful") || Input.Contains("well") || Input.Contains("alright"))
                {   
                   // Console.WriteLine();
                    PrintDivider();
                    TypeText("Glad to hear it!");
                    TypeText("Try asking me questions like:");
                    TypeText("1)  What is your purpose?");
                    TypeText("2)  How can I stay safe while browsing the internet?");
                    TypeText("3)  How can I detect phishing threats?");
                    TypeText("4)  Give me tips on creating a strong password?");
                    PrintDivider();
                   // Console.WriteLine();
                }
                else if (Input.Contains("purpose"))
                {
                   // Console.WriteLine();
                    PrintDivider();
                    TypeText("I can provide you with insightful tips and tricks to help you stay safe online. Try asking me another one of the questions mentioned above.");
                    PrintDivider();
                   // Console.WriteLine();

                }
                else if (Input.Contains("password"))
                {
                   // Console.WriteLine();
                    PrintDivider();
                    TypeText("Of course I can!");
                    TypeText("The best way to protect your data online is to always create passwords that are long, unique, and hard to guess. A strong password should be at least 12 characters, mixing uppercase and lowercase letters, numbers, and symbols. Avoid using personal information like your name or birthdate, and never reuse the same password across different accounts ");
                    TypeText("If you're afraid that you might forget your paswords, there are some tactics that you could use to never loose access to your passwords such as Google's password manager or simply oting your passwords in your notepad.");
                    TypeText("If you choose the latter, always make sure that no-one can easily access the application used to store your data.");
                    TypeText("Remember: Prevention is always better than cure (:");
                    PrintDivider();
                    TypeText("Try asking another!");
                    PrintDivider();
                    // Console.WriteLine();


                }
                else if (Input.Contains("phishing"))
                {
                  //  Console.WriteLine();
                    PrintDivider();
                    TypeText("Be cautious of emails or messages that ask you to click links, download attachments, or provide personal information. ");
                    TypeText("Phishing attempts often look like they come from trusted companies, but small details — like misspelled addresses, urgent language, or suspicious links can give them away. ");
                    TypeText("Always verify the sender before responding.");
                    PrintDivider();
                    TypeText("Try asking another!");
                    PrintDivider(); 
                    // Console.WriteLine();


                }
                else if (Input.Contains("browsing") || Input.Contains("browse"))
                {
                   // Console.WriteLine();
                    PrintDivider();
                    TypeText("When browsing online, always stick to trusted websites and look for ‘https://’ in the address bar.");
                    TypeText("The ‘s’ means the connection is secure. Avoid clicking on pop‑ups or suspicious ads, and never enter personal information on sites that don’t look legitimate. ");
                    TypeText("Using updated browsers and security software adds another layer of protection, so be sure to keep your browser updated and install antivirus, malware, and browsing protection extentions.");
                    PrintDivider();
                    TypeText("Try asking another!");
                    PrintDivider();
                    //Console.WriteLine();



                }
                else if(Input.Contains("about") || Input.Contains("ask"))
                {
                   // Console.WriteLine();
                    PrintDivider();
                    TypeText("Try asking me questions like:");
                    TypeText("1)  What is your purpose");
                    TypeText("2)  How can I stay safe while browsing the internet");
                    TypeText("3)  How can I detect phishing threats");
                    TypeText("4)  Give me tips on creating a strong password");
                    PrintDivider();
                    TypeText("Try asking another!");
                    PrintDivider();
                    // Console.WriteLine();

                }
                else
                {
                   // Console.WriteLine();
                    PrintDivider();
                    TypeText("I didn't quite understand that, please rephrase or try asking about cybersecurity related topics. ");
                    PrintDivider();
                   // Console.WriteLine();
                }





            } //end of loop
            } // end of InvokeChat

        public void PrintDivider()
        {
            
            int width = Console.WindowWidth;

            // to prevent automatic line wrap
            width = width > 0 ? width - 1 : 80;

            
            Console.WriteLine(new string('-', width));
        }














    }
}
