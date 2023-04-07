using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public KeyCode leftKey;
    public KeyCode rightKey;

    public float bounds = 6f;

    private float speed = 3.5f; // For floats, add the f at the end
    private float baseSpeed = 3.5f;
    private float accel = 1/4f;
    private float maxSpeed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(leftKey) && transform.position.x > -bounds) {
            ProcessAccel();
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(rightKey) && transform.position.x < bounds) { 
            ProcessAccel();
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        // When button is RELEASED, resest the speed to base value
        if (Input.GetKeyUp(leftKey) || Input.GetKeyUp(rightKey)) {
            speed = baseSpeed;
        }
    }

    void ProcessAccel() {
        speed += accel;
        if (speed > maxSpeed) {
            speed = maxSpeed;
        }
    }
}
