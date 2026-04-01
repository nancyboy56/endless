using UnityEngine;
using TMPro;

public class DataDisplay : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI displayText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        displayText.text = PlayerPrefs.GetInt("Score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
