namespace GameFifteen
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using GameFifteen.Models;

    public class Matrix
    {
        private readonly List<IPoint> directions = new List<IPoint>
                                                       {
                                                           new Point(1, 1),
                                                           new Point(1, 0),
                                                           new Point(1, -1),
                                                           new Point(0, -1),
                                                           new Point(-1, -1),
                                                           new Point(-1, 0),
                                                           new Point(-1, 1),
                                                           new Point(0, 1)
                                                       };

        private readonly int[,] matrix;

        private int currentDirectionIndex;

        private int matrixSize;

        public Matrix(int n)
        {
            this.MatrixSize = n;
            this.matrix = new int[this.MatrixSize, this.MatrixSize];
            this.FillMatrixValues();
        }

        public int MatrixSize
        {
            get
            {
                return this.matrixSize;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Matrix size cannot be less than 1");
                }

                this.matrixSize = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            for (var i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < this.matrix.GetLength(0); j++)
                {
                    output.Append(string.Format("{0,3}", this.matrix[i, j]));
                }

                output.Append(Environment.NewLine);
            }

            return output.ToString();
        }

        private void FillMatrixValues()
        {
            IPoint currentPosition = new Point(0, 0);
            var currentWriteValue = 1;

            do
            {
                this.matrix[currentPosition.X, currentPosition.Y] = currentWriteValue;
                currentPosition = this.Move(currentPosition) ?? this.GetFirstFreeCell();

                currentWriteValue++;
            }
            while (currentPosition != null);
        }

        private IPoint Move(IPoint point)
        {
            for (var i = this.currentDirectionIndex; i < this.directions.Count + this.currentDirectionIndex; i++)
            {
                var newPointX = point.X + this.directions[i % this.directions.Count].X;
                var newPointY = point.Y + this.directions[i % this.directions.Count].Y;
                var newPoint = new Point(newPointX, newPointY);
                if (this.IsPointInMatrixRange(newPoint) && (this.matrix[newPoint.X, newPoint.Y] == 0))
                {
                    this.currentDirectionIndex = i % this.directions.Count;
                    return newPoint;
                }
            }

            return null;
        }

        private bool IsPointInMatrixRange(IPoint point)
        {
            var pointInMatrixRange = point.X >= 0 && point.X < this.matrix.GetLength(0) && point.Y >= 0
                                     && point.Y < this.matrix.GetLength(0);
            return pointInMatrixRange;
        }

        private IPoint GetFirstFreeCell()
        {
            var point = new Point(0, 0);

            for (var firstFreeCell = 0; firstFreeCell < this.matrix.GetLength(0); firstFreeCell++)
            {
                for (var secondFreeCell = 0; secondFreeCell < this.matrix.GetLength(0); secondFreeCell++)
                {
                    if (this.matrix[firstFreeCell, secondFreeCell] == 0)
                    {
                        point.X = firstFreeCell;
                        point.Y = secondFreeCell;
                        this.currentDirectionIndex = 0;
                        return point;
                    }
                }
            }

            return null;
        }
    }
}