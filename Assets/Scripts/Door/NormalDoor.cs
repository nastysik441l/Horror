
using UnityEngine;

public class NormalDoor : Door
{
    protected override void Open()
    {
        print("Normal");
              Message.gameObject.SetActive(true);
    }

   
     
}
