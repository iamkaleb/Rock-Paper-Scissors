using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int playerWins;
    public int playerTies;
    public int playerLosses;
    public Text WinText;
    public Text LossText;
    public Text TieText;

    [ContextMenu("Increase Wins")]
    public void addScore()
    {
        playerWins++;
        SetText();
    }
    [ContextMenu("Increase Ties")]
    public void addTie()
    {
        playerTies++;
        SetText();
    }
    [ContextMenu("Increase Losses")]
    public void addLoss()
    {
        playerLosses++;
        SetText();
    }

    private void SetText()
    {
        WinText.text = $"Wins: {playerWins}";
        LossText.text = $"Losses: {playerLosses}";
        TieText.text = $"Tie: {playerTies}";
    }
}
