﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Vehicles.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumption { get; }

        void Drive(double distance);

        void Refuel(double fuel);
    }
}
