using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Camera cam;
    public PlayerController player;
    public GameObject[] platformPrefab;
    public float spawnPoint = 0;
    public GameObject currentPlatform;
    public float safeMargine;
    // Start is called before the first frame update
    void Start()
    {
        //int k = Random.Range(0, platformPrefab.Length);
        //currentPlatform = Instantiate(platformPrefab[0], transform.position, Quaternion.identity);
        //GameObject tempBlock = Instantiate(platformPrefab[k],transform.position =new Vector3(5f,0f,0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        }

        while(spawnPoint > player.transform.position.x + safeMargine)
        {
            int k = Random.Range(0, platformPrefab.Length);
            currentPlatform = Instantiate(platformPrefab[k],gameObject.transform.position, Quaternion.identity);
            PlatformController platform = currentPlatform.GetComponent<PlatformController>();
            currentPlatform.transform.position = new Vector3(spawnPoint + platform.platformSize / 2, 0, 0);
            //spawnPoint = 35f; // spawnPoint + platform.platformSize / 2;
        }
    }

   
}
