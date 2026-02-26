using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject pillar;

    [SerializeField, Range(0,10)]
    float delay = 3.5f;

    [SerializeField] private float randomY;

    [SerializeField] private float groundHeight;
    
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
            //spawns at the y height of the ground
            // i think the scaling it differently is bad so i think I will just draw different assets
            //unless i can make a readjust height asset using a shader
            //i could do that
            GameObject newPillar = Instantiate(pillar, new Vector3(pillar.transform.position.x, groundHeight,pillar.transform.position.z ), Quaternion.identity);
            
           // might make this delay a bit random idk yet
            yield return new WaitForSeconds(delay);
        } 
    }
}
