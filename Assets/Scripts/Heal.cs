using UnityEngine;
using UnityEngine.EventSystems;

public class Heal : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] private Health _health;
    [SerializeField] private Animator _animator;


    public void OnPointerDown(PointerEventData eventData)
    {
        _animator.SetBool("Heal", true);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _health.ChangeHealth(100);
        _animator.SetBool("Heal", false);
    }
}
