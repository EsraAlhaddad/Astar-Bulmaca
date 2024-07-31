using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    internal class Astar
    {


        internal class Node
        {
            public int[,] State { get; }
            public int G { get; }
            public int H { get; }
            public int F => G + H;
            public Node Parent { get; }

            public Node(int[,] state, int g, int h, Node parent)
            {
                State = state;
                G = g;
                H = h;
                Parent = parent;
            }
        }



        internal bool ArraysEqual(int[,] arr1, int[,] arr2)
        {
            if (arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1))
            {
                return false;
            }

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] != arr2[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Heuristik fonksiyonu (Manhattan mesafesi + yanlış yerleştirilmiş fayans sayısı)
        private int CalculateHeuristic(int[,] currentState, int[,] goalState)
        {
            int heuristic = 0;

            // Durumların boyutlarının aynı olduğundan emin olun
            int size = currentState.GetLength(0);

            // Manhattan mesafesini ve yanlış yerleştirilmiş fayans sayısını hesaplamak için her elemanın hedef konum ile mevcut konumu arasındaki farkı topla
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int value = currentState[i, j];
                    if (value != 0) // Boş kareyi hesaba katmıyoruz
                    {
                        // Mevcut konumu bul
                        int currentRow = i;
                        int currentCol = j;

                        // Hedef konumu bul
                        int goalRow = -1;
                        int goalCol = -1;

                        // Hedef konumu ara
                        for (int m = 0; m < size; m++)
                        {
                            for (int n = 0; n < size; n++)
                            {
                                if (goalState[m, n] == value)
                                {
                                    goalRow = m;
                                    goalCol = n;
                                    break;
                                }
                            }
                            if (goalRow != -1 && goalCol != -1)
                                break;
                        }

                        // Manhattan mesafesini ve yanlış yerleştirilmiş fayans sayısını hesapla ve toplama ekle
                        heuristic += Math.Abs(currentRow - goalRow) + Math.Abs(currentCol - goalCol);
                        if (value != goalState[i, j])
                        {
                            heuristic++;
                        }
                    }
                }
            }

            return heuristic;
        }

        // Komşu düğümleri oluşturma (sadece boş karenin komşu karelerle yer değiştirmesi)
        private List<int[,]> GetNeighbors(int[,] state)
        {
            List<int[,]> neighbors = new List<int[,]>();

            // Boş karenin konumunu bul
            int emptyRow = -1;
            int emptyCol = -1;
            for (int i = 0; i < state.GetLength(0); i++)
            {
                for (int j = 0; j < state.GetLength(1); j++)
                {
                    if (state[i, j] == 0)
                    {
                        emptyRow = i;
                        emptyCol = j;
                        break;
                    }
                }
            }

            // Yukarı hareket
            if (emptyRow > 0)
            {
                int[,] tempState = (int[,])state.Clone();
                tempState[emptyRow, emptyCol] = tempState[emptyRow - 1, emptyCol];
                tempState[emptyRow - 1, emptyCol] = 0;
                neighbors.Add(tempState);
            }

            // Aşağı hareket
            if (emptyRow < state.GetLength(0) - 1)
            {
                int[,] tempState = (int[,])state.Clone();
                tempState[emptyRow, emptyCol] = tempState[emptyRow + 1, emptyCol];
                tempState[emptyRow + 1, emptyCol] = 0;
                neighbors.Add(tempState);
            }

            // Sol hareket
            if (emptyCol > 0)
            {
                int[,] tempState = (int[,])state.Clone();
                tempState[emptyRow, emptyCol] = tempState[emptyRow, emptyCol - 1];
                tempState[emptyRow, emptyCol - 1] = 0;
                neighbors.Add(tempState);
            }

            // Sağ hareket
            if (emptyCol < state.GetLength(1) - 1)
            {
                int[,] tempState = (int[,])state.Clone();
                tempState[emptyRow, emptyCol] = tempState[emptyRow, emptyCol + 1];
                tempState[emptyRow, emptyCol + 1] = 0;
                neighbors.Add(tempState);
            }

            return neighbors;
        }

        // 8-Puzzle problemi için A* algoritması ile çözümü hesapla
        public List<int[,]> SolvePuzzle(int[,] initialState, int[,] goalState)
        {
            // Çözüm listesi
            List<int[,]> solution = new List<int[,]>();

            // İlerleme listesi
            List<Node> openList = new List<Node>();

            // Başlangıç durumunu açık listeye ekle
            Node initialNode = new Node(initialState, 0, CalculateHeuristic(initialState, goalState), null);
            openList.Add(initialNode);

            // A* algoritması
            while (openList.Count > 0)
            {
                // En iyi düğümü seç (en küçük F değeri olan)
                int bestIndex = 0;
                for (int i = 1; i < openList.Count; i++)
                {
                    if (openList[i].F < openList[bestIndex].F)
                    {
                        bestIndex = i;
                    }
                }

                // Seçilen düğümü kapat listesine ekle
                Node currentNode = openList[bestIndex];
                openList.RemoveAt(bestIndex);

                // Hedef duruma ulaşıldıysa çık
                if (currentNode.H == 0)
                {
                    // Çözümü oluştur
                    while (currentNode != null)
                    {
                        solution.Insert(0, currentNode.State);
                        currentNode = currentNode.Parent;
                    }
                    break;
                }

                // Komşuları bul
                List<int[,]> neighbors = GetNeighbors(currentNode.State);

                // Her bir komşuyu işle
                foreach (var neighbor in neighbors)
                {
                    // Yeni düğüm oluştur
                    Node newNode = new Node(neighbor, currentNode.G + 1, CalculateHeuristic(neighbor, goalState), currentNode);
                    bool isOpen = false;

                    // Açık listeyi kontrol et
                    foreach (var node in openList)
                    {
                        if (ArraysEqual(node.State, newNode.State) && node.F <= newNode.F)
                        {
                            isOpen = true;
                            break;
                        }
                    }

                    // Açık listede değilse ekle
                    // Açık listede değilse veya yeni düğüm daha iyi bir yol sağlıyorsa ekle
                    if (!isOpen)
                    {
                        openList.Add(newNode);
                    }
                    else
                    {
                        // Açık listede zaten varsa, daha iyi bir yol sağlayıp sağlamadığını kontrol et
                        foreach (var node in openList)
                        {
                            if (this.ArraysEqual(node.State, newNode.State) && node.F > newNode.F)
                            {
                                // Daha iyi bir yol bulunduğunda, yeni düğümü eski düğüm ile değiştir
                                openList.Remove(node);
                                openList.Add(newNode);
                                break;
                            }
                        }
                    }
                }
            }
            return solution;
        }
    }
}