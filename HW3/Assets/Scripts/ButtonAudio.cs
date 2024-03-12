using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class ButtonAudio : MonoBehaviour
{
    public AudioClip buttonSound;
    private AudioSource audioSource;

    void Start()
    {
        GetComponent<XRPushButton>().onPress.AddListener(() => ToggleButton());
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleButton()
    {
        audioSource.PlayOneShot(buttonSound);
    }
}
