using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyLabOrdersApi.Models
{
    public partial class LabContext : DbContext
    {
        public LabContext()
        {
        }

        public LabContext(DbContextOptions<LabContext> options)
            : base(options)
        {
        }

        public DbSet<WebPatreq> WebPatreqs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<WebPatreq>(entity =>
            {
                entity.HasKey(e => e.Accno);

                entity.Property(e => e.Accno).HasColumnName("ACCNO");

                entity.Property(e => e.Accdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCDATE");

                entity.Property(e => e.AcctTrans).HasColumnName("ACCT_TRANS");

                entity.Property(e => e.Addrstr1)
                    .HasMaxLength(35)
                    .HasColumnName("ADDRSTR1");

                entity.Property(e => e.Addrstr2)
                    .HasMaxLength(35)
                    .HasColumnName("ADDRSTR2");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.AltSource).HasMaxLength(20);

                entity.Property(e => e.AssignmentOfBenefits).HasMaxLength(1);

                entity.Property(e => e.Authorization1).HasMaxLength(25);

                entity.Property(e => e.Authorization2).HasMaxLength(25);

                entity.Property(e => e.Authorization3).HasMaxLength(25);

                entity.Property(e => e.Billprof)
                    .HasMaxLength(1)
                    .HasColumnName("BILLPROF");

                entity.Property(e => e.Billsprof)
                    .HasMaxLength(1)
                    .HasColumnName("BILLSPROF");

                entity.Property(e => e.Billstatus)
                    .HasMaxLength(1)
                    .HasColumnName("BILLSTATUS");

                entity.Property(e => e.Billto)
                    .HasMaxLength(20)
                    .HasColumnName("BILLTO");

                entity.Property(e => e.CellPhone).HasMaxLength(15);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .HasColumnName("CITY");

                entity.Property(e => e.Comment1)
                    .HasMaxLength(85)
                    .HasColumnName("COMMENT1");

                entity.Property(e => e.Comment2)
                    .HasMaxLength(2500)
                    .HasColumnName("COMMENT2");

                entity.Property(e => e.Comment3)
                    .HasMaxLength(85)
                    .HasColumnName("COMMENT3");

                entity.Property(e => e.Comment4)
                    .HasMaxLength(85)
                    .HasColumnName("COMMENT4");

                entity.Property(e => e.Comment5)
                    .HasMaxLength(85)
                    .HasColumnName("COMMENT5");

                entity.Property(e => e.Comment6)
                    .HasMaxLength(85)
                    .HasColumnName("COMMENT6");

                entity.Property(e => e.Comment7)
                    .HasMaxLength(85)
                    .HasColumnName("COMMENT7");

                entity.Property(e => e.Commentw1)
                    .HasMaxLength(85)
                    .HasColumnName("COMMENTW1");

                entity.Property(e => e.Complete).HasColumnName("COMPLETE");

                entity.Property(e => e.CopyToId).HasColumnName("CopyToID");

                entity.Property(e => e.CopyToName).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Dcode)
                    .HasMaxLength(30)
                    .HasColumnName("DCODE");

                entity.Property(e => e.Dcode1)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE1");

                entity.Property(e => e.Dcode10)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE10");

                entity.Property(e => e.Dcode11)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE11");

                entity.Property(e => e.Dcode2)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE2");

                entity.Property(e => e.Dcode3)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE3");

                entity.Property(e => e.Dcode4)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE4");

                entity.Property(e => e.Dcode5)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE5");

                entity.Property(e => e.Dcode6)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE6");

                entity.Property(e => e.Dcode7)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE7");

                entity.Property(e => e.Dcode8)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE8");

                entity.Property(e => e.Dcode9)
                    .HasMaxLength(12)
                    .HasColumnName("DCODE9");

                entity.Property(e => e.DirNo)
                    .HasMaxLength(50)
                    .HasColumnName("DIR_NO");

                entity.Property(e => e.DlicenseNo)
                    .HasMaxLength(15)
                    .HasColumnName("DLicenseNo");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Docno).HasColumnName("DOCNO");

                entity.Property(e => e.Docno1)
                    .HasMaxLength(50)
                    .HasColumnName("DOCNO_1");

                entity.Property(e => e.Docno2).HasColumnName("DOCNO_2");

                entity.Property(e => e.Docno3).HasColumnName("DOCNO_3");

                entity.Property(e => e.DoctorName).HasMaxLength(50);

                entity.Property(e => e.Dtdrawn)
                    .HasColumnType("datetime")
                    .HasColumnName("DTDRAWN");

                entity.Property(e => e.Dtrecvd)
                    .HasColumnType("datetime")
                    .HasColumnName("DTRECVD");

                entity.Property(e => e.EffectiveFrom1).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom2).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFrom3).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo1).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo2).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo3).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.Emailed).HasColumnName("EMAILED");

                entity.Property(e => e.EmpCode).HasMaxLength(10);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.Ethnicity).HasMaxLength(15);

                entity.Property(e => e.Faxed).HasColumnName("FAXED");

                entity.Property(e => e.Fname)
                    .HasMaxLength(15)
                    .HasColumnName("FNAME");

                entity.Property(e => e.GroupName1).HasMaxLength(50);

                entity.Property(e => e.GroupName2).HasMaxLength(50);

                entity.Property(e => e.GroupName3).HasMaxLength(50);

                entity.Property(e => e.GroupNo2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Groupno)
                    .HasMaxLength(15)
                    .HasColumnName("GROUPNO");

                entity.Property(e => e.Groupno3)
                    .HasMaxLength(15)
                    .HasColumnName("GROUPNO3");

                entity.Property(e => e.Hl7transmitted).HasColumnName("HL7TRANSMITTED");

                entity.Property(e => e.Image)
                    .HasMaxLength(50)
                    .HasColumnName("image");

                entity.Property(e => e.Ins1Subscriber).HasMaxLength(15);

                entity.Property(e => e.Ins2Subscriber).HasMaxLength(15);

                entity.Property(e => e.Ins3Subscriber).HasMaxLength(15);

                entity.Property(e => e.Inscd1)
                    .HasMaxLength(7)
                    .HasColumnName("INSCD1");

                entity.Property(e => e.Inscd2)
                    .HasMaxLength(7)
                    .HasColumnName("INSCD2");

                entity.Property(e => e.Inscd3)
                    .HasMaxLength(50)
                    .HasColumnName("INSCD3");

                entity.Property(e => e.Insno1)
                    .HasMaxLength(30)
                    .HasColumnName("INSNO1");

                entity.Property(e => e.Insno2)
                    .HasMaxLength(30)
                    .HasColumnName("INSNO2");

                entity.Property(e => e.Insno3)
                    .HasMaxLength(30)
                    .HasColumnName("INSNO3");

                entity.Property(e => e.Lname)
                    .HasMaxLength(15)
                    .HasColumnName("LNAME");

                entity.Property(e => e.Location).HasMaxLength(10);

                entity.Property(e => e.Mi)
                    .HasMaxLength(1)
                    .HasColumnName("MI");

                entity.Property(e => e.ModifyingUsername).HasMaxLength(25);

                entity.Property(e => e.NursingHome).HasMaxLength(100);

                entity.Property(e => e.NursingHomeId).HasColumnName("NursingHomeID");

                entity.Property(e => e.OfficeName).HasMaxLength(30);

                entity.Property(e => e.PatChart)
                    .HasMaxLength(15)
                    .HasColumnName("PAT_CHART");

                entity.Property(e => e.PatientId2)
                    .HasMaxLength(25)
                    .HasColumnName("PatientID2");

                entity.Property(e => e.PatientId3)
                    .HasMaxLength(25)
                    .HasColumnName("PatientID3");

                entity.Property(e => e.PracticeName).HasMaxLength(30);

                entity.Property(e => e.Printed).HasColumnName("PRINTED");

                entity.Property(e => e.PrintedBy).HasMaxLength(25);

                entity.Property(e => e.Race).HasMaxLength(25);

                entity.Property(e => e.RelToResParty).HasMaxLength(10);

                entity.Property(e => e.ReleasedBy).HasMaxLength(25);

                entity.Property(e => e.ReleaseofInformation).HasMaxLength(1);

                entity.Property(e => e.Reltosub)
                    .HasMaxLength(50)
                    .HasColumnName("RELTOSUB");

                entity.Property(e => e.Reltosub2)
                    .HasMaxLength(10)
                    .HasColumnName("RELTOSUB2");

                entity.Property(e => e.RepInitdt)
                    .HasColumnType("datetime")
                    .HasColumnName("REP_INITDT");

                entity.Property(e => e.RepLastdt)
                    .HasColumnType("datetime")
                    .HasColumnName("REP_LASTDT");

                entity.Property(e => e.Repdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REPDATE");

                entity.Property(e => e.RepeatOrder).HasMaxLength(3);

                entity.Property(e => e.RepeatOrderFor).HasMaxLength(100);

                entity.Property(e => e.ReportStatus).HasMaxLength(15);

                entity.Property(e => e.Reptime)
                    .HasMaxLength(5)
                    .HasColumnName("REPTIME");

                entity.Property(e => e.ReqId)
                    .HasMaxLength(15)
                    .HasColumnName("REQ_ID");

                entity.Property(e => e.RequisitionType).HasMaxLength(10);

                entity.Property(e => e.ResponsiblePartyCode).HasMaxLength(15);

                entity.Property(e => e.RoomOrWard).HasMaxLength(50);

                entity.Property(e => e.Saved).HasColumnName("SAVED");

                entity.Property(e => e.Seclevel)
                    .HasMaxLength(3)
                    .HasColumnName("SECLEVEL");

                entity.Property(e => e.Sex)
                    .HasMaxLength(15)
                    .HasColumnName("SEX");

                entity.Property(e => e.SignatureSource).HasMaxLength(1);

                entity.Property(e => e.Siteno)
                    .HasMaxLength(10)
                    .HasColumnName("SITENO");

                entity.Property(e => e.Source).HasMaxLength(30);

                entity.Property(e => e.SpecCollectorId)
                    .HasMaxLength(15)
                    .HasColumnName("SpecCollectorID");

                entity.Property(e => e.Specrecv)
                    .HasMaxLength(20)
                    .HasColumnName("SPECRECV");

                entity.Property(e => e.Ssno)
                    .HasMaxLength(15)
                    .HasColumnName("SSNO");

                entity.Property(e => e.Stat).HasColumnName("STAT");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("STATE");

                entity.Property(e => e.SubSsno)
                    .HasMaxLength(15)
                    .HasColumnName("SubSSNO");

                entity.Property(e => e.Subdob)
                    .HasColumnType("datetime")
                    .HasColumnName("SUBDOB");

                entity.Property(e => e.Subempst)
                    .HasMaxLength(1)
                    .HasColumnName("SUBEMPST");

                entity.Property(e => e.Subfname)
                    .HasMaxLength(15)
                    .HasColumnName("SUBFNAME");

                entity.Property(e => e.Subgen)
                    .HasMaxLength(3)
                    .HasColumnName("SUBGEN");

                entity.Property(e => e.Subinsno)
                    .HasMaxLength(15)
                    .HasColumnName("SUBINSNO");

                entity.Property(e => e.Sublname)
                    .HasMaxLength(15)
                    .HasColumnName("SUBLNAME");

                entity.Property(e => e.Submi)
                    .HasMaxLength(1)
                    .HasColumnName("SUBMI");

                entity.Property(e => e.Subsex)
                    .HasMaxLength(1)
                    .HasColumnName("SUBSEX");

                entity.Property(e => e.Suppinsind)
                    .HasMaxLength(1)
                    .HasColumnName("SUPPINSIND");

                entity.Property(e => e.Telno)
                    .HasMaxLength(15)
                    .HasColumnName("TELNO");

                entity.Property(e => e.Tmdrawn)
                    .HasMaxLength(10)
                    .HasColumnName("TMDRAWN");

                entity.Property(e => e.Tmrecvd)
                    .HasMaxLength(10)
                    .HasColumnName("TMRECVD");

                entity.Property(e => e.Username).HasMaxLength(25);

                entity.Property(e => e.WorkPhone).HasMaxLength(15);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .HasColumnName("ZIP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
