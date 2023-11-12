using System.Collections;
using UnityEngine;


public class PotionSpawner : MonoBehaviour
{
    public GameObject potionToSpawn;
    public float sizeChange;
    public string mouseoverText;
    public bool scaleUp;

    //If the potion is actively on the map
    public bool potionSpawned = false;
    // Use this for initialization
    void Awake()
    {
        SpawnPotions();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnPotions()
    {
    //Instantiate(potionToSpawn, transform.position, Quaternion.identity);
        var newpot = Instantiate(potionToSpawn);
        newpot.transform.parent = gameObject.transform;
        newpot.transform.position = gameObject.transform.position;

        PotionBase potionBase = newpot.GetComponent<PotionBase>();
        potionBase.heightAmt = sizeChange;
        potionBase.mouseoverText = mouseoverText;
        potionBase.scaleUp = scaleUp;

        potionSpawned = true;

    }
}
