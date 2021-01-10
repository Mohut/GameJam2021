using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector2 movementSpeed;
    [SerializeField] private Sprite sprite;
    private Rigidbody2D body;
    private GameObject viewArea;
    private float time;
    [SerializeField] private SpriteRenderer spriteToDelete;
    [SerializeField] private bool convinced;
    private string key = "convinced";
    [SerializeField] private bool enemyConvinced;
    [SerializeField] private GameObject player;
    [SerializeField] private Collider2D m_Collider;
    [SerializeField] private AudioSource audioSource;
    private bool isPlaying;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        time = 2;
        convinced = false;
        m_Collider = GetComponent<Collider2D>();
        player = GameObject.FindWithTag("Player");
        isPlaying = false;
        audioSource.volume = 0.3f;
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

    private void Convinced()
    {
        if (convinced)
        {
            player.GetComponent<moveHero>().score++;
            convinced = false;
            PlayerPrefs.SetInt(key, player.GetComponent<moveHero>().score);
            Debug.Log(PlayerPrefs.GetInt(key));
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            time -= Time.deltaTime;
            if (!isPlaying)
            {
                audioSource.Play();
                isPlaying = true;
            }
            
        }

        if (time <= 0)
        {
            GetComponent<SpriteRenderer>().sprite = sprite;
            spriteToDelete.enabled = false;
            convinced = true;
            body.rotation = 0;
            m_Collider.enabled = false;
            Convinced();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        audioSource.Stop();
        isPlaying = false;
    }

    private void BorderHit()
    {
        movementSpeed = -movementSpeed;
        if(!convinced)
        body.rotation += 180;
    }
}
