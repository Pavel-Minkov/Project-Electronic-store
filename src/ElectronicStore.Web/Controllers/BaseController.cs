using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ElectronicStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicStore.Web.Controllers
{
    public abstract class BaseController:Controller
    {
        protected readonly ElectronicStoreContext db;
        protected readonly IMapper mapper;

        protected BaseController(ElectronicStoreContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
    }
}
