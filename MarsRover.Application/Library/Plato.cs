using System;
using System.Collections.Generic;
namespace MarsRover.Application.Library
{

    public class Plato
    { 

    private int x;
    private int y;
    List<Position> PositionList = new List<Position>();
    List<Rover> Rovers = new List<Rover>();


    public Plato(int x_, int y_)
    {
        x = x_;
        y = y_;
        PositionList.Add(new Position() { id = 0, position = 'N' });
        PositionList.Add(new Position() { id = 1, position = 'E' });
        PositionList.Add(new Position() { id = 2, position = 'W' });
        PositionList.Add(new Position() { id = 3, position = 'S' });
    }

        public void RoverAdd(int _x, int _y, char yon)
        {
            _x = _x < 0 ? 0 : _x;
            _x = _x > x ? x : _x;

            Rovers.Add(new Rover(_x, _y, yon, PositionList));
        }

        public string hareket(int sira, char key)
    {
        switch (key.ToString().ToLower())
        {
            case "m":
                return Rovers[sira].Move(x, y);

            case "l":
                return Rovers[sira].Left();

            case "r":
                return Rovers[sira].Right();

            default:
                return "Geçerli bir işlem giriniz.";
        }
    }
        public int RoverSay()
        {
            return Rovers.Count;
        }

    }
}
