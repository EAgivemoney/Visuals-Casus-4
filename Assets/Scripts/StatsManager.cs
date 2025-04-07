using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager
{
    public int Goals { get; private set; } = 0;
    public int Assists { get; private set; } = 0;
    public int Fouls { get; private set; } = 0;

    public void UpdateStats(int goals, int assists, int fouls)
    {
        Goals = goals;
        Assists = assists;
        Fouls = fouls;
    }

    public int CalculateScore()
    {
        return (Goals * 5) + (Assists * 3) - (Fouls * 2);
    }
}
