using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Behaviour
{
    [Tooltip("The Current Focus of the Entity")]
    [SerializeField]
    protected GameObject target = null;

    [Tooltip("The Previous Focus of the Entity")]
    [SerializeField]
    protected GameObject oldTarget = null;

    public void Start()
    {
    }

    public void Update()
    {
    }
}
