using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Animator currentAnimator;
    float maxRunningSpeed = 15f, maxEWalkingSpeed = 8f, currentSpeed;
    Vector3 _deltaPos = new Vector3();
    SpriteRenderer _renderer;
    
    private void Awake()
    {
        currentAnimator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            currentAnimator.SetBool("isAttacking", true);
        }
        else if(Input.GetButtonDown("Fire1")){
            currentAnimator.SetBool("isAttacking", false);
        }

        currentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3") ? maxRunningSpeed : maxEWalkingSpeed);
        _deltaPos.x = currentSpeed * Time.deltaTime;
        currentAnimator.SetFloat("Speed", Mathf.Abs(currentSpeed));

        _renderer.flipX = currentSpeed < 0;        

        gameObject.transform.Translate(_deltaPos);
    }
}
