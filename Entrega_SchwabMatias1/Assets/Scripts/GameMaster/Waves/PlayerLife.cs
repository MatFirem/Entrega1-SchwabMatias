using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int lifePlayer = 10;
       private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Enemy")
        {
            lifePlayer--;
            Debug.Log("You lose 1 point of life");
        }
        if(lifePlayer<=0)
        {
            Debug.Log("You Lose");
        }
    }
    


}
