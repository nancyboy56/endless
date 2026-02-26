using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    Animator ani;

    [SerializeField]private Score score;


    [SerializeField] [Range(0,10)]
    float force = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Player!");
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update!");


    }

    //callbackcontext is whatever controllers is
    public void Jump(InputAction.CallbackContext context)
    {
        //Debug.Log("Jump!");
        rb.linearVelocity = Vector2.up * force;
        

        ani.SetBool("isFlapping", true);
        
    }
    public void SetIdle()
    {
        ani.SetBool("isFlapping", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collside!");
        if (collision.gameObject.CompareTag("Score"))
        {
            Debug.Log("Score!!");
            score.AddScore();
        }
    }
}
