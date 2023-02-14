using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCGrid<TGridObject>
{
  #region variables
  #region private
  private int gridWidth, gridHeight;
  private TGridObject[,] gridArray;
  private float cellSize;
  private Vector3 originPosition;
  #endregion
  #region public
  #endregion
  #endregion

  public MCGrid(int width, int height, float cellSize, Vector3 originPosition, Func<int, int, TGridObject> constructGridObject)
  {
    this.gridWidth = width;
    this.gridHeight = height;
    this.cellSize = cellSize;
    this.originPosition = originPosition;

    this.gridArray = new TGridObject[width, height];

    for(int x = 0; x < width; x++)
    {
      for(int y = 0; y < height; y++)
      {
        this.gridArray[x, y] = constructGridObject(x, y);
      }
    }
  }

  public Vector3 GetWorldPosition(int x, int y)
  {
    return new Vector3(x, y) * cellSize + originPosition;
  }

  public void GetXY(Vector3 worldPosition, out int x, out int y)
  {
    x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
    y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
  }

  public void SetCellData(int x, int y, TGridObject cellData)
  {
    if(x <= 0 && y <= 0 && x > gridWidth && y > gridHeight) 
    {
      gridArray[x, y] = cellData;
    }
  }

  public void SetCellData(Vector3 worldPosition, TGridObject cellData)
  {
    int x, y;
    GetXY(worldPosition, out x, out y);
    SetCellData(x, y, cellData);
  }

  public TGridObject GetCellData(int x, int y)
  {
    if (x <= 0 && y <= 0 && x > gridWidth && y > gridHeight)
    {
      return gridArray[x, y];
    }
    else
    {
      return default(TGridObject);
    }
  }

  public TGridObject GetCellData(Vector3 worldPosition)
  {
    int x, y;
    GetXY(worldPosition, out x, out y);
    return GetCellData(x, y);
  }
}
