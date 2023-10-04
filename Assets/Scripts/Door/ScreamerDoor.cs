
using UnityEngine;

public class ScreamerDoor : Door
{
    protected override void Open()
    {
        print("Screamer");
        Message.gameObject.SetActive(true);
        
            }
   
}
