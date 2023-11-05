using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class PotionSpawner : MonoBehaviour
    {
        public GameObject potionToSpawn;

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
            Instantiate(potionToSpawn, transform.position, Quaternion.identity);

        }
    }
}