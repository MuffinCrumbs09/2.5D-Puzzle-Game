using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    #region Scripts
    [field: SerializeField] public InputReader _ir { get; private set; }
    #endregion

    #region Components
    [field: SerializeField] public CharacterController _cc { get; private set; }
    [field: SerializeField] public Camera _cam { get; private set; }
    #endregion

    #region Movement
    [field: SerializeField] public float walkSpeed {  get; private set; }
    [field: SerializeField] public float runSpeed {  get; private set; }
    #endregion
    private void Start()
    {
        SwitchState(new PlayerIdleState(this));
    }
}
