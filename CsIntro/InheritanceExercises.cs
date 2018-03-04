using System;

namespace CsIntro
{
    class InheritanceExercises
    {
        public void InheritanceExercise()
        {
            var vehicle = new Vehicle();
            var car = new Car();
            var bike = new Bike();
            var vessel = new Vessel();
            var plane = new Airplane();

            vehicle.DisplayInfo();
            car.DisplayInfo();
            bike.DisplayInfo();
            vessel.DisplayInfo();
            plane.DisplayInfo();

            vehicle.StartEngine();
            car.StartEngine();
            // bike.StartEngine(); commented out to avoid thrown exception
            vessel.StartEngine();
            plane.StartEngine();

            vehicle.Accelerate();
            car.Accelerate();
            bike.Accelerate();
            vessel.Accelerate();
            plane.Accelerate();

            Console.WriteLine("==========================");
            Console.WriteLine("Vehicle has a speed of {0}", vehicle.Speed);
            Console.WriteLine("Car has a speed of {0}", car.Speed);
            Console.WriteLine("Bike has a speed of {0}", bike.Speed);
            Console.WriteLine("Vessel has a speed of {0}", vessel.Speed);
            Console.WriteLine("Plane has a speed of {0}", plane.Speed);


            vehicle.Brake();
            car.Brake(50);
            bike.Brake(5);
            vessel.Brake(10);
            plane.Brake(50);

            vehicle.DisplayInfo();
            car.DisplayInfo();
            bike.DisplayInfo();
            vessel.DisplayInfo();
            plane.DisplayInfo();
        }
    }

    class Vehicle
    {
        protected bool isEngineStarted = false;

        protected int speed;

        protected int numberOfWheels;

        protected string environment;

        public bool IsEngineStarted => this.isEngineStarted;

        public int Speed => this.speed;

        public int NumberOfWheels => this.numberOfWheels;

        public string Environment => this.environment;

        public Vehicle()
        {
            this.isEngineStarted = false;
        }

        public virtual void StartEngine()
        {
            this.isEngineStarted = true;
        }

        public virtual void StopEngine()
        {
            this.isEngineStarted = false;
        }

        public virtual void Accelerate()
        {
            if (this.isEngineStarted == false)
            {
                this.isEngineStarted = true;
            }
        }

        public virtual void Accelerate(int increment)
        {
            this.speed += increment;
            this.Accelerate();
        }

        public virtual void Brake()
        {
            if (this.speed < 0) this.speed = 0;

            if (this.speed == 0)
            {
                this.isEngineStarted = false;
            }
        }

        public virtual void Brake(int decrement)
        {
            this.speed -= decrement;
            this.Brake();
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Current Vehicle is {0}", this.GetType().Name);
            Console.WriteLine("Its natural environment is the {0}", this.environment);
            Console.WriteLine("Engine is started? {0}", this.isEngineStarted);
            Console.WriteLine("Current Speed Is {0}", this.speed);
            Console.WriteLine("It has {0} wheels", this.numberOfWheels);
        }
    }

    class Car : Vehicle
    {
        public Car()
            : base() // by calling base() the isEngineStarted gets initialized to false on base class.
        {
            base.numberOfWheels = 4;
            base.environment = "Road";
        }

        // No need to override StartEngine
        // No need to override StopEngine

        public override void Accelerate()
        {
            base.speed += 10;
            base.Accelerate();
        }

        public override void Brake()
        {
            base.speed += 10;
            base.Brake();
        }

        // No need to override DisplayInfo
    }

    class Bike : Vehicle
    {
        public Bike()
            : base()
        {
            base.numberOfWheels = 2;
            base.environment = "Road";
        }

        public override void StartEngine()
        {
            throw new Exception("A bike has no engine. It cannot be started");
        }

        public override void StopEngine()
        {
            throw new Exception("A bike has no engine. It cannot be started");
        }

        public override void Accelerate()
        {
            base.speed += 5;
            // No call to Base class as it manipulates the engine and bikes dont have engine
        }

        public override void Accelerate(int increment)
        {
            // No call to Base class as it manipulates the engine and bikes dont have engine
            base.speed += increment;
        }

        public override void Brake()
        {
            base.speed += 5;
            // No call to Base class as it manipulates the engine and bikes dont have engine
            if (speed < 0) base.speed = 0;
        }

        public override void Brake(int decrement)
        {
            // No call to Base class as it manipulates the engine and bikes dont have engine
            base.speed -= decrement;
            if (speed < 0) base.speed = 0;
        }

        public override void DisplayInfo()
        {
            // override to remove engine info as it has no engine;
            Console.WriteLine("========================");
            Console.WriteLine("Current Vehicle is {0}", this.GetType().Name);
            Console.WriteLine("Its natural environment is the {0}", this.environment);
            Console.WriteLine("Current Speed Is {0}", this.speed);
            Console.WriteLine("It has {0} wheels", this.numberOfWheels);
        }
    }

    class Vessel : Vehicle
    {
        public Vessel()
            : base()
        {
            base.numberOfWheels = 0;
            base.environment = "Sea";
        }

        // No need to override StartEngine
        // No need to override StopEngine

        public override void Accelerate()
        {
            base.speed += 8;
            base.Accelerate();
        }

        public override void Brake()
        {
            base.speed += 8;
            base.Brake();
        }

        // No need to override DisplayInfo
    }

    class Airplane : Vehicle
    {
        public Airplane()
            : base() // by calling base() the isEngineStarted gets initialized to false on base class.
        {
            base.numberOfWheels = 12;
            base.environment = "Air";
        }

        // No need to override StartEngine
        // No need to override StopEngine

        public override void Accelerate()
        {
            base.speed += 50;
            base.Accelerate();
        }

        public override void Brake()
        {
            base.speed += 50;
            base.Brake();
        }

        // No need to override DisplayInfo
    }
}
