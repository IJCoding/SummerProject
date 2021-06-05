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

    public Animator animator;

    [Tooltip("The object that will be used to detect enemies")]
    public Transform AttackArea;

    [Range(0,2)]
    [Tooltip("Variable to set the radius for the Attack Area")]
    public float attackRange = 0.5f;

    [Range(0, 25)]
    [Tooltip("Variable to set the attack damage dealt")]
    public float Damage = 25f;

    [Tooltip("Variable to set which layers to detect enemies on")]
    public LayerMask EnemyLayers;

    public void Start()
    {
    }

    void Strike()       //declaring function for attacking
    {

        animator.SetTrigger("Attack");      //calls in the appropriate triger fopr the animator to play corresponding animation

        Collider2D[] hitEnemy = Physics2D.OverlapCircleAll(AttackArea.position, attackRange, EnemyLayers);

        foreach (Collider2D enemy in hitEnemy)
        {

            Debug.Log("HIT" + enemy.name);

            enemy.GetComponent<Health>().TakeDamage(Damage);
        
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (AttackArea == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(AttackArea.position, attackRange);
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))        //condition for input(temorary)
        {

            Strike();       //attacking
            
        }
    }
}
