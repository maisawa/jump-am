using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name + " ���ڐG����");
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
    }
}