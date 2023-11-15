using System.Collections;
using UnityEngine;


/// <summary>
/// Checks range from camera to Gameobject via Raycast.
/// Should be attached to Player Object.
/// </summary>
public class RangeFinder : MonoBehaviour
{
    public float maxDistance = 5f;
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hit, maxDistance))
        {
            //If object is Interactable
            if(hit.collider.gameObject.layer == 3)
            {
                if(hit.collider.gameObject.tag == "Potions")
                {
                    PotionInteract();
                    if (Input.GetMouseButtonDown(0) && GlobalVars.activeScaling == false)
                    {
                        PotionBase potionBase = hit.collider.gameObject.GetComponent<PotionBase>();
                        potionBase.UsePotion();
                    }
                }

                if (hit.collider.gameObject.tag == "Moveables")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        MoveableInteract();
                    }
                }

            }
        }
    }

    public void PotionInteract()
    {
        PotionBase potionBase = hit.collider.gameObject.GetComponent<PotionBase>();
        potionBase.MouseOver();
    }

    public void MoveableInteract()
    {
        MoveableBase moveBase = hit.collider.gameObject.GetComponent<MoveableBase>();
        moveBase.Interact();
    }
}
