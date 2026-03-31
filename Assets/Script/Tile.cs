using Unity.VisualScripting;
using UnityEngine;


public class Tile : MonoBehaviour
{


    float distance;
    float maxDistance;
    float stepLength;
    bool moveFarword;
    bool moveX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxDistance = 5.0f;
        distance = maxDistance;
        moveFarword = false;

        if (moveX)
        {
            transform.Translate(distance, 0, 0);
        }
        else { 
            transform.Translate(0,0, distance);    
        }
    }

    // Update is called once per frame
    void Update()
    {
        stepLength = Time.deltaTime * 6f;

        if (moveX)
        {
            MoveX();
        }

        else
        {

        }
    }


    void  MoveX()
    {
        if (moveFarword) {

            if (distance < maxDistance)
            {
                transform.Translate(stepLength, 0, 0);
                distance = stepLength;

            }
            else {
                moveFarword = false;      
                }




            if (moveFarword)
            {

                if (distance > -maxDistance)
                {
                    transform.Translate(-stepLength, 0, 0);
                    distance -= stepLength;
                }
                else
                {
                    moveFarword = true;
                }

            }
        }
    }

    void MoveZ()
    {
        if (moveFarword)
        {

            if (distance < maxDistance)
            {
                transform.Translate( 0, 0, stepLength);
                distance = stepLength;

            }
            else
            {
                moveFarword = false;
            }




            if (moveFarword)
            {

                if (distance > -maxDistance)
                {
                    transform.Translate( 0, 0, -stepLength);
                    distance -= stepLength;
                }
                else
                {
                    moveFarword = true;
                }

            }
        }


    }
}
