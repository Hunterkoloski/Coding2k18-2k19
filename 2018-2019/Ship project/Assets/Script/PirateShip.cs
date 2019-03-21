using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateShip : MonoBehaviour {

    public GameObject bullet;
	// Use this for initialization
	void Start ()
    {
      
	}
   
	// Update is called once per frame
	void Update ()
    {
        int speed = 10;
        Vector3 Velocity = new Vector3(0, 100, 0);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
    if (Input.GetKey(KeyCode.W) && transform.position.y <= 4.03)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -4.16)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 9.43)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -9.43)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(bullet, transform.position, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = Vector3.right * 13; 
        }
    }
}
