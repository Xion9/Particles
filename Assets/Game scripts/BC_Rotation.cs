using UnityEngine;
using System.Collections;

/**
 * Rotate the game object at a set speed on a timmer.
 * 
 * @author j@gamemechanix.io
 * @project SpellCraft
 * @copyright GameMechanix.io 2016
 **/


public class BC_Rotation : MonoBehaviour
{

    public Vector3 speed = Vector3.up;
    public bool isTurning = true;
    public int counter = 50;
  
    void FixedUpdate ()
    {
        while (isTurning)
        {
           transform.Rotate(speed);
            counter--;
        }
        if (counter > 0)
        {
           transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f));
            isTurning = false;
        }

       
            
            //}
            //else
            //{
              //  counter--;
            } 
    }

