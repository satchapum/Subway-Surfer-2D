using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform targetleft;
    public Transform targetmiddle;
    public Transform targetright;
    private float current;
    public float speed;

    private void Start()
    {
        current = 0;
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            current = Mathf.Clamp(current - 1, -1, 1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            current = Mathf.Clamp(current + 1, -1, 1);
        }

        
        Vector3 targetPosition = targetmiddle.position;
        if (current == -1)
        {
            targetPosition = targetleft.position;
        }
        else if (current == 1)
        {
            targetPosition = targetright.position;
        }

        
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
