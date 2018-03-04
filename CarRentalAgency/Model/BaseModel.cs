using System;

namespace CarRentalAgency.Model
{
    public class BaseModel
    {
        private string id;

        public string Id => this.id;

        public BaseModel(string id = null)
        {
            if (id == null)
            {
                this.id = Guid.NewGuid().ToString();
            }
            else
            {
                this.id = id;
            }
        }
    }
}
