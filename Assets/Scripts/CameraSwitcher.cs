using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject toToggle;
    public bool toggle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            toToggle.SetActive(toggle);
    }
}
