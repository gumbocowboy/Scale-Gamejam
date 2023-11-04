using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    public GameObject objToScale;

    public int objSize;
    [Tooltip("The in-game size of the object that will effect puzzles")]
    public float sizeChange;
    [Tooltip("Will this item scale the player up")]
    public bool scaleUp = false;
    
    public Vector3 objMaxSize = new Vector3(10.0f, 10.0f, 10.0f);
    public Vector3 objMinSize;
    public Vector3 changeVector;



    Vector3 currentSize;
    Vector3 targetSize;
  
    Vector3 sizeDiff;

    float smoothSpeed = 0.3f;
    void Start()
    {
        sizeDiff = new Vector3(sizeChange, sizeChange, sizeChange);
        Debug.Log(this.gameObject.name + " sizechange is " + sizeChange);
    }

    void Update()
    {
        changeVector = sizeDiff;
    }


    public void StartScaling()
    {
        Debug.Log("Scaling called from " + this.gameObject.name);
        Debug.Log(this.gameObject.name + " sizechange is " + sizeChange);

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
        float elapsedTime = 0;
        Vector3 startScale = objToScale.transform.localScale;
        Vector3 targetSize = startScale += scaleTo;
        /*        while (elapsedTime < seconds)
                {
                    objToScale.transform.localScale = Vector3.Lerp(startScale, targetSize, (elapsedTime / seconds));
                    elapsedTime += Time.deltaTime;
                    yield return new WaitForEndOfFrame();

                }*/
        yield return new WaitForEndOfFrame();

        objToScale.transform.localScale = targetSize;
        GlobalVars.currentHeight += (int)sizeChange;

    }

    public IEnumerator ScaleDown(GameObject obj, Vector3 scaleTo, float seconds)
    {
        float elapsedTime = 0;
        Vector3 startScale = objToScale.transform.localScale;
        Vector3 targetSize = startScale -= scaleTo;
        /*  while (elapsedTime < seconds)
          {
              objToScale.transform.localScale = Vector3.Lerp(startScale, targetSize, (elapsedTime / seconds));
              elapsedTime += Time.deltaTime;

              yield return new WaitForEndOfFrame();
          }*/
        yield return new WaitForEndOfFrame();

        objToScale.transform.localScale = targetSize;
        GlobalVars.currentHeight -= (int)sizeChange;
    }

}