﻿using LibraryData.Models;
using System.Collections.Generic;

namespace LibraryData
{
    public interface IStatusService
    {
        IEnumerable<Status> GetAll();
        Status Get(int id);
        void Add(Status newStatus);
    }
}
