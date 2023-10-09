using UnityEngine;
using DG.Tweening;

public class Screamer : MonoBehaviour
{
   [SerializeField] private Transform _screamerPoint;

[SerializeField] private float _timeToScream;

public void ScreamerAnimation()
{
gameObject.SetActive(true);
    transform.DOMove(_screamerPoint.position,_timeToScream);
    transform.DOScale(Vector3.one,_timeToScream);
}
}
