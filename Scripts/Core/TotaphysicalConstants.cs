using UnityEngine;

public static class TotaphysicalConstants
{
    // Micro-capacity value of Imoumikapo (continuity energy)
    public const float ImoumikapoInitial = 0.00009f; // 0.009%
    public const float ImoumikapoMaximum = 0.01f;     // 1.0%

    // Gotomai constant — transformation threshold
    public const float GotomaiBase = 0.5f;
    public const float GotomaiCritical = 0.9f;

    // Kaboo — foundational stability constant
    public const float KabooStable = 0.3f;
    public const float KabooWeak = 0.1f;

    // Akiitoko field pulse threshold
    public const float AkiitokoPulseThreshold = 1.0f;

    // Transition time for Multiral layers
    public const float MultiralTransi
