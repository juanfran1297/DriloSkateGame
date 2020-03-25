using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 12.0f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Input
        if(Input.GetButtonDown("Fire1"))
        {

        }
    }

    void FixedUpdate()
    {
        //Movement
        rb.velocity = new Vector2(speed, 0f);
    }
}
