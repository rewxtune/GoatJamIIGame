using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;


public class SimpleDayNightCycle2D : MonoBehaviour
{
    public Gradient dayNightGradient;    // Gradient for light colors
    public float cycleDuration = 60f;    // Length of full day-night cycle in seconds
    public Light2D globalLight;          // Reference to your Global Light 2D component

    private float timer = 0f;

    void Update()
    {
        if (globalLight == null)
            return;

        timer += Time.deltaTime;
        if (timer > cycleDuration)
            timer = 0f;

        float t = timer / cycleDuration; // Normalize time between 0 and 1

        // Set Global Light 2D color based on gradient
        globalLight.color = dayNightGradient.Evaluate(t);
    }
}