using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBehaviourScript : MonoBehaviour
{
    [SerializeField] private Color myColor;

    // Start is called before the first frame update
    void Start()
    {
        UpdateColor();
    }

    void OnValidate()
    {
        UpdateColor();
    }

    private void UpdateColor()
    {
        GetComponent<Renderer>().material.color = myColor;
    }
}
