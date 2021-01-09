using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHero : MonoBehaviour
{

    public Rigidbody2D rbody;
    public float panSpeed = 20f;
    public float speed = 10.0f;
    public Vector2 movement;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
        rbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // movement = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        Vector3 pos = transform.position;
 
         if (Input.GetKey ("w") || Input.GetKey(KeyCode.UpArrow)) {
             pos.y += speed * Time.deltaTime;
         }
         if (Input.GetKey ("s") || Input.GetKey(KeyCode.DownArrow)) {
             pos.y -= speed * Time.deltaTime;
         }
         if (Input.GetKey ("d") || Input.GetKey(KeyCode.RightArrow)) {
             pos.x += speed * Time.deltaTime;
         }
         if (Input.GetKey ("a") || Input.GetKey(KeyCode.LeftArrow)) {
             pos.x -= speed * Time.deltaTime;
         }
             
 
         transform.position = pos;

    }

    void FixedUpdate()
    {
        MoveCharacter(movement);
    }
    void MoveCharacter(Vector2 direction)
    {
        rbody.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));

    }
}
