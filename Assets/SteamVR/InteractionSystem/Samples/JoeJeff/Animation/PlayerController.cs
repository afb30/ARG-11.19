using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space")){
		anim.SetBool("isFalling",true);
	}else{
		anim.SetBool("isFalling",false);
	}
    }
}
