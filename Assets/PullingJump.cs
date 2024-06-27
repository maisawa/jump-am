using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{

    [SerializeField] int maxJumpCount = 2;
    int jumpCount = 0;

    [SerializeField] float groundAngleLimit = 30;
    [SerializeField] float jumpPower = 10f;
    Rigidbody rb;
    Vector3 clickPosition;

    bool canJump = false;
    AudioSource audio;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �h���b�O�J�n�ʒu�i�X�N���[����Ԃ̍��W�j��ۑ�����
            clickPosition = Input.mousePosition;
        }   // �}�E�X���{�^��(0)���v���X�i�����j���ꂽ���Ƃ����o����
        else if (canJump && Input.GetMouseButtonUp(0))
        {
            Debug.Log(jumpCount);
            if (jumpCount < maxJumpCount)
            {
                // �h���b�O�Ƌt�����̃x�N�g�����v�Z����
                Vector3 dragVector = clickPosition - Input.mousePosition;
                // �h���b�O�̃x�N�g���̋��������߂�
                float size = dragVector.magnitude;
                // �W�����v����
                rb.velocity = dragVector.normalized * jumpPower;
                jumpCount++;
                Debug.Log(jumpCount);
                audio.Play();
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // �Փ˖ʂ̊p�x�ɂ���ăW�����v�\�����肷��
        Vector3 normal = collision.contacts[0].normal;  // �@�����Ƃ��Ă���
        canJump = CanJump(normal);
    }


    bool CanJump(Vector3 normal)
    {
        float angle = Vector3.Angle(normal, Vector3.up);

        if (angle < groundAngleLimit)
        {
            Debug.Log("jumpCount �����Z�b�g����");
            jumpCount = 0;
            return true; // �W�����v�\
        }

        return false;
    }
}