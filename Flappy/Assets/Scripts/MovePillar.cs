using UnityEngine;

public class MovePillar : MonoBehaviour
{
    [SerializeField, Range(0,10)]
    float speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //is this the most effective way to do this
        // i feel like it should work out the boundaries from the screen size
        if (transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
