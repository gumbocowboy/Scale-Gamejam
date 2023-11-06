using System.Collections;
using UnityEngine;
/// <summary>
/// Used to Respawn all Potions. This needs cleaned up.
/// </summary>
namespace Assets.Scripts
{
    public class RespawnButton : MonoBehaviour
    {
        GameObject[] potionSpawns;
        // Use this for initialization
        void Start()
        {
            potionSpawns = GameObject.FindGameObjectsWithTag("PotionSpawn");
        }

        // Update is called once per frame
        void OnMouseDown()
        {
            foreach(GameObject pot in potionSpawns)
            {
                
                PotionSpawner spawn = pot.GetComponent<PotionSpawner>();
                if(spawn.potionSpawned == false)
                {
                    spawn.SpawnPotions();

                }
            }
        }
    }
}