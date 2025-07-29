using UnityEngine;

public class FieldPulseEvent : MonoBehaviour
{
    public float pulseStrength = 0f;
    public float decayRate = 0.05f;
    public bool isActive = false;

    void Update()
    {
        if (isActive)
        {
            ApplyPulseEffect();
            pulseStrength -= decayRate * Time.deltaTime;

            if (pulseStrength <= 0f)
            {
                pulseStrength = 0f;
                isActive = false;
                Debug.Log("🌑 Pulse event has faded.");
            }
        }
    }

    public void TriggerPulse(float instability)
    {
        pulseStrength = instability * 10f; // Amplify for visual/simulation effect
        isActive = true;
        Debug.Log("🌟 Akiitoko Field Pulse Triggered! Strength: " + pulseStrength);
    }

    void ApplyPulseEffect()
    {
        // Placeholder for real-world visuals, sound, or reaction
        Debug.Log("⚡ Akiitoko Field Pulse in progress... [" + pulseStrength.ToString("F2") + "]");
    }
}
