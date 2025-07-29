using UnityEngine;
using UnityEngine.UI;

public class RealmEnergyUI : MonoBehaviour
{
    public Slider gotomaiBar;
    public Slider imoumikapoBar;
    public Slider kabooBar;

    public Realm linkedRealm;

    void Start()
    {
        if (linkedRealm == null)
        {
            linkedRealm = new Realm("VisualRealm", 0.5f, 0.3f, 0.2f);
        }
    }

    void Update()
    {
        if (linkedRealm != null)
        {
            gotomaiBar.value = linkedRealm.gotomaiLevel;
            imoumikapoBar.value = linkedRealm.imoumikapoFlow;
            kabooBar.value = linkedRealm.kabooStability;
        }
    }
}
