// capture the info about each guest (assume at least one and unknown maximum)
// info to capture: first name, last name, message to the host
// once done, loop through each guest and print their info

using GuestBookLibrary.Models;
namespace ConsoleUI;

internal class Program
{
    private static List<GuestModel> guests = new();
    static void Main(string[] args)
    {
        GetGuestInfo();
        PrintGuestInfo();
    }

    private static void PrintGuestInfo()
    {
        guests.ForEach(x => x.GuestInfo());
    }

    private static void GetGuestInfo()
    {
        bool moreGuests;
        do
        {
            GuestModel guest = new();

            guest.FirstName = GetInput("What is your first name? ");
            guest.LastName = GetInput("What is your last name? ");
            guest.MessageToHost = GetInput("What is your message to the host? ");
            moreGuests = GetInput("Are there more guests (y/n)? ") == "y" ? true : false;

            guests.Add(guest);
            Console.Clear();

        } while (moreGuests);
    }

    private static string GetInput(string input)
    {
        Console.Write(input);
        return Console.ReadLine();
    }
}
