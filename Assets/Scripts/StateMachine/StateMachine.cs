using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    private State _curState;
    private bool isSwitching;

    private void Update()
    {
        if(isSwitching) return;
        _curState?.Tick(Time.deltaTime);
    }

    public void SwitchState(State newState)
    {
        if (isSwitching) return;
        isSwitching = true;

        _curState?.Exit();
        _curState = newState;
        _curState?.Enter();

        isSwitching = false;
    }
}
