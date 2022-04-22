using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuEasy : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();

        data.Add(new SudokuData.SudokuBoardData(
            new int[81] {0,0,0,0,6,0,0,0,0,0,0,0,5,7,9,0,0,0,5,0,0,2,0,4,9,3,6,0,0,5,7,0,0,0,8,1,0,0,
                3,0,0,0,6,0,0,9,2,0,0,0,1,5,0,0,2,1,6,9,0,3,0,0,4,0,0,0,1,2,6,0,0,0,0,0,0,0,5,0,0,0,0},
            new int[81] {4,9,1,3,6,8,2,7,5,3,6,2,5,7,9,4,1,8,5,8,7,2,1,4,9,3,6,6,4,5,7,9,2,3,8,1,1,7,3,
                8,4,5,6,2,9,9,2,8,6,3,1,5,4,7,2,1,6,9,8,3,7,5,4,7,5,4,1,2,6,8,9,3,8,3,9,4,5,7,1,6,2 }
            ));
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 0, 2, 0, 0, 7, 0, 8, 0, 3, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 4, 0, 8, 2, 0, 0, 0, 4, 7, 8, 5, 0, 3, 0, 6, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 0, 2, 0, 8, 9, 5, 7, 0, 0, 0, 4, 6, 0, 1, 8, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 7, 0, 5, 0, 2, 0, 0, 9, 0, },
            new int[81] { 5, 2, 9, 6, 7, 4, 8, 1, 3, 8, 3, 7, 1, 5, 9, 6, 4, 2, 6, 1, 4, 3, 8, 2, 5, 7, 9, 4, 7, 8, 5, 9, 3, 2, 6, 1, 9,
                5, 2, 7, 1, 6, 4, 3, 8, 3, 6, 1, 2, 4, 8, 9, 5, 7, 2, 9, 3, 4, 6, 7, 1, 8, 5, 1, 8, 6, 9, 3, 5, 7, 2, 4, 7, 4, 5, 8, 2, 1, 3, 9, 6, }
            ));
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 0, 0, 0, 0, 0, 6, 9, 0, 7, 3, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 5, 0, 7, 0, 4, 8, 0, 4, 2, 0, 0, 0, 9, 0, 7, 0, 0,
                3, 1, 0, 0, 0, 6, 4, 0, 0, 7, 0, 4, 0, 0, 0, 2, 1, 0, 5, 8, 0, 1, 0, 2, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 6, 7, 0, 2, 3, 0, 0, 0, 0, 0, },
            new int[81] { 2, 8, 4, 5, 3, 6, 9, 1, 7, 3, 1, 7, 8, 9, 4, 5, 6, 2, 6, 9, 5, 2, 7, 1, 4, 8, 3, 4, 2, 6, 1, 8, 9, 3, 7, 5, 8,
                3, 1, 7, 5, 2, 6, 4, 9, 5, 7, 9, 4, 6, 3, 8, 2, 1, 9, 5, 8, 6, 1, 7, 2, 3, 4, 1, 4, 3, 9, 2, 8, 7, 5, 6, 7, 6, 2, 3, 4, 5, 1, 9, 8, }
            ));

        return data;
    }
}

public class SudokuMed : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();

        data.Add(new SudokuData.SudokuBoardData(
            new int[81] {4,0,9,0,0,5,7,6,3,0,0,0,0,0,0,0,9,2,0,0,0,3,0,0,4,8,0,0,0,7,0,4,0,0,5,0,3,
                0,0,0,0,0,0,0,9,0,1,0,0,2,0,3,0,0,0,7,4,0,0,1,0,0,0,6,2,0,0,0,0,0,0,0,1,5,3,7,0,0,8,0,6},
            new int[81] {4,8,9,2,1,5,7,6,3,7,3,1,4,6,8,5,9,2,5,6,2,3,7,9,4,8,1,2,9,7,1,4,3,6,5,8,3,
                4,6,8,5,7,1,2,9,8,1,5,9,2,6,3,7,4,9,7,4,6,8,1,2,3,5,6,2,8,5,3,4,9,1,7,1,5,3,7,9,2,8,4,6}
            ));
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 3, 0, 0, 0, 1, 0, 4, 0, 0, 0, 6, 0, 0, 8, 0, 7, 0, 5, 7, 0, 2, 9, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 2, 6, 0, 1, 0, 
                0, 0, 8, 0, 9, 0, 0, 0, 6, 0, 3, 1, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 1, 9, 0, 8, 2, 0, 5, 0, 9, 0, 0, 1, 0, 0, 0, 1, 0, 4, 0, 0, 0, 2, },
            new int[81] { 3, 5, 8, 2, 1, 7, 4, 9, 6, 1, 6, 9, 3, 8, 4, 7, 2, 5, 7, 4, 2, 9, 5, 6, 1, 8, 3, 9, 8, 7, 4, 3, 2, 6, 5, 1, 5,
                1, 4, 8, 6, 9, 2, 3, 7, 6, 2, 3, 1, 7, 5, 8, 4, 9, 4, 3, 6, 5, 2, 1, 9, 7, 8, 2, 7, 5, 6, 9, 8, 3, 1, 4, 8, 9, 1, 7, 4, 3, 5, 6, 2, }
            ));
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 6, 0, 2, 0, 0, 0, 4, 5, 0, 0, 7, 5, 0, 0, 1, 0, 3, 0, 9, 0, 0, 0, 0, 8, 0, 0, 0, 0, 6, 0, 0, 9, 0, 0, 0, 5, 0, 
                2, 8, 0, 0, 0, 7, 4, 0, 7, 0, 0, 0, 4, 0, 0, 8, 0, 0, 0, 0, 2, 0, 0, 0, 0, 3, 0, 3, 0, 9, 0, 0, 1, 7, 0, 0, 8, 6, 0, 0, 0, 5, 0, 4, },
            new int[81] { 6, 1, 2, 7, 3, 9, 4, 5, 8, 8, 7, 5, 4, 2, 1, 9, 3, 6, 9, 4, 3, 5, 6, 8, 2, 1, 7, 4, 6, 1, 8, 9, 7, 3, 2, 5, 3,
                2, 8, 6, 1, 5, 7, 4, 9, 7, 5, 9, 3, 4, 2, 6, 8, 1, 1, 9, 7, 2, 5, 4, 8, 6, 3, 5, 3, 4, 9, 8, 6, 1, 7, 2, 2, 8, 6, 1, 7, 3, 5, 9, 4, }
            ));
        return data;
    }
}

