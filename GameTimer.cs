using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timerDuration = 60f; // Total time in seconds
    private float timeRemaining;
    public Text timerText; // UI Text element to display the timer
    public bool countdown = true; // Determines if the timer counts down or up

    private bool isRunning = true;

    void Start()
    { 
        timeRemaining = countdown ? timerDuration : 0f;
        UpdateTimerText();
    }

    void Update()
    {
        if (isRunning)
        {
            if (countdown)
            {
                timeRemaining -= Time.deltaTime;
                if (timeRemaining <= 0)
                {
                    timeRemaining = 0;
                    isRunning = false;
                    TimerEnded();
                }
            }
            else
            {
                timeRemaining += Time.deltaTime;
                if (timeRemaining >= timerDuration)
                {
                    isRunning = false;
                    TimerEnded();
                }
            }

            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = $"{minutes:D2}:{seconds:D2}";
    }

    void TimerEnded()
    {
        Debug.Log("Timer has ended!");
        // Add logic here for what happens when the timer ends
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void PauseTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        timeRemaining = countdown ? timerDuration : 0f;
        isRunning = false;
        UpdateTimerText();
    }
}
