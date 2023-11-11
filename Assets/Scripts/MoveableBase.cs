using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The base script to be attacked to all Moveable Objects
/// </summary>
public class MoveableBase : MonoBehaviour
{
    public string itemName;
    public int requiredHeight;
    public string mouseoverText;
    public UIController uiCont;

    void OnMouseOver()
    {
        uiCont.ShowMouseOver(mouseoverText);
    }

    void OnMouseExit()
    {
        uiCont.HideMouseOver();
    }

    void OnMouseDown()
    {
        if(GlobalVars.currentHeight == requiredHeight)
        {
            Debug.Log("WOW");
        }
        else
        {
            uiCont.ShowWrongSize(requiredHeight);

        }
    }
}
