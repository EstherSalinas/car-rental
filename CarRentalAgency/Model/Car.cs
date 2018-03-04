using System;

namespace CarRentalAgency.Model
{
    public class Car : BaseModel
    {
        private string maker;
        private string model;
        private EnergyType energyType;
        private int kms;
        private decimal pricePerDay;
        private int maxKmsPerDay;
        private decimal pricePerExtraKm;
        private bool isAvailable;
        private decimal depositFee;


        public string Maker => this.maker;
        public string Model => this.model;
        public EnergyType EnergyType => this.energyType;
        public int Kms => this.kms;
        public decimal PricePerDay => this.pricePerDay;
        public int MaxKmsPerDay => this.maxKmsPerDay;
        public decimal PricePerExtraKm => this.pricePerExtraKm;
        public decimal DepositFee => this.depositFee;
        public bool IsAvailable => this.isAvailable;

        private Car(string id = null)
            : base(id)
        {
            this.kms = 0;
            this.isAvailable = true;
        }

        public Car(string maker, string model, EnergyType energyType, decimal pricePerDay, int maxKmsPerDay, decimal pricePerExtraKm, decimal depositFee, bool isAvailable = false, string id = null)
            : this(id) // to call the parameterless constructor which will default some properties.
        {
            this.maker = maker;
            this.model = model;
            this.energyType = energyType;
            this.pricePerDay = pricePerDay;
            this.maxKmsPerDay = maxKmsPerDay;
            this.pricePerExtraKm = pricePerExtraKm;
            this.depositFee = depositFee;
        }

        public void Block()
        {
            this.isAvailable = false;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                   this.Maker,
                   this.Model,
                   this.EnergyType,
                   this.PricePerDay,
                   this.MaxKmsPerDay,
                   this.PricePerExtraKm,
                   this.DepositFee,
                   this.IsAvailable,
                   this.Id);
        }
    }
}
