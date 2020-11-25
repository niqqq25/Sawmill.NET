using Lenta.Shared.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lenta.Shared.Models.ManufacturingProcess
{
    public class ManufacturingProcessDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ManufacturingProcessStatus Status { get; set; }
    }
}
