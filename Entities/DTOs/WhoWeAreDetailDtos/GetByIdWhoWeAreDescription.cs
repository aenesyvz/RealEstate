﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.WhoWeAreDetailDtos
{

    public class GetByIdWhoWeAreDescription
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
