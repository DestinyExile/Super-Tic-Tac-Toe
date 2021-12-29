using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    public static int turnCount = 1;

    public static void changeTurn()
    {
        turnCount++;
        Debug.Log(turnCount);
    }
}
