using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField] SlotController Slot1 = null;
    [SerializeField] SlotController Slot2 = null;
    [SerializeField] SlotController Slot3 = null;
    [SerializeField] SlotController Slot4 = null;
    [SerializeField] SlotController Slot5 = null;
    [SerializeField] SlotController Slot6 = null;
    [SerializeField] SlotController Slot7 = null;
    [SerializeField] SlotController Slot8 = null;
    [SerializeField] SlotController Slot9 = null;
    [SerializeField] GameObject xMarker = null;
    [SerializeField] GameObject oMarker = null;

    public static bool boardWon = false;

    private void Update()
    {
        if(!boardWon)
        {
            checkWin();
        }
    }

    public void checkWin()
    {
        //horizontal first row
        if (Slot1.slotState == Slot2.slotState && Slot2.slotState == Slot3.slotState)
        {
            if (Slot1.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot1.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }

        //horizontal second row
        if (Slot4.slotState == Slot5.slotState && Slot5.slotState == Slot6.slotState)
        {
            if (Slot4.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot4.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }

        //horizontal third row
        if (Slot7.slotState == Slot8.slotState && Slot8.slotState == Slot9.slotState)
        {
            if (Slot7.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot7.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }

        //veritcal first columnn
        if (Slot1.slotState == Slot4.slotState && Slot4.slotState == Slot7.slotState)
        {
            if (Slot1.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot1.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }

        //veritcal second columnn
        if (Slot2.slotState == Slot5.slotState && Slot5.slotState == Slot8.slotState)
        {
            if (Slot2.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot2.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }

        //veritcal third columnn
        if (Slot3.slotState == Slot6.slotState && Slot6.slotState == Slot9.slotState)
        {
            if (Slot3.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot3.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }

        //right diagonal
        if (Slot1.slotState == Slot5.slotState && Slot5.slotState == Slot9.slotState)
        {
            if (Slot1.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot1.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }

        //left diagonal
        if (Slot3.slotState == Slot5.slotState && Slot5.slotState == Slot7.slotState)
        {
            if (Slot3.slotState == 1)
            {
                xMarker.SetActive(true);
                boardWon = true;
            }
            if (Slot3.slotState == 2)
            {
                oMarker.SetActive(true);
                boardWon = true;
            }
        }
    }

    public bool checkWinState()
    {
        return boardWon;
    }
}