public class SudokuHard : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();

        data.Add(new SudokuData.SudokuBoardData(
            new int[81] {4,0,0,5,0,0,0,3,0,0,9,0,0,2,0,6,4,0,2,7,0,0,0,3,8,0,5,0,0,0,0,0,0,0,0,3,
                0,0,9,4,0,2,7,0,0,7,0,0,0,0,0,0,0,0,8,0,7,3,0,0,0,5,6,0,1,4,0,6,0,0,7,0,0,5,0,0,0,7,0,0,8},
            new int[81] {4,8,1,5,7,6,2,3,9,3,9,5,1,2,8,6,4,7,2,7,6,9,4,3,8,1,5,1,4,2,7,8,9,5,6,3,
                5,6,9,4,3,2,7,8,1,7,3,8,6,5,1,9,2,4,8,2,7,3,9,4,1,5,6,9,1,4,8,6,5,3,7,2,6,5,3,2,1,7,4,9,8}
            ));
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 0, 0, 0, 0, 7, 0, 0, 9, 1, 0, 0, 0, 0, 3, 4, 5, 0, 0, 0, 9, 3, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 3, 7, 5,
                1, 6, 9, 3, 8, 2, 4, 4, 0, 0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 1, 8, 0, 0, 0, 5, 4, 8, 0, 0, 0, 0, 9, 1, 0, 0, 2, 0, 0, 0, 0, },
            new int[81] { 8, 4, 6, 2, 7, 5, 3, 9, 1, 1, 2, 7, 9, 3, 4, 5, 6, 8, 5, 9, 3, 1, 6, 8, 2, 4, 7, 6, 8, 9, 5, 4, 2, 7, 1, 3, 7, 5, 
                1, 6, 9, 3, 8, 2, 4, 4, 3, 2, 8, 1, 7, 6, 5, 9, 2, 7, 4, 3, 5, 9, 1, 8, 6, 3, 6, 5, 4, 8, 1, 9, 7, 2, 9, 1, 8, 7, 2, 6, 4, 3, 5, }
            ));
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 9, 8, 0, 6, 3, 2, 0, 7, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 7, 2, 6, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 5, 0, 0, 9, 1, 6,
                0, 0, 0, 0, 0, 5, 3, 5, 0, 0, 4, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 6, 4, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 3, 0, 1, 5, 4, 0, 2, 7, },
            new int[81] { 9, 8, 1, 6, 3, 2, 5, 7, 4, 3, 4, 5, 8, 7, 1, 2, 9, 6, 7, 2, 6, 5, 4, 9, 3, 1, 8, 2, 7, 8, 3, 1, 5, 4, 6, 9, 1, 6,
                4, 9, 2, 8, 7, 5, 3, 5, 9, 3, 4, 6, 7, 1, 8, 2, 8, 5, 2, 7, 9, 3, 6, 4, 1, 4, 1, 7, 2, 8, 6, 9, 3, 5, 6, 3, 9, 1, 5, 4, 8, 2, 7, }
            ));

        return data;
    }
}

public class SudokuData : MonoBehaviour
{
    public static SudokuData instance;

    public struct SudokuBoardData
    {
        public int[] unsolvedData;
        public int[] solvedData;

        public SudokuBoardData(int[] unsolved, int[] solved): this()
        {
            this.unsolvedData = unsolved;
            this.solvedData = solved;
        }
    }
    public Dictionary<string, List<SudokuBoardData>> sudokuGame = new Dictionary<string, List<SudokuBoardData>>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }

    private void Start()
    {
        sudokuGame.Add("Easy", SudokuEasy.getData());
        sudokuGame.Add("Medium", SudokuMed.getData());
        sudokuGame.Add("Hard", SudokuHard.getData());
    }
}
