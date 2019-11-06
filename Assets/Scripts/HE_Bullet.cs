using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HE_Bullet : MonoBehaviour
{
    //If bullet collides with minion, destroy minion and bullet
        //The bullet has collided with something
        // Lets check that its a minion
         private void OnCollisionEnter(Collision collision)
            {
                if (collision.gameObject.CompareTag("Minion"))
                {
                    Destroy(collision.gameObject); //Destroys minion
                    Destroy(gameObject); // Destorys Bullet
                }
            }
}
