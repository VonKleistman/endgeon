using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMove : MonoBehaviour
{
    #region Variables
    #region Private
    private Rigidbody2D rb;
    private Vector3 mDelta;
    #endregion

    #region Public
    public float speed;
    #endregion
    #endregion

    // Start is called before the first frame update
    void Start()
    {
    }

    // FixedUpdate is ideal for anything involved in physics
    void FixedUpdate()
    {
        #region Local Variables
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        #endregion
        mDelta = new Vector3(x, y, 0);

        /*
        if (mDelta.x > 0)
            transform.localScale = new Vector3.one;
        else if (mDelta.x < 0)
            transform.localScale = new Vector3(6, 6, 0);
        */

        // transform.Translate(mDelta * Time.deltaTime);
        transform.Translate(mDelta * speed);
    }
}
