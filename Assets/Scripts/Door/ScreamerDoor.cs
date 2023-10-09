
using UnityEngine;
using DG.Tweening;


public class ScreamerDoor : Door
{
     [SerializeField] private Player _player;

    [SerializeField] private Screamer _screamerTemplate;
    protected override void Open()
    {
        print("Screamer");
        Message.gameObject.SetActive(true);
        if(Input.GetKeyDown(KeyCode.E))
           {          DoorModel.transform.DORotate(new Vector3(0f,135f,0f),2);
_screamerTemplate.ScreamerAnimation();
_player.gameObject.SetActive(false);

}
            }
   
}
