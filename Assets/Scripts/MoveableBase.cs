using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The base script to be attacked to all Moveable Objects
/// </summary>
public class MoveableBase : MonoBehaviour
{
    public string itemName;
    public float requiredHeight;
    public string mouseoverText;
    UIController uiCont;

    private void Awake()
    {
        GameObject ui = GameObject.FindGameObjectWithTag("MainUI");
        uiCont = ui.GetComponent<UIController>();
    }


    public void Interact()
    {
        if(GlobalVars.currentHeight >= requiredHeight)
        {
            Debug.Log("WOW");
        }
        else
        {
            uiCont.ShowWrongSize(requiredHeight);

        }
    }
}
