using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Follow : Movement
{
    [Range(0, 10)]
    [TooltipAttribute("This variable will set the speed of the movement")]
    [SerializeField]
    float speed = 3.5f;

    [Range(0, 10)]
    [TooltipAttribute("This variable will set from which distance does the enemy follow the player")]
    [SerializeField]
    float distance = 3f;
    
    // Start is called before the first frame update
    public new void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    public new void Update()
    {        
        if (Vector2.Distance(transform.position, target.transform.position) > distance)           //if the distance is greater than the variable given the condition will be trigered
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }
}
