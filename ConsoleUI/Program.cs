// capture the info about each guest (assume at least one and unknown maximum)
// info to capture: first name, last name, message to the host
// once done, loop through each guest and print their info

using GuestBookLibrary.Models;
namespace ConsoleUI;

internal class Program
{
    static void Main(string[] args)
    {
        List<GuestModel> guests = new();
        GetGuestInfo(guests);

        guests.ForEach(x => x.GuestInfo());
    }

    private static void GetGuestInfo(List<GuestModel> guests)
    {
        bool moreGuests;
        do
        {
            GuestModel guest = new();

            Console.Write("What is your first name? ");
            guest.FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            guest.LastName = Console.ReadLine();

            Console.Write("What is your message to the host? ");
            guest.MessageToHost = Console.ReadLine();

            Console.Write("Are there more guests (y/n)? ");
            moreGuests = Console.ReadLine() == "y" ? true : false;

            guests.Add(guest);
            Console.Clear();

        } while (moreGuests);
    }
}
