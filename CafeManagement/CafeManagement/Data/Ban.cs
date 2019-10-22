﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Data
{
    public class Ban
    {
        public Ban()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BanId { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
        CaPheContext caPheContext = new CaPheContext();
        public List<Ban> GetAllTable()
        {
           return (from item in caPheContext.Bans
             select item).ToList();
        }

    }
}