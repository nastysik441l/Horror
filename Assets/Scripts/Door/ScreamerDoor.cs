
using UnityEngine;
using DG.Tweening;


public class ScreamerDoor : Door
{
     [SerializeField] private Player _player;

    [SerializeField] private Screamer _screamerTemplate;
[SerializeField] private RectTransform _gameOverScreen;

    protected override void Open()
    {
        print("Screamer");
           Sound.Play();
        Message.gameObject.SetActive(true);
        if(Input.GetKeyDown(KeyCode.E))
           {          DoorModel.transform.DORotate(new Vector3(0f,135f,0f),2);
_screamerTemplate.ScreamerAnimation();
_player.gameObject.SetActive(false);
_gameOverScreen.gameObject.SetActive(true);
}
            }
   
}
