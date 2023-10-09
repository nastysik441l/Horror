
using UnityEngine;
using TMPro;

public abstract class Door : MonoBehaviour
{
    protected abstract void Open();

  [SerializeField] protected TMP_Text Message;

[SerializeField] protected Transform DoorModel;
[SerializeField] protected AudioSource DoorOpenSound;

 private void OnTriggerStay(Collider collider)
    =>Open();
    







}
