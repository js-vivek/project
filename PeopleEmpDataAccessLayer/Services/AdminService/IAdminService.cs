﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PeopleEmpDataAccessLayer.Services.AdminService
{
    [ServiceContract]
    interface IAdminService
    {
        [OperationContract]
        string TestService();
    }
}
