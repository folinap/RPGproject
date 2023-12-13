using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField]private EnemyState _currentState;
    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        EnemyState nextState = _currentState?.RunCurrentState();
    
        if(nextState != null )
        {
            SwitchToTheNextState(nextState);
        }
    }

    private void SwitchToTheNextState(EnemyState nextState)
    {
        _currentState = nextState;
    }
}
