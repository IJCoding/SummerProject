using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    [Range(0, 10)]
    [TooltipAttribute("This variable will set the speed of the movement")]
    public float speed = 3.5f;

    [Range(0, 10)]
    [TooltipAttribute("This variable will set from which distance does the enemy follow the player")]
    public float distance = 3f;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > distance)           //if the distance is greater than the variable given the condition will be trigered
        {
           transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }        

    }
}
