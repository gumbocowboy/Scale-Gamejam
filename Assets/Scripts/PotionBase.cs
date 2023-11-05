using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The base script to be attached to all Potions
/// </summary>
public class PotionBase : MonoBehaviour
{
    public float heightAmt = 0.0f;
    public string mouseoverText;
    //public UIController uiCont;
    public bool scaleUp = false;
    UIController uiCont;
    void Start()
    {
        GameObject ui = GameObject.FindGameObjectWithTag("MainUI");
        Debug.Log(" UI Name is " + ui.name);
        uiCont = ui.GetComponent<UIController>();
    }

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
