using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public float timeDelay = 10;
    float timeSS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
     timeSS = timeSS + Time.deltaTime;

        if(timeSS>timeDelay)
        {
            timeSS = 0;
            int r=   Random.Range(0, itemPrefabs.Length);
            Instantiate(itemPrefabs[r]);
        }
    }
}
