using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector2 movementSpeed;
    [SerializeField] private Sprite sprite;
    private Rigidbody2D body;
    private GameObject viewArea;
    private float time;
    [SerializeField] private SpriteRenderer spriteToDelete;
    private bool convinced;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        time = 2;
        convinced = false;
    }

    void Update()
    {
        body.velocity = movementSpeed;
    }
    
    //checks collision and inverts the movementSpeed variable so the person moves in the opposite direction
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Border"))
        {
            BorderHit();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            time -= Time.deltaTime;
        }

        if (time <= 0)
        {
            GetComponent<SpriteRenderer>().sprite = sprite;
            spriteToDelete.enabled = false;
            convinced = true;
            body.rotation = 0;
            FindObjectOfType<moveHero>().convinced++;
        }
    }

    private void BorderHit()
    {
        movementSpeed = -movementSpeed;
        if(!convinced)
        body.rotation += 180;
    }
}
