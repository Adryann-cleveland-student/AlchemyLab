using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    FirstPerson firstPerson;
    Movement movement;
    PlayerInteraction playerInteraction;
    // Start is called before the first frame update
    void Start()
    {
        firstPerson = GetComponent<FirstPerson>();
        movement = GetComponent<Movement>();
        playerInteraction = GetComponent<PlayerInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        HandleMoveInput();
        HandleInteractionInput();
    }

    void HandleCameraInput()
    {
        firstPerson.AddXAxisInput(Input.GetAxis("Mouse Y")* Time.deltaTime);
        firstPerson.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }

    void HandleMoveInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

        movement.AddMoveInput(forwardInput, rightInput);
    }
    void HandleInteractionInput()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        { 
        playerInteraction.TryInteract();
        }
    }
}
