using System.Net;

namespace clubMemberIndexer;

class Program
{
    class ClubMembers
    {
        public const int Size = 15;  // global variable

        private string[] Members = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // constructor
        public ClubMembers()
        {
            for (int i = 0; i < Size; i++)
            {
                Members[i] = string.Empty;
            }
            ClubType = string.Empty;
            ClubLocation = string.Empty;
            MeetingDate = string.Empty;
        }

        //indexer get and set methods
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= Size - 1)
                {
                    tmp = Members[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= Size - 1)
                {
                    Members[index] = value;
                }
            }

        }
    }
    static void Main()
    {
        // Create a new ClubMembers object
        ClubMembers myClub = new ClubMembers();

        // Add values to the Members indexer
        myClub[0] = "Olivia Maxwell";
        myClub[1] = "Ethan Sullivan";
        myClub[2] = "Ava Rodriguez";
        myClub[3] = "Mason Harper";
        myClub[4] = "Sophia Mitchell";
        myClub[5] = "Jackson Turner";
        myClub[6] = "Isabella Sanchez";
        myClub[7] = "Liam Bennett";
        myClub[8] = "Aria Parker";
        myClub[9] = "Noah Anderson";
        myClub[10] = "Grace Thompson";
        myClub[11] = "Lucas Carter";
        myClub[12] = "Mia Foster";
        myClub[13] = "Oliver Ramirez";
        myClub[14] = "Lily Morgan";

        // Set values for other properties
        myClub.ClubType = "Sports Club";
        myClub.ClubLocation = "Community Center";
        myClub.MeetingDate = "Every Monday";

        // Display club information
        Console.WriteLine("Club Information:");
        Console.WriteLine($"Club Type: {myClub.ClubType}");
        Console.WriteLine($"Club Location: {myClub.ClubLocation}");
        Console.WriteLine($"Meeting Date: {myClub.MeetingDate}");

        Console.WriteLine("\nMembers:");
        for (int i = 0; i < ClubMembers.Size; i++)
        {
            Console.WriteLine($"Member {i + 1}: {myClub[i]}");
        }
    }
}