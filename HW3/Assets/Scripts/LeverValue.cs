using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class LeverValue : MonoBehaviour
{
    public Transform rightLever;
    public Transform leftLever;
    public Canvas firstCanvas;
    public Canvas secondCanvas;
    public Light[] pointLights;

    private bool currentLeftValue;
    private bool currentRightValue;
    public bool isLeversValid;

    void Start()
    {
        firstCanvas.gameObject.SetActive(false);
        secondCanvas.gameObject.SetActive(false);
        isLeversValid = false;
    }

    void Update()
    {
        currentLeftValue = leftLever.GetComponent<XRLever>().value;
        currentRightValue = rightLever.GetComponent<XRLever>().value;

        if (currentLeftValue == true ^ currentRightValue == true)
        {
            firstCanvas.gameObject.SetActive(true);
            secondCanvas.gameObject.SetActive(false);
            isLeversValid = false;
            foreach (Light pointLight in pointLights)
            {
                pointLight.enabled = true;
            }
        }
        else if (currentLeftValue == false && currentRightValue == false)
        {
            firstCanvas.gameObject.SetActive(false);
            secondCanvas.gameObject.SetActive(false);
            isLeversValid = false;
            foreach (Light pointLight in pointLights)
            {
                pointLight.enabled = true;
            }
        }
        else if (currentLeftValue == true && currentRightValue == true)
        {
            firstCanvas.gameObject.SetActive(false);
            secondCanvas.gameObject.SetActive(true);
            isLeversValid = true;
            foreach (Light pointLight in pointLights)
            {
                pointLight.enabled = false;
            }
        }
    }
}
