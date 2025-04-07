using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBall : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // Se llama antes de que empiece el primer frame
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Se llama una vez por cada frame fijo de física
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical   = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Se multiplica también por Time.fixedDeltaTime para un movimiento más suave
        rb.AddForce(movement * ( speed * Time.fixedDeltaTime) );
    }
}