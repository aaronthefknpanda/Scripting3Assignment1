using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq.Expressions;

public class DotweenTest : MonoBehaviour
{
    public bool movingRight;

    // Start is called before the first frame update
    void Start()
    {
        movingRight = true;
        transform.DOMove(new Vector3(4.0f, 4.0f, 0.0f), 1);
        transform.DORotate(new Vector3(0.0f, 0.0f, -180.0f), 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            if(movingRight)
            {
                movingRight = false;
                transform.DOMove(new Vector3(-4.0f, 4.0f, 0.0f), 1);
                transform.DORotate(new Vector3(0.0f, 0.0f, 0.0f), 0.5f);
            }
            else if(!movingRight)
            {
                movingRight = true;
                transform.DOMove(new Vector3(4.0f, 4.0f, 0.0f), 1);
                transform.DORotate(new Vector3(0.0f, 0.0f, -180.0f), 0.5f);
            }

            transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.5f);
        }
    }
}
