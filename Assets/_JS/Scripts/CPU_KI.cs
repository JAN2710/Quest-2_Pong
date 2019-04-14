using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU_KI : MonoBehaviour
{
    public Transform ball;
    public float ballPosY;
    public Transform cpuGegener;
    public Rigidbody2D cpuRB;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball").transform;
        cpuGegener = gameObject.transform;
        cpuRB = gameObject.GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        ballPosY = ball.position.y;


        if (ballPosY > cpuGegener.position.y + 0.2)
        {
            print("CPU nach unten");
            cpuRB.velocity = new Vector2 (0, speed);
        }
        else if (ballPosY < cpuGegener.position.y - 0.2)
        {
            print("CPU nach oben");
            cpuRB.velocity = new Vector2 (0, -speed);
        }
        else
            cpuRB.velocity = new Vector2 (0, 0);

    }
}
