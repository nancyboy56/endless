using System;
using UnityEngine;
using System.Collections;


public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefab;

    [SerializeField, Range(0,2)]
    // startoing delay 
    private float minDelay = 0.5f;


    [SerializeField, Range(0,15)] private float maxDelay = 7f;
    [SerializeField, Range(0, 10)] private float baseDelay = 2f;
    [SerializeField, Range(0,2)] private float interval = 0.5f;
    
    [SerializeField] private float groundHeight;

    [SerializeField] private float delay = 0f;
    
    //[Se]
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Instantiate(pillar, transform.position, Quaternion.identity);

        StartCoroutine(SpawnLoop()); 
    }


//coroutine
    IEnumerator SpawnLoop()
    {
        // lowkey dont like this while true but oh well
        //feels unreadable
        while (true)
        {
            // this means that objects could come way to first too early.
            // i think the min has to start higher over time
            delay = UnityEngine.Random.Range(minDelay + baseDelay, maxDelay);
            maxDelay -= interval;

            // make sure the basedaly doesnt get less than 0
            if (baseDelay - interval / 2 > 0)
            {
                baseDelay -= interval/2;
            }
            
            GameObject newPillar = Instantiate(obstaclePrefab[0], new Vector3(transform.position.x, groundHeight,transform.position.z ), Quaternion.identity);
            
            yield return new WaitForSeconds(delay);
        } 
    }
}
