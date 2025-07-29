using UnityEngine;

public class SimulationStarter : MonoBehaviour
{
    public AkiitokoFieldManager fieldManager;

    void Start()
    {
        Realm myRealm = new Realm("Iyakapo", 0.55f, 0.31f, 0.20f);
        Debug.Log("🌍 Starting simulation for realm: " + myRealm.realmName);

        // Assign realm to field manager
        if (fieldManager != null)
        {
            fieldManager.currentRealm = myRealm;
            Debug.Log("✅ Akiitoko Field is monitoring: " + myRealm.realmName);
        }
        else
        {
            Debug.LogWarning("⚠️ No field manager assigned!");
        }
    }
}
