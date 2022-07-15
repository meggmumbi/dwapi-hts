﻿// <auto-generated />
using System;
using Dwapi.Hts.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dwapi.Hts.Infrastructure.Migrations
{
    [DbContext(typeof(HtsContext))]
    [Migration("20220714181654_HtsEligbilityAddedColumns")]
    partial class HtsEligbilityAddedColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Cargo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Items");

                    b.Property<Guid>("ManifestId");

                    b.Property<Guid?>("RefId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ManifestId");

                    b.ToTable("Cargoes");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Docket", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Instance");

                    b.Property<string>("Name");

                    b.Property<Guid?>("RefId");

                    b.HasKey("Id");

                    b.ToTable("Dockets");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Facility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Emr");

                    b.Property<int?>("MasterFacilityId");

                    b.Property<string>("Name")
                        .HasMaxLength(120);

                    b.Property<Guid?>("RefId");

                    b.Property<int>("SiteCode");

                    b.Property<DateTime?>("SnapshotDate");

                    b.Property<int?>("SnapshotSiteCode");

                    b.Property<int?>("SnapshotVersion");

                    b.HasKey("Id");

                    b.HasIndex("MasterFacilityId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientSelfTested");

                    b.Property<string>("ClientTestedAs");

                    b.Property<string>("County");

                    b.Property<string>("CoupleDiscordant");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("DisabilityType");

                    b.Property<DateTime?>("Dob");

                    b.Property<string>("Emr");

                    b.Property<int?>("EncounterId");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("FinalResultHTS");

                    b.Property<string>("FinalResultsGiven");

                    b.Property<string>("Gender");

                    b.Property<string>("HtsNumber");

                    b.Property<string>("KeyPop");

                    b.Property<string>("KeyPopulationType");

                    b.Property<string>("MaritalStatus");

                    b.Property<int?>("MonthsLastTested");

                    b.Property<string>("NUPI");

                    b.Property<string>("PatientConsented");

                    b.Property<string>("PatientDisabled");

                    b.Property<int>("PatientPk");

                    b.Property<string>("Pkv");

                    b.Property<string>("PopulationType");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<string>("Serial");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("StrategyHTS");

                    b.Property<string>("SubCounty");

                    b.Property<string>("TBScreeningHTS");

                    b.Property<DateTime?>("TestKitExpiryDate1");

                    b.Property<string>("TestKitExpiryDate2");

                    b.Property<string>("TestKitLotNumber1");

                    b.Property<string>("TestKitLotNumber2");

                    b.Property<string>("TestKitName1");

                    b.Property<string>("TestKitName2");

                    b.Property<string>("TestResultsHTS1");

                    b.Property<string>("TestResultsHTS2");

                    b.Property<string>("TestType");

                    b.Property<string>("TestedBefore");

                    b.Property<DateTime?>("VisitDate");

                    b.Property<string>("Ward");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientLinkage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CccNumber");

                    b.Property<DateTime?>("DateEnrolled");

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<DateTime?>("DatePrefferedToBeEnrolled");

                    b.Property<string>("Emr");

                    b.Property<string>("EnrolledFacilityName");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("FacilityReferredTo");

                    b.Property<string>("HandedOverTo");

                    b.Property<string>("HandedOverToCadre");

                    b.Property<string>("HtsNumber");

                    b.Property<int>("PatientPk");

                    b.Property<DateTime?>("PhoneTracingDate");

                    b.Property<DateTime?>("PhysicalTracingDate");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<DateTime?>("ReferralDate");

                    b.Property<string>("ReportedCCCNumber");

                    b.Property<DateTime?>("ReportedStartARTDate");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("TracingOutcome");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("ClientLinkages");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientPartner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<string>("CccNumber");

                    b.Property<string>("CurrentlyLivingWithIndexClient");

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("HtsNumber");

                    b.Property<string>("IpvScreeningOutcome");

                    b.Property<string>("KnowledgeOfHivStatus");

                    b.Property<DateTime?>("LinkDateLinkedToCare");

                    b.Property<string>("Linked");

                    b.Property<int?>("PartnerPatientPk");

                    b.Property<int?>("PartnerPersonId");

                    b.Property<int>("PatientPk");

                    b.Property<string>("PnsApproach");

                    b.Property<string>("PnsConsent");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<string>("RelationshipToIndexClient");

                    b.Property<string>("ScreenedForIpv");

                    b.Property<string>("Sex");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<DateTime?>("Trace1Date");

                    b.Property<string>("Trace1Outcome");

                    b.Property<string>("Trace1Type");

                    b.Property<DateTime?>("Trace2Date");

                    b.Property<string>("Trace2Outcome");

                    b.Property<string>("Trace2Type");

                    b.Property<DateTime?>("Trace3Date");

                    b.Property<string>("Trace3Outcome");

                    b.Property<string>("Trace3Type");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("ClientPartners");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientTests", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientSelfTested");

                    b.Property<string>("ClientTestedAs");

                    b.Property<string>("Consent");

                    b.Property<string>("CoupleDiscordant");

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<int?>("EncounterId");

                    b.Property<string>("EntryPoint");

                    b.Property<string>("EverTestedForHiv");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("FinalTestResult");

                    b.Property<string>("HtsNumber");

                    b.Property<int?>("MonthsSinceLastTest");

                    b.Property<string>("PatientGivenResult");

                    b.Property<int>("PatientPk");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("TbScreening");

                    b.Property<DateTime?>("TestDate");

                    b.Property<string>("TestResult1");

                    b.Property<string>("TestResult2");

                    b.Property<string>("TestStrategy");

                    b.Property<string>("TestType");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("HtsClientTests");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientTracing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("HtsNumber");

                    b.Property<int>("PatientPk");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<DateTime?>("TracingDate");

                    b.Property<string>("TracingOutcome");

                    b.Property<string>("TracingType");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("HtsClientTracing");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsEligibilityExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlcoholSex");

                    b.Property<string>("BreastfeedingMother");

                    b.Property<string>("CCCNumber");

                    b.Property<string>("ChildReasonsForIneligibility");

                    b.Property<string>("CondomBurst");

                    b.Property<string>("Cough");

                    b.Property<string>("CoupleDiscordant");

                    b.Property<string>("CurrentlyHasSTI");

                    b.Property<string>("CurrentlyHasTB");

                    b.Property<string>("CurrentlyOnPep");

                    b.Property<string>("CurrentlyOnPrep");

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<DateTime?>("DateTestedProvider");

                    b.Property<DateTime?>("DateTestedSelf");

                    b.Property<string>("Department");

                    b.Property<string>("EligibleForTest");

                    b.Property<string>("EmotionalViolence");

                    b.Property<string>("Emr");

                    b.Property<string>("EncounterId");

                    b.Property<string>("EverHadSTI");

                    b.Property<string>("EverHadSex");

                    b.Property<string>("EverHadTB");

                    b.Property<string>("EverOnPep");

                    b.Property<string>("EverOnPrep");

                    b.Property<string>("ExperiencedGBV");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Fever");

                    b.Property<string>("HtsNumber");

                    b.Property<string>("IsHealthWorker");

                    b.Property<string>("KeyPopulation");

                    b.Property<string>("KnownStatusPartner");

                    b.Property<string>("MoneySex");

                    b.Property<string>("MothersStatus");

                    b.Property<string>("MultiplePartners");

                    b.Property<string>("NeedleStickInjuries");

                    b.Property<string>("NewPartner");

                    b.Property<string>("NightSweats");

                    b.Property<int?>("NumberOfPartners");

                    b.Property<string>("PartnerHivStatus");

                    b.Property<int>("PatientPk");

                    b.Property<string>("PatientType");

                    b.Property<string>("PhysicalViolence");

                    b.Property<string>("PopulationType");

                    b.Property<string>("Pregnant");

                    b.Property<string>("PriorityPopulation");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<string>("ReasonsForIneligibility");

                    b.Property<Guid?>("RefId");

                    b.Property<string>("ReferredForTesting");

                    b.Property<string>("RelationshipWithContact");

                    b.Property<string>("ResultOfHIV");

                    b.Property<string>("ResultOfHIVSelf");

                    b.Property<string>("ScreenedTB");

                    b.Property<string>("SexualViolence");

                    b.Property<string>("SexuallyActive");

                    b.Property<string>("SharedNeedle");

                    b.Property<int>("SiteCode");

                    b.Property<int?>("SpecificReasonForIneligibility");

                    b.Property<string>("StartedOnART");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("TBStatus");

                    b.Property<string>("TestedHIVBefore");

                    b.Property<string>("TraditionalProcedures");

                    b.Property<string>("UnknownStatusPartner");

                    b.Property<DateTime?>("VisitDate");

                    b.Property<int?>("VisitID");

                    b.Property<string>("WeightLoss");

                    b.Property<string>("WhoPerformedTest");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("HtsEligibilityExtract");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsPartnerNotificationServices", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<string>("CccNumber");

                    b.Property<string>("CurrentlyLivingWithIndexClient");

                    b.Property<DateTime?>("DateElicited");

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<DateTime?>("Dob");

                    b.Property<string>("Emr");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityLinkedTo");

                    b.Property<string>("FacilityName");

                    b.Property<string>("HtsNumber");

                    b.Property<string>("IpvScreeningOutcome");

                    b.Property<string>("KnowledgeOfHivStatus");

                    b.Property<DateTime?>("LinkDateLinkedToCare");

                    b.Property<string>("LinkedToCare");

                    b.Property<string>("MaritalStatus");

                    b.Property<int?>("PartnerPatientPk");

                    b.Property<int?>("PartnerPersonID");

                    b.Property<int>("PatientPk");

                    b.Property<string>("PnsApproach");

                    b.Property<string>("PnsConsent");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<string>("RelationsipToIndexClient");

                    b.Property<string>("ScreenedForIpv");

                    b.Property<string>("Sex");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("HtsPartnerNotificationServices");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsPartnerTracing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BookingDate");

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("HtsNumber");

                    b.Property<int?>("PartnerPersonID");

                    b.Property<int>("PatientPk");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<DateTime?>("TraceDate");

                    b.Property<string>("TraceOutcome");

                    b.Property<string>("TraceType");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("HtsPartnerTracings");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsTestKits", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<string>("Emr");

                    b.Property<int?>("EncounterId");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("HtsNumber");

                    b.Property<int>("PatientPk");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<Guid?>("RefId");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("TestKitExpiry1");

                    b.Property<string>("TestKitExpiry2");

                    b.Property<string>("TestKitLotNumber1");

                    b.Property<string>("TestKitLotNumber2");

                    b.Property<string>("TestKitName1");

                    b.Property<string>("TestKitName2");

                    b.Property<string>("TestResult1");

                    b.Property<string>("TestResult2");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("HtsTestKits");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Manifest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateArrived");

                    b.Property<DateTime>("DateLogged");

                    b.Property<Guid?>("EmrId");

                    b.Property<string>("EmrName");

                    b.Property<int>("EmrSetup");

                    b.Property<DateTime?>("End");

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("Name");

                    b.Property<int>("Recieved");

                    b.Property<Guid?>("RefId");

                    b.Property<int>("Sent");

                    b.Property<Guid?>("Session");

                    b.Property<int>("SiteCode");

                    b.Property<DateTime?>("Start");

                    b.Property<int>("Status");

                    b.Property<DateTime>("StatusDate");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("Manifests");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.MasterFacility", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("County")
                        .HasMaxLength(120);

                    b.Property<string>("Name")
                        .HasMaxLength(120);

                    b.Property<Guid?>("RefId");

                    b.Property<DateTime?>("SnapshotDate");

                    b.Property<int?>("SnapshotSiteCode");

                    b.Property<int?>("SnapshotVersion");

                    b.HasKey("Id");

                    b.ToTable("MasterFacilities");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Subscriber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthCode");

                    b.Property<string>("DocketId");

                    b.Property<string>("Name");

                    b.Property<Guid?>("RefId");

                    b.HasKey("Id");

                    b.HasIndex("DocketId");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Cargo", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Manifest")
                        .WithMany("Cargoes")
                        .HasForeignKey("ManifestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Facility", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.MasterFacility")
                        .WithMany("Mentions")
                        .HasForeignKey("MasterFacilityId");
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClient", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("Clients")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientLinkage", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("Linkages")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientPartner", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("Partners")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientTests", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("ClientTestses")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsClientTracing", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("ClientTracings")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsEligibilityExtract", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("Eligibility")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsPartnerNotificationServices", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("PartnerNotifications")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsPartnerTracing", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("HtsPartnerTracings")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.HtsTestKits", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("Kitses")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Manifest", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Facility")
                        .WithMany("Manifests")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dwapi.Hts.Core.Domain.Subscriber", b =>
                {
                    b.HasOne("Dwapi.Hts.Core.Domain.Docket")
                        .WithMany("Subscribers")
                        .HasForeignKey("DocketId");
                });
#pragma warning restore 612, 618
        }
    }
}
