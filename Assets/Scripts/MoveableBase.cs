using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableBase : MonoBehaviour
{
    public string itemName;
    public int requiredHeight;
    public string mouseoverText;
    public UIController uiCont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*    public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collide");
            if (collision.gameObject.tag == "Player")
            {
                Debug.Log("Hit");
            }
        }*/

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
