﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KerbalKonstructs.Core;

namespace KerbalKonstructs.Modules
{
    class Hangar : KKFacility
    {
        [CareerSetting]
        public string InStorage;
        [CareerSetting]
        public string InStorage2;
        [CareerSetting]
        public string InStorage3;


        [CFGSetting]
        float FacilityMassCapacity;
        [CFGSetting]
        int FacilityCraftCapacity;


    }
}