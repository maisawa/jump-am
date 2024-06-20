using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationConponent : MonoBehaviour
{
    // Start is called before the first frame update

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
