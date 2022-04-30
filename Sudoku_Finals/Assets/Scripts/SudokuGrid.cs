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
    private int selectedGriddata = -1;

    private void Start()
    {
        if (gridSquare.GetComponent<GridSquare>() == null)
        {
            Debug.LogError("This game object needs gridsquare script!");
        }
        CreateGrid();
        if (GameSettings.instance.GetContinuePreviousGame())
            SetGridFormFile();
        else
        SetGridNum(GameSettings.instance.GetGameMode());
    }

    private void CreateGrid()
    {
        if (GameSettings.instance.GetContinuePreviousGame())
            SetGridFormFile();
        else
            SetGridNum(GameSettings.instance.GetGameMode());
        SpawnGridSquares();
        SetSquarePos();
    }

    private void SetGridNum(string level)
    {
        selectedGriddata = Random.Range(0, SudokuData.instance.sudokuGame[level].Count);
        var data = SudokuData.instance.sudokuGame[level][selectedGriddata];

        SetGridSqData(data);
    }

    private void SpawnGridSquares()
    {
        int squareIndex = 0;
        for(int row =0; row <rows; row++)
        {
            for(int col =0; col < columns; col++)
            {
                grids.Add(Instantiate(gridSquare) as GameObject);
                grids[grids.Count-1].GetComponent<GridSquare>().SetSquareIndex(squareIndex);
                grids[grids.Count - 1].transform.parent = this.transform;
                grids[grids.Count - 1].transform.localScale = new Vector3(squareScale, squareScale, squareScale);

                squareIndex++;
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

    private void SetGridSqData(SudokuData.SudokuBoardData data)
    {
        for(int index = 0; index < grids.Count; index++)
        {
            grids[index].GetComponent<GridSquare>().SetNumber(data.unsolvedData[index]);
            grids[index].GetComponent<GridSquare>().SetCorrectNumber(data.solvedData[index]);
            grids[index].GetComponent<GridSquare>().SetHasDefaultValue(data.unsolvedData[index] != 0 && data.unsolvedData[index] == data.solvedData[index]);
        }
    }


    void SetGridFormFile()
    {
        string level = GameSettings.instance.GetGameMode();
        selectedGriddata = Config.ReadGameBoardLevel();
        var data = Config.ReadGridData();

        SetGridSqData(data);
    }

    private void OnDisable()
    {
        var solved_data = SudokuData.instance.sudokuGame[GameSettings.instance.GetGameMode()][selectedGriddata].solvedData;
        int[] unsolved_data = new int[81];

        for (int i = 0; i < grids.Count; i++)
        {
            var comp = grids[i].GetComponent<GridSquare>();
            unsolved_data[i] = comp.GetSquareNumber();
            //string key = "square_note:" i.ToString();
            //grid_notes.Add(key, comp.GetSquareNotes()); //AINT GOT NOTES
        }
        SudokuData.SudokuBoardData current_game_data = new SudokuData.SudokuBoardData(unsolved_data, solved_data);

        if (GameSettings.instance.GetExitAfterWon() == false)
        {
            Config.SaveBoardData(current_game_data,
                GameSettings.instance.GetGameMode(),
                selectedGriddata,
                Lives.instance.GetErrorNumber());
        }
        else
            Config.DeleteDataFile();
    }
}
