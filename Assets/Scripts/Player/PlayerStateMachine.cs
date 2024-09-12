using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    #region Scripts
    [field: SerializeField] public InputReader _ir { get; private set; }
    #endregion

    #region Components
    [field: SerializeField] public Rigidbody _rb { get; private set; }
    [field: SerializeField] public Camera _cam { get; private set; }
    #endregion

    #region Movement
    [field: SerializeField] public float walkSpeed {  get; private set; }
    [field: SerializeField] public float runSpeed {  get; private set; }
    [field: SerializeField] public float jumpForce {  get; private set; }
    private bool isGrounded;
    #endregion
    private void Start()
    {
        SwitchState(new PlayerIdleState(this));
    }

    private void Jump()
    {
        if(isGrounded)
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
            isGrounded = false;
    }

    private void OnEnable()
    {
        _ir.JumpEvent += Jump;
    }
    private void OnDisable()
    {
        _ir.JumpEvent -= Jump;
    }
}
