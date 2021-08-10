using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Paddle player1;
    public Paddle player2;
    public float speed;
    public Text scoreText1;
    public Text scoreText2;
    public UIManager managerUI;

    private int scoreP1;
    private int scoreP2;
    private bool isSingle;

    //Initiate score variables, and determine if it's single or multiplayer
    void Start()
    {
        scoreP1 = 0;
        scoreP2 = 0;
        UpdateScore();
        if (SceneManager.GetActiveScene().name == "Single")
            isSingle = true;
        else
            isSingle = false;
    }

    //First player's input
    void P1Position()
    {
        if (Input.GetKey(KeyCode.W) && player1.transform.position.y < 3.5)
            player1.GoUp(speed);
        if (Input.GetKey(KeyCode.S) && player1.transform.position.y > -3.5)
            player1.GoDown(speed);
    }

    //Second player's input
    void P2Position()
    {
        if (Input.GetKey(KeyCode.UpArrow) && player2.transform.position.y < 3.5)
            player2.GoUp(speed);
        if (Input.GetKey(KeyCode.DownArrow) && player2.transform.position.y > -3.5)
            player2.GoDown(speed);
    }

    //Run AI's movement pattern
    void AIPosition()
    {
        player2.UpdatePosition(speed);
    }

    //Increment score for scoring player
    public void Score(string goal)
    {
        if (goal == "RightGoal")
        {
            scoreP1++;
            if (scoreP1 >= 10)
                EndGame("p1");
        }
        else
        {
            scoreP2++;
            if (scoreP2 >= 10)
                EndGame("p2");
        }
        
        UpdateScore();
    }

    //Update the score text boxes
    void UpdateScore()
    {
        scoreText1.text = scoreP1.ToString();
        scoreText2.text = scoreP2.ToString();
    }

    //Display who won, or quit to menu if escape is pressed
    void EndGame(string command)
    {        
        switch (command)
        {
            case "p1":
                managerUI.Display("Player 1");
                Invoke("GoToMenu", 5);
                break;
            case "p2":
                managerUI.Display("Player 2");
                Invoke("GoToMenu", 5);
                break;
            case "quit":
                GoToMenu();
                break;
            default:
                break;
        }
    }

    //This exists so that the scene load can be invoked
    void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //Run player's movement functions depending on single or multiplayer
    void Update()
    {
        P1Position();
        if (isSingle)
            AIPosition();
        else
            P2Position();

        if (Input.GetKey(KeyCode.Escape))
            EndGame("quit");
    }
}
