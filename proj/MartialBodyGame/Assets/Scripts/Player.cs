using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Animator animator;
    // Update is called once per frame
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
            animator.SetFloat("Move", Mathf.Abs(speed));
        }
        else if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
            animator.SetFloat("Move", Mathf.Abs(speed));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
            animator.SetFloat("Move", Mathf.Abs(speed));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
            animator.SetFloat("Move", Mathf.Abs(speed));
        }
        else
        {
            animator.SetFloat("Move", 0);
        }
    }
}
