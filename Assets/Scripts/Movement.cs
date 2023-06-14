using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.HID;

[SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
public class Movement : MonoBehaviour
{
    private PlayerControl controls;
    private CharacterController characterController;
    public GameObject avatar;

    [Range(0.5f, 1000f)]
    public float moveSpeed = 20f;
    [Range(0.5f, 1000f)]
    public float rotationSpeed = 25f;

    public float gravity = 9.81f;
    private void Awake()
    {
        characterController = avatar.GetComponent<CharacterController>();
        controls = new PlayerControl();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(controls.HeadsetPlayer.move.ReadValue<Vector2>());
        Debug.Log(controls.DesktopPlayer.move.ReadValue<Vector2>());
        HeadsetMove();
        KeyboardMove();
    }

    private void OnEnable()
    {
        controls.HeadsetPlayer.Enable();
        controls.DesktopPlayer.Enable();
    }

    private void OnDisable()
    {
        controls.HeadsetPlayer.Disable();
        controls.DesktopPlayer.Disable();
    }

    private void HeadsetMove()
    {
        Vector2 input = controls.HeadsetPlayer.move.ReadValue<Vector2>();
        Vector3 movement;

        if (input.x > 0.2)
        {
            movement = -(avatar.transform.forward);
            characterController.Move(movement * (moveSpeed * (input.x * 100) * Time.deltaTime));
        }
        
        if (input.x < -0.2)
        {
            movement = (avatar.transform.forward);
            characterController.Move(movement * (moveSpeed * (input.x * -100) * Time.deltaTime));
        }
        
        if (input.y > 0.2)
        {
            var multiplier = input.y * 20;
            avatar.transform.Rotate(Vector3.up * (rotationSpeed * multiplier * Time.deltaTime * 1));
        }
        
        if (input.y < -0.2)
        {
            var multiplier = input.y * 20;
            avatar.transform.Rotate(Vector3.down * (rotationSpeed * multiplier * Time.deltaTime * -1));
        }

        gravity = characterController.isGrounded ? 0f : 9.81f;
        gravity -= (float)gravity * Time.deltaTime;
        characterController.Move(Vector3.down * gravity);
    }

    private void KeyboardMove()
    {
        Vector2 input = controls.DesktopPlayer.move.ReadValue<Vector2>();
        Vector3 movement = (input.y * avatar.transform.forward) + (input.x * avatar.transform.right);
        characterController.Move((movement * (moveSpeed * 20 * Time.deltaTime)));
        
        gravity = characterController.isGrounded ? 0f : 9.81f;
        gravity -= (float)gravity * Time.deltaTime;
        characterController.Move(Vector3.down * gravity);
    }
}
