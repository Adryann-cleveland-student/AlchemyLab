
using UnityEngine;
using UnityEngine.Events;

public class InteractObjects : MonoBehaviour
{
   [SerializeField] private string interactionText = "Im an interactable object";

    public UnityEvent OnInteract = new UnityEvent();

     private void OnEnable()
    {
        
    }
    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
        OnInteract.Invoke();
    }
     
}
