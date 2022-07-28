using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBMovement : MonoBehaviour
{
    public float movementSpeed = 3f;
    float screenBorderL = -8;
    float screenBorderR = 8;
    float screenBorderU = 4.5f;
    float screenBorderD = -4.5f;

    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        input.Normalize();

        transform.Translate(input * movementSpeed * Time.deltaTime);

        if (transform.position.x < screenBorderL)
            transform.position = new Vector2(screenBorderL, transform.position.y);
        else if (transform.position.x > screenBorderR)
            transform.position = new Vector2(screenBorderR, transform.position.y);

        if (transform.position.y < screenBorderD)
            transform.position = new Vector2(transform.position.x, screenBorderD);
        else if (transform.position.y > screenBorderU)
            transform.position = new Vector2(transform.position.x, screenBorderU);
    }
}
