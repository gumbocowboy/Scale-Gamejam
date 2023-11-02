using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverTest : MonoBehaviour
{
    public GameObject uiobj;
    public bool makeBig;
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
        Debug.Log("Foo");
        ObjectScaler objScale = this.GetComponent<ObjectScaler>();
        StartCoroutine(objScale.ScaleUp(objScale.objToScale, objScale.objMaxSize, 5f));
    }
}
