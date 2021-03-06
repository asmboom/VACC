﻿using UnityEngine;


public class WindForce : MonoBehaviour, Force {

    private Vector3 windForce = new Vector3();
    private int newForceTimer = 0;

    [SerializeField]
    [Range(0.0f, 2.0f)]
    private float modifier = 1.0f;

    [SerializeField]
    private Vector3 windDirection = new Vector3(1,0,0);


    public Vector3 getForce()
    {
        UpdateForce();
        return windForce*modifier;
    }

    private void UpdateForce()
    {
        
        if (newForceTimer <= 0)
        {
            newForceTimer--;
            if (newForceTimer < -10)
            {
                newForceTimer = Random.Range(100, 300);
            }
           
            windForce += windDirection.normalized *Random.Range(0,-10);

        }
        else
        {
            newForceTimer--;
            windForce*=0.9f;
        }
    }



}
