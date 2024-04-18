
using UnityEngine;

public class InteractObjects : MonoBehaviour
{
   [SerializeField] private string interactionText = "Im an interactable object";

    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
        print("ive been interacted with!");
    }
}
