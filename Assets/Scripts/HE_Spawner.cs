using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HE_Spawner : MonoBehaviour
{
    public GameObject minionPrefab;
    public float Timer = 0.5f;
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0f)
        {
            Timer = 0.5f;
            GameObject newMinion = Instantiate(minionPrefab, transform.position, transform.rotation);
        }
    }
}
