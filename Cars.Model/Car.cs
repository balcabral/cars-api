using System;
namespace Cars.Model
{
	public class Car : BaseModel
    {
		public string Name
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public long Year
        {
            get;
            set;
        }

        public long Price
        {
            get;
            set;
        }
    }
}
