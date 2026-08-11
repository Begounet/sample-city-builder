using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Length of a full day in seconds")]
    public float dayDuration = 120f;

    private float timeOfDay = 0f; // 0..1

    void Update()
    {
        timeOfDay += Time.deltaTime / dayDuration;
        if (timeOfDay > 1f) timeOfDay -= 1f;
        // TODO: update lighting, sun rotation, and any day/night events
    }
}
