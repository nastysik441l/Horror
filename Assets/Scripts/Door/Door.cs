using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Door : MonoBehaviour
{
    protected abstract void Open();

  [SerializeField] protected TMP_Text Message;



 private void OnTriggerStay(Collider collider)
    =>Open();
    







}
