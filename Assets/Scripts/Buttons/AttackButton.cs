using UnityEngine;
using UnityEngine.EventSystems;

public class AttackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Attack _attack;
    public void OnPointerDown(PointerEventData eventData)
    {
        _attack.ComboAttack();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _attack.AttackCoolDow();
    }
}
