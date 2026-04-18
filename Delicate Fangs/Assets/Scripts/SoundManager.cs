using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioSource[] audios;
 

    public void WingPLay()
    {
        audios[0].Play();
    }
    
    public void ScoringPLay()
    {
        audios[1].Play();
    }
    
    public void HealPLay()
    {
        audios[2].Play();
    }
    
    public void DamagePLay()
    {
        audios[3].Play();
    }
}
