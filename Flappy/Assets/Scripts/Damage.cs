using System;
using TMPro;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private Health health;
    
    //i dont know if it should really be called here
    //it feels a bit strange tp have the UI with the logic and it 
    [SerializeField] private TextMeshProUGUI healthDisplay;

    [SerializeField] private int damageLayer = 6;

    // i think each enemy and obstance is going to have to be on its own gameobject
    // that makes the most sense even if its slightly inefficent
    //its more readable and scaleable
    [SerializeField] private int obstacleDamage = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("current health: "+ health.GetHealth());
        // should each obstacle or enemy know how much damage it does
        // its more efficent to write it all here but anyway
        //might refactor later
        if (collision.gameObject.layer == damageLayer)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                health.TakeDamage(obstacleDamage);
                
                // easy way so the collisions dont get messed up
                // or should i just delete the collider
                Destroy(collision.gameObject);
                
                if(healthDisplay != null)
                {
                    healthDisplay.text = "Health: " + health.GetHealth().ToString();
                }
            }
        }
    }
}
