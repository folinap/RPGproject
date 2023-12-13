using System.Collections;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]private Animator _animator;
    private float  animExitTime = 0.75f;
    int attackCount = 0;

    
    public void ComboAttack()
    {
        if (!IsAnimationPlaying("Attack State.Third Attack"))
        {
            _animator.SetInteger("Attack", ++attackCount);
            Debug.Log(attackCount);
        }
    }
    public void AttackCoolDow() 
    {
        StopAllCoroutines();
        StartCoroutine(AttackCoolDown());
    }
    private IEnumerator AttackCoolDown()
    {
        yield return new WaitForSeconds(animExitTime);
        _animator.SetInteger("Attack", 0);
        attackCount = 0;
        
    }
    public bool IsAnimationPlaying(string animationName)
    {
        var animatorStateInfo = _animator.GetCurrentAnimatorStateInfo(0);
        if (animatorStateInfo.IsName(animationName))
            return true;

        return false;
    }
}
