
using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject pillar;

    [SerializeField, Range(0,10)]
    float delay = 3.5f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Instantiate(pillar, transform.position, Quaternion.identity);

        StartCoroutine(SpawnLoop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//coroutine
    IEnumerator SpawnLoop()
    {
        while (true)
        {
            GameObject newPillar = Instantiate(pillar, transform.position, Quaternion.identity);
            
            // changes the scale for its child but not the parent
            //this code is pretty dumb and ugly
            //i think i should just make them both different prefabs and have them spawn in together
            //or have same as the same prefab and just load in different pillar art and then spawn two at once 
            // bc get child 1 and 0 is actually so dumb and why is this even possible this way lol
            float pillarY = Random.Range(1.5f,2.0f);
            newPillar.transform.GetChild(0).localScale = new Vector3(pillar.transform.localScale.x, pillarY , pillar.transform.localScale.z);
            newPillar.transform.GetChild(1).localScale = new Vector3(pillar.transform.localScale.x,  pillarY, pillar.transform.localScale.z);
           // newPillar.transform.localScale = new Vector3(pillar.transform.localScale.x,  Random.Range(1.0f,2.0f), pillar.transform.localScale.z);

            yield return new WaitForSeconds(delay);
        } 
    }
}
