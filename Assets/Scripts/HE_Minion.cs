using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This enemy will move toward the turret and dies when shot.
/// </summary>
public class HE_Minion : MonoBehaviour
{
    public GameObject turret;
    public float speed = 5;

    private void Start()
    {
        turret = GameObject.Find("Turret");
    }
    void Update()
    {
        if(turret != null)
        {
            transform.LookAt(turret.transform.position);
        }
        //Look at turret
        transform.LookAt(turret.transform.position);

        //MOVE
        transform.position += transform.forward * Time.deltaTime * speed;
    }


    //Kills Turret on collision
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Turret"))
        {
            Destroy(collision.gameObject); //Destroys Turret
            Destroy(gameObject); //Destorys Minion
        }
    }
}
