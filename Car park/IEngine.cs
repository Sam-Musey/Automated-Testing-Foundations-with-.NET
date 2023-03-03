using System;
namespace Car_park
{
	public interface IEngine
	{
		public double Power { get; set; }
		public float Volume { get; set; }
		public string Type { get; set; }
        public int SerialNumber { get; set; }

	}
}

