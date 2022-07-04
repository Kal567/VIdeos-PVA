using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviorC10 : MonoBehaviour
{
    GameObject centerObject;
    Vector3 currentPosition = new Vector3(), angle, currentSpeed = new Vector3(10 ,10);
    float currentDistance, scalarAcceleration = 0f, shootingTime;

    // Update is called once per frame
    void Update()
    {
        angle = currentSpeed * (Time.time - shootingTime) / currentDistance;

        currentPosition.x = centerObject.transform.position.x + currentDistance  * Mathf.Cos(angle.x);
        currentPosition.y = centerObject.transform.position.x + currentDistance  * Mathf.Sin(angle.y);
        gameObject.transform.position = currentPosition;

        currentSpeed.x += scalarAcceleration * Time.deltaTime;
        currentSpeed.y += scalarAcceleration * Time.deltaTime;
    }

    public void Shoot(GameObject center, float distance){
        centerObject = center;
        currentDistance = distance;
        shootingTime = Time.time;
    }
}
