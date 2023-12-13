using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : EnemyState
{
    [SerializeField]private ChaseState _chaseState;
    [SerializeField]private bool _canSeeThePlayer;
    public override EnemyState RunCurrentState()
    {
        if (_canSeeThePlayer)
            return _chaseState;
        else
            return this;
    }
}
