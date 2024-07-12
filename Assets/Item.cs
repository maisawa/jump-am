using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Animator _anim;
    AudioSource _audioSource;

    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    /// <summary>
    /// 取得アニメーションの再生が終わったら呼び出す処理
    /// オブジェクトを破棄 (destroy) する
    /// </summary>
    void OnGetAnimationFinished()
    {
        Debug.Log("オブジェクトを破棄します");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
        _anim.SetBool("IsGet", true);
        //_anim.Play("Get");
        //Debug.Log(other.name + " が接触した");
        //Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
    }
}