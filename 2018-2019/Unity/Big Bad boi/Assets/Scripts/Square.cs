using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    [SerializeField]
    GameObject ballPrefab;
    float speed = 1f;

    Vector3 velocity = new Vector3(0, 0, 0);



    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
        MovementWASD();
        MoveTurns();
        float timer = 0;
        float timetoreach = 1f;
        {
            timer = Time.deltaTime;
            if (timer > timetoreach)
            {
                GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                timer = 0;
            }

        }
    }
    void MoveTurns()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
        velocity.Normalize();
        transform.position += velocity * Time.deltaTime * speed;
    }
    void MovementWASD()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < .9)
            {
                velocity += Vector3.up;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -.9)
            {
                velocity += Vector3.down;
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.7)
            {
                velocity += Vector3.left;
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.7)
            {
                velocity += Vector3.right;
            }

            velocity.Normalize();
            transform.position += velocity * Time.deltaTime * speed;

            velocity = new Vector3(0, 0, 0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject newBall = Instantiate(ballPrefab);

            }
        }

    }
    public Vector3 LookAtDirection(float eulerAngles2)
    {
        return new Vector3(Mathf.Cos(eulerAngles2 * Mathf.Deg2Rad), Mathf.Sin(eulerAngles2) * (Mathf.Deg2Rad), 0);
    }
    void ballshooter()
    {
        velocity.Normalize();
        transform.position += velocity * Time.deltaTime * speed;

        velocity = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBall = Instantiate(ballPrefab);
        }
    }



}








