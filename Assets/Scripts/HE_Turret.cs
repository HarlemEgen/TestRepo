using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotates towards the mouse position and shoots when you click
/// </summary>
public class HE_Turret : MonoBehaviour
{
    void Update()
    {

        //ROTATES TO MOUSE POSITION
        //THE INFORMATION OF WHAT OUR RAYCAST HAS HIT
        RaycastHit hit;
        //CREATE A RAYCAST TO POINT AT THE MOUSE'S POSITION.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //IF OUR RAYCAST HITS AN OBJECT
        if (Physics.Raycast(ray, out hit, 100))
        {
            //transform.LookAt(hit.transform.position);
            transform.LookAt(new Vector3(hit.point.x, 0, hit.point.z));
        }
        //SHOOTS WHEN MOUSE BUTTON IS CLICKED

    }
}
