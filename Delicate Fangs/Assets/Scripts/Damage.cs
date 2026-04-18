using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    
    [SerializeField] private string dieScene ="End Run";

    [SerializeField] private Healthbar hbDisplay;
    
    [SerializeField] private SoundManager soundManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateHealthDisplay();
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
                
                if (health.isDead())
                {
                    Die();
                }
                
                // easy way so the collisions dont get messed up
                // or should i just delete the collider
                Destroy(collision.gameObject);
                soundManager.DamagePLay();
                
                //updates hearts through here but runs its own script
               hbDisplay.UpdateHealth (health.GetHealth(), health.GetMaxHealth());
                //UpdateHealthDisplay();
            }
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Debug.Log("helaed");
            health.Heal(1);
            soundManager.HealPLay();
            hbDisplay.UpdateHealth (health.GetHealth(), health.GetMaxHealth());
        }
    }
    

    // currently just go to end screen
    //might want to do animations later
    private void Die()
    {
        SceneManager.LoadScene(dieScene);
    }

    // im not using a number anymore but i should have had it on heart and linked the scriipt
    //it is just confusing having it here
    private void UpdateHealthDisplay()
    {
        if(healthDisplay != null)
        {
            healthDisplay.text = "Health: " + health.GetHealth().ToString();
        }
    }
}
