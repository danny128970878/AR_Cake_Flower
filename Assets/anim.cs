using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour {
    public GameObject f;
    public Animator ani;
    // Use this for initialization
    void Start () {
        //ani = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            f.SetActive(true);
            ani.SetBool("next", true);
        }
	}
}
