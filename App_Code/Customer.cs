﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
	//public Customer()
	//{
        public string FirstName{set; get; }
        public string LastName{set; get; }
        public string Email{set; get; }
        public string LicenseNumber{set; get; }
        public string VehicleMake{set; get; }
        public string VehicleYear{set; get; }
        public string PlainPassword{set; get; }
        public Byte[] Password { set; get; }
        public int Passcode{set; get; }

	//}
}