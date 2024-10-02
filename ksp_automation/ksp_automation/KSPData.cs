using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ksp_automation
{
    public static class KSPData
    {
        public static List<CelestialBody> CelestialBodies { get; private set; }
        public static List<Part> Parts { get; private set; }
        public static List<Engine> Engines { get; private set; }
        public static List<FuelTank> FuelTanks { get; private set; }

        static KSPData()
        {
            InitializeCelestialBodies();
            InitializeParts();
            InitializeEngines();
            InitializeFuelTanks();
        }

        // InitializeCelestialBodies, InitializeParts, InitializeEngines, and InitializeFuelTanks methods remain the same
        // ...

        private static void InitializeCelestialBodies()
        {
            CelestialBodies = new List<CelestialBody>
            {
            new CelestialBody { BodyId = 1, Name = "Kerbol", Type = "Star", ParentBody = null, HasAtmosphere = true, IsLandable = false, DistanceFromKerbin = 13599840256, Gravity = 17.1m, EscapeVelocity = 94672 },
            new CelestialBody { BodyId = 2, Name = "Moho", Type = "Planet", ParentBody = "Kerbol", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 9832684544, Gravity = 2.70m, EscapeVelocity = 1161 },
             new CelestialBody { BodyId = 3, Name = "Eve", Type = "Planet", ParentBody = "Kerbol", HasAtmosphere = true, IsLandable = true, DistanceFromKerbin = 9734357701, Gravity = 16.7m, EscapeVelocity = 4832 },
            new CelestialBody { BodyId = 4, Name = "Gilly", Type = "Moon", ParentBody = "Eve", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 9734357701, Gravity = 0.049m, EscapeVelocity = 35 },
          new CelestialBody { BodyId = 5, Name = "Kerbin", Type = "Planet", ParentBody = "Kerbol", HasAtmosphere = true, IsLandable = true, DistanceFromKerbin = 0, Gravity = 9.81m, EscapeVelocity = 3431 },
          new CelestialBody { BodyId = 6, Name = "Mun", Type = "Moon", ParentBody = "Kerbin", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 12000, Gravity = 1.63m, EscapeVelocity = 807 },
          new CelestialBody { BodyId = 7, Name = "Minmus", Type = "Moon", ParentBody = "Kerbin", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 47000, Gravity = 0.491m, EscapeVelocity = 242 },
           new CelestialBody { BodyId = 8, Name = "Duna", Type = "Planet", ParentBody = "Kerbol", HasAtmosphere = true, IsLandable = true, DistanceFromKerbin = 20726155264, Gravity = 2.94m, EscapeVelocity = 1372 },
            new CelestialBody { BodyId = 9, Name = "Ike", Type = "Moon", ParentBody = "Duna", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 20726155264, Gravity = 1.10m, EscapeVelocity = 534 },
          new CelestialBody { BodyId = 10, Name = "Dres", Type = "Planet", ParentBody = "Kerbol", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 40839348203, Gravity = 1.13m, EscapeVelocity = 558 },
          new CelestialBody { BodyId = 11, Name = "Jool", Type = "Planet", ParentBody = "Kerbol", HasAtmosphere = true, IsLandable = false, DistanceFromKerbin = 68773560320, Gravity = 7.85m, EscapeVelocity = 9704 },
           new CelestialBody { BodyId = 12, Name = "Laythe", Type = "Moon", ParentBody = "Jool", HasAtmosphere = true, IsLandable = true, DistanceFromKerbin = 68773560320, Gravity = 7.85m, EscapeVelocity = 2912 },
          new CelestialBody { BodyId = 13, Name = "Vall", Type = "Moon", ParentBody = "Jool", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 68773560320, Gravity = 2.31m, EscapeVelocity = 1105 },
          new CelestialBody { BodyId = 14, Name = "Tylo", Type = "Moon", ParentBody = "Jool", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 68773560320, Gravity = 7.85m, EscapeVelocity = 2912 },
         new CelestialBody { BodyId = 15, Name = "Bop", Type = "Moon", ParentBody = "Jool", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 68773560320, Gravity = 0.589m, EscapeVelocity = 239 },
          new CelestialBody { BodyId = 16, Name = "Pol", Type = "Moon", ParentBody = "Jool", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 68773560320, Gravity = 0.373m, EscapeVelocity = 181 },
          new CelestialBody { BodyId = 17, Name = "Eeloo", Type = "Planet", ParentBody = "Kerbol", HasAtmosphere = false, IsLandable = true, DistanceFromKerbin = 90118820000, Gravity = 1.69m, EscapeVelocity = 855 }
            };
        }
        private static void InitializeParts()
        {
            Parts = new List<Part>
    {
        // Command and Control
        new Part { PartId = 1, Name = "Mk1 Command Pod", Description = "A small command pod for one kerbal", Mass = 0.84m, Cost = 600m, CategoryId = 1, ManufacturerId = 1 },
        new Part { PartId = 2, Name = "Mk1-2 Command Pod", Description = "A larger command pod for three kerbals", Mass = 4.0m, Cost = 3800m, CategoryId = 1, ManufacturerId = 1 },
        new Part { PartId = 3, Name = "Mk1 Inline Cockpit", Description = "Inline cockpit for spaceplanes", Mass = 1.25m, Cost = 1600m, CategoryId = 1, ManufacturerId = 1 },

        // Fuel Tanks
        new Part { PartId = 4, Name = "FL-T100 Fuel Tank", Description = "Small fuel tank", Mass = 0.5625m, Cost = 150m, CategoryId = 2, ManufacturerId = 1 },
        new Part { PartId = 5, Name = "FL-T200 Fuel Tank", Description = "Medium fuel tank", Mass = 1.125m, Cost = 275m, CategoryId = 2, ManufacturerId = 1 },
        new Part { PartId = 6, Name = "FL-T400 Fuel Tank", Description = "Large fuel tank", Mass = 2.25m, Cost = 500m, CategoryId = 2, ManufacturerId = 1 },
        new Part { PartId = 7, Name = "FL-T800 Fuel Tank", Description = "Extra large fuel tank", Mass = 4.5m, Cost = 800m, CategoryId = 2, ManufacturerId = 1 },

        // Engines
        new Part { PartId = 101, Name = "LV-T30 \"Reliant\" Liquid Fuel Engine", Description = "Reliable liquid fuel engine for medium rockets", Mass = 1.25m, Cost = 1100m, CategoryId = 3, ManufacturerId = 3 },
        new Part { PartId = 102, Name = "LV-T45 \"Swivel\" Liquid Fuel Engine", Description = "Swivel engine with thrust vectoring", Mass = 1.5m, Cost = 1200m, CategoryId = 3, ManufacturerId = 3 },
        new Part { PartId = 103, Name = "LV-909 \"Terrier\" Liquid Fuel Engine", Description = "Efficient upper stage engine", Mass = 0.5m, Cost = 390m, CategoryId = 3, ManufacturerId = 3 },
        new Part { PartId = 104, Name = "LV-N \"Nerv\" Atomic Rocket Motor", Description = "Nuclear thermal rocket engine", Mass = 3.0m, Cost = 10000m, CategoryId = 3, ManufacturerId = 3 },
        new Part { PartId = 105, Name = "48-7S \"Spark\" Liquid Fuel Engine", Description = "Tiny engine for small crafts", Mass = 0.1m, Cost = 200m, CategoryId = 3, ManufacturerId = 3 },

        // Structural
        new Part { PartId = 201, Name = "FL-A5 Adapter", Description = "Structural adapter", Mass = 0.075m, Cost = 300m, CategoryId = 4, ManufacturerId = 1 },
        new Part { PartId = 202, Name = "TR-18A Stack Decoupler", Description = "Staging decoupler", Mass = 0.05m, Cost = 400m, CategoryId = 4, ManufacturerId = 1 },
        new Part { PartId = 203, Name = "EAS-4 Strut Connector", Description = "Strut for stabilizing crafts", Mass = 0.05m, Cost = 200m, CategoryId = 4, ManufacturerId = 1 },

        // Aerodynamics
        new Part { PartId = 301, Name = "AV-R8 Winglet", Description = "Small winglet for stability", Mass = 0.02m, Cost = 100m, CategoryId = 5, ManufacturerId = 2 },
        new Part { PartId = 302, Name = "Delta-Deluxe Winglet", Description = "Large winglet for stability", Mass = 0.1m, Cost = 600m, CategoryId = 5, ManufacturerId = 2 },

        // Science
        new Part { PartId = 401, Name = "Mystery Goo™ Containment Unit", Description = "For science!", Mass = 0.15m, Cost = 800m, CategoryId = 6, ManufacturerId = 1 },
        new Part { PartId = 402, Name = "SC-9001 Science Jr.", Description = "Materials bay for experiments", Mass = 0.3m, Cost = 1500m, CategoryId = 6, ManufacturerId = 1 }
    };
        }
        private static void InitializeEngines()
        {
            Engines = new List<Engine>
    {
        new Engine {
            PartId = 101,
            Name = "LV-T30 \"Reliant\" Liquid Fuel Engine",
            Description = "Reliable liquid fuel engine for medium rockets",
            Mass = 1.25m,
            Cost = 1100m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 240.0m,
            ThrustSeaLevel = 205.16m,
            IspVacuum = 310,
            IspSeaLevel = 265,
            FuelConsumptionRate = 13.697m,
            FuelTypeId = 2
        },
        new Engine {
            PartId = 102,
            Name = "LV-T45 \"Swivel\" Liquid Fuel Engine",
            Description = "Swivel engine with thrust vectoring",
            Mass = 1.5m,
            Cost = 1200m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 215.0m,
            ThrustSeaLevel = 167.97m,
            IspVacuum = 320,
            IspSeaLevel = 250,
            FuelConsumptionRate = 12.890m,
            FuelTypeId = 2
        },
        new Engine {
            PartId = 103,
            Name = "LV-909 \"Terrier\" Liquid Fuel Engine",
            Description = "Efficient upper stage engine",
            Mass = 0.5m,
            Cost = 390m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 60.0m,
            ThrustSeaLevel = 50.0m,
            IspVacuum = 345,
            IspSeaLevel = 85,
            FuelConsumptionRate = 3.215m,
            FuelTypeId = 2
        },
        new Engine {
            PartId = 104,
            Name = "LV-N \"Nerv\" Atomic Rocket Motor",
            Description = "Nuclear thermal rocket engine",
            Mass = 3.0m,
            Cost = 10000m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 60.0m,
            ThrustSeaLevel = 60.0m,
            IspVacuum = 800,
            IspSeaLevel = 185,
            FuelConsumptionRate = 1.531m,
            FuelTypeId = 1
        },
        new Engine {
            PartId = 105,
            Name = "48-7S \"Spark\" Liquid Fuel Engine",
            Description = "Tiny engine for small crafts",
            Mass = 0.1m,
            Cost = 200m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 20.0m,
            ThrustSeaLevel = 18.0m,
            IspVacuum = 320,
            IspSeaLevel = 270,
            FuelConsumptionRate = 1.200m,
            FuelTypeId = 2
        },
        new Engine {
            PartId = 106,
            Name = "RE-L10 \"Poodle\" Liquid Fuel Engine",
            Description = "Efficient medium-sized upper stage engine",
            Mass = 1.75m,
            Cost = 1300m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 250.0m,
            ThrustSeaLevel = 230.0m,
            IspVacuum = 350,
            IspSeaLevel = 270,
            FuelConsumptionRate = 13.45m,
            FuelTypeId = 2
        },
        new Engine {
            PartId = 107,
            Name = "RE-I5 \"Skipper\" Liquid Fuel Engine",
            Description = "High-thrust engine for large rockets",
            Mass = 3.0m,
            Cost = 5300m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 300.0m,
            ThrustSeaLevel = 280.0m,
            IspVacuum = 330,
            IspSeaLevel = 280,
            FuelConsumptionRate = 16.10m,
            FuelTypeId = 2
        },
        new Engine {
            PartId = 108,
            Name = "RE-M3 \"Mainsail\" Liquid Fuel Engine",
            Description = "High-power engine for very large rockets",
            Mass = 6.0m,
            Cost = 13000m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 1500.0m,
            ThrustSeaLevel = 1379.03m,
            IspVacuum = 310,
            IspSeaLevel = 285,
            FuelConsumptionRate = 80.55m,
            FuelTypeId = 2
        },
        new Engine {
            PartId = 109,
            Name = "CR-7 R.A.P.I.E.R. Engine",
            Description = "Dual-mode air-breathing and rocket engine",
            Mass = 2.0m,
            Cost = 6000m,
            CategoryId = 3,
            ManufacturerId = 3,
            ThrustVacuum = 180.0m,
            ThrustSeaLevel = 162.30m,
            IspVacuum = 305,
            IspSeaLevel = 275,
            FuelConsumptionRate = 10.75m,
            FuelTypeId = 2
        }
    };
        }
        private static void InitializeFuelTanks()
        {
            FuelTanks = new List<FuelTank>
    {
        new FuelTank {
            TankId = 1,
            Name = "Oscar-B Fuel Tank",
            TotalFuelUnits = 18.0m,
            FuelTypeId = 2,
            Mass = 0.025m,
            Cost = 70m
        },
        new FuelTank {
            TankId = 2,
            Name = "FL-T100 Fuel Tank",
            TotalFuelUnits = 90.0m,
            FuelTypeId = 2,
            Mass = 0.0625m,
            Cost = 150m
        },
        new FuelTank {
            TankId = 3,
            Name = "FL-T200 Fuel Tank",
            TotalFuelUnits = 180.0m,
            FuelTypeId = 2,
            Mass = 0.125m,
            Cost = 275m
        },
        new FuelTank {
            TankId = 4,
            Name = "FL-T400 Fuel Tank",
            TotalFuelUnits = 360.0m,
            FuelTypeId = 2,
            Mass = 0.25m,
            Cost = 500m
        },
        new FuelTank {
            TankId = 5,
            Name = "FL-T800 Fuel Tank",
            TotalFuelUnits = 720.0m,
            FuelTypeId = 2,
            Mass = 0.5m,
            Cost = 800m
        },
        new FuelTank {
            TankId = 6,
            Name = "Rockomax X200-8 Fuel Tank",
            TotalFuelUnits = 1440.0m,
            FuelTypeId = 2,
            Mass = 1.0m,
            Cost = 1550m
        },
        new FuelTank {
            TankId = 7,
            Name = "Rockomax X200-16 Fuel Tank",
            TotalFuelUnits = 2880.0m,
            FuelTypeId = 2,
            Mass = 2.0m,
            Cost = 3000m
        },
        new FuelTank {
            TankId = 8,
            Name = "Rockomax X200-32 Fuel Tank",
            TotalFuelUnits = 5760.0m,
            FuelTypeId = 2,
            Mass = 4.0m,
            Cost = 5750m
        },
        new FuelTank {
            TankId = 9,
            Name = "Rockomax Jumbo-64 Fuel Tank",
            TotalFuelUnits = 11520.0m,
            FuelTypeId = 2,
            Mass = 8.0m,
            Cost = 10400m
        },
        new FuelTank {
            TankId = 10,
            Name = "Kerbodyne S3-3600 Tank",
            TotalFuelUnits = 16200.0m,
            FuelTypeId = 2,
            Mass = 11.25m,
            Cost = 13500m
        },
        new FuelTank {
            TankId = 11,
            Name = "Kerbodyne S3-7200 Tank",
            TotalFuelUnits = 32400.0m,
            FuelTypeId = 2,
            Mass = 22.5m,
            Cost = 25000m
        },
        new FuelTank {
            TankId = 12,
            Name = "Kerbodyne S3-14400 Tank",
            TotalFuelUnits = 64800.0m,
            FuelTypeId = 2,
            Mass = 45.0m,
            Cost = 47000m
        },
        new FuelTank {
            TankId = 13,
            Name = "Mk1 Liquid Fuel Fuselage",
            TotalFuelUnits = 400.0m,
            FuelTypeId = 1,
            Mass = 0.375m,
            Cost = 550m
        },
        new FuelTank {
            TankId = 14,
            Name = "PB-X50R Xenon Container",
            TotalFuelUnits = 750.0m,
            FuelTypeId = 3,
            Mass = 0.075m,
            Cost = 6000m
        },
        new FuelTank {
            TankId = 15,
            Name = "FL-R10 RCS Fuel Tank",
            TotalFuelUnits = 100.0m,
            FuelTypeId = 4,
            Mass = 0.05m,
            Cost = 650m
        }
    };
        }






    }

    public class CelestialBody
    {
        public int BodyId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ParentBody { get; set; }
        public bool HasAtmosphere { get; set; }
        public bool IsLandable { get; set; }
        public long DistanceFromKerbin { get; set; }
        public decimal Gravity { get; set; }
        public int EscapeVelocity { get; set; }
    }

    public class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Mass { get; set; }
        public decimal Cost { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
    }

    public class Engine : Part
    {
        public decimal ThrustVacuum { get; set; }
        public decimal ThrustSeaLevel { get; set; }
        public int IspVacuum { get; set; }
        public int IspSeaLevel { get; set; }
        public decimal FuelConsumptionRate { get; set; }
        public int FuelTypeId { get; set; }
    }
    public class FuelTank
    {
        public int TankId { get; set; }
        public string Name { get; set; }
        public decimal TotalFuelUnits { get; set; }
        public int FuelTypeId { get; set; }
        public decimal Mass { get; set; }  // Added property
        public decimal Cost { get; set; }  // Added property
    }
}
