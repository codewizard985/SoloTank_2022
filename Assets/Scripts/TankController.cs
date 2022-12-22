using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class TankController : BaseController
{
    [SerializeField] private float speed = 0.2f;
    [SerializeField] private float tiltAngle = 60.0f;

    // update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        /*        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
                {
                    transform.Translate(0f, 0f, speed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                {
                    transform.Translate(0f, 0f, -speed * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    transform.Rotate(0f, tiltAngle * Time.deltaTime, 0f);
                }

                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
                {
                    transform.Rotate(0f, -tiltAngle * Time.deltaTime, 0f);
                }*/

        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z)) && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }
    }
}
