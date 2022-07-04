using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerC9 : MonoBehaviour
{
    public GameObject Munition;
    Vector3 startingSpeed;
    const float SCALAR_SPEED = 15f;
    float currentAngle, deltaY, deltaX;
    Vector3 userInput = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        startingSpeed = new Vector3(SCALAR_SPEED, SCALAR_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ? (Vector3)Input.GetTouch(0).position : Input.mousePosition);
        deltaY = userInput.y - gameObject.transform.position.y;
        deltaX = userInput.x - gameObject.transform.position.x;

        currentAngle = Mathf.Atan(deltaY / deltaX);
        
        if(Input.GetButtonDown("Fire1")){
            Instantiate(Munition, gameObject.transform.position, Quaternion.identity).GetComponent<MunitionBehaviorC9>().Shoot(startingSpeed, currentAngle);
        }
    }
}
