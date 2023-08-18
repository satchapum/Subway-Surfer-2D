using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform targetleft;
    public Transform targetmiddle;
    public Transform targetright;
    public float speed;
    private float currentLine;
    private Vector3 targetPosition;

    void Start()
    {
        targetPosition = targetmiddle.position;
        currentLine = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentLine == 0)
            {
                targetPosition = targetleft.position;
                currentLine--;
            }
            else if (currentLine == 1)
            {
                targetPosition = targetmiddle.position;
                currentLine--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentLine == 0)
            {
                targetPosition = targetright.position;
                currentLine++;
            }
            else if (currentLine == -1)
            {
                targetPosition = targetmiddle.position;
                currentLine++;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}