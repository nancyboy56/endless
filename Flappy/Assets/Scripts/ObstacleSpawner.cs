using System;
using UnityEngine;
using System.Collections;
using Random = System.Random;


public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefab;
    // 1 to 100 though
    [SerializeField, Range(0,100)] private float[] percentage;

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
            Delay();
           // bool spawn = false;
            for (int i = percentage.Length- 1; i >= 0; i--)
            {
                if (UnityEngine.Random.Range(0, 100) < percentage[i])
                {
                    Debug.Log("spawn!");
                    GameObject newObject = Instantiate(obstaclePrefab[i], new Vector3(transform.position.x, groundHeight,transform.position.z ), Quaternion.identity);

                   // spawn = true;
                    
                    // i think this kinda bad code but you know whatevs
                    // stops trying to spawn when it spawn one
                    //could make it a while loop yeah
                    break;
                }
            }
            
            
            
            //GameObject newPillar = Instantiate(obstaclePrefab[0], new Vector3(transform.position.x, groundHeight,transform.position.z ), Quaternion.identity);
            
            
            
            yield return new WaitForSeconds(delay);
        } 
    }

  
    
    
    // i think this shoudl return to delay it makes more sense but it is a bit reduncant?
    private void Delay()
    {
        delay = UnityEngine.Random.Range(minDelay + baseDelay, maxDelay);
        maxDelay -= interval;

        // make sure the basedaly doesnt get less than 0
        if (baseDelay - interval / 2 > 0)
        {
            baseDelay -= interval/2;
        }
    }
}
