using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationConponent : MonoBehaviour
{

    Animator _anim;
    void Start()
    {
        _anim=GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            _anim.Play("Idle");
        }
        if(Input.GetKeyDown(KeyCode.B)) {
            _anim.Play("Get");
        }
    }
}
