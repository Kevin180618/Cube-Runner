using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playerscript kp;
    public score lion;
    public gamecontroller gmc;
    public gamecontroller wmc;
    public AudioSource cubecollect;
    public AudioSource gmo;
    public AudioSource winnn;
    
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="collectable")
            {
            cubecollect.Play();
                lion.addscore(1);
                Destroy(other.gameObject);
            }
        if (other.gameObject.tag == "win")
        {
            winnn.Play();
            wmc.win();
            Destroy(other.gameObject);
            kp.enabled = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="obstacles")
        {
            gmo.Play();
            gmc.gameover();
            kp.enabled = false;
        }
        

    }



}
