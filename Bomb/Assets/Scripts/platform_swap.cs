using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_swap : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Crouch"))
        {
            waitTime = 0;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            if(waitTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = 0;
            }else
            {
                waitTime -= Time.deltaTime;
            }
        }
        if (Input.GetButtonDown("Jump"))
        {
            effector.rotationalOffset = 0;
        }
    }
}
