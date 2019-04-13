using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    //public float speed = 5f;

    public GameObject Bat1;
    public GameObject Bat2;
    public float speed_1 = 10f;
    public float speed_2 = 10f;
    public float acceleration = 2f;

    public AudioSource ballAudioScource;
    public AudioClip bleep;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Bat1 = GameObject.Find("Bat_1");
        Bat2 = GameObject.Find("Bat_2");
        StartCoroutine(Pause());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 17f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
            acceleration = 1f;
        }

        if (this.transform.position.x <= -17f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
            acceleration = 1f;
        }

    }
     IEnumerator Pause ()
    {
        int directionY = Random.Range(-1, 2);
        int directionX = Random.Range(-1, 2);

        if (directionX == 0)
        {
            directionX = 1;
        }

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2(speed_1 * directionX, speed_1 * directionY);
       
    }

    void OnCollisionEnter2D (Collision2D hit)
    {
        if(hit.gameObject.name == "Bat_1")
        {
            if (Bat1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(speed_1 * acceleration, 15f);

            }
            else if (Bat1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(speed_1 * acceleration, -15f);
            }
            else 
            {
                rb.velocity = new Vector2(speed_2 * acceleration, 0f );
            }
            acceleration += 0.2f;

        }

        if (hit.gameObject.name == "Bat_2")
        {
            if (Bat2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-speed_1 * acceleration, 15f);
            }
            else if (Bat2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-speed_1 * acceleration, -15f);
            }
            else 
            {
                rb.velocity = new Vector2(-speed_2 * acceleration, 0f);
            }
            acceleration += 0.2f;
        }
        ballAudioScource.PlayOneShot(bleep);

    }

    //void OnCollisionEnter2D(Collision2D collisionIn)
    //{
    //    ballAudioScource.PlayOneShot(bleep);
    //}
    //void Awake()
    //{

    //    source = GetComponent<Sound1>();
    //}

    //void OnCollisionEnter(Collision collisionInfo)
    //{
    //    if (collisionInfo.collider.tag == "Bat")
    //    {
    //        Debug.Log("Hallo");
    //    }
    //}
}
