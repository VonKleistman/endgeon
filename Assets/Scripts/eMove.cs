using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class eMove : MonoBehaviour
{
    #region Variables
    #region Private
    private int num;
    private Rigidbody2D rb;
    private float waitTime;
    private Tilemap collisionMap;
    private Vector3 movRight = new Vector3(1, 0, 0), movLeft = new Vector3(-1, 0, 0), movUp = new Vector3(0, 1, 0), movDown = new Vector3(0, -1, 0), targPos;
  #endregion

  #region Public
    #endregion
    #endregion

    private void Start()
    {
        waitTime = Time.time + Random.Range(1f, 3f);
        collisionMap = GameObject.Find("Collideables").GetComponent<Tilemap>();
        InvokeRepeating("Walk", waitTime, .2f); //inbuilt solution to avoid using update
    }

    private void Update()
    {

    }

    // Update is called once per frame
    void Walk()
    {
      targPos = this.transform.position;
    Debug.Log(this.gameObject.name + " is attempting to move");
      num = Random.Range(1, 5);
      switch (num)
    {
      case 1:
        {
          CheckForCollisionTile(movRight);
          break;
        }
        case 2:
        {
          CheckForCollisionTile(movLeft);
          break;
        }
        case 3:
        {
          CheckForCollisionTile(movDown);
          break;
        }
      case 4:
        {
          CheckForCollisionTile(movUp);
          break;
        }
        default:
        {
          break;
        }

    }
    this.transform.position = targPos;
    }

  void CheckForCollisionTile(Vector3 otherPos)
  {
    if (!collisionMap.HasTile(Vector3Int.FloorToInt(collisionMap.WorldToCell(targPos + otherPos))))
    {
      targPos += otherPos;
      Debug.Log(targPos);
    }
  }
}
