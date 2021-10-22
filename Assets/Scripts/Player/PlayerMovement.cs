using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
}




































/*
// References
    Camera camera;
    CharacterController characterController;
    PlayerInput input;

    Vector3 horizontalRotation = Vector3.zero;
    Vector3 verticalRotation = Vector3.zero;

    [SerializeField]
    float RotationSpeed = 400f;

    [SerializeField]
    float WalkSpeed = 10f;

    [SerializeField]
    bool VerticalInverted = false;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        characterController = GetComponent<CharacterController>();
        camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RotationalMovement();
        TranslationalMovement();
    }

    void RotationalMovement()
    {
        // Horizontal
        horizontalRotation.y = input.GetLookInputHorizontal();
        transform.Rotate(horizontalRotation * RotationSpeed * Time.deltaTime, Space.Self);

        // Vertical
        verticalRotation.x += (VerticalInverted ? 1 : -1) * input.GetLookInputVertical() * RotationSpeed * Time.deltaTime;
        verticalRotation.x = Mathf.Clamp(verticalRotation.x, -89f, 89f);
        camera.transform.localEulerAngles = verticalRotation;

    }

    void TranslationalMovement()
    {
        Vector3 moveInput = transform.TransformVector(input.GetMoveInput());
        characterController.Move(moveInput * WalkSpeed * Time.deltaTime);
    }
*/
