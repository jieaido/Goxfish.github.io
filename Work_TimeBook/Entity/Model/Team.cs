﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class TeamEntity
    {
        public TeamEntity()
        {
            this.UserInfoEntities = new HashSet<UserInfoEntity>();
            this.StationEntities = new HashSet<StationEntity>();
        }
        [Key]
        public int TeamEntityId { get; set; }
        public string TeamName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInfoEntity> UserInfoEntities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StationEntity> StationEntities { get; set; }
    }
    }

