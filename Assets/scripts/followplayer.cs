using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform follow;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camerapos = transform.position;
        camerapos.x = follow.position.x + offset;
        transform.position = camerapos; 
    }
}
