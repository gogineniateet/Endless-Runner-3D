using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Camera cam;
    public PlayerController player;
    private PlatformController platform;
    public GameObject[] platformPrefab;
    public float spawnPoint = 0;
    private GameObject currentPlatform;
    public float safeMargin;
    // Start is called before the first frame update
    void Start()
    {
        //int k = Random.Range(0, platformPrefab.Length);
        currentPlatform = Instantiate(platformPrefab[0], transform.position, Quaternion.identity);
        //GameObject tempBlock = Instantiate(platformPrefab[k],transform.position =new Vector3(5f,0f,0f),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        }

        while (spawnPoint < player.transform.position.x + safeMargin)
        {
            int randomValue = Random.Range(0, platformPrefab.Length);
            currentPlatform = Instantiate(platformPrefab[randomValue]);
            platform = currentPlatform.GetComponent<PlatformController>();
            //print("Platform Size from Game Manager: " + platform.GetSizeUpdated());
            currentPlatform.transform.position = new Vector3(spawnPoint + platform.transform.localScale.x / 2, 0f, 0f);
            spawnPoint = spawnPoint + platform.transform.localScale.x;
        }
    }

   
}
