using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxhealth = 5;

    [SerializeField] private int currenthealth = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currenthealth = maxhealth;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
    }

    public void Heal(int heal)
    {
        if (currenthealth + heal > maxhealth)
        {
            currenthealth = maxhealth;
        }
        else
        {
            currenthealth += heal;
        }
    }

    public int GetHealth()
    {
        return currenthealth;
    }

    public bool isDead()
    {
        if (currenthealth <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  
}
