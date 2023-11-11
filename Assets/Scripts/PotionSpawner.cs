using System.Collections;
using UnityEngine;


    public class PotionSpawner : MonoBehaviour
    {
        public GameObject potionToSpawn;
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
        potionSpawned = true;

        }
    }
