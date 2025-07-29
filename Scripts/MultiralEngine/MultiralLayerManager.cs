using UnityEngine;

public enum MultiralState
{
    Spiral,
    Linear,
    Chaos,
    Static,
    Unknown
}

public class MultiralLayerManager : MonoBehaviour
{
    public MultiralState currentState = MultiralState.Spiral;
    public float transitionTimer = 0f;
    public float transitionInterval = 10f;

    void Update()
    {
        transitionTimer += Time.deltaTime;

        if (transitionTimer >= transitionInterval)
        {
            TransitionToNextState();
            transitionTimer = 0f;
        }
    }

    void TransitionToNextState()
    {
        currentState = (MultiralStat
