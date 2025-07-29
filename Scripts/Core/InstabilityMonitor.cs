using UnityEngine;

public class InstabilityMonitor : MonoBehaviour
{
    public Realm targetRealm;
    public float instabilityThreshold = 1.0f;

    public FieldPulseEvent pulseEvent;
    public LogSystem logger;

    private bool isTriggered = false;

    void Update()
    {
        float instability = targetRealm.CalculateInstability();

        if (!isTriggered && instability > instabilityThreshold)
        {
            isTriggered = true;

            if (pulseEvent != null)
                pulseEvent.TriggerPulse();

            if (logger != null)
                logger.LogMessage($"🔥 Instability triggered at {instability:F2} in realm: {targetRealm.realmName}");

            // Optional future triggers:
            // OpenPortal(); CreateCollapse(); ActivateTotaphysicalBeacon();
        }
        else if (instability <= instabilityThreshold)
        {
            isTriggered = false; // Reset if system stabilizes
        }
    }
}
