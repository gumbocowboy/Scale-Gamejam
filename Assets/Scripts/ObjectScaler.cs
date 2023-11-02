using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    public GameObject objToScale;
    
    public Vector3 objMaxSize = new Vector3 (20.0f, 20.0f, 20.0f);
    public Vector3 objMinSize;

    float smoothSpeed = 0.3f;


    public IEnumerator ScaleUp(GameObject obj, Vector3 scaleTo, float seconds)
    {
        float elapsedTime = 0;
        Vector3 startScale = objToScale.transform.localScale;
        while(elapsedTime < seconds)
        {
            objToScale.transform.localScale = Vector3.Lerp(startScale, objMaxSize, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        objToScale.transform.localScale = objMaxSize;
    }

    public void ScaleDown()
    {
        
    }
}
