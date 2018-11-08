using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public List<Vector3> teleportlocations = new List<Vector3>();
    float jump = 4;
    float speed = 2;

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        velocity = rbody.velocity;
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity += Vector3.up * jump;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime) * 5, velocity.y, 0);
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f), 0);
    }

    public void onclickteleportbutton()
    {
        transform.position = teleportlocations[Random.Range(0, teleportlocations.Count)];
    }
}
