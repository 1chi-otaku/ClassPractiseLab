﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise
{
    internal class Matrix
    {
        private int[,] matrix;
        public Matrix() {
            matrix = new int[3, 3] { { 0, 0,0 }, { 0, 0,0 }, { 0, 0,0 } };
        }
        public Matrix(int[,] matrix) {
            this.matrix = matrix;
        }
        public Matrix(int n, int m)
        {
            matrix = new int[n, m];
        }
        public Matrix(int n)
        {
            matrix = new int[n,1];
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Random(int min, int max)
        {
            Random r  = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = r.Next(min, max);
                }
            }
        }
        public void Input()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter " + (i + 1) + ";" + (j + 1) + " element:");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int Min()
        {
            int min = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < min)
                    {
                        min = matrix[i,j];
                    }
                }
            }
            return min;
        }
        public int Max()
        {
            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            return max;
        }

    }
}
