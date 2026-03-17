using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 20f;
    public float maxTilt = 15f;

    private float tiltX = 0f;
    private float tiltZ = 0f;

    void Update()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.Z)) x = 1f;
        if (Input.GetKey(KeyCode.S)) x = -1f;
        if (Input.GetKey(KeyCode.Q)) z = 1f;
        if (Input.GetKey(KeyCode.D)) z = -1f;

        tiltX += x * rotationSpeed * Time.deltaTime;
        tiltZ += z * rotationSpeed * Time.deltaTime;

        tiltX = Mathf.Clamp(tiltX, -maxTilt, maxTilt);
        tiltZ = Mathf.Clamp(tiltZ, -maxTilt, maxTilt);

        transform.rotation = Quaternion.Euler(tiltX, 0f, tiltZ);
    }
}