using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody body;
    public float force = 100f;
    public float l = 100f;
    public float speed = 10f;
    public float speed22 = 1f;
    public float max_z;
    public float min_z;

    void Update()
    {
        Vector3 playerpos = transform.position;
        playerpos.z = Mathf.Clamp(playerpos.z, min_z, max_z);
        transform.position = playerpos;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position - new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position - new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
        }
        //body.AddForce(l * Time.deltaTime, 0, 0);
    }

    /*private void FixedUpdate()
    {
        body.AddForce(l * Time.deltaTime, 0, 0);
    }*/
    public void FixedUpdate()
    {
        body.AddForce(force * Time.deltaTime, 0, 0);
    }
}