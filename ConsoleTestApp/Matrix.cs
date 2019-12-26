using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Matrix
    {
        int rows, columns;

        int[,] matrix;


        public void ReadRowsColumns()
        {
            
            Console.WriteLine("Enter the  number of rows in Matrix  ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the  number of columns in Matrix ");
            columns = Convert.ToInt32(Console.ReadLine());
            matrix = new int[rows, columns];
        }
    
        public void ReadDataMatrix1()
        {

            Console.WriteLine("Enter the  elements in Matrix1 ");
            Console.WriteLine("\n");
            for (int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
        
        }
        public void DisplayMatrix1()
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");

                }
            }
        }
        public void AddMatrix(Matrix a, Matrix b)
        {
             rows = a.rows;
             columns = a.columns;
            matrix = new int[rows, columns];
            Console.WriteLine(rows);
            Console.WriteLine(columns);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }


        }

        public void DiffMatrix(Matrix a, Matrix b)
        {
            rows = a.rows;
            columns = a.columns;
            matrix = new int[rows, columns];
            Console.WriteLine(rows);
            Console.WriteLine(columns);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                }
            }


        }


        public static void Main()
            {
                Matrix ob1 = new Matrix();
                Matrix ob2 = new Matrix();
                Matrix ob3 = new Matrix();
                Matrix ob4 = new Matrix();
                Console.WriteLine("****************************ENTER THE MATRIX 1 ******************************");
                ob1.ReadRowsColumns();
                ob1.ReadDataMatrix1();


                Console.WriteLine("****************************ENTER THE MATRIX 2 ******************************");
                ob2.ReadRowsColumns();
                ob2.ReadDataMatrix1();

                Console.WriteLine("***************************THE FIRST MATRIX *******************************");
                ob1.DisplayMatrix1();
                Console.WriteLine("\n");

                Console.WriteLine("***************************THE SECOND MATRIX *******************************");
                ob1.DisplayMatrix1();
                Console.WriteLine("\n");

                Console.WriteLine("***************************THE SUM MATRIX *******************************");
            ob3.AddMatrix(ob1, ob2);
            ob3.DisplayMatrix1();

            Console.WriteLine("***************************THE DIFFERENCE MATRIX *******************************");
            ob4.DiffMatrix(ob1, ob2);
            ob4.DisplayMatrix1();

            Console.ReadKey();


            }


        

    }
}

