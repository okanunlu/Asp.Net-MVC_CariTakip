﻿using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip.Models
{
    public class Tur
    {
        public virtual int Id { get; set; }
        public virtual string Adi { get; set; }

    }

    public class TurMap : ClassMapping<Tur>
    {
        public TurMap()
        {
            Table("turler");
            Id(x => x.Id, x => x.Generator(Generators.Identity));
            Property(x => x.Adi, x => x.NotNullable(true));
        }
    }
}