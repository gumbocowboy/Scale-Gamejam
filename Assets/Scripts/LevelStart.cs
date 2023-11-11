using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart: MonoBehaviour
{
    GameObject playerObj;
    public float startingHeight;
    public float startingStep;




    public void SpawnPlayer()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        Vector3 startSize = new Vector3(startingHeight, startingHeight, startingHeight);
        playerObj.transform.localScale = startSize;
        //playerObj.transform.position = gameObject.transform.position;
        CharacterController cont = playerObj.GetComponent<CharacterController>();
        cont.stepOffset = startingStep;

    }
}
