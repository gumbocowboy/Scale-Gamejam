using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The base script to be attached to all Potions objects.
/// </summary>
/// 
[RequireComponent(typeof(ObjectScaler))]
public class PotionBase : MonoBehaviour
{
    public float heightAmt = 0.0f;
    public string mouseoverText;
    //public UIController uiCont;
    public bool scaleUp = false;
    UIController uiCont;
    void Awake()
    {
        GameObject ui = GameObject.FindGameObjectWithTag("MainUI");
        uiCont = ui.GetComponent<UIController>();
    }

    public void MouseOver()
    {
        uiCont.ShowMouseOver(mouseoverText);    
    }


    public void UsePotion()
    {
        ObjectScaler scaler = this.GetComponent<ObjectScaler>();
        uiCont.HideMouseOver();

        scaler.StartScaling(heightAmt, scaleUp);
    }
}
