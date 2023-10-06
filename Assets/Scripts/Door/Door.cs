using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Door : MonoBehaviour
{
    protected abstract void Open();

  [SerializeField] protected TMP_Text Message;

[SerializeField] protected Transform DoorModel;

 private void OnTriggerStay(Collider collider)
    =>Open();
    







}
