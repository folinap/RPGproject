using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : EnemyState
{
    [SerializeField]private AttackState _attackState;
    [SerializeField]private Transform _player;
    [SerializeField]private Transform _enemy;
    [SerializeField]private Animator _enemyAnimator;
    
    private bool _isInAttackRange;
    private int _moveSpeed = 4;
    private int _minDist = 1;


    public override EnemyState RunCurrentState()
    {
        if (_isInAttackRange)
            return _attackState;
        else
        { 
            ChasePlayer();
            return this;
        }

    }

    public void ChasePlayer()
    {
        _enemy.transform.LookAt(_player);
        float distance = Vector3.Distance(_enemy.transform.position, _player.position);

        if (distance >= _minDist)
        {
            _enemyAnimator.SetFloat("Distance", distance);
            _enemy.transform.position += _enemy.transform.forward * _moveSpeed * Time.deltaTime;
        }
        else
        {
            _isInAttackRange = true;
        }
    }
}
