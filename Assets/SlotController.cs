using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    [SerializeField] GameObject xMarker = null;
    [SerializeField] GameObject oMarker = null;

    private Image slotImage;

    private void Start()
    {
        slotImage = GetComponent<Image>();
    }

    public void setSlot()
    {
        if(TurnController.turnCount % 2 == 1)
        {
            if(xMarker != null)
                xMarker.SetActive(true);
        }
        if(TurnController.turnCount % 2 == 0)
        {
            if (oMarker != null)
                oMarker.SetActive(true);
        }

        slotImage.raycastTarget = false;

        TurnController.changeTurn();
    }
}
