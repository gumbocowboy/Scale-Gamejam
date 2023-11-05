using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    GameObject objToScale;

    
    
    
    

    Vector3 changeVector;

    Vector3 currentSize;
    Vector3 targetSize;  
    Vector3 sizeDiff;

    float smoothSpeed = 0.3f;
    void Start()
    {
        /*        sizeDiff = new Vector3(sizeChange, sizeChange, sizeChange);
                Debug.Log(this.gameObject.name + " sizechange is " + sizeChange);*/
        objToScale = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(objToScale.name);
    }

    void Update()
    {
    }


    public void StartScaling(float scaleAmt, bool scaleUp)
    {

        changeVector = new Vector3(scaleAmt,scaleAmt,scaleAmt);

        if (scaleUp)
        {
            StartCoroutine(ScaleUp(objToScale, changeVector, 5f));
        }
        else
        {
            StartCoroutine(ScaleDown(objToScale, changeVector, 5f));
        }

    }




    public IEnumerator ScaleUp(GameObject obj, Vector3 scaleTo, float seconds)
    {

        Vector3 startScale = objToScale.transform.localScale;
        Vector3 targetSize = startScale += scaleTo;
 
        yield return new WaitForEndOfFrame();

        objToScale.transform.localScale = targetSize;
        GlobalVars.currentHeight += (int)scaleTo.x;
        Destroy(this.gameObject);

    }

    public IEnumerator ScaleDown(GameObject obj, Vector3 scaleTo, float seconds)
    {

        Vector3 startScale = objToScale.transform.localScale;
        Vector3 targetSize = startScale -= scaleTo;

        yield return new WaitForEndOfFrame();

        objToScale.transform.localScale = targetSize;
        GlobalVars.currentHeight -= (int)scaleTo.x;
        Destroy(this.gameObject);

    }

}