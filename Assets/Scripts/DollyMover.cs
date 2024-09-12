using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyMover : MonoBehaviour
{

    public CinemachineDollyCart cart;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(Input.GetKey(KeyCode.S))
            {
                cart.m_Position += .01f;
            }

            if (Input.GetKey(KeyCode.W))
            {
                cart.m_Position -= .01f;
            }
        }
    }
}
