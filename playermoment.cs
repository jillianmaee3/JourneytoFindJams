using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoment : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    Vector2 movement;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void OnMovement()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        movement.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }
        if (movement.x > 0)
        {
            body.transform.localScale = new Vector3(0.4626735f, 0.4683398f, 1);
        }
        if (movement.x < 0)
        {
            body.transform.localScale = new Vector3(-0.4626735f, 0.4683398f, 1);
        }
    }
}