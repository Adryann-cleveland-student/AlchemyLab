using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float maxDistance = 2f;
   
    [SerializeField] private Text interactableDescription;

    private Text interactableName;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 orgin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string objectName ="";

        if (Physics.Raycast(orgin, direction, out raycastHit, maxDistance))
        {
             objectName = raycastHit.collider.gameObject.name;
      
        }
        SetInteractableNameText(objectName);
    }
    private void SetInteractableNameText(string newText)
    {
        if(interactableName)
        {
            interactableName.text = newText;
        }
    }
}
