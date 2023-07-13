using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int playerWins;
    public int playerTies;
    public int playerLosses;
    public Text ScoreText;

    [ContextMenu("Increase Wins")]
    public void addScore()
    {
        playerWins++;
        ScoreText.text = $"Wins: {playerWins}. Ties: {playerTies}. Losses: {playerLosses}.";
    }
    [ContextMenu("Increase Ties")]
    public void addTie()
    {
        playerTies++;
        ScoreText.text = $"Wins: {playerWins}. Ties: {playerTies}. Losses: {playerLosses}.";
    }
    [ContextMenu("Increase Losses")]
    public void addLoss()
    {
        playerLosses++;
        ScoreText.text = $"Wins: {playerWins}. Ties: {playerTies}. Losses: {playerLosses}.";
    }
}
