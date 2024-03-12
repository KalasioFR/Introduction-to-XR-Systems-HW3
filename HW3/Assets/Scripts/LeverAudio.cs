using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class LeverAudio : MonoBehaviour
{
    public AudioClip leverSound;
    private AudioSource audioSource;

    void Start()
    {
        GetComponent<XRLever>().onLeverActivate.AddListener(() => ToggleLever());
        GetComponent<XRLever>().onLeverDeactivate.AddListener(() => ToggleLever());
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleLever()
    {
        audioSource.PlayOneShot(leverSound);
    }
}
