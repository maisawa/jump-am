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
    /// �擾�A�j���[�V�����̍Đ����I�������Ăяo������
    /// �I�u�W�F�N�g��j�� (destroy) ����
    /// </summary>
    void OnGetAnimationFinished()
    {
        Debug.Log("�I�u�W�F�N�g��j�����܂�");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.Play();
        _anim.SetBool("IsGet", true);
        //_anim.Play("Get");
        //Debug.Log(other.name + " ���ڐG����");
        //Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
    }
}