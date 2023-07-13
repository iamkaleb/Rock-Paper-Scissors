using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text Result;
    public LogicManager logicManager;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch(randomChoice)
        {
            case "Rock":
                switch(myChoice)
                {
                    case "Rock":
                        Result.text = "Tie!";
                        logicManager.addTie();
                        break;

                    case "Paper":
                        Result.text = "The paper covers the rock, you win!";
                        logicManager.addScore();
                        break;

                    case "Scissors":
                        Result.text = "The rock destroys the scissors, you lose!";
                        logicManager.addLoss();
                        break;
                    
                }

                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "The paper covers the rock, you lose!";
                        logicManager.addLoss();
                        break;

                    case "Paper":
                        Result.text = "Tie!";
                        logicManager.addTie();
                        break;

                    case "Scissors":
                        Result.text = "The scissors cuts the paper, you win!";
                        logicManager.addScore();
                        break;

                }

                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "The rock destroys the scissors, you win!";
                        logicManager.addScore();
                        break;

                    case "Paper":
                        Result.text = "The scissors cuts the paper, you lose!";
                        logicManager.addLoss();
                        break;

                    case "Scissors":
                        Result.text = "Tie!";
                        logicManager.addTie();

                        break;
                }

                AIChoice.sprite = Scissors;
                break;

        }
    }
}
