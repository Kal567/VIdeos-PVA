using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerC10 : MonoBehaviour
{
    public GameObject Shield;
    const float shieldDistance = 2f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire2")){
            Instantiate(Shield, gameObject.transform.position, Quaternion.identity).GetComponent<ShieldBehaviorC10>().Shoot(gameObject, shieldDistance);
        }

    }

}
