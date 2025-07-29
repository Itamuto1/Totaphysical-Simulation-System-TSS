using UnityEngine;

[System.Serializable]
public class Realm
{
    public string realmName;
    public float gotomaiLevel;      // Totaphysical transformation force
    public float imoumikapoFlow;    // Continuity flow across dimensions
    public float kabooStability;    // Realm’s structural stability

    public Realm(string name, float gotomai, float imoumi, float kaboo)
    {
        realmName = name;
        gotomaiLevel = gotomai;
        imoumikapoFlow = imoumi;
        kabooStability = kaboo;
    }

    public float CalculateInstability()
    {
        float difference = Mathf.Abs(gotomaiLevel - imoumikapoFlow);
        float instability = difference / (kabooStability + 0.01f); // Avoid divide by zero
        return instability;
    }

    public bool IsUnstable()
    {
        return CalculateInstability() > 1.0f;
    }
}
