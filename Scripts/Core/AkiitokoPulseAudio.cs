using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AkiitokoPulseAudio : MonoBehaviour
{
    public AudioClip pulseClip;
    public float minPitch = 0.9f;
    public float maxPitch = 1.2f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    public void TriggerAkiitokoPulse()
    {
        if (pulseClip != null)
        {
            audioSource.pitch = Random.Range(minPitch, maxPitch);
            audioSource.PlayOneShot(pulseClip);
        }
    }
}
``
