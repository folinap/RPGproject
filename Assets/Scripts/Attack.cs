using UnityEngine;
using UnityEngine.EventSystems;

public class Attack : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]private Animator _animator;

   
    public void OnPointerDown(PointerEventData eventData)
    {
        _animator.SetInteger("Attack", 1);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _animator.SetInteger("Attack", 0);
    }
}
