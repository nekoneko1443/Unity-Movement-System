using UnityEngine;

public class CharacterMover : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 5.0f;
    [SerializeField]
    private Transform cameraTransform;

    public void Move(Vector3 direction)
    {
        direction = Vector3.ClampMagnitude(direction, 1.0f);

        // transform.position += direction * moveSpeed * Time.deltaTime;
        Vector3 forward = cameraTransform.forward;

        forward.y = 0.0f;
        forward.Normalize();

        Vector3 right = cameraTransform.right;
        right.y = 0.0f;
        right.Normalize();

        Vector3 movement = right * direction.x + Vector3.up * direction.y + forward * direction.z;

        transform.position += movement * moveSpeed * Time.deltaTime;

    }
}
