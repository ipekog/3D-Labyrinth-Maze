using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Started : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("Started");
    }
}
