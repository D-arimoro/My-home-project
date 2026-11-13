using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Level1Timer : MonoBehaviour
{
    [SerializeField] private float levelTime = 35f;
    [SerializeField] private TMP_Text timerText;
    private float timeLeft;

    void Start()
    {
        timeLeft = Mathf.Max(0f, levelTime);

        UpdateTimerDisplay();
    }


    void Update()
    {
        if (timeLeft > 0f)
        {
            timeLeft -= Time.deltaTime;

            timeLeft = Mathf.Max(0f, timeLeft);
            UpdateTimerDisplay();
            if (timeLeft <= 0f)
            {
                SceneManager.LoadScene("LoseScreen");
            }
        }
    }

    void UpdateTimerDisplay()
    {
        int totalSeconds = Mathf.CeilToInt(timeLeft);
        int minutes = totalSeconds / 60;
        int SECONDS = totalSeconds % 60;

        timerText.text = $"{minutes:00}:{SECONDS:00}";
    }
}
