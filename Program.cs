// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"GAME #{i+1}");
    PlayGame(1, 2);
}

void PlayGame(int Player1ID, int Player2ID)
{
    bool Player1Choice = GetPlayerChoice(Player1ID);
    bool Player2Choice = GetPlayerChoice(Player2ID);
    int Player1Score, Player2Score;

    // True = Stay Silence
    // False = Snitch
    if (Player1Choice && Player1Choice) // Nobody Snitches
    {
        Player1Score = 1;
        Player2Score = 1;
    }
    else if (Player1Choice) // P1 Snitches
    {
        Player1Score = 0;
        Player2Score = 5;
    }
    else if (Player2Choice) // P2 Snitches
    {
        Player1Score = 5;
        Player2Score = 0;
    }
    else // Both Snitch
    {
        Player1Score = 3;
        Player2Score = 3;
    }

    Console.WriteLine($"---{Player1ID} vs {Player2ID}---");
    Console.WriteLine($"   P1 " + (Player1Choice ? "Remained Silent" : "Snitched") + $" => {Player1Score} points");
    Console.WriteLine($"   P2 " + (Player2Choice ? "Remained Silent" : "Snitched") + $" => {Player2Score} points");
    RecordGameResult(Player1ID, Player1Score, Player2ID, Player2Score);
}

bool GetPlayerChoice(int PlayerID)
{
    return false;
}

void RecordGameResult(int Player1ID, int Player1Score, int Player2ID, int Player2Score)
{

}