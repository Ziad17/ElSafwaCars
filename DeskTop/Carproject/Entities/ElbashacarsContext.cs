using System.Data.Entity;
using MySql.Data.Entity;

namespace Carproject.Entities;

[DbConfigurationType(typeof(MySqlEFConfiguration))]
public class ElbashacarsContext : DbContext
{
    public ElbashacarsContext() : base(ValidatingFunctions.getCONNECTION_STRINGS())
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    //public virtual DbSet<Car> Cars { get; set; }

    //public virtual DbSet<Cartransfer> CarTransfers { get; set; }

    //public virtual DbSet<Contr> Contrs { get; set; }

    //public virtual DbSet<FinishBill> FinishBills { get; set; }

    //public virtual DbSet<Install> Installs { get; set; }

    public virtual DbSet<LawSuit> LawSuits { get; set; }

    //public virtual DbSet<Password> Passwords { get; set; }

    //public virtual DbSet<Profit> Profits { get; set; }

    //public virtual DbSet<SellingContract> SellingContracts { get; set; }

    //public virtual DbSet<SubInstall> SubInstalls { get; set; }

    //public virtual DbSet<Withdarw> WithDraws { get; set; }
}
