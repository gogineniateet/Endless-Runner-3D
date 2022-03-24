using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float platformSize;
    // Start is called before the first frame update
    void Start()
    {
        platformSize = transform.localScale.x;
        Debug.Log(platformSize);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
