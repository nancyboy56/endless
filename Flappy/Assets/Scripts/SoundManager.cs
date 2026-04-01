using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioSource wings, scoring;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void WingPLay()
    {
        wings.Play();
    }
    
    public void ScoringPLay()
    {
        scoring.Play();
    }
}
