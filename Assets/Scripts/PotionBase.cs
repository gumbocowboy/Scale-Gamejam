using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The base script to be attached to all Potions
/// </summary>
public class PotionBase : MonoBehaviour
{
    public int heightAmt;
    public string mouseoverText;
    public UIController uiCont;
    public bool scaleUp = false;

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
        ObjectScaler scaler = this.GetComponent<ObjectScaler>();
        scaler.StartScaling(heightAmt, scaleUp);
    }
}
