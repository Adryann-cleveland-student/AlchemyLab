using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{

    CharacterController characterController;
    public float moveSpeed = 5f;

    private Vector3 moveDrirection;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDrirection.Normalize();
        moveDrirection.y = -1f;

        characterController.Move(moveDrirection * moveSpeed * Time.deltaTime);
    }

    public void AddMoveInput(float forwardInput, float rightInput)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f;
        right.x = 0f;

        forward.Normalize();
        right.Normalize();

         moveDrirection = (forwardInput * forward) + (rightInput * right);
    }
}
