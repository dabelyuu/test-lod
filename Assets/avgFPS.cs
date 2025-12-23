using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    [Header("UI Components")]
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI fpsText; // To display the average result

    private float elapsedTime = 0f;
    private int frameCount = 0;
    private bool isTracking = true;

    // Target: 1 minute 11 seconds = 71 seconds
    private const float TargetTime = 71f;

    void Update()
    {
        if (isTracking)
        {
            elapsedTime += Time.deltaTime;
            frameCount++;

            UpdateTimerDisplay();

            // Check if we reached 1 minute and 11 seconds
            if (elapsedTime >= TargetTime)
            {
                FinishTracking();
            }
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 100) % 100);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    void FinishTracking()
    {
        isTracking = false;
        
        // Final calculation
        float averageFps = frameCount / elapsedTime;

        Debug.Log($"Tracking Finished! Total Frames: {frameCount}, Avg FPS: {averageFps}");
        
        if (fpsText != null)
        {
            fpsText.text = $"Avg FPS: {averageFps:F2}"; // F2 formats to 2 decimal places
        }
    }
}