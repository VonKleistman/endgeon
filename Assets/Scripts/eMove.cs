using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eMove : MonoBehaviour
{
    #region Variables
    #region Private
    private int num;
    private Rigidbody2D rb;
    #endregion

    #region Public
    #endregion
    #endregion

    // Update is called once per frame
    void Update()
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
