using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    
    [SerializeField] Image healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar = GetComponent<Image>();
    }


    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        float percentage = currentHealth / maxHealth;
        healthBar.fillAmount = percentage;
    }
    
}
