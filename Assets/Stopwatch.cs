using UnityEngine;
using TMPro; // Include this if using TextMeshPro

public class Stopwatch : MonoBehaviour
{
    [Header("UI Components")]
    public TextMeshProUGUI timerText; // Drag your UI Text here

    private float elapsedTime = 0f;
    // private bool isRunning = false;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        UpdateTimerDisplay();
    }

    // public void StartStopwatch() => isRunning = true;
    // public void PauseStopwatch() => isRunning = false;
    
    // public void ResetStopwatch()
    // {
    //     isRunning = false;
    //     elapsedTime = 0f;
    //     UpdateTimerDisplay();
    // }

    void UpdateTimerDisplay()
    {
        // Calculate minutes and seconds
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 100) % 100);

        // Format string as 00:00:00
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }
}