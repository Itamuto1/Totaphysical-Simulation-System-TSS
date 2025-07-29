using UnityEngine;

public class RealmUIManager : MonoBehaviour
{
    public Realm linkedRealm;

    void Start()
    {
        if (linkedRealm != null)
        {
            Debug.Log("🌌 Realm Linked: " + linkedRealm.realmName);
            DisplayRealmStats();
        }
        else
        {
            Debug.LogWarning("⚠️ No Realm linked to UI Manager.");
        }
    }

    void DisplayRealmStats()
    {
        Debug.Log("📊 Totaphysical Status — " + linkedRealm.realmName);
        Debug.Log("🔁 Imoumikapo Flow: " + linkedRealm.imoumikapoFlow);
        Debug.Log("🔧 Gotomai Level: " + linkedRealm.gotomaiLevel);
        Debug.Log("🛡 Kaboo Stability: " + linkedRealm.kabooStability);
        Debug.Log("⚡ Instability Value: " + linkedRealm.CalculateInstability());
    }

    void Update()
    {
        if (linkedRealm != null)
            DisplayRealmStats();
    }
}
