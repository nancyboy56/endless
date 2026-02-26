using System;
using TMPro;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private GameObject health;

    [SerializeField] private int damageLayer = 6;
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
        
        // should each obstacle or enemy know how much damage it does
        // its more efficent to write it all here but anyway
        //might refactor later
        if (collision.gameObject.layer == damageLayer)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                
            }
        }
    }
}
