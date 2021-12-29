using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    [SerializeField] GameObject xMarker = null;
    [SerializeField] GameObject oMarker = null;

    public int slotState = 0;

    private Image slotImage;

    private void Start()
    {
        slotImage = GetComponent<Image>();
    }

    public void setSlot()
    {
        if(TurnController.turnCount % 2 == 1)
        {
            if (xMarker != null)
            {
                xMarker.SetActive(true);
                slotState = 1;
            }
        }
        if(TurnController.turnCount % 2 == 0)
        {
            if (oMarker != null)
            {
                oMarker.SetActive(true);
                slotState = 2;
            }
        }

        slotImage.raycastTarget = false;

        TurnController.changeTurn();
    }
}
