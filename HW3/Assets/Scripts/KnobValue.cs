using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class KnobValue : MonoBehaviour
{
    public Canvas knobCanva;
    private float currentValue;
    public bool isKnobValid;

    void Start()
    {
        knobCanva.gameObject.SetActive(false);
        isKnobValid = false;
    }

    void Update()
    {
        currentValue = GetComponent<XRKnob>().value;

        if (currentValue >= 0.9f)
        {
            knobCanva.gameObject.SetActive(true);
            isKnobValid = true;
        }
        else if (currentValue < 0.9f)
        {
            knobCanva.gameObject.SetActive(false);
            isKnobValid = false;
        }
    }
}
