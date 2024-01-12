﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle , ICompany
    {
        public Truck()
        {
        }

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F150";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void Drive()
        {
            if ( HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive{GetType().Name} now driving forward . . .");
            }
            else 
            {
                Console.WriteLine($"{GetType().Name} now driving forward . . .");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void Park()
        {
            Console.WriteLine();
        }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public bool ChangeGears(bool ischanged)
        {
            throw new NotImplementedException();
        }
    }
}