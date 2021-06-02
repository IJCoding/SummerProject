using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : Behaviour
{
    [Tooltip("The Current Focus of the Entity")]
    [SerializeField]
    protected GameObject target;

    [Tooltip("The Previous Focus of the Entity")]
    [SerializeField]
    protected GameObject oldTarget;

    public void Start()
    {
        
    }

    public void Update()
    {
        
    }
}
