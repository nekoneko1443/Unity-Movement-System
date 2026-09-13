using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 0.1f;

    private float pitch = 0.0f;

    public void Look(Vector2 input)
    {
        float mouseX = input.x * sensitivity;
        float mouseY = input.y * sensitivity;

        transform.Rotate(Vector3.up * mouseX);

        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -89.0f, 89.0f);

        transform.localEulerAngles = new Vector3(pitch, transform.localEulerAngles.y, 0.0f);
    }
}
