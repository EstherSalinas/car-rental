using System;

namespace CarRentalAgency.Model
{
    public class Rental : BaseModel
    {
        private string carId;
        private string customerId;
        private DateTime startDate;
        private DateTime endDate;
        private int carInitialKms;
        private decimal fee;
        private decimal depositFee;
        private int creditCardNumber;
        private RentalStatus status;

        private bool carDamaged;
        private int carFinalKms;
        private decimal extraKmsFee;
        private decimal finalTotal;

        public string CarId => this.carId;
        public string CustomerId => this.customerId;
        public DateTime StartDate => this.startDate;
        public DateTime EndDate => this.endDate;
        public int NumberOfDays => (this.endDate - this.startDate).Days;
        public int CarInitialKms => this.carInitialKms;
        public decimal Fee => this.fee;
        public decimal DepositFee => this.depositFee;
        // do not expose credit card detaails
        public RentalStatus Status => this.status;

        public bool CarDamaged => this.carDamaged;
        public int CarFinalKms => this.carFinalKms;
        public decimal ExtraKmsFee => this.extraKmsFee;
        public decimal FinalTotal => this.finalTotal;

        private Rental(string id = null, RentalStatus status = RentalStatus.Ongoing)
            : base(id)
        {
            this.status = status;
        }

        /// <summary>
        /// Constructor meant to be used when creating a new rental.
        /// </summary>
        /// <param name="car"></param>
        /// <param name="customerId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="creditCardNumber"></param>
        /// <param name="id"></param>
        public Rental(Car car, string customerId, DateTime startDate, DateTime endDate, int creditCardNumber,
            string id = null)
            : this(id)
        {
            this.carId = car.Id;
            this.customerId = customerId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.carInitialKms = car.Kms;
            this.depositFee = car.DepositFee;
            this.extraKmsFee = car.PricePerExtraKm;
            this.creditCardNumber = creditCardNumber;

            this.SetFee(car.PricePerDay);

            // The properties related to the end of the rental are set to as if the rental will end with the initial conditions as they cant be stored empty
            // They will be updated at the end of the rental
            this.carDamaged = false;
            this.carFinalKms = car.Kms;
            this.finalTotal = this.fee;

        }

        /// <summary>
        /// Constructor meant to be used when loading a rental from the data source.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="carId"></param>
        /// <param name="customerId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="carInitialKms"></param>
        /// <param name="fee"></param>
        /// <param name="depositFee"></param>
        /// <param name="creditCardNumber"></param>
        /// <param name="status"></param>
        /// <param name="carDamaged"></param>
        /// <param name="carFinalKms"></param>
        /// <param name="extraKmsFee"></param>
        /// <param name="finalTotal"></param>
        public Rental(string id, string carId, string customerId, DateTime startDate, DateTime endDate, int carInitialKms, decimal fee, decimal depositFee,
            int creditCardNumber, RentalStatus status, bool carDamaged, int carFinalKms, decimal extraKmsFee, decimal finalTotal) :
            this(id, status)
        {
            // id
            this.carId = carId;
            this.customerId = customerId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.carInitialKms = carInitialKms;
            this.fee = fee;
            this.depositFee = depositFee;
            this.creditCardNumber = creditCardNumber;
            // status
            this.carDamaged = carDamaged;
            this.carFinalKms = carFinalKms;
            this.extraKmsFee = extraKmsFee;
            this.finalTotal = finalTotal;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13}",
                   this.Id,
                   this.carId,
                   this.customerId,
                   this.startDate,
                   this.endDate,
                   this.carInitialKms,
                   this.fee,
                   this.depositFee,
                   this.creditCardNumber,
                   this.carDamaged,
                   this.carFinalKms,
                   this.extraKmsFee,
                   this.finalTotal);
        }

        private void SetFee(decimal pricePerDay)
        {
            this.fee = this.NumberOfDays * pricePerDay;
        }
    }
}

