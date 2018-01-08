using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tack : MonoBehaviour {

    //public GameObject sp;
    //public ParticleSystem system;
    public Transform enemy1;
    public GameObject enemy2;
    public float Walkdistance = 10;
    public AudioSource a;

    // Use this for initialization
    void Start () {
        // system.Stop();
        a.Stop();

    }
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(this.transform.position, enemy1.transform.position);

        if (distance <= Walkdistance)
        {
            //  system.Play();
            enemy2.SetActive(true);
            a.Play();
        }
    }
}
