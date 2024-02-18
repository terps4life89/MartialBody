using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float nullSpeed = 0;
    public Animator animator;
    public int attackCounter = 0; 
    private float lastAttackTime;
    private float resetTime = 1f;
    private bool isAttacking = false;


    private void Update()
    {
        try
        {
            if (Input.GetButtonDown("Fire1") && !isAttacking)
            {
                isAttacking = true;
                attackCounter++;

                if (attackCounter > 2)
                {
                    attackCounter = 0;
                }

                animator.SetInteger("AtackCount", attackCounter);
                lastAttackTime = Time.time;

                Invoke("ResetAttack", .5f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(transform.right * speed * Time.deltaTime);
                animator.SetFloat("Move", Mathf.Abs(speed));
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(transform.up * speed * Time.deltaTime);
                animator.SetFloat("Move", Mathf.Abs(speed));
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-transform.right * speed * Time.deltaTime);
                animator.SetFloat("Move", Mathf.Abs(speed));
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-transform.up * speed * Time.deltaTime);
                animator.SetFloat("Move", Mathf.Abs(speed));
            }
            if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S))
            {
                animator.SetFloat("Move", nullSpeed);
            }

            if (Time.time - lastAttackTime > resetTime)
            {
                attackCounter = 0;
                animator.SetInteger("AtackCount", attackCounter);
            }
        }
        catch (Exception ex)
        {
            //
        }
    }

    void ResetAttack()
    {
        isAttacking = false;
    }
}
