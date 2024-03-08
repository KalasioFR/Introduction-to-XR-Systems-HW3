using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class OnOpen : MonoBehaviour
{
    public Animator animator;
    public string boolName = "Open";
    
    void Start()
    {
        GetComponent<XRPushButton>().onPress.AddListener(() => ToggleDoorOpen());
    }

    public void ToggleDoorOpen()
   {
        bool isOpen = animator.GetBool(boolName);
        animator.SetBool(boolName, !isOpen);
   } 
}
