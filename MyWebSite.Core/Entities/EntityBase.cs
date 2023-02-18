﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSite.Core.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual Guid ID { get; set; } = Guid.NewGuid();
        public virtual string CreatedBy { get; set; } = "Nurselenay ZENGİN";
        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
    }
}
