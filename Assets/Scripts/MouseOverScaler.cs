using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverScaler : MonoBehaviour
{
    public GameObject uiobj;
    [Tooltip("UI Object to be displayed when mousing over Object")]

    public bool makeBig = false;
    [Tooltip("Will this item Scale Up the player?")]

    ObjectScaler objScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        uiobj.SetActive(true);    
    }

    void OnMouseExit()
    {
        uiobj.SetActive(false);    
    }

    void OnMouseDown()
    {
        objScale = this.GetComponent<ObjectScaler>();
        //objScale.changeVector = new Vector3(objScale.sizeChange, objScale.sizeChange, objScale.sizeChange);



        Debug.Log("Mouse down on " + this.gameObject.name);
        objScale.StartScaling();
        //StartCoroutine(objScale.ScaleUp(objScale.objToScale, objScale.changeVector, 5f));


    }
}
