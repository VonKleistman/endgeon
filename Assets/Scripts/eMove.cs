using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eMove : MonoBehaviour
{
    #region Variables
    #region Private
    private int num;
    private Rigidbody2D rb;
    private float waitTime;
    #endregion

    #region Public
    #endregion
    #endregion

    private void Start()
    {
        waitTime = Time.time + Random.Range(1f, 3f);
    }

    private void Update()
    {

        if (Time.time > waitTime)
        {
            waitTime = Time.time + Random.Range(1f, 3f);
            Walk();
        }
    }

    // Update is called once per frame
    void Walk()
    {
        var r = new System.Random();
        num = r.Next(1, 4);

        if (num == 1)
        {
            transform.Translate(0, .2f, 1);
        }
        else if (num == 2)
        {
            transform.Translate(.2f, 0, 1);
        }
        else if (num == 3)
        {
            transform.Translate(0, -.2f, 1);
        }
        else
        {
            transform.Translate(-.2f, 0, 1);
        }
    }
}
