using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject character;
    Vector3 goalvector = new Vector3();
    float speed = 2f;
    float hspeed = 3f;
    float vspeed = 1.2f;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(character.transform.position.x, character.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        goalvector = new Vector3(character.transform.position.x, character.transform.position.y, -10);
        goalvector += new Vector3(character.GetComponent<Rigidbody2D>().velocity.x, character.GetComponent<Rigidbody2D>().velocity.y, 0);
        Vector3 velocity = goalvector - transform.position;

        transform.position += new Vector3(velocity.x * Time.deltaTime * hspeed, velocity.y * Time.deltaTime * vspeed, 0);
    }
}
