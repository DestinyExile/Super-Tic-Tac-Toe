using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class BoardEnabler : MonoBehaviour
{
    [SerializeField] GameObject board1Cover = null;
    [SerializeField] GameObject board2Cover = null;
    [SerializeField] GameObject board3Cover = null;
    [SerializeField] GameObject board4Cover = null;
    [SerializeField] GameObject board5Cover = null;
    [SerializeField] GameObject board6Cover = null;
    [SerializeField] GameObject board7Cover = null;
    [SerializeField] GameObject board8Cover = null;
    [SerializeField] GameObject board9Cover = null;

    public static string previousSlot = "";
    private int previousSlotNumber = 0;

    private void Update()
    {
        if(TurnController.turnCount > 1)
        {
            getSlotNumber();
            enableBoards();
        }
    }

    private void getSlotNumber()
    {
        string slotNumberString = Regex.Match(previousSlot, @"\d+").Value;
        previousSlotNumber = System.Int32.Parse(slotNumberString);
    }

    private void enableBoards()
    {
        if(previousSlotNumber == 1 && !board1Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard1();
        }
        else if(previousSlotNumber == 1 && board1Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 2 && !board2Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard2();
        }
        else if (previousSlotNumber == 2 && board2Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 3 && !board3Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard3();
        }
        else if (previousSlotNumber == 3 && board3Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 4 && !board4Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard4();
        }
        else if (previousSlotNumber == 4 && board4Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 5 && !board5Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard5();
        }
        else if (previousSlotNumber == 5 && board5Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 6 && !board6Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard6();
        }
        else if (previousSlotNumber == 6 && board6Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 7 && !board7Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard7();
        }
        else if (previousSlotNumber == 7 && board7Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 8 && !board8Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard8();
        }
        else if (previousSlotNumber == 8 && board8Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }

        if (previousSlotNumber == 9 && !board9Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoard9();
        }
        else if (previousSlotNumber == 9 && board1Cover.GetComponentInParent<BoardController>().checkWinState())
        {
            enableBoardAll();
        }
    }

    private void enableBoard1()
    {
        board1Cover.SetActive(false);
        board2Cover.SetActive(true);
        board3Cover.SetActive(true);
        board4Cover.SetActive(true);
        board5Cover.SetActive(true);
        board6Cover.SetActive(true);
        board7Cover.SetActive(true);
        board8Cover.SetActive(true);
        board9Cover.SetActive(true);
    }

    private void enableBoard2()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(false);
        board3Cover.SetActive(true);
        board4Cover.SetActive(true);
        board5Cover.SetActive(true);
        board6Cover.SetActive(true);
        board7Cover.SetActive(true);
        board8Cover.SetActive(true);
        board9Cover.SetActive(true);
    }

    private void enableBoard3()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(true);
        board3Cover.SetActive(false);
        board4Cover.SetActive(true);
        board5Cover.SetActive(true);
        board6Cover.SetActive(true);
        board7Cover.SetActive(true);
        board8Cover.SetActive(true);
        board9Cover.SetActive(true);
    }

    private void enableBoard4()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(true);
        board3Cover.SetActive(true);
        board4Cover.SetActive(false);
        board5Cover.SetActive(true);
        board6Cover.SetActive(true);
        board7Cover.SetActive(true);
        board8Cover.SetActive(true);
        board9Cover.SetActive(true);
    }

    private void enableBoard5()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(true);
        board3Cover.SetActive(true);
        board4Cover.SetActive(true);
        board5Cover.SetActive(false);
        board6Cover.SetActive(true);
        board7Cover.SetActive(true);
        board8Cover.SetActive(true);
        board9Cover.SetActive(true);
    }

    private void enableBoard6()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(true);
        board3Cover.SetActive(true);
        board4Cover.SetActive(true);
        board5Cover.SetActive(true);
        board6Cover.SetActive(false);
        board7Cover.SetActive(true);
        board8Cover.SetActive(true);
        board9Cover.SetActive(true);
    }

    private void enableBoard7()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(true);
        board3Cover.SetActive(true);
        board4Cover.SetActive(true);
        board5Cover.SetActive(true);
        board6Cover.SetActive(true);
        board7Cover.SetActive(false);
        board8Cover.SetActive(true);
        board9Cover.SetActive(true);
    }

    private void enableBoard8()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(true);
        board3Cover.SetActive(true);
        board4Cover.SetActive(true);
        board5Cover.SetActive(true);
        board6Cover.SetActive(true);
        board7Cover.SetActive(true);
        board8Cover.SetActive(false);
        board9Cover.SetActive(true);
    }

    private void enableBoard9()
    {
        board1Cover.SetActive(true);
        board2Cover.SetActive(true);
        board3Cover.SetActive(true);
        board4Cover.SetActive(true);
        board5Cover.SetActive(true);
        board6Cover.SetActive(true);
        board7Cover.SetActive(true);
        board8Cover.SetActive(true);
        board9Cover.SetActive(false);
    }

    private void enableBoardAll()
    {
        board1Cover.SetActive(false);
        board2Cover.SetActive(false);
        board3Cover.SetActive(false);
        board4Cover.SetActive(false);
        board5Cover.SetActive(false);
        board6Cover.SetActive(false);
        board7Cover.SetActive(false);
        board8Cover.SetActive(false);
        board9Cover.SetActive(false);
    }
}
