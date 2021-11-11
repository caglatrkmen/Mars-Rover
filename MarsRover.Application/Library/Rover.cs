using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System;

namespace MarsRover.Application.Library
{

    class Rover
    {
        private int x;
        private int y;
        private int positionsay;
        public List<Position> PositionList;
        public Rover(int _x, int _y, char _yon, List<Position> Positions)
        {
            x = _x;
            y = _y;
            PositionList = Positions;

            positionsay = PositionList.Find(y => y.position == _yon).id;
        }

        public string Right()
        {
            positionsay = positionsay + 1 > PositionList.Count - 1 ? 0 : positionsay + 1;
            return this.bilgi();
        }

        public string Left()
        {
            positionsay = positionsay - 1 < 0 ? PositionList.Count - 1 : positionsay - 1;
            return this.bilgi();

        }

        public string Move(int xkonum, int ykonum)
        {
            switch (positionsay)
            {
                case 0:
                    y = y + 1 > ykonum ? ykonum : y + 1;
                    break;
                case 1:
                    x = x + 1 > xkonum ? xkonum : x + 1;
                    break;
                case 2:
                    y = y - 1 < 0 ? 0 : y - 1;
                    break;
                case 3:
                    x = x - 1 < 0 ? 0 : x - 1;
                    break;
            }

            return bilgi();
        }

        public string bilgi()
        {
            return (x.ToString() + "," + y.ToString() + "," + PositionList.Find(y => y.id == positionsay).position);
        }
    }
}