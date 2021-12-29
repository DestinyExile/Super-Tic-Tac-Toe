using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    [SerializeField] GameObject player1TurnText = null;
    [SerializeField] GameObject player2TurnText = null;

    public static int turnCount = 1;

    private void Update()
    {
        if(turnCount % 2 == 0)
        {
            player2TurnText.SetActive(true);
            player1TurnText.SetActive(false);
        }
        else
        {
            player1TurnText.SetActive(true);
            player2TurnText.SetActive(false);
        }
    }

    public static void changeTurn()
    {
        turnCount++;

    }
}
