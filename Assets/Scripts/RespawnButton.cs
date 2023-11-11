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
        GameObject playerObj;
        public string mouseoverText;
        public float startingHeight;
        public float startingStep;


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
            RespawnPotions();
            /*            LevelStart spawner = playerSpawnPoint.GetComponent<LevelStart>();
                        spawner.SpawnPlayer();*/
            ResetPlayer();
        }

        void RespawnPotions()
        {
            foreach (GameObject pot in potionSpawns)
            {

                PotionSpawner spawn = pot.GetComponent<PotionSpawner>();
                if (spawn.potionSpawned == false)
                {
                    spawn.SpawnPotions();

                }
            }
        }
        
        void ResetPlayer()
        {
            playerObj = GameObject.FindGameObjectWithTag("Player");
            Vector3 startSize = new Vector3(startingHeight, startingHeight, startingHeight);
            playerObj.transform.localScale = startSize;
            //playerObj.transform.position = gameObject.transform.position;
            CharacterController cont = playerObj.GetComponent<CharacterController>();
            cont.stepOffset = startingStep;
        }
    }

}