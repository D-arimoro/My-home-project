using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] private float collisionDamage = 20f; //sets collisionDamage amount //class can be adjusted in unity inspector
    [SerializeField] private Image healthBar; //class can be adjusted in unity inspector
    private float fullBar = 120f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.fillAmount = fullBar / 120F; //sets full health
    }

    public void TakeDamage() 
    {
        if (fullBar <= 0f)
        {
            return;
        }
        fullBar = Mathf.Clamp(fullBar - collisionDamage, 0f, 120f); //damage calculation
        healthBar.fillAmount = fullBar / 120f;
        if (fullBar <= 0f)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }

}
