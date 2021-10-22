using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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
}


















/*
float RotationSpeed = 400f;
float cameraAngle = 0f;

Vector3 moveVelocity = Vector3.zero;
float WalkSpeed = 10f;

public void CameraMovement()
{
    if (!MoveControlEnabled)
        return;

    // horizontal character rotation
    transform.Rotate(new Vector3(0f, (input.GetLookInputHorizontal() * RotationSpeed * Time.deltaTime), 0f), Space.Self);

    // vertical camera rotation
    float cameraAngle += input.GetLookInputVertical() * RotationSpeed * Time.deltaTime;
    cameraAngle = Mathf.Clamp(cameraAngle, -89f, 89f);
    camera.transform.localEulerAngles = new Vector3(cameraAngle, 0, 0);
}


public void CharacterMovement()
{
    Vector3 moveInput = transform.TransformVector(input.GetMoveInput());

    // Simples
    Vector3 moveInput = transform.TransformVector(input.GetMoveInput());
    characterController.Move(moveInput * WalkSpeed * Time.deltaTime);

   // Rebuscado
    Vector3 moveInput = transform.TransformVector(m_InputHandler.GetMoveInput());
   Vector3 targetVelocity = moveInput * WalkSpeed;
   MoveVelocity = Vector3.Lerp(MoveVelocity, targetVelocity, WalkAcceleration * Time.deltaTime);
    m_Controller.Move(MoveVelocity * Time.deltaTime);
}
*/
