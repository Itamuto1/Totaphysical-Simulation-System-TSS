using UnityEngine;

public enum MultiralState
{
    Spiral,
    Linear,
    Chaos,
    Static,
    Unknown
}

public class MultiralLogicSwitcher : MonoBehaviour
{
    public Realm realm;
    public MultiralState currentState = MultiralState.Spiral;

    public float chaosMagnitude = 0.2f; // how wild the chaos jumps
    private float timeCounter = 0f;
    private float switchInterval = 10f;

    void Update()
    {
        timeCounter += Time.deltaTime;

        if (timeCounter >= switchInterval)
        {
            AdvanceMultiralState();
            timeCounter = 0f;
        }

        ApplyMultiralEffects();
    }

    void AdvanceMultiralState()
    {
        currentState = (MultiralState)(((int)currentState + 1) % System.Enum.GetValues(typeof(MultiralState)).Length);
        Debug.Log($"🌐 Multiral state changed to: {currentState}");
    }

    void ApplyMultiralEffects()
    {
        switch (currentState)
        {
            case MultiralState.Spiral:
                realm.imoumikapoFlow += 0.001f * Time.deltaTime;
                realm.gotomaiLevel = Mathf.PingPong(Time.time * 0.05f, 0.4f);
                break;

            case MultiralState.Linear:
                realm.gotomaiLevel += 0.005f * Time.deltaTime;
                break;

            case MultiralState.Chaos:
                realm.kabooStability = Random.Range(0f, chaosMagnitude);
                realm.imoumikapoFlow = Random.Range(0f, 1f);
                break;

            case MultiralState.Static:
                // Freeze realm values
                realm.gotomaiLevel = 0.1f;
                realm.kabooStability = 0.3f;
                break;

            case MultiralState.Unknown:
                // Add your own mysterious behavior here
                realm.gotomaiLevel = Mathf.PerlinNoise(Time.time, 0f);
                break;
        }
    }
}
