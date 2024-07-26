
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_mail.Model;
using E_mail.Data;

namespace E_mail.Data
{
    public class EmailContext: DbContext
    {
        public EmailContext(DbContextOptions<EmailContext> options)
                  : base(options)
        {
        }

        public DbSet<E_mail.Model.mailrequest> mailrequest { get; set; } = default!;
        public DbSet<E_mail.Model.mailSetting> mailSetting { get; set; } = default!;
    }
}



