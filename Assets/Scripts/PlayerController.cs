using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public string inputID;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;

    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // Move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input.
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

        
    }
}
