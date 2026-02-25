using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprovedPlayerController : MonoBehaviour
{

    [Header("Character Attributes")]
    public float walkSpeed = 2;
    public float runSpeed = 6;
    public float gravity = -12;
    public float jumpHeight = 1;
    [Range(0, 1)]
    public float airControlPercent = 1;

    [Header("Smoothen's The Turn Rotation")]
    [Range(0, 0.2f)]
    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    [Header("Extra Control (Usually Fine at 0 Though)")]
    public float speedSmoothTime = 0.1f;
    float speedSmoothVelocity;
    public float currentSpeed;
    float velocityY;

    Transform cameraT;
    CharacterController controller;

    [Header("Character Movement Check")]
    public bool isMoving;
    public bool isMovingLateral;

    [Header("Camera Setting")]
    public bool bUseCameraControlRotation; // makes it so the rotation of the capsule follows the camera, Turning it off will make it so you can rotate with your camera without your character turning too.

    [Header("PlayerAnimator")]
    public PlayerAnimator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
