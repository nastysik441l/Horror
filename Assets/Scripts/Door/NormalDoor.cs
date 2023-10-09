
using UnityEngine;
using DG.Tweening;

public class NormalDoor : Door
{
    protected override void Open()
    {
        print("Normal");
        Sound.Play();
   Message.gameObject.SetActive(true);
        if(Input.GetKeyDown(KeyCode.E))
  DoorModel.transform.DORotate(new Vector3(0f,135f,0f),2);
  }

        private void OnTriggerExit(Collider collider)
        
        {  
            Message.gameObject.SetActive(false);
               DoorModel.transform.DORotate(Vector3.zero,1.5f);
        }
}
