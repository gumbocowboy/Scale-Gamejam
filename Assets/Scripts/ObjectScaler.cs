using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    GameObject objToScale;

    
    
    
    

    Vector3 changeVector;
    Vector3 newsize;

    Vector3 startSize;
    Vector3 targetSize;  
    Vector3 sizeDiff;

    float smoothSpeed = 10f;
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
        startSize = objToScale.transform.localScale;
        changeVector = new Vector3(scaleAmt,scaleAmt,scaleAmt);

        if (scaleUp)
        {
            newsize = startSize += changeVector;

            StartCoroutine(ScaleUp(objToScale, changeVector, 5f));
        }
        else
        {
            newsize = startSize -= changeVector;

            StartCoroutine(ScaleDown(objToScale, changeVector, 5f));
        }

        
         

    }




    public IEnumerator ScaleUp(GameObject obj, Vector3 scaleTo, float seconds)
    {

        Vector3 targetSize = startSize += scaleTo;

        float elapsedTime = 0f;

        while(elapsedTime < 1f)
        {
            Debug.Log("Hitting Smooth Scaler");
            objToScale.transform.localScale = Vector3.Lerp(startSize, newsize, elapsedTime);
            elapsedTime += Time.deltaTime * smoothSpeed;
            yield return null;

        }


        objToScale.transform.localScale = newsize;
        GlobalVars.currentHeight += (int)scaleTo.x;
        PotionSpawner potSpawner = this.GetComponentInParent<PotionSpawner>();
        potSpawner.potionSpawned = false;
        GlobalVars.activeScaling = false;
        Destroy(this.gameObject);


    }

    public IEnumerator ScaleDown(GameObject obj, Vector3 scaleTo, float seconds)
    {

        Vector3 startScale = objToScale.transform.localScale;
        Vector3 targetSize = startScale -= scaleTo;

       // Vector3 slowedScale = Vector3.Lerp(startScale, targetSize, smoothSpeed);



        yield return new WaitForEndOfFrame();

        objToScale.transform.localScale = newsize;
        
        
        
        CharacterController cont = objToScale.GetComponent<CharacterController>();
        //cont.stepOffset = cont.stepOffset - .50f;
       
        cont.stepOffset = .25f;
        GlobalVars.currentHeight -= (int)scaleTo.x;
        PotionSpawner potSpawner = this.GetComponentInParent<PotionSpawner>();
        potSpawner.potionSpawned = false;
        GlobalVars.activeScaling = false;

        Destroy(this.gameObject);

    }



}