using midtermIdeas;

class MultiClubMember : Member
{   //variable to store membership points
    public int MembershipPoints { get; set; }
    //Check in method adds to their membership points
    public override void CheckIn(Club club)
    {
        MembershipPoints += 10; // Example, you can adjust how many points to add
        Console.WriteLine($"{Name} checked in at {club.Name}. Membership points: {MembershipPoints}");
    }
}