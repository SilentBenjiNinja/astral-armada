using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrolling : MonoBehaviour
{
    public float scrollSpeed = 2;

    Transform[] transforms;

    private void Awake()
    {
        transforms = transform.GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        for (int i = 1; i < transforms.Length;i++)
        {
            transforms[i].Translate(0, Time.deltaTime * scrollSpeed * -1, 0);

            if (transforms[i].position.y < -20f)
            {
                transforms[i].Translate(0, 40, 0);
            }
        }
    }
}
