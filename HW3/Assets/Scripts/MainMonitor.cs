using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class MainMonitor : MonoBehaviour
{
    public Transform levers;
    public Transform dial;
    public Canvas firstCanva;
    public Canvas secondCanva;
    public Canvas thirdCanva;
    public Canvas fourthCanva;
    private bool dialValue;
    private bool leversValue;


    void Start()
    {
        firstCanva.gameObject.SetActive(true);
        secondCanva.gameObject.SetActive(false);
        thirdCanva.gameObject.SetActive(false);
        fourthCanva.gameObject.SetActive(false);
    }

    void Update()
    {
        dialValue = dial.GetComponent<KnobValue>().isKnobValid;
        leversValue = levers.GetComponent<LeverValue>().isLeversValid;

        if (dialValue == false && leversValue == false)
        {
            firstCanva.gameObject.SetActive(true);
            secondCanva.gameObject.SetActive(false);
            thirdCanva.gameObject.SetActive(false);
            fourthCanva.gameObject.SetActive(false);
        }
        else if (dialValue == true && leversValue == false)
        {
            firstCanva.gameObject.SetActive(false);
            secondCanva.gameObject.SetActive(true);
            thirdCanva.gameObject.SetActive(false);
            fourthCanva.gameObject.SetActive(false);
        }
        else if (dialValue == false && leversValue == true)
        {
            firstCanva.gameObject.SetActive(false);
            secondCanva.gameObject.SetActive(false);
            thirdCanva.gameObject.SetActive(true);
            fourthCanva.gameObject.SetActive(false);
        }
        else if (dialValue == true && leversValue == true)
        {
            firstCanva.gameObject.SetActive(false);
            secondCanva.gameObject.SetActive(false);
            thirdCanva.gameObject.SetActive(false);
            fourthCanva.gameObject.SetActive(true);
        }
    }
}
