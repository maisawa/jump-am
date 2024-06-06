using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArrowDraw : MonoBehaviour
{
    [SerializeField] Image arrowImage;
    Vector3 clickPosition;
    void Start()
    {
        arrowImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        else if(Input.GetMouseButton(0))
        {
            Vector2 dragvector = clickPosition - Input.mousePosition;
            float size = dragvector.magnitude;
            float angleRad=Mathf.Atan2(dragvector.y, dragvector.x);
            arrowImage.rectTransform.position = clickPosition;
            arrowImage.rectTransform.rotation= Quaternion.Euler(0,0,angleRad*Mathf.Rad2Deg);
            arrowImage.rectTransform.sizeDelta=new Vector2(size,size);
        }
        else if(Input.GetMouseButtonUp(0)) {
            arrowImage.gameObject.SetActive(false);
        }
    }
}
