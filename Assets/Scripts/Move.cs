using UnityEngine;
using DG.Tweening;


public class Move : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;

    private float _movingDuration = 5f;

    private void Start()
    {
        transform.DOMove(_targetPoint.position, _movingDuration).SetLoops(-1,LoopType.Yoyo);
    }
}
