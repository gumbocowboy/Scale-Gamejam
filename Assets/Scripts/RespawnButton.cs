using System.Collections;
using UnityEngine;
/// <summary>
/// Used to Respawn all Potions. This needs cleaned up.
/// </summary>
namespace Assets.Scripts
{
    public class RespawnButton : MonoBehaviour
    {
        UIController uiCont;
        GameObject[] potionSpawns;
        GameObject playerSpawnPoint;
        public string mouseoverText;
        // Use this for initialization
        void Start()
        {
            GameObject ui = GameObject.FindGameObjectWithTag("MainUI");
            Debug.Log(" UI Name is " + ui.name);
            uiCont = ui.GetComponent<UIController>();
            potionSpawns = GameObject.FindGameObjectsWithTag("PotionSpawn");
            playerSpawnPoint = GameObject.FindGameObjectWithTag("PlayerSpawn");
        }


         void OnMouseOver()
        {
            uiCont.ShowMouseOver(mouseoverText);
        }
        void OnMouseExit()
        {
            uiCont.HideMouseOver();
        }


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
            LevelStart spawner = playerSpawnPoint.GetComponent<LevelStart>();
            spawner.SpawnPlayer();
        }
    }
}