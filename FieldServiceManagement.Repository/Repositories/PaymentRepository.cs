﻿using FieldServiceManagement.Core.Entities;
using FieldServiceManagement.Core.Repositories;
using FieldServiceManagement.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Repository.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRespository
    {
        public PaymentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
