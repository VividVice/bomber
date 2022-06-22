using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_platform_destraction : MonoBehaviour
{
    float delay = 3f;
    float countdown;
    public GameObject destructable;

    void dead()
    {
        Destroy(destructable,0.5f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
            if (collision.gameObject.name == "PLayer")
            {
                dead();
            }
    }
}
