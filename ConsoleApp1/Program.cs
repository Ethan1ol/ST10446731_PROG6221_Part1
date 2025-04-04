using System;
using System.Media;
using System.IO;
using System.Threading;

class Chatbot
{
    public string Name { get; set; }

    public Chatbot(string name)
    {
        Name = name;
    }

    public void PlayVoiceGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("E:\\Projects\\ConsoleApp1\\BlitzAudio.wav");
            player.Play(); // Play asynchronously
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error playing voice greeting: " + ex.Message);
            Console.ResetColor();
        }
    }

    public void Blitz()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        PlayVoiceGreeting(); // Play audio while ASCII art is displayed

        string botLogo = @"
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
      BLITZ
         __
 _(\    |@@|
(__/\__ \--/ __
   \___|----|  |   __
       \ }{ /\ )_ / _\
       /\__/\ \__O (__
      (--/\--)    \__/
      _)(  )(_)
     `---''---`    
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        ";

        Console.WriteLine(botLogo);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n Welcome to Your Cybersecurity Awareness Bot!\n");
        Console.WriteLine("Conquering the world...\n");
        Console.ResetColor();
    }

    public void GreetUser()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nHi! I'm Blitz, your CyberSecurity Safety Assistant, here to inform you about the dangers of the Cyber world.\n");
        Console.ResetColor();

        Console.Write("\nWhat's your name?\n");
        Console.ForegroundColor = ConsoleColor.Magenta;
        string userName = Console.ReadLine();
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nIt's nice to meet you "+ userName+" Ready to learn about CyberSecurity safety? Because I know I am!\n");
        Console.ResetColor();

        BlitzOptions();
        BlitzAnswers();
    }

    public void BlitzOptions()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nYou can ask anything about cybersecurity. Some examples are:\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n1. What's my purpose?\n");
        Console.WriteLine("\n2. Password safety\n");
        Console.WriteLine("\n3. Phishing?\n");
        Console.WriteLine("\n4. Safe browsing\n");
        Console.WriteLine("\n5. Quit\n");
        Console.ResetColor();
    }

    public void BlitzAnswers()
    {
        string choice;
        do
        {
            Console.Write("\nEnter the number of the topic you want to learn about (or 5 to quit): \n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            choice = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            if (choice == "1")
            {
                Console.WriteLine("\nIm here is assist you about the dangers of the cyber world.\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nTry to use Unique passwords using a mix of upper an dlower case letters, include numbers and some special characters to keep the hackers on their toes.\n If possible enable 2FA systems such as authentication apps or sms codes to ensure only you can access ur accounts.\n");
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nStay away from sus links that you recieve on your emails and sms. \n Ensure that the emails are correct and no funny letters that seems sus.\n  Keep your look out for poor grammar or urgent requests.\n");
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nEnsure that your browser is updated with the latest security patches.\n Stay away from payments on websites without HTTPS in their URL with a lock next to it.\n Install ad bock extenstions.\n");
            }
            else if (choice == "5")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSee you again buddy stay safe on Web:)\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 5.\n");
            }
            Console.ResetColor();
        } while (choice != "5");
    }
}

class Program
{
    static void Main()
    {
        Console.Title = "Blitz - CyberSecurity Bot";
        Console.Clear();

        Chatbot bot = new Chatbot("Blitz");
        bot.Blitz();     
        bot.GreetUser(); 

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPress any key to exit...");
        Console.ResetColor();
        Console.ReadKey();
    }
}

















