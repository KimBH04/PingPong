using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                gameManager.Player2Score();
            }
            else
            {
                gameManager.Player1Score();
            }
        }
    }
}
