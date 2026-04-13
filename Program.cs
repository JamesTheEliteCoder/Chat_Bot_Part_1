namespace Chat_Bot_Poe_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //this program was created for PROG
            methods Methods = new methods();


            Methods.PlayGreeting();
            //displaying of the logo
            Console.WriteLine(File.ReadAllText("logo.txt"));
            Methods.AskName();
            Methods.InvokeChat();
        }
    }
}
