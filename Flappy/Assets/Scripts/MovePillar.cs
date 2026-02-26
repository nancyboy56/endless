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
        
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
