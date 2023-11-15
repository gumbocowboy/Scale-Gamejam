using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// When attached to a GameObject, it will face the Main Camera at all times. Used for text.
/// </summary>
public class BillboardText : MonoBehaviour
{

    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
