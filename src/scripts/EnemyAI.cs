using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public int HP = 100;
    public bool dieB;
    public Animator EnmDead;
    [SerializeField] private BoxCollider2D boxCollider2D;
    [SerializeField] private BoxCollider2D trigger2D;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            HP -= 50;
            if (HP <= 0)
            {
                EnmDead.SetBool("dieB", true);
                Destroy(boxCollider2D);
                Destroy(trigger2D);
            }
        }
        
    }
}
