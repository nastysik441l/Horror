using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    [SerializeField] private float _mouseSensitive;
  private   void Look()
    {
        var mouseY=Input.GetAxis("Mouse X");
        var rotationVector=new Vector3(0f,mouseY,0f) * _mouseSensitive*Time.deltaTime;
        transform.Rotate(rotationVector);
    }

    
  private  void Update()
    {
        Look();
    }
}
