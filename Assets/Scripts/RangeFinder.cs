﻿using System.Collections;
using UnityEngine;


/// <summary>
/// Checks range from camera to Gameobject via Raycast.
/// Should be attached to Player Object.
/// </summary>
public class RangeFinder : MonoBehaviour
{
    public float maxDistance = 5f;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if(Physics.Raycast(ray, out hit, maxDistance))
        {
            if(hit.collider.gameObject.layer == 3)
            {
                if(hit.collider.gameObject.tag == "Potions")
                {
                    PotionBase potionBase = hit.collider.gameObject.GetComponent<PotionBase>();
                    potionBase.MouseOver();
                }

                if (hit.collider.gameObject.tag == "Moveables")
                {
                    Debug.Log("Moveab");
                }

            }
        }
    }
}
