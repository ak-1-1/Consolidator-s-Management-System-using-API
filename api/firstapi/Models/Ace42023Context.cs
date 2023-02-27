using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace firstapi.Models;

public partial class Ace42023Context : DbContext
{
    public Ace42023Context()
    {
    }

    public Ace42023Context(DbContextOptions<Ace42023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminArpit> AdminArpits { get; set; }

    public virtual DbSet<ArtUser> ArtUsers { get; set; }

    public virtual DbSet<Artistishan> Artistishans { get; set; }

    public virtual DbSet<Authorhritik> Authorhritiks { get; set; }

    public virtual DbSet<BookCollege> BookColleges { get; set; }

    public virtual DbSet<Bookhritik> Bookhritiks { get; set; }

    public virtual DbSet<Bookuserhritik> Bookuserhritiks { get; set; }

    public virtual DbSet<BrijeshBuyer> BrijeshBuyers { get; set; }

    public virtual DbSet<BrijeshProperty> BrijeshProperties { get; set; }

    public virtual DbSet<BrijeshSeller> BrijeshSellers { get; set; }

    public virtual DbSet<BrijeshTran> BrijeshTrans { get; set; }

    public virtual DbSet<Companyawa> Companyawas { get; set; }

    public virtual DbSet<CourseArpit> CourseArpits { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DakshUser> DakshUsers { get; set; }

    public virtual DbSet<DeptFrp> DeptFrps { get; set; }

    public virtual DbSet<DeptRahul> DeptRahuls { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<EmpArpit> EmpArpits { get; set; }

    public virtual DbSet<EmpAvaneshwari> EmpAvaneshwaris { get; set; }

    public virtual DbSet<EmpBrijesh> EmpBrijeshes { get; set; }

    public virtual DbSet<EmpDaksh> EmpDakshes { get; set; }

    public virtual DbSet<EmpHarsh> EmpHarshes { get; set; }

    public virtual DbSet<EmpHritik> EmpHritiks { get; set; }

    public virtual DbSet<EmpIshwar> EmpIshwars { get; set; }

    public virtual DbSet<EmpJaivardhan> EmpJaivardhans { get; set; }

    public virtual DbSet<EmpMana> EmpManas { get; set; }

    public virtual DbSet<EmpPrem> EmpPrems { get; set; }

    public virtual DbSet<EmpSatyam> EmpSatyams { get; set; }

    public virtual DbSet<EmpUseravani> EmpUseravanis { get; set; }

    public virtual DbSet<Empawanish> Empawanishes { get; set; }

    public virtual DbSet<Empharshit> Empharshits { get; set; }

    public virtual DbSet<Empishan> Empishans { get; set; }

    public virtual DbSet<Empprabhat> Empprabhats { get; set; }

    public virtual DbSet<EmpsRahul> EmpsRahuls { get; set; }

    public virtual DbSet<EmpsSameer> EmpsSameers { get; set; }

    public virtual DbSet<EmpsSuneet> EmpsSuneets { get; set; }

    public virtual DbSet<Empsuppawanish> Empsuppawanishes { get; set; }

    public virtual DbSet<FlightAvani> FlightAvanis { get; set; }

    public virtual DbSet<Flightawa> Flightawas { get; set; }

    public virtual DbSet<FlightbookingAvani> FlightbookingAvanis { get; set; }

    public virtual DbSet<FlightuserAvani> FlightuserAvanis { get; set; }

    public virtual DbSet<GradeCollege> GradeColleges { get; set; }

    public virtual DbSet<HarshitAuth> HarshitAuths { get; set; }

    public virtual DbSet<HarshitEmpAbout> HarshitEmpAbouts { get; set; }

    public virtual DbSet<HarshitEmpList> HarshitEmpLists { get; set; }

    public virtual DbSet<IBooking> IBookings { get; set; }

    public virtual DbSet<IFlight> IFlights { get; set; }

    public virtual DbSet<IUser> IUsers { get; set; }

    public virtual DbSet<LoginAwa> LoginAwas { get; set; }

    public virtual DbSet<ManasFerry> ManasFerries { get; set; }

    public virtual DbSet<ManasPort> ManasPorts { get; set; }

    public virtual DbSet<ManasTicket> ManasTickets { get; set; }

    public virtual DbSet<ManasUser> ManasUsers { get; set; }

    public virtual DbSet<Painting> Paintings { get; set; }

    public virtual DbSet<PatientsTable> PatientsTables { get; set; }

    public virtual DbSet<PlaceImage> PlaceImages { get; set; }

    public virtual DbSet<PremAttendance> PremAttendances { get; set; }

    public virtual DbSet<PremEmployee> PremEmployees { get; set; }

    public virtual DbSet<ProjectArpit> ProjectArpits { get; set; }

    public virtual DbSet<RahulBook> RahulBooks { get; set; }

    public virtual DbSet<RahulBooking> RahulBookings { get; set; }

    public virtual DbSet<RahulUser> RahulUsers { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<SameerLmsBookCollection> SameerLmsBookCollections { get; set; }

    public virtual DbSet<SameerLmsBooking> SameerLmsBookings { get; set; }

    public virtual DbSet<SameerLmsUser> SameerLmsUsers { get; set; }

    public virtual DbSet<SameerLmslogin> SameerLmslogins { get; set; }

    public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }

    public virtual DbSet<StudentArpit> StudentArpits { get; set; }

    public virtual DbSet<StudentCollege> StudentColleges { get; set; }

    public virtual DbSet<SuneetDept> SuneetDepts { get; set; }

    public virtual DbSet<SuneetEmployee> SuneetEmployees { get; set; }

    public virtual DbSet<SuneetUser> SuneetUsers { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TouristPlace> TouristPlaces { get; set; }

    public virtual DbSet<TransactionVrm> TransactionVrms { get; set; }

    public virtual DbSet<UserCollege> UserColleges { get; set; }

    public virtual DbSet<UserList> UserLists { get; set; }

    public virtual DbSet<UserPrem> UserPrems { get; set; }

    public virtual DbSet<Userbtl> Userbtls { get; set; }

    public virtual DbSet<Userbtlishan> Userbtlishans { get; set; }

    public virtual DbSet<Userhritik> Userhritiks { get; set; }

    public virtual DbSet<UsersRahul> UsersRahuls { get; set; }

    public virtual DbSet<Usertbl> Usertbls { get; set; }

    public virtual DbSet<Usertbl2> Usertbl2s { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEVSQL.corp.local;Database=ACE 4- 2023;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminArpit>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__Admin_Ar__CBA1B2574D9736C4");

            entity.ToTable("Admin_Arpit");

            entity.Property(e => e.Userid)
                .ValueGeneratedNever()
                .HasColumnName("userid");
            entity.Property(e => e.Pwd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pwd");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ArtUser>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__art_user__DD70126488BB7E01");

            entity.ToTable("art_user");

            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Uname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("uname");
        });

        modelBuilder.Entity<Artistishan>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__artistis__DE508E2E425390CD");

            entity.ToTable("artistishan");

            entity.Property(e => e.Aid)
                .ValueGeneratedNever()
                .HasColumnName("aid");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Birthplace)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("birthplace");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.StyleOfWork)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("style_of_work");
        });

        modelBuilder.Entity<Authorhritik>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__authorhr__C6970A10555A5A05");

            entity.ToTable("authorhritik");

            entity.Property(e => e.Aid).ValueGeneratedNever();
            entity.Property(e => e.Aname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Place)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Speciality)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BookCollege>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__bookColl__490D1AE108E2EE28");

            entity.ToTable("bookCollege");

            entity.Property(e => e.BookId)
                .ValueGeneratedNever()
                .HasColumnName("book_id");
            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.BookName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("book_name");
            entity.Property(e => e.IssuedTo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("issued_to");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Bookhritik>(entity =>
        {
            entity.HasKey(e => e.Bookid).HasName("PK__bookhrit__8BEA95C5A0B3FD2E");

            entity.ToTable("bookhritik");

            entity.Property(e => e.Bookid)
                .ValueGeneratedNever()
                .HasColumnName("bookid");
            entity.Property(e => e.Authorid).HasColumnName("authorid");
            entity.Property(e => e.Genre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("genre");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Year)
                .HasColumnType("date")
                .HasColumnName("year");

            entity.HasOne(d => d.Author).WithMany(p => p.Bookhritiks)
                .HasForeignKey(d => d.Authorid)
                .HasConstraintName("FK__bookhriti__autho__1F98B2C1");
        });

        modelBuilder.Entity<Bookuserhritik>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__bookuser__C5B69A4AC4341A6F");

            entity.ToTable("bookuserhritik");

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Uname)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BrijeshBuyer>(entity =>
        {
            entity.HasKey(e => e.BuyerId).HasName("PK__Brijesh___BAD1715251431297");

            entity.ToTable("Brijesh_buyer");

            entity.Property(e => e.BuyerId)
                .ValueGeneratedNever()
                .HasColumnName("buyer_id");
            entity.Property(e => e.BuyerName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("buyer_name");
            entity.Property(e => e.BuyerPassword)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("buyer_password");
            entity.Property(e => e.InitBal)
                .HasDefaultValueSql("((100))")
                .HasColumnName("init_bal");
        });

        modelBuilder.Entity<BrijeshProperty>(entity =>
        {
            entity.HasKey(e => e.PropertyId).HasName("PK__Brijesh___735BA463E5D56375");

            entity.ToTable("Brijesh_property");

            entity.Property(e => e.PropertyId)
                .ValueGeneratedNever()
                .HasColumnName("property_id");
            entity.Property(e => e.Loc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("loc");
            entity.Property(e => e.PName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("p_name");
            entity.Property(e => e.RentPd).HasColumnName("rent_pd");
            entity.Property(e => e.SellerpId).HasColumnName("sellerp_id");

            entity.HasOne(d => d.Sellerp).WithMany(p => p.BrijeshProperties)
                .HasForeignKey(d => d.SellerpId)
                .HasConstraintName("FK__Brijesh_p__selle__4C6B5938");
        });

        modelBuilder.Entity<BrijeshSeller>(entity =>
        {
            entity.HasKey(e => e.SellerId).HasName("PK__Brijesh___780A0A9702CCDD3D");

            entity.ToTable("Brijesh_seller");

            entity.Property(e => e.SellerId)
                .ValueGeneratedNever()
                .HasColumnName("seller_id");
            entity.Property(e => e.SellerName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("seller_name");
            entity.Property(e => e.SellerPassword)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("seller_password");
        });

        modelBuilder.Entity<BrijeshTran>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__brijesh___438CAC186C2792EF");

            entity.ToTable("brijesh_trans");

            entity.Property(e => e.TransId).HasColumnName("trans_id");
            entity.Property(e => e.BuyertId).HasColumnName("buyert_id");
            entity.Property(e => e.DateFrom)
                .HasColumnType("date")
                .HasColumnName("date_from");
            entity.Property(e => e.DateTo)
                .HasColumnType("date")
                .HasColumnName("date_to");
            entity.Property(e => e.PropId).HasColumnName("prop_id");

            entity.HasOne(d => d.Buyert).WithMany(p => p.BrijeshTrans)
                .HasForeignKey(d => d.BuyertId)
                .HasConstraintName("FK__brijesh_t__buyer__4E53A1AA");

            entity.HasOne(d => d.Prop).WithMany(p => p.BrijeshTrans)
                .HasForeignKey(d => d.PropId)
                .HasConstraintName("FK__brijesh_t__prop___4F47C5E3");
        });

        modelBuilder.Entity<Companyawa>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__companya__D837D05FC2E68D49");

            entity.ToTable("companyawa");

            entity.Property(e => e.Cid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("cid");
            entity.Property(e => e.Cname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("cname");
        });

        modelBuilder.Entity<CourseArpit>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Course_A__D837D05FD53A9C35");

            entity.ToTable("Course_Arpit");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("cid");
            entity.Property(e => e.Cname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cname");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__Customer__CBA1B257F2C4ED15");

            entity.ToTable("Customer");

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<DakshUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__DakshUse__1788CC4C5F10387A");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Userpassword)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeptFrp>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__dept_frp__C03122187BC50FC9");

            entity.ToTable("dept_frp");

            entity.Property(e => e.Did).ValueGeneratedNever();
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfEmployees).HasColumnName("No_of_employees");
        });

        modelBuilder.Entity<DeptRahul>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__dept_rah__D877D216FF2C365C");

            entity.ToTable("dept_rahul");

            entity.Property(e => e.Did)
                .ValueGeneratedNever()
                .HasColumnName("did");
            entity.Property(e => e.Dname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dname");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__Emp__C1971B53F11D094C");

            entity.ToTable("Emp");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.Awards)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hobbies)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TeamLead)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Team_Lead");
            entity.Property(e => e.TeamName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Team_Name");

            entity.HasOne(d => d.TeamNameNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.TeamName)
                .HasConstraintName("FK__Emp__Team_Name__336AA144");
        });

        modelBuilder.Entity<EmpArpit>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpArpit__D9509F6D748FA414");

            entity.ToTable("EmpArpit");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpAvaneshwari>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empAvane__D9509F6DDA2524D9");

            entity.ToTable("empAvaneshwari");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpBrijesh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empBrije__D9509F6DFBBCEE86");

            entity.ToTable("empBrijesh");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpDaksh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpDaksh__C1971B53E4E8E96D");

            entity.ToTable("EmpDaksh");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpHarsh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpHarsh__C1971B533A73B3F7");

            entity.ToTable("EmpHarsh");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpHritik>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empHriti__D9509F6D9EBABC74");

            entity.ToTable("empHritik");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpIshwar>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empIshwa__D9509F6D71EE07E4");

            entity.ToTable("empIshwar");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpJaivardhan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empJaiva__D9509F6D2BCB7371");

            entity.ToTable("empJaivardhan");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<EmpMana>(entity =>
        {
            entity.HasKey(e => e.Eid);

            entity.ToTable("empManas");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpPrem>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empPrem__D9509F6D27559C2D");

            entity.ToTable("empPrem");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpSatyam>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpSatya__D9509F6D23134A4E");

            entity.ToTable("empSatyam");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpUseravani>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__empUsera__C5B69A4A38D0985D");

            entity.ToTable("empUseravani");

            entity.Property(e => e.Uid).ValueGeneratedNever();
            entity.Property(e => e.Uname)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Upassword)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Empawanish>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empawani__C1971B537D8161BB");

            entity.ToTable("empawanish");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.SId).HasColumnName("S_id");
            entity.Property(e => e.Salary).HasColumnName("salary");

            entity.HasOne(d => d.SIdNavigation).WithMany(p => p.Empawanishes)
                .HasForeignKey(d => d.SId)
                .HasConstraintName("FK__empawanish__S_id__68487DD7");
        });

        modelBuilder.Entity<Empharshit>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empharsh__D9509F6D853D881C");

            entity.ToTable("empharshit");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Empishan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empishan__D9509F6DC5134935");

            entity.ToTable("empishan");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Empprabhat>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empprabh__D9509F6DB7BF358E");

            entity.ToTable("empprabhat");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<EmpsRahul>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsRahu__D9509F6DEC4CB700");

            entity.ToTable("empsRahul");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Ecity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ecity");
            entity.Property(e => e.Edoj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("edoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Esal).HasColumnName("esal");
        });

        modelBuilder.Entity<EmpsSameer>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsSame__D9509F6D10A6543F");

            entity.ToTable("empsSameer");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Ecity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ecity");
            entity.Property(e => e.Edoj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("edoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Esal).HasColumnName("esal");
        });

        modelBuilder.Entity<EmpsSuneet>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsSune__D9509F6D3F2EB727");

            entity.ToTable("empsSuneet");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Ecity)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ecity");
            entity.Property(e => e.Edoj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("edoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Esal).HasColumnName("esal");
        });

        modelBuilder.Entity<Empsuppawanish>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("PK__empsuppa__A3DCCCA5B9ECAFAA");

            entity.ToTable("empsuppawanish");

            entity.Property(e => e.SId)
                .ValueGeneratedNever()
                .HasColumnName("S_id");
            entity.Property(e => e.Sname)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlightAvani>(entity =>
        {
            entity.HasKey(e => e.FlightNo).HasName("PK__flightAv__E3700CB103A7E6CB");

            entity.ToTable("flightAvani");

            entity.Property(e => e.FlightNo)
                .ValueGeneratedNever()
                .HasColumnName("flight_no");
            entity.Property(e => e.AirlinesName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("airlines_name");
            entity.Property(e => e.Departure)
                .HasColumnType("date")
                .HasColumnName("departure");
            entity.Property(e => e.LeaveFrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("leave_from");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<Flightawa>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__flightaw__DD7012647DE9C8F3");

            entity.ToTable("flightawa");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.Cid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("cid");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Jfrom)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("jfrom");
            entity.Property(e => e.Jto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("jto");
            entity.Property(e => e.Nticket).HasColumnName("nticket");
            entity.Property(e => e.Uname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("uname");

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.Flightawas)
                .HasForeignKey(d => d.Cid)
                .HasConstraintName("FK__flightawa__cid__5D60DB10");
        });

        modelBuilder.Entity<FlightbookingAvani>(entity =>
        {
            entity.HasKey(e => e.Bid).HasName("PK__flightbo__DE90ADE768208635");

            entity.ToTable("flightbookingAvani");

            entity.Property(e => e.Bid)
                .ValueGeneratedNever()
                .HasColumnName("bid");
            entity.Property(e => e.FlightNo).HasColumnName("flightNo");
            entity.Property(e => e.Seats).HasColumnName("seats");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");

            entity.HasOne(d => d.FlightNoNavigation).WithMany(p => p.FlightbookingAvanis)
                .HasForeignKey(d => d.FlightNo)
                .HasConstraintName("FK__flightboo__fligh__2C88998B");
        });

        modelBuilder.Entity<FlightuserAvani>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__flightus__CBA1B2574A92BF8A");

            entity.ToTable("flightuserAvani");

            entity.Property(e => e.Userid)
                .ValueGeneratedNever()
                .HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Userpass)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userpass");
        });

        modelBuilder.Entity<GradeCollege>(entity =>
        {
            entity.HasKey(e => new { e.Email, e.Subject }).HasName("PK__gradeCol__C78362F3494A794C");

            entity.ToTable("gradeCollege");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subject");
            entity.Property(e => e.Grade)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("grade");

            entity.HasOne(d => d.EmailNavigation).WithMany(p => p.GradeColleges)
                .HasForeignKey(d => d.Email)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_email");
        });

        modelBuilder.Entity<HarshitAuth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HarshitA__3214EC0704F1DC5B");

            entity.ToTable("HarshitAuth");

            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HarshitEmpAbout>(entity =>
        {
            entity.HasKey(e => e.AId).HasName("PK__HarshitE__DE518A06C357C8FE");

            entity.ToTable("HarshitEmpAbout");

            entity.Property(e => e.AId).HasColumnName("aId");
            entity.Property(e => e.EDept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("eDept");
            entity.Property(e => e.EHobbies)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eHobbies");
            entity.Property(e => e.EName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("eName");
            entity.Property(e => e.EQual)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("eQual");
            entity.Property(e => e.ESdept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("eSDept");
            entity.Property(e => e.EmpId).HasColumnName("empId");
        });

        modelBuilder.Entity<HarshitEmpList>(entity =>
        {
            entity.HasKey(e => e.EId).HasName("PK__HarshitE__D9519B452B638E65");

            entity.ToTable("HarshitEmpList");

            entity.Property(e => e.EId).HasColumnName("eId");
            entity.Property(e => e.EAdd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eAdd");
            entity.Property(e => e.EDesg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("eDesg");
            entity.Property(e => e.EDoj)
                .HasColumnType("date")
                .HasColumnName("eDoj");
            entity.Property(e => e.EName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("eName");
            entity.Property(e => e.EPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ePhone");
        });

        modelBuilder.Entity<IBooking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__iBooking__5DE3A5B10159E289");

            entity.ToTable("iBookings");

            entity.Property(e => e.BookingId)
                .ValueGeneratedNever()
                .HasColumnName("booking_id");
            entity.Property(e => e.BookingDate)
                .HasColumnType("date")
                .HasColumnName("booking_date");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.SeatNumber)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("seat_number");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Flight).WithMany(p => p.IBookings)
                .HasForeignKey(d => d.FlightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__iBookings__fligh__41B8C09B");

            entity.HasOne(d => d.User).WithMany(p => p.IBookings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__iBookings__user___40C49C62");
        });

        modelBuilder.Entity<IFlight>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__iFlights__E3705765959FAB65");

            entity.ToTable("iFlights");

            entity.Property(e => e.FlightId)
                .ValueGeneratedNever()
                .HasColumnName("flight_id");
            entity.Property(e => e.AvailableSeats).HasColumnName("available_seats");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("destination");
            entity.Property(e => e.FlightDate)
                .HasColumnType("date")
                .HasColumnName("flight_date");
            entity.Property(e => e.FlightNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flight_number");
            entity.Property(e => e.FlightPrice).HasColumnName("flight_price");
            entity.Property(e => e.FlightTime).HasColumnName("flight_time");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("origin");
        });

        modelBuilder.Entity<IUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__iUsers__B9BE370F2D23F7C0");

            entity.ToTable("iUsers");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_email");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_password");
            entity.Property(e => e.UserPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_phone");
        });

        modelBuilder.Entity<LoginAwa>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__login_aw__CBA1B257090F5E79");

            entity.ToTable("login_awa");

            entity.Property(e => e.Userid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("userid");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("phonenumber");
            entity.Property(e => e.Pword)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("pword");
            entity.Property(e => e.Username)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ManasFerry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ManasFerry1");

            entity.ToTable("ManasFerry");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Charge).HasColumnName("charge");
            entity.Property(e => e.Departure)
                .HasColumnType("datetime")
                .HasColumnName("departure");
            entity.Property(e => e.DestinationId).HasColumnName("destinationId");
            entity.Property(e => e.Image)
                .HasColumnType("text")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OriginId).HasColumnName("originId");
            entity.Property(e => e.RoomsLeft).HasColumnName("roomsLeft");

            entity.HasOne(d => d.Destination).WithMany(p => p.ManasFerryDestinations)
                .HasForeignKey(d => d.DestinationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasFerry_ManasPort1");

            entity.HasOne(d => d.Origin).WithMany(p => p.ManasFerryOrigins)
                .HasForeignKey(d => d.OriginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasFerry_ManasPort");
        });

        modelBuilder.Entity<ManasPort>(entity =>
        {
            entity.ToTable("ManasPort");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image)
                .HasColumnType("text")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ManasTicket>(entity =>
        {
            entity.ToTable("ManasTicket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdultCount).HasColumnName("adultCount");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.FerryId).HasColumnName("ferryId");
            entity.Property(e => e.RoomNo).HasColumnName("roomNo");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Ferry).WithMany(p => p.ManasTickets)
                .HasForeignKey(d => d.FerryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasTicket_ManasFerry");

            entity.HasOne(d => d.User).WithMany(p => p.ManasTickets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasTicket_ManasUser");
        });

        modelBuilder.Entity<ManasUser>(entity =>
        {
            entity.ToTable("ManasUser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.Wallet).HasColumnName("wallet");
        });

        modelBuilder.Entity<Painting>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Painting__DD37D91A3E6137C2");

            entity.ToTable("Painting");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.ArtistId).HasColumnName("artist_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.StyleOfArt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("style_of_art");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Year)
                .HasColumnType("date")
                .HasColumnName("year");

            entity.HasOne(d => d.Artist).WithMany(p => p.Paintings)
                .HasForeignKey(d => d.ArtistId)
                .HasConstraintName("FK__Painting__artist__1CBC4616");
        });

        modelBuilder.Entity<PatientsTable>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__patients__DD37D91A019C0A12");

            entity.ToTable("patientsTable");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pname");
            entity.Property(e => e.Problem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("problem");
            entity.Property(e => e.Pstatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pstatus");
        });

        modelBuilder.Entity<PlaceImage>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__place_im__DC9AC955551DE3F3");

            entity.ToTable("place_images");

            entity.Property(e => e.ImageId).HasColumnName("image_id");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("image_url");
            entity.Property(e => e.PlaceId).HasColumnName("place_id");

            entity.HasOne(d => d.Place).WithMany(p => p.PlaceImages)
                .HasForeignKey(d => d.PlaceId)
                .HasConstraintName("FK__place_ima__place__6F7F8B4B");
        });

        modelBuilder.Entity<PremAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PremAtte__3213E83F0164D6A1");

            entity.ToTable("PremAttendance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttendanceDay)
                .HasColumnType("date")
                .HasColumnName("attendanceDay");
            entity.Property(e => e.AttendanceStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attendanceStatus");
            entity.Property(e => e.AttendanceTime)
                .HasColumnType("datetime")
                .HasColumnName("attendanceTime");
            entity.Property(e => e.AttendanceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("attendanceType");
            entity.Property(e => e.EmpId).HasColumnName("empId");
            entity.Property(e => e.ManagerId).HasColumnName("managerId");

            entity.HasOne(d => d.Emp).WithMany(p => p.PremAttendanceEmps)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("FK__PremAtten__empId__1209AD79");

            entity.HasOne(d => d.Manager).WithMany(p => p.PremAttendanceManagers)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__PremAtten__manag__11158940");
        });

        modelBuilder.Entity<PremEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PremEmpl__3213E83FED4A9851");

            entity.ToTable("PremEmployee");

            entity.HasIndex(e => e.Username, "UQ__PremEmpl__F3DBC572A9C4953A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("doj");
            entity.Property(e => e.ManagerId).HasColumnName("managerId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__PremEmplo__manag__0E391C95");
        });

        modelBuilder.Entity<ProjectArpit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Project___3213E83F5182274A");

            entity.ToTable("Project_Arpit");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("branch");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Pwd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pwd");
            entity.Property(e => e.Yr).HasColumnName("yr");
        });

        modelBuilder.Entity<RahulBook>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__rahul_Bo__490D1AE1A7731EE7");

            entity.ToTable("rahul_Book");

            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.BookAuthor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("book_author");
            entity.Property(e => e.BookName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("book_name");
            entity.Property(e => e.BookQty).HasColumnName("book_qty");
        });

        modelBuilder.Entity<RahulBooking>(entity =>
        {
            entity.HasKey(e => e.Bookingid).HasName("PK__rahul_Bo__C6D307052EFDAB3E");

            entity.ToTable("rahul_Booking");

            entity.Property(e => e.Bookingid).HasColumnName("bookingid");
            entity.Property(e => e.Bid).HasColumnName("bid");
            entity.Property(e => e.Uid).HasColumnName("uid");

            entity.HasOne(d => d.BidNavigation).WithMany(p => p.RahulBookings)
                .HasForeignKey(d => d.Bid)
                .HasConstraintName("FK__rahul_Booki__bid__1E6F845E");

            entity.HasOne(d => d.UidNavigation).WithMany(p => p.RahulBookings)
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("FK__rahul_Booki__uid__1D7B6025");
        });

        modelBuilder.Entity<RahulUser>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__rahul_Us__CBA1B25753B271DE");

            entity.ToTable("rahul_User");

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
            entity.Property(e => e.Userpassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userpassword");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__2ECD6E04FD5FD456");

            entity.Property(e => e.ReviewId).HasColumnName("reviewId");
            entity.Property(e => e.Review1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("review");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reviews__userid__640DD89F");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reviews__vehicle__6501FCD8");
        });

        modelBuilder.Entity<SameerLmsBookCollection>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__SameerLM__447D36EBDB443295");

            entity.ToTable("SameerLMS_BookCollection");

            entity.Property(e => e.Isbn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BookName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PublishDate)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SameerLmsBooking>(entity =>
        {
            entity.HasKey(e => e.Usbn).HasName("PK__SameerLM__AA65F839731F75C3");

            entity.ToTable("SameerLMS_Bookings");

            entity.Property(e => e.Usbn)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("USBN");
            entity.Property(e => e.Isbn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.IssueDate)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.SameerLmsBookings)
                .HasForeignKey(d => d.Isbn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SameerLMS___ISBN__3DB3258D");

            entity.HasOne(d => d.User).WithMany(p => p.SameerLmsBookings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SameerLMS__UserI__3CBF0154");
        });

        modelBuilder.Entity<SameerLmsUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__SameerLM__1788CC4C7BB43450");

            entity.ToTable("SameerLMS_User");

            entity.Property(e => e.UserId)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserContact)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SameerLmslogin>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__SameerLM__1788CC4CD4B51CD8");

            entity.ToTable("SameerLMSLogin");

            entity.Property(e => e.UserId)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserContact)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ServiceProvider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PK__service___00E2131085C74D5E");

            entity.ToTable("service_providers");

            entity.Property(e => e.ProviderId).HasColumnName("provider_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.ProviderRating)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("provider_rating");
            entity.Property(e => e.ProviderType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("provider_type");
        });

        modelBuilder.Entity<StudentArpit>(entity =>
        {
            entity.HasKey(e => e.Rollno).HasName("PK__Student___FABA8B5B9F5DA77E");

            entity.ToTable("Student_Arpit");

            entity.Property(e => e.Rollno)
                .ValueGeneratedNever()
                .HasColumnName("rollno");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.StudentArpits)
                .HasForeignKey(d => d.Cid)
                .HasConstraintName("FK__Student_Arp__cid__23F3538A");
        });

        modelBuilder.Entity<StudentCollege>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__studentC__AB6E6165EC426050");

            entity.ToTable("studentCollege");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Birthdate)
                .HasColumnType("date")
                .HasColumnName("birthdate");
            entity.Property(e => e.Cgpa)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("CGPA");
            entity.Property(e => e.Degree)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("degree");
            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Rollno).HasColumnName("rollno");
        });

        modelBuilder.Entity<SuneetDept>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__Suneet_D__0148818EA754B5DB");

            entity.ToTable("Suneet_Dept");

            entity.Property(e => e.DeptId)
                .ValueGeneratedNever()
                .HasColumnName("DeptID");
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoOfEmployees).HasColumnName("No_of_Employees");
        });

        modelBuilder.Entity<SuneetEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Suneet_E__7AD04FF1F58F10EF");

            entity.ToTable("Suneet_Employee");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .HasColumnName("Date_of_birth");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Dept).WithMany(p => p.SuneetEmployees)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK__Suneet_Em__DeptI__18B6AB08");
        });

        modelBuilder.Entity<SuneetUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Suneet_U__1788CCACBFF2E4B3");

            entity.ToTable("Suneet_Users");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Userpassword)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamName).HasName("PK__Team__16C2F8BF06095764");

            entity.ToTable("Team");

            entity.HasIndex(e => e.Id, "UQ__Team__3214EC06B5CD49C7").IsUnique();

            entity.Property(e => e.TeamName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Team_Name");
            entity.Property(e => e.TeamLead)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Team_Lead");
        });

        modelBuilder.Entity<TouristPlace>(entity =>
        {
            entity.HasKey(e => e.PlaceId).HasName("PK__tourist___BF2B684AD276B7B5");

            entity.ToTable("tourist_places");

            entity.Property(e => e.PlaceId).HasColumnName("place_id");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PlaceRating)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("place_rating");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("state");

            entity.HasMany(d => d.Providers).WithMany(p => p.Places)
                .UsingEntity<Dictionary<string, object>>(
                    "PlaceServiceProvider",
                    r => r.HasOne<ServiceProvider>().WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__place_ser__provi__73501C2F"),
                    l => l.HasOne<TouristPlace>().WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__place_ser__place__725BF7F6"),
                    j =>
                    {
                        j.HasKey("PlaceId", "ProviderId").HasName("PK__place_se__AF25497BC7B13366");
                        j.ToTable("place_service_providers");
                    });
        });

        modelBuilder.Entity<TransactionVrm>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__9B57CF722FBCDF36");

            entity.ToTable("Transaction_vrm");

            entity.Property(e => e.TransactionId).HasColumnName("transactionId");
            entity.Property(e => e.RentalEndDate)
                .HasColumnType("date")
                .HasColumnName("rental_end_date");
            entity.Property(e => e.RentalRate)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("rental_rate");
            entity.Property(e => e.RentalStartDate)
                .HasColumnType("date")
                .HasColumnName("rental_start_date");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.VehicleId).HasColumnName("vehicleId");

            entity.HasOne(d => d.User).WithMany(p => p.TransactionVrms)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacti__useri__04AFB25B");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.TransactionVrms)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacti__vehic__03BB8E22");
        });

        modelBuilder.Entity<UserCollege>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__userColl__AB6E6165A4C62A7A");

            entity.ToTable("userCollege");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<UserList>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserList__1788CCACB1F20DE7");

            entity.ToTable("UserList");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<UserPrem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userPrem__3213E83F69169E0F");

            entity.ToTable("userPrem");

            entity.HasIndex(e => e.Username, "UQ__userPrem__F3DBC572C90E61BE").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Userbtl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__userbtl__1788CC4C1ACB02D1");

            entity.ToTable("userbtl");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Userbtlishan>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__userbtli__1788CC4C891106E7");

            entity.ToTable("userbtlishan");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Userhritik>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__userhrit__1797D024DBE43055");

            entity.ToTable("userhritik");

            entity.Property(e => e.Userid).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsersRahul>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__usersRah__DD7012643BA6E206");

            entity.ToTable("usersRahul");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.Uname)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("uname");
            entity.Property(e => e.Upswd)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("upswd");
        });

        modelBuilder.Entity<Usertbl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usertbl__1788CC4C7D51C4F2");

            entity.ToTable("Usertbl");

            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usertbl2>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usertbl2__1788CC4CD87FA2C4");

            entity.ToTable("Usertbl2");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Vehicle__5B9D25F2FF662495");

            entity.ToTable("Vehicle");

            entity.Property(e => e.VehicleId).HasColumnName("vehicleId");
            entity.Property(e => e.DailyRent).HasColumnName("dailyRent");
            entity.Property(e => e.IsAvailable)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ModelName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelName");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("registrationNumber");
            entity.Property(e => e.VehicleType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vehicleType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
