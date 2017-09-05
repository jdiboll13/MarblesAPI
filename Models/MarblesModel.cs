using System;
using System.Collections.Generic;

namespace MarblesAPI.Models
{
    public class MarblesModel
    {
        public MarblesModel()
        {
        }

        public int ID { get; set; }
        public string Color { get; set; }

        public List<MarblesModel> GetMarbles()
        {
            var MarblesList = new List<MarblesModel>();
            var Red = new MarblesModel
            {
                ID = 1,
                Color = "Red",
            };
            var Blue = new MarblesModel
            {
                ID = 2,
                Color = "Blue",
            };
            var Yellow = new MarblesModel
            {
                ID = 3,
                Color = "Yellow",
            };
            var Green = new MarblesModel
            {
                ID = 4,
                Color = "Green",
            };
            var Black = new MarblesModel
            {
                ID = 5,
                Color = "Black",
            };
            var Brown = new MarblesModel
            {
                ID = 6,
                Color = "Brown",
            };
            var Orange = new MarblesModel
            {
                ID = 7,
                Color = "Orange",
            };
            var White = new MarblesModel
            {
                ID = 8,
                Color = "White",
            };
            var Gray = new MarblesModel
            {
                ID = 9,
                Color = "Gray",
            };
            MarblesList.Add(Red);
            MarblesList.Add(Blue);
            MarblesList.Add(Yellow);
            MarblesList.Add(Green);
            MarblesList.Add(Black);
            MarblesList.Add(Brown);
            MarblesList.Add(Orange);
            MarblesList.Add(White);
            MarblesList.Add(Gray);
            return MarblesList;
        }
        public override string ToString()
        {
            return $"Marble: {ID} is of the color {Color}";
        }
    }
}