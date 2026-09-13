// using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private InputActionReference moveAction;
    [SerializeField]
    private InputActionReference lookAction;

    [SerializeField]
    private CharacterMover characterMover;
    [SerializeField]
    private CameraLook cameraLook;
    private void OnEnable()
    {
        moveAction.action.Enable();
        lookAction.action.Enable();
        Debug.Log("MakeAction is enable");
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
        lookAction.action.Enable();
        Debug.Log("MakeAction is disable");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = moveAction.action.ReadValue<Vector3>();
        Vector2 lookInput = lookAction.action.ReadValue<Vector2>();

        // Debug.Log(input);
        characterMover.Move(input);
        cameraLook.Look(lookInput);
    }
}
