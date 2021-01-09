using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector2 movementSpeed;
    private Rigidbody2D body;
    private GameObject viewArea;
    private BoxCollider2D collider;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        body.velocity = movementSpeed;
    }
    
    //checks collision and inverts the movementSpeed variable so the person moves in the opposite direction
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Border"))
        {
            BorderHit();
        }
    }

    private void BorderHit()
    {
        movementSpeed = -movementSpeed;
        //transform.localPosition = -transform.localPosition;
       
       
        body.rotation += 180;

    }
}
