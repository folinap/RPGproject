using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : EnemyState
{
    [SerializeField] private ChaseState _chaseState;

    public override EnemyState RunCurrentState()
    {
        _chaseState.ChasePlayer();
        return this;
    }


}

