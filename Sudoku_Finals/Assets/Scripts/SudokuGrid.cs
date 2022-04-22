using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuGrid : MonoBehaviour
{
    public int columns = 0;
    public int rows = 0;
    public float squareOffset = 0f;
    
    public GameObject gridSquare;
    public Vector2 startPos = new Vector2(0f, 0f);
    public float squareScale = 1f;

    private List<GameObject> grids = new List<GameObject>();

    private void Start()
    {
        if (gridSquare.GetComponent<GridSquare>() == null)
        {
            Debug.LogError("This game object needs gridsquare script!");
        }
        CreateGrid();
        SetGridNum();
    }

    private void CreateGrid()
    {
        SpawnGridSquares();
        SetSquarePos();
    }

    private void SetGridNum()
    {
        foreach(var square in grids)
        {
            square.GetComponent<GridSquare>().SetNumber(Random.Range(0, 10));
        }
    }

    private void SpawnGridSquares()
    {
        for(int row =0; row <rows; row++)
        {
            for(int col =0; col < columns; col++)
            {
                grids.Add(Instantiate(gridSquare) as GameObject);
                grids[grids.Count - 1].transform.parent = this.transform;
                grids[grids.Count - 1].transform.localScale = new Vector3(squareScale, squareScale, squareScale);
            }
        }
    }

    private void SetSquarePos()
    {
        var square_rect = grids[0].GetComponent<RectTransform>();
        Vector2 offset = new Vector2();
        offset.x = square_rect.rect.width * square_rect.transform.localScale.x + squareOffset;
        offset.y = square_rect.rect.height * square_rect.transform.localScale.y + squareOffset;

        int columnNum = 0;
        int rowNum = 0;

        foreach (GameObject square in grids)
        {
            if (columnNum + 1 > columns)
            {
                rowNum++;
                columnNum = 0;
            }

            var posXoffset = offset.x * columnNum;
            var posYoffset = offset.y * rowNum;
            square.GetComponent<RectTransform>().anchoredPosition = new Vector2(startPos.x + posXoffset, startPos.y - posYoffset);
            columnNum++;
        }
    }
}
