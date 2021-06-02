using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour
{
    [Tooltip("Script that defines how the Entity moves")]
    [SerializeField]
    Movement movement = null;

    [Tooltip("Script that defines how the Entity attacks")]
    [SerializeField]
    Attack attack = null;

    // Start is called before the first frame update
    void Start()
    {
        if (movement)
            movement.Update();

        if (attack)
            attack.Update();

    }
}
