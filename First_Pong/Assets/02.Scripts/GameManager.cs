using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public Text player1Text;
    public Text player2Text;

    public int player1Score;
    public int player2Score;

    public void Player1Score()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        ResetPosition();
    }

    public void Player2Score()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
