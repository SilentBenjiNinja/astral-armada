using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAGetHit : MonoBehaviour
{
    public JuiceManager jm;

    private void Awake()
    {
        jm = GameObject.FindWithTag("JuiceManager").GetComponent<JuiceManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        //jm.OnAA1Kill(collision.transform.position);
        jm.OnAA1Kill(transform.position);
        Destroy(this.gameObject);
    }
}
