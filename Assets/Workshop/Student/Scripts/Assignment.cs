using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Assignment
{
    public class Assignment : MonoBehaviour
    {
        public void Start()
        {
            // สามารถ Uncomment เพื่อเทสทีละข้อได้เลย
            // AS01_RandomItemDrop();
            // AS02_NestedLoopForCreate2DMap();
            // AS03_NestedLoopForMakingWallAround();
             AS04_AttackEnemy();
             AS05_DynamicIterationLoop();
             AS06_WhileLoopAndArray();
             AS07_HealTargetAtIndex();
             AS08_RandomPickingDialogue();
             AS09_MultiplicationTable();
             AS10_FindSummationFromZeroToNUsingWhileLoop();
             AS11_SpawnEnemies();
             StartCoroutine(AS12_CountTime());
             AS13_SumOfNumbersInRow();
             AS14_SumOfNumbersInColumn();
             AS15_MakeTheTriangle();
             AS16_MultiplicationTableOf_2_3_and_4();
             EX_01_TicTacToeGame_TurnPlay();
        }

        #region Assignment

        [Header("AS01_RandomItemDrop")]
        public GameObject[] as01_items;
        public void AS01_RandomItemDrop()
        {
            if (as01_items != null && as01_items.Length > 0)
            {
                int randomIndex = UnityEngine.Random.Range(0, as01_items.Length);
                GameObject droppedItem = Instantiate(as01_items[randomIndex]);
                Debug.Log("Got item: " + droppedItem.name);
            }
        }

        [Header("AS02_NestedLoopForCreate2DMap")]
        public GameObject[] as02_floorTiles;
        public int as02_columns = 5;
        public int as02_rows = 5;
        public void AS02_NestedLoopForCreate2DMap()
        {
            Debug.Log($"Column ...\n{as02_columns}");
            Debug.Log($"Row ...\n{as02_rows}");

            StringBuilder mapBuilder = new StringBuilder();
            for (int row = 0; row < as02_rows; row++)
            {
                for (int col = 0; col < as02_columns; col++)
                {
                    int randomTileIndex = UnityEngine.Random.Range(0, as02_floorTiles.Length);
                    GameObject currentTile = Instantiate(as02_floorTiles[randomTileIndex], new Vector2(col, row), Quaternion.identity);
                    mapBuilder.Append(currentTile.name);
                }
                mapBuilder.AppendLine();
            }
            Debug.Log(mapBuilder.ToString());
        }

        [Header("AS03_NestedLoopForMakingWallAround")]
        public GameObject as03_wall;
        public int as03_columns = 5;
        public int as03_rows = 5;
        public void AS03_NestedLoopForMakingWallAround()
        {
            Debug.Log($"Column ...\n{as03_columns}");
            Debug.Log($"Row ...\n{as03_rows}");

            StringBuilder wallBuilder = new StringBuilder();

            for (int r = -1; r <= as03_rows; r++)
            {
                for (int c = -1; c <= as03_columns; c++)
                {
                    bool isBorder = (c == -1 || c == as03_columns || r == -1 || r == as03_rows);

                    if (isBorder)
                    {
                        Instantiate(as03_wall, new Vector2(c, r), Quaternion.identity);
                        wallBuilder.Append("*");
                    }
                    else
                    {
                        wallBuilder.Append(" ");
                    }
                }
                wallBuilder.AppendLine();
            }
            Debug.Log(wallBuilder.ToString());
        }

        [Header("AS04_AttackEnemy")]
        public int[] as04_enemyHP;
        public int as04_damage;
        public int as04_target;
        public void AS04_AttackEnemy()
        {
            if (as04_enemyHP != null && as04_enemyHP.Length > 0)
            {
                as04_enemyHP[0] -= as04_damage;
                Debug.Log($"FirstEnemy hp :{as04_enemyHP[0]}");

                int finalIndex = as04_enemyHP.Length - 1;
                as04_enemyHP[finalIndex] -= as04_damage;
                Debug.Log($"LastEnemy hp :{as04_enemyHP[finalIndex]}");

                if (as04_target >= 0 && as04_target <= finalIndex)
                {
                    as04_enemyHP[as04_target] -= as04_damage;
                    Debug.Log($"TargetEnemy {as04_target} hp :{as04_enemyHP[as04_target]}");
                }
            }
        }

        [Header("AS05_DynamicIterationLoop")]
        public int as05_n;
        public void AS05_DynamicIterationLoop()
        {
            for (int count = 0; count < as05_n; count++)
            {
                Debug.Log(count);
            }
        }

        [Header("AS06_WhileLoopAndArray")]
        public string[] as06_ironManSuitNames;
        public void AS06_WhileLoopAndArray()
        {
            if (as06_ironManSuitNames == null) return;

            Debug.Log("======Log by One======");
            int idx1 = 0;
            while (idx1 < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[idx1]);
                idx1++;
            }

            Debug.Log("======Log by Two======");
            int idx2 = 0;
            while (idx2 < as06_ironManSuitNames.Length)
            {
                Debug.Log(as06_ironManSuitNames[idx2]);
                idx2 += 2;
            }
        }

        [Header("AS07_HealTargetAtIndex")]
        public int[] as07_heroHPs;
        public int as07_heal;
        public int as07_targetIndex;
        public void AS07_HealTargetAtIndex()
        {
            if (as07_heroHPs != null && as07_heroHPs.Length > 0)
            {
                as07_heroHPs[0] += as07_heal;
                Debug.Log($"FirstHero hp :{as07_heroHPs[0]}");

                int lastIndex = as07_heroHPs.Length - 1;
                as07_heroHPs[lastIndex] += as07_heal;
                Debug.Log($"LastHero hp :{as07_heroHPs[lastIndex]}");

                if (as07_targetIndex >= 0 && as07_targetIndex < as07_heroHPs.Length)
                {
                    as07_heroHPs[as07_targetIndex] += as07_heal;
                    Debug.Log($"TargetHero {as07_targetIndex} hp :{as07_heroHPs[as07_targetIndex]}");
                }
            }
        }

        [Header("AS08_RandomPickingDialogue")]
        public string[] as08_dialogues;
        public void AS08_RandomPickingDialogue()
        {
            if (as08_dialogues != null && as08_dialogues.Length > 0)
            {
                int randomLine = UnityEngine.Random.Range(0, as08_dialogues.Length);
                Debug.Log(as08_dialogues[randomLine]);
            }
        }

        [Header("AS09_MultiplicationTable")]
        public int as09_n;
        public void AS09_MultiplicationTable()
        {
            for (int multiplier = 1; multiplier <= 12; multiplier++)
            {
                Debug.Log(as09_n + "x" + multiplier + "=" + (as09_n * multiplier));
            }
        }

        [Header("AS10_FindSummationFromZeroToNUsingWhileLoop")]
        public int as10_n;
        public void AS10_FindSummationFromZeroToNUsingWhileLoop()
        {
            int totalSum = 0;
            int counter = 1;
            while (counter <= as10_n)
            {
                totalSum += counter;
                counter++;
            }
            Debug.Log($"ผลรวมของ n จาก 1 ถึง {as10_n} คือ {totalSum}");
        }

        [Header("AS11_SpawnEnemies")]
        public int[] as11_enemyHPs;
        public GameObject as11_enemyPrefab;
        public void AS11_SpawnEnemies()
        {
            if (as11_enemyHPs == null || as11_enemyPrefab == null) return;

            for (int enemyIndex = 0; enemyIndex < as11_enemyHPs.Length; enemyIndex++)
            {
                Vector3 spawnPosition = transform.position + new Vector3(enemyIndex + 1, 0, 0);
                Instantiate(as11_enemyPrefab, spawnPosition, Quaternion.identity);
            }
        }

        [Header("AS12_CountTime")]
        public float as12_countTime;
        public IEnumerator AS12_CountTime()
        {
            float timeLeft = as12_countTime;
            while (timeLeft > 0)
            {
                Debug.Log(timeLeft);
                yield return new WaitForSeconds(1f);
                timeLeft--;
            }
            Debug.Log(0);
        }

        [Header("AS13_SumOfNumbersInRow")]
        public Grid2DInt as13_matrix = new Grid2DInt
        {
            rows = 3,
            cols = 3,
            data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };
        public int as13_row;
        public void AS13_SumOfNumbersInRow()
        {
            var my2DMatrix = as13_matrix.Get2DArray();
            int totalRowSum = 0;
            int maxCols = my2DMatrix.GetLength(1);

            Debug.Log($"Row ...\n{as13_row}");

            if (as13_row >= 0 && as13_row < my2DMatrix.GetLength(0))
            {
                for (int c = 0; c < maxCols; c++)
                {
                    totalRowSum += my2DMatrix[as13_row, c];
                }
            }

            Debug.Log(totalRowSum);
        }

        [Header("AS14_SumOfNumbersInColumn")]
        public Grid2DInt as14_matrix = new Grid2DInt
        {
            rows = 3,
            cols = 3,
            data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        };
        public int as14_column;
        public void AS14_SumOfNumbersInColumn()
        {
            var my2DMatrix = as14_matrix.Get2DArray();
            int totalColSum = 0;
            int maxRows = my2DMatrix.GetLength(0);

            Debug.Log($"Col ...\n{as14_column}");

            if (as14_column >= 0 && as14_column < my2DMatrix.GetLength(1))
            {
                for (int r = 0; r < maxRows; r++)
                {
                    totalColSum += my2DMatrix[r, as14_column];
                }
            }

            Debug.Log(totalColSum);
        }

        [Header("AS15_MakeTheTriangle")]
        public int as15_size;
        public void AS15_MakeTheTriangle()
        {
            Debug.Log($"Size ...\n{as15_size}");
            StringBuilder triangleBuilder = new StringBuilder();

            for (int r = 1; r <= as15_size; r++)
            {
                for (int star = 1; star <= r; star++)
                {
                    triangleBuilder.Append("*");
                }
                triangleBuilder.AppendLine();
            }

            Debug.Log(triangleBuilder.ToString());
        }

        public void AS16_MultiplicationTableOf_2_3_and_4()
        {
            StringBuilder textBuilder = new StringBuilder();

            for (int m = 1; m <= 12; m++)
            {
                string line = $"2 x {m} = {2 * m}\t3 x {m} = {3 * m}\t4 x {m} = {4 * m}";
                textBuilder.AppendLine(line);
            }

            Debug.Log(textBuilder.ToString());
        }

        #endregion

        #region Extra assignment

        [Header("EX_01_TicTacToeGame_TurnPlay")]
        public Grid2DString ex01_board = new Grid2DString
        {
            rows = 3,
            cols = 3,
            data = new string[] {
                "X", "X", "O",
                "X", "O", "X",
                "", "", ""
            }
        };
        public string ex01_playerTurn = "O";
        public int ex01_row = 2;
        public int ex01_column = 0;

        public void EX_01_TicTacToeGame_TurnPlay()
        {
            var currentBoard = ex01_board.Get2DArray();

            bool isOutOfBounds = ex01_row < 0 || ex01_row >= 3 || ex01_column < 0 || ex01_column >= 3;
            if (isOutOfBounds || !string.IsNullOrEmpty(currentBoard[ex01_row, ex01_column]))
            {
                PrintBoard(currentBoard);
                Debug.Log(">> Invalid move");
                return;
            }

            currentBoard[ex01_row, ex01_column] = ex01_playerTurn;
            PrintBoard(currentBoard);

            bool isWinner = false;

            for (int i = 0; i < 3; i++)
            {
                if ((currentBoard[i, 0] == ex01_playerTurn && currentBoard[i, 1] == ex01_playerTurn && currentBoard[i, 2] == ex01_playerTurn) ||
                    (currentBoard[0, i] == ex01_playerTurn && currentBoard[1, i] == ex01_playerTurn && currentBoard[2, i] == ex01_playerTurn))
                {
                    isWinner = true;
                }
            }

            if ((currentBoard[0, 0] == ex01_playerTurn && currentBoard[1, 1] == ex01_playerTurn && currentBoard[2, 2] == ex01_playerTurn) ||
                (currentBoard[0, 2] == ex01_playerTurn && currentBoard[1, 1] == ex01_playerTurn && currentBoard[2, 0] == ex01_playerTurn))
            {
                isWinner = true;
            }

            if (isWinner)
            {
                Debug.Log($">> {ex01_playerTurn} Win!");
                return;
            }

            bool boardFull = true;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (string.IsNullOrEmpty(currentBoard[r, c]))
                    {
                        boardFull = false;
                    }
                }
            }

            if (boardFull)
            {
                Debug.Log(">> Draw");
            }
            else
            {
                Debug.Log(">> Continue");
            }
        }
        #endregion

        private void PrintBoard(string[,] board)
        {
            StringBuilder sb = new();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine("-------------");
                sb.AppendLine("| " + spaceIfEmpty(board[i, 0]) + " | " + spaceIfEmpty(board[i, 1]) + " | " + spaceIfEmpty(board[i, 2]) + " |");
            }
            sb.AppendLine("-------------");
            Debug.Log(sb.ToString());
        }

        private string spaceIfEmpty(string value)
        {
            return string.IsNullOrEmpty(value) ? " " : value;
        }
    }
}