using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    Animator _anim;

    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
            _anim.Play("Idle");

        if (Input.GetKeyDown(KeyCode.B))
            _anim.Play("Get");
    }

    void Test01()
    {

    }
}