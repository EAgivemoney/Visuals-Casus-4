using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomScores : MonoBehaviour
{
    public TextMeshProUGUI score1, score2;

    public TextMeshProUGUI goals1Text, goals2Text;
    public TextMeshProUGUI assists1Text, assists2Text;
    public TextMeshProUGUI fouls1Text, fouls2Text;

    private StatsManager team1Stats, team2Stats;

    void Start()
    {
        team1Stats = new StatsManager();
        team2Stats = new StatsManager();

        AssignRandomValues();
    }

    void AssignRandomValues()
    {
        int goals1 = Random.Range(0, 11);
        int assists1 = Random.Range(0, 11);
        int fouls1 = Random.Range(0, 6);

        int goals2 = Random.Range(0, 11);
        int assists2 = Random.Range(0, 11);
        int fouls2 = Random.Range(0, 6);

        team1Stats.UpdateStats(goals1, assists1, fouls1);
        team2Stats.UpdateStats(goals2, assists2, fouls2);

        int scoreTeam1 = team1Stats.CalculateScore();
        int scoreTeam2 = team2Stats.CalculateScore();

        score1.text = FormatNumber(scoreTeam1);
        score2.text = FormatNumber(scoreTeam2);

        goals1Text.text = FormatNumber(goals1);
        assists1Text.text = FormatNumber(assists1);
        fouls1Text.text = FormatNumber(fouls1);

        goals2Text.text = FormatNumber(goals2);
        assists2Text.text = FormatNumber(assists2);
        fouls2Text.text = FormatNumber(fouls2);
    }

    string FormatNumber(int number)
    {
        return number.ToString("D2");
    }
}
