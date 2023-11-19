using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FlexiSkills.Models.EBPortal;

namespace FlexiSkills.Models
{
    public partial class EBPortalDbContext : DbContext
    {
        public EBPortalDbContext()
        {
        }

        public EBPortalDbContext(DbContextOptions<EBPortalDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abuja1> Abuja1s { get; set; } = null!;
        public virtual DbSet<Abuja2> Abuja2s { get; set; } = null!;
        public virtual DbSet<AcceptanceBal> AcceptanceBals { get; set; } = null!;
        public virtual DbSet<AcceptanceExemption> AcceptanceExemptions { get; set; } = null!;
        public virtual DbSet<AcceptanceFee> AcceptanceFees { get; set; } = null!;
        public virtual DbSet<AcceptanceLock> AcceptanceLocks { get; set; } = null!;
        public virtual DbSet<AcceptanceNdftupdateCount> AcceptanceNdftupdateCounts { get; set; } = null!;
        public virtual DbSet<Accepted> Accepteds { get; set; } = null!;
        public virtual DbSet<AcceptedCopy> AcceptedCopies { get; set; } = null!;
        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Addbuffer> Addbuffers { get; set; } = null!;
        public virtual DbSet<AdminLogin> AdminLogins { get; set; } = null!;
        public virtual DbSet<AdminTbl> AdminTbls { get; set; } = null!;
        public virtual DbSet<Admission> Admissions { get; set; } = null!;
        public virtual DbSet<AdmissionAllAcc> AdmissionAllAccs { get; set; } = null!;
        public virtual DbSet<AdmissionAllAccFt> AdmissionAllAccFts { get; set; } = null!;
        public virtual DbSet<AdmissionAllAdmit> AdmissionAllAdmits { get; set; } = null!;
        public virtual DbSet<AdmissionAllAdmitFt> AdmissionAllAdmitFts { get; set; } = null!;
        public virtual DbSet<AdmissionAllRep> AdmissionAllReps { get; set; } = null!;
        public virtual DbSet<AdmissionAllRepFt> AdmissionAllRepFts { get; set; } = null!;
        public virtual DbSet<AdmissionAllpayfresh> AdmissionAllpayfreshes { get; set; } = null!;
        public virtual DbSet<AdmissionAllpayfreshFt> AdmissionAllpayfreshFts { get; set; } = null!;
        public virtual DbSet<AdmissionAllreg> AdmissionAllregs { get; set; } = null!;
        public virtual DbSet<AdmissionAllregFt> AdmissionAllregFts { get; set; } = null!;
        public virtual DbSet<AdmissionAllregfresh> AdmissionAllregfreshes { get; set; } = null!;
        public virtual DbSet<AdmissionAllregfreshFt> AdmissionAllregfreshFts { get; set; } = null!;
        public virtual DbSet<AdmissionCopy> AdmissionCopies { get; set; } = null!;
        public virtual DbSet<AdmissionError> AdmissionErrors { get; set; } = null!;
        public virtual DbSet<AdmissionLetterPayment> AdmissionLetterPayments { get; set; } = null!;
        public virtual DbSet<AdmissionLetterPaymentsCopy> AdmissionLetterPaymentsCopies { get; set; } = null!;
        public virtual DbSet<AdmissionList> AdmissionLists { get; set; } = null!;
        public virtual DbSet<AdmissionRejectionPayment> AdmissionRejectionPayments { get; set; } = null!;
        public virtual DbSet<AdmissionRejectionPaymentsCopy> AdmissionRejectionPaymentsCopies { get; set; } = null!;
        public virtual DbSet<AdmissionSummaryAll> AdmissionSummaryAlls { get; set; } = null!;
        public virtual DbSet<AdmissionUnflagReason> AdmissionUnflagReasons { get; set; } = null!;
        public virtual DbSet<Admissionlistview> Admissionlistviews { get; set; } = null!;
        public virtual DbSet<Admittable> Admittables { get; set; } = null!;
        public virtual DbSet<Admitted12> Admitted12s { get; set; } = null!;
        public virtual DbSet<Admitted120> Admitted120s { get; set; } = null!;
        public virtual DbSet<AllGrad> AllGrads { get; set; } = null!;
        public virtual DbSet<AllJamb1617> AllJamb1617s { get; set; } = null!;
        public virtual DbSet<Allottedstudent> Allottedstudents { get; set; } = null!;
        public virtual DbSet<Allottedstudents2> Allottedstudents2s { get; set; } = null!;
        public virtual DbSet<AllottedstudentsCopy> AllottedstudentsCopies { get; set; } = null!;
        public virtual DbSet<AllottedstudentsCopy1> AllottedstudentsCopy1s { get; set; } = null!;
        public virtual DbSet<AllottedstudentsCopy2> AllottedstudentsCopy2s { get; set; } = null!;
        public virtual DbSet<AllottedstudentsCopy3> AllottedstudentsCopy3s { get; set; } = null!;
        public virtual DbSet<Allpaid> Allpaids { get; set; } = null!;
        public virtual DbSet<Allpayment1314Fulltime> Allpayment1314Fulltimes { get; set; } = null!;
        public virtual DbSet<Allpayment1314Parttime> Allpayment1314Parttimes { get; set; } = null!;
        public virtual DbSet<Allpayment1415Fulltime> Allpayment1415Fulltimes { get; set; } = null!;
        public virtual DbSet<Allpayment1415Parttime> Allpayment1415Parttimes { get; set; } = null!;
        public virtual DbSet<Allpayment1516Fulltime> Allpayment1516Fulltimes { get; set; } = null!;
        public virtual DbSet<Allpayment1516Parttime> Allpayment1516Parttimes { get; set; } = null!;
        public virtual DbSet<Alluser> Allusers { get; set; } = null!;
        public virtual DbSet<AppSetup> AppSetups { get; set; } = null!;
        public virtual DbSet<Appbuffer> Appbuffers { get; set; } = null!;
        public virtual DbSet<Applicant> Applicants { get; set; } = null!;
        public virtual DbSet<ApplicantComplaint> ApplicantComplaints { get; set; } = null!;
        public virtual DbSet<ApplicantsExempt> ApplicantsExempts { get; set; } = null!;
        public virtual DbSet<ApplicationinvoiceGen> ApplicationinvoiceGens { get; set; } = null!;
        public virtual DbSet<ApplicationinvoiceGenCopy> ApplicationinvoiceGenCopies { get; set; } = null!;
        public virtual DbSet<ApplicationinvoiceGenCopy1> ApplicationinvoiceGenCopy1s { get; set; } = null!;
        public virtual DbSet<Apppayerror> Apppayerrors { get; set; } = null!;
        public virtual DbSet<Appstatus> Appstatuses { get; set; } = null!;
        public virtual DbSet<AppstatusTest> AppstatusTests { get; set; } = null!;
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; } = null!;
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; } = null!;
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = null!;
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; } = null!;
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; } = null!;
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; } = null!;
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; } = null!;
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; } = null!;
        public virtual DbSet<AuditTrail> AuditTrails { get; set; } = null!;
        public virtual DbSet<AuthVerify> AuthVerifies { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Below16> Below16s { get; set; } = null!;
        public virtual DbSet<Below16compare> Below16compares { get; set; } = null!;
        public virtual DbSet<Ben716> Ben716s { get; set; } = null!;
        public virtual DbSet<Biodata2> Biodata2s { get; set; } = null!;
        public virtual DbSet<BiodataApplicant> BiodataApplicants { get; set; } = null!;
        public virtual DbSet<BiodataApplicantImage> BiodataApplicantImages { get; set; } = null!;
        public virtual DbSet<BiodataApplicantImagesNew> BiodataApplicantImagesNews { get; set; } = null!;
        public virtual DbSet<BiodataCopy2> BiodataCopy2s { get; set; } = null!;
        public virtual DbSet<BiodataEnrol> BiodataEnrols { get; set; } = null!;
        public virtual DbSet<BiodataLg> BiodataLgs { get; set; } = null!;
        public virtual DbSet<BiodataLg2> BiodataLg2s { get; set; } = null!;
        public virtual DbSet<BiodataOther> BiodataOthers { get; set; } = null!;
        public virtual DbSet<Biodatum> Biodata { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Breakdown1617Copy> Breakdown1617Copies { get; set; } = null!;
        public virtual DbSet<BreakdownExempt> BreakdownExempts { get; set; } = null!;
        public virtual DbSet<Bsc1001415> Bsc1001415s { get; set; } = null!;
        public virtual DbSet<Bsc100graded> Bsc100gradeds { get; set; } = null!;
        public virtual DbSet<Bscgraded> Bscgradeds { get; set; } = null!;
        public virtual DbSet<Businessadmin> Businessadmins { get; set; } = null!;
        public virtual DbSet<CarryCapacity> CarryCapacities { get; set; } = null!;
        public virtual DbSet<CarryingCapacity> CarryingCapacities { get; set; } = null!;
        public virtual DbSet<ChangeOfCoursePayment> ChangeOfCoursePayments { get; set; } = null!;
        public virtual DbSet<ChangeOfCoursePayment2> ChangeOfCoursePayment2s { get; set; } = null!;
        public virtual DbSet<ChangeOfCoursePaymentCopy> ChangeOfCoursePaymentCopies { get; set; } = null!;
        public virtual DbSet<Changehnd> Changehnds { get; set; } = null!;
        public virtual DbSet<ChangeofCourse> ChangeofCourses { get; set; } = null!;
        public virtual DbSet<ChangeofCourse2> ChangeofCourse2s { get; set; } = null!;
        public virtual DbSet<ChangeofCourse2016> ChangeofCourse2016s { get; set; } = null!;
        public virtual DbSet<ChangeofCourseHistory> ChangeofCourseHistories { get; set; } = null!;
        public virtual DbSet<Changeofcourse1617> Changeofcourse1617s { get; set; } = null!;
        public virtual DbSet<CivlHnd> CivlHnds { get; set; } = null!;
        public virtual DbSet<Clearance> Clearances { get; set; } = null!;
        public virtual DbSet<ClearanceFlag> ClearanceFlags { get; set; } = null!;
        public virtual DbSet<ClearanceNotQualified> ClearanceNotQualifieds { get; set; } = null!;
        public virtual DbSet<ClearanceOfficer> ClearanceOfficers { get; set; } = null!;
        public virtual DbSet<ClearanceOverride> ClearanceOverrides { get; set; } = null!;
        public virtual DbSet<ClearanceRegularization> ClearanceRegularizations { get; set; } = null!;
        public virtual DbSet<ClearanceRegularizationPayment> ClearanceRegularizationPayments { get; set; } = null!;
        public virtual DbSet<ClearanceRejectionReason> ClearanceRejectionReasons { get; set; } = null!;
        public virtual DbSet<ClearanceRequirement> ClearanceRequirements { get; set; } = null!;
        public virtual DbSet<ClearanceRequirement1> ClearanceRequirements1 { get; set; } = null!;
        public virtual DbSet<ClearanceRequirementCompleted> ClearanceRequirementCompleteds { get; set; } = null!;
        public virtual DbSet<ClearanceReverse> ClearanceReverses { get; set; } = null!;
        public virtual DbSet<ClearanceVerificationStatus> ClearanceVerificationStatuses { get; set; } = null!;
        public virtual DbSet<Club> Clubs { get; set; } = null!;
        public virtual DbSet<ComplaintAll> ComplaintAlls { get; set; } = null!;
        public virtual DbSet<Compsci> Compscis { get; set; } = null!;
        public virtual DbSet<EBPortal.Convert> Converts { get; set; } = null!;
        public virtual DbSet<Conveyregret> Conveyregrets { get; set; } = null!;
        public virtual DbSet<Conveyregrets2> Conveyregrets2s { get; set; } = null!;
        public virtual DbSet<ConveyregretsChangeofcourse> ConveyregretsChangeofcourses { get; set; } = null!;
        public virtual DbSet<ConveyregretsChangeofcoursee> ConveyregretsChangeofcoursees { get; set; } = null!;
        public virtual DbSet<Correctedscore> Correctedscores { get; set; } = null!;
        public virtual DbSet<CorrectionPanelhistory> CorrectionPanelhistories { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Course1> Courses1 { get; set; } = null!;
        public virtual DbSet<CourseCode> CourseCodes { get; set; } = null!;
        public virtual DbSet<CourseRegistration> CourseRegistrations { get; set; } = null!;
        public virtual DbSet<CourseRegistration11> CourseRegistration11s { get; set; } = null!;
        public virtual DbSet<CourseRegistrationDetail> CourseRegistrationDetails { get; set; } = null!;
        public virtual DbSet<CourseRegistrationLatePayment> CourseRegistrationLatePayments { get; set; } = null!;
        public virtual DbSet<CourseRegistrationLateSubmission> CourseRegistrationLateSubmissions { get; set; } = null!;
        public virtual DbSet<CourseStatus> CourseStatuses { get; set; } = null!;
        public virtual DbSet<CourseTitle> CourseTitles { get; set; } = null!;
        public virtual DbSet<CourseregistrationApproval> CourseregistrationApprovals { get; set; } = null!;
        public virtual DbSet<CrimeElect> CrimeElects { get; set; } = null!;
        public virtual DbSet<Cutof> Cutofs { get; set; } = null!;
        public virtual DbSet<Cutoff20152016> Cutoff20152016s { get; set; } = null!;
        public virtual DbSet<Cvdumpsent> Cvdumpsents { get; set; } = null!;
        public virtual DbSet<DayOne> DayOnes { get; set; } = null!;
        public virtual DbSet<DbLog> DbLogs { get; set; } = null!;
        public virtual DbSet<De2015> De2015s { get; set; } = null!;
        public virtual DbSet<DeptTable> DeptTables { get; set; } = null!;
        public virtual DbSet<DirectEntryAll> DirectEntryAlls { get; set; } = null!;
        public virtual DbSet<DirectEntryAllCopy> DirectEntryAllCopies { get; set; } = null!;
        public virtual DbSet<DirectInsert> DirectInserts { get; set; } = null!;
        public virtual DbSet<DirectInsertAll> DirectInsertAlls { get; set; } = null!;
        public virtual DbSet<DirectInsertChangeofCourse> DirectInsertChangeofCourses { get; set; } = null!;
        public virtual DbSet<DirectInsertChangeofCourse1> DirectInsertChangeofCourse1s { get; set; } = null!;
        public virtual DbSet<DirectInsertChangeofCourseRegraded> DirectInsertChangeofCourseRegradeds { get; set; } = null!;
        public virtual DbSet<DirectInsertCorrectedff> DirectInsertCorrectedffs { get; set; } = null!;
        public virtual DbSet<DirectInsertFirstChoice> DirectInsertFirstChoices { get; set; } = null!;
        public virtual DbSet<DirectInsertMain> DirectInsertMains { get; set; } = null!;
        public virtual DbSet<DirectInsertOld> DirectInsertOlds { get; set; } = null!;
        public virtual DbSet<DirectInsertPt> DirectInsertPts { get; set; } = null!;
        public virtual DbSet<DirectInsertRegraded> DirectInsertRegradeds { get; set; } = null!;
        public virtual DbSet<DirectStudent> DirectStudents { get; set; } = null!;
        public virtual DbSet<DirectentryPayment> DirectentryPayments { get; set; } = null!;
        public virtual DbSet<Dob> Dobs { get; set; } = null!;
        public virtual DbSet<DupsEed> DupsEeds { get; set; } = null!;
        public virtual DbSet<EbportalLog> EbportalLogs { get; set; } = null!;
        public virtual DbSet<Eedmatnum1111> Eedmatnum1111s { get; set; } = null!;
        public virtual DbSet<Eenableddvverified> Eenableddvverifieds { get; set; } = null!;
        public virtual DbSet<Eld> Elds { get; set; } = null!;
        public virtual DbSet<ElectricalHnd> ElectricalHnds { get; set; } = null!;
        public virtual DbSet<EneedCbt> EneedCbts { get; set; } = null!;
        public virtual DbSet<EnvHnd> EnvHnds { get; set; } = null!;
        public virtual DbSet<Epething> Epethings { get; set; } = null!;
        public virtual DbSet<Er4Bsc1516> Er4Bsc1516s { get; set; } = null!;
        public virtual DbSet<Er5view1516pt> Er5view1516pts { get; set; } = null!;
        public virtual DbSet<Err> Errs { get; set; } = null!;
        public virtual DbSet<Err2> Err2s { get; set; } = null!;
        public virtual DbSet<ErrBuffer> ErrBuffers { get; set; } = null!;
        public virtual DbSet<Error127> Error127s { get; set; } = null!;
        public virtual DbSet<Error18> Error18s { get; set; } = null!;
        public virtual DbSet<Error21> Error21s { get; set; } = null!;
        public virtual DbSet<ErrorJamb1617> ErrorJamb1617s { get; set; } = null!;
        public virtual DbSet<EscreenExemption> EscreenExemptions { get; set; } = null!;
        public virtual DbSet<EscreenExemption1> EscreenExemptions1 { get; set; } = null!;
        public virtual DbSet<EscreenExemptionBck> EscreenExemptionBcks { get; set; } = null!;
        public virtual DbSet<ExceptionVerificationPayment> ExceptionVerificationPayments { get; set; } = null!;
        public virtual DbSet<Export> Exports { get; set; } = null!;
        public virtual DbSet<FakeNdNceResult1516> FakeNdNceResult1516s { get; set; } = null!;
        public virtual DbSet<FirstChoice201516> FirstChoice201516s { get; set; } = null!;
        public virtual DbSet<Firstchoice1617> Firstchoice1617s { get; set; } = null!;
        public virtual DbSet<Firstchoice1617Copy> Firstchoice1617Copies { get; set; } = null!;
        public virtual DbSet<Firstcombined> Firstcombineds { get; set; } = null!;
        public virtual DbSet<FlagAdmission> FlagAdmissions { get; set; } = null!;
        public virtual DbSet<FlagAdmissionCopy> FlagAdmissionCopies { get; set; } = null!;
        public virtual DbSet<FlagAdmissionCopy1> FlagAdmissionCopy1s { get; set; } = null!;
        public virtual DbSet<Foodtech> Foodteches { get; set; } = null!;
        public virtual DbSet<Found> Founds { get; set; } = null!;
        public virtual DbSet<GenMatricno> GenMatricnos { get; set; } = null!;
        public virtual DbSet<GenMatricnosar> GenMatricnosars { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Genmatric> Genmatrics { get; set; } = null!;
        public virtual DbSet<Genmatric1> Genmatric1s { get; set; } = null!;
        public virtual DbSet<GradTable2016> GradTable2016s { get; set; } = null!;
        public virtual DbSet<GradedOlevel> GradedOlevels { get; set; } = null!;
        public virtual DbSet<GradedUtme> GradedUtmes { get; set; } = null!;
        public virtual DbSet<GraderOlevelTotalCount> GraderOlevelTotalCounts { get; set; } = null!;
        public virtual DbSet<GraderUtmelTotalCount> GraderUtmelTotalCounts { get; set; } = null!;
        public virtual DbSet<Gradsegun> Gradseguns { get; set; } = null!;
        public virtual DbSet<GtcocalscanPaymentDetail> GtcocalscanPaymentDetails { get; set; } = null!;
        public virtual DbSet<Gtcocut> Gtcocuts { get; set; } = null!;
        public virtual DbSet<Gtcocut1> Gtcocuts1 { get; set; } = null!;
        public virtual DbSet<HNdacc> HNdaccs { get; set; } = null!;
        public virtual DbSet<Hdn> Hdns { get; set; } = null!;
        public virtual DbSet<HndCertificate> HndCertificates { get; set; } = null!;
        public virtual DbSet<HndWithScore> HndWithScores { get; set; } = null!;
        public virtual DbSet<Hndscreeninglist> Hndscreeninglists { get; set; } = null!;
        public virtual DbSet<Hostel> Hostels { get; set; } = null!;
        public virtual DbSet<HostelApplicationPayment> HostelApplicationPayments { get; set; } = null!;
        public virtual DbSet<HostelExemption> HostelExemptions { get; set; } = null!;
        public virtual DbSet<HostelExtra> HostelExtras { get; set; } = null!;
        public virtual DbSet<HostelExtra2> HostelExtra2s { get; set; } = null!;
        public virtual DbSet<HostelExtra3> HostelExtra3s { get; set; } = null!;
        public virtual DbSet<HostelExtra4> HostelExtra4s { get; set; } = null!;
        public virtual DbSet<HostelLock> HostelLocks { get; set; } = null!;
        public virtual DbSet<HostelPayment2> HostelPayments1 { get; set; } = null!;
        public virtual DbSet<Hosteladmin> Hosteladmins { get; set; } = null!;
        public virtual DbSet<Hostelapplication> Hostelapplications { get; set; } = null!;
        public virtual DbSet<HostelapplicationCopy> HostelapplicationCopies { get; set; } = null!;
        public virtual DbSet<HostelapplicationCopy1> HostelapplicationCopy1s { get; set; } = null!;
        public virtual DbSet<HostelapplicationWithduplicate> HostelapplicationWithduplicates { get; set; } = null!;
        public virtual DbSet<Hostelclearancelog> Hostelclearancelogs { get; set; } = null!;
        public virtual DbSet<Hostellist1> Hostellist1s { get; set; } = null!;
        public virtual DbSet<Hostelpaydistinct> Hostelpaydistincts { get; set; } = null!;
        public virtual DbSet<Hostelpayment> Hostelpayments { get; set; } = null!;
        public virtual DbSet<Hostelpayment1> Hostelpayment1s { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<ImagesBsc> ImagesBscs { get; set; } = null!;
        public virtual DbSet<ImeHnd> ImeHnds { get; set; } = null!;
        public virtual DbSet<ImeHnd2> ImeHnd2s { get; set; } = null!;
        public virtual DbSet<Invalidsex> Invalidsexes { get; set; } = null!;
        public virtual DbSet<Jamb11617> Jamb11617s { get; set; } = null!;
        public virtual DbSet<JambAdmission20162017> JambAdmission20162017s { get; set; } = null!;
        public virtual DbSet<JambData201516> JambData201516s { get; set; } = null!;
        public virtual DbSet<JambData201516Copy> JambData201516Copies { get; set; } = null!;
        public virtual DbSet<JambDe> JambDes { get; set; } = null!;
        public virtual DbSet<JambDe1617> JambDe1617s { get; set; } = null!;
        public virtual DbSet<JambDeletion> JambDeletions { get; set; } = null!;
        public virtual DbSet<JambErrorAfterAdmission> JambErrorAfterAdmissions { get; set; } = null!;
        public virtual DbSet<JambErrorEvangel> JambErrorEvangels { get; set; } = null!;
        public virtual DbSet<JambErrors2> JambErrors2s { get; set; } = null!;
        public virtual DbSet<JambErrorsNew> JambErrorsNews { get; set; } = null!;
        public virtual DbSet<JambReg> JambRegs { get; set; } = null!;
        public virtual DbSet<JambScore201617> JambScore201617s { get; set; } = null!;
        public virtual DbSet<JambVsYabaState> JambVsYabaStates { get; set; } = null!;
        public virtual DbSet<Jambadmission> Jambadmissions { get; set; } = null!;
        public virtual DbSet<Jambadmission1617> Jambadmission1617s { get; set; } = null!;
        public virtual DbSet<Jambadmitted> Jambadmitteds { get; set; } = null!;
        public virtual DbSet<JambdataNew> JambdataNews { get; set; } = null!;
        public virtual DbSet<Jambimgg1617> Jambimgg1617s { get; set; } = null!;
        public virtual DbSet<Jamblga> Jamblgas { get; set; } = null!;
        public virtual DbSet<JambmultipleReg1617> JambmultipleReg1617s { get; set; } = null!;
        public virtual DbSet<Jambnoscore1617> Jambnoscore1617s { get; set; } = null!;
        public virtual DbSet<Jambnsukkaerror> Jambnsukkaerrors { get; set; } = null!;
        public virtual DbSet<Jambscoregrader> Jambscoregraders { get; set; } = null!;
        public virtual DbSet<Jambstate> Jambstates { get; set; } = null!;
        public virtual DbSet<JambvsYabaProgram> JambvsYabaPrograms { get; set; } = null!;
        public virtual DbSet<Jambvstech> Jambvsteches { get; set; } = null!;
        public virtual DbSet<Jambvsyabaolevel> Jambvsyabaolevels { get; set; } = null!;
        public virtual DbSet<L18except> L18excepts { get; set; } = null!;
        public virtual DbSet<LateRegToken> LateRegTokens { get; set; } = null!;
        public virtual DbSet<Lessthan40PostutmeApplicantList> Lessthan40PostutmeApplicantLists { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<LevelRepeat> LevelRepeats { get; set; } = null!;
        public virtual DbSet<Lga> Lgas { get; set; } = null!;
        public virtual DbSet<ListofCourseChangeofCourse> ListofCourseChangeofCourses { get; set; } = null!;
        public virtual DbSet<MainstreamInvoice> MainstreamInvoices { get; set; } = null!;
        public virtual DbSet<ManualAdmission> ManualAdmissions { get; set; } = null!;
        public virtual DbSet<ManualDirectInsert> ManualDirectInserts { get; set; } = null!;
        public virtual DbSet<Marketingnum> Marketingnums { get; set; } = null!;
        public virtual DbSet<Maskprogid> Maskprogids { get; set; } = null!;
        public virtual DbSet<Matnum> Matnums { get; set; } = null!;
        public virtual DbSet<Matricbase> Matricbases { get; set; } = null!;
        public virtual DbSet<MechHnd> MechHnds { get; set; } = null!;
        public virtual DbSet<Medical> Medicals { get; set; } = null!;
        public virtual DbSet<MedicalFire> MedicalFires { get; set; } = null!;
        public virtual DbSet<MedicalRecord> MedicalRecords { get; set; } = null!;
        public virtual DbSet<Metaaalur> Metaaalurs { get; set; } = null!;
        public virtual DbSet<MicroFinanceHostel> MicroFinanceHostels { get; set; } = null!;
        public virtual DbSet<MicroFinanceHostelCopy1> MicroFinanceHostelCopy1s { get; set; } = null!;
        public virtual DbSet<MicroFinanceNew> MicroFinanceNews { get; set; } = null!;
        public virtual DbSet<MicroFinancePending> MicroFinancePendings { get; set; } = null!;
        public virtual DbSet<MobileNotification> MobileNotifications { get; set; } = null!;
        public virtual DbSet<MopupDay> MopupDays { get; set; } = null!;
        public virtual DbSet<MysqlProgram> MysqlPrograms { get; set; } = null!;
        public virtual DbSet<Name> Names { get; set; } = null!;
        public virtual DbSet<NewCollegeMatriccnumm> NewCollegeMatriccnumms { get; set; } = null!;
        public virtual DbSet<NewJambErrorAfterAdmission> NewJambErrorAfterAdmissions { get; set; } = null!;
        public virtual DbSet<NewOtherPayment> NewOtherPayments { get; set; } = null!;
        public virtual DbSet<Newmatricgen> Newmatricgens { get; set; } = null!;
        public virtual DbSet<Newmatricgendel> Newmatricgendels { get; set; } = null!;
        public virtual DbSet<Newyabaerror> Newyabaerrors { get; set; } = null!;
        public virtual DbSet<NoisyDatum> NoisyData { get; set; } = null!;
        public virtual DbSet<NotOnJamb20162017> NotOnJamb20162017s { get; set; } = null!;
        public virtual DbSet<NyscUpdate> NyscUpdates { get; set; } = null!;
        public virtual DbSet<Nyscjamb> Nyscjambs { get; set; } = null!;
        public virtual DbSet<Nysclist2021> Nysclist2021s { get; set; } = null!;
        public virtual DbSet<Oldyear> Oldyears { get; set; } = null!;
        public virtual DbSet<OlevelExam> OlevelExams { get; set; } = null!;
        public virtual DbSet<OlevelExamMonth> OlevelExamMonths { get; set; } = null!;
        public virtual DbSet<OlevelExamName> OlevelExamNames { get; set; } = null!;
        public virtual DbSet<OlevelExamYear> OlevelExamYears { get; set; } = null!;
        public virtual DbSet<OlevelExamsApplicant> OlevelExamsApplicants { get; set; } = null!;
        public virtual DbSet<OlevelGrade> OlevelGrades { get; set; } = null!;
        public virtual DbSet<OlevelResult> OlevelResults { get; set; } = null!;
        public virtual DbSet<OlevelResultsApplicant> OlevelResultsApplicants { get; set; } = null!;
        public virtual DbSet<OlevelResultsApplicantPre> OlevelResultsApplicantPres { get; set; } = null!;
        public virtual DbSet<OlevelSittingSelected> OlevelSittingSelecteds { get; set; } = null!;
        public virtual DbSet<OlevelSittingTbl> OlevelSittingTbls { get; set; } = null!;
        public virtual DbSet<OlevelSittingTbl1> OlevelSittingTbls1 { get; set; } = null!;
        public virtual DbSet<OlevelSubject> OlevelSubjects { get; set; } = null!;
        public virtual DbSet<Olevelgrader> Olevelgraders { get; set; } = null!;
        public virtual DbSet<OlevelgraderPt> OlevelgraderPts { get; set; } = null!;
        public virtual DbSet<Olevelvsyaba> Olevelvsyabas { get; set; } = null!;
        public virtual DbSet<OnlineAppChangeCourse> OnlineAppChangeCourses { get; set; } = null!;
        public virtual DbSet<OnlineAppImage> OnlineAppImages { get; set; } = null!;
        public virtual DbSet<OnlineAppLogDb> OnlineAppLogDbs { get; set; } = null!;
        public virtual DbSet<OnlineAppSaved> OnlineAppSaveds { get; set; } = null!;
        public virtual DbSet<OnlineAppSetting> OnlineAppSettings { get; set; } = null!;
        public virtual DbSet<OnlineAppVerficationPayment> OnlineAppVerficationPayments { get; set; } = null!;
        public virtual DbSet<OnlineappAll> OnlineappAlls { get; set; } = null!;
        public virtual DbSet<OnlineappComplain> OnlineappComplains { get; set; } = null!;
        public virtual DbSet<OnlineappCompleted> OnlineappCompleteds { get; set; } = null!;
        public virtual DbSet<OnlineappPayment> OnlineappPayments { get; set; } = null!;
        public virtual DbSet<OtherPayment> OtherPayments { get; set; } = null!;
        public virtual DbSet<Otmstudent> Otmstudents { get; set; } = null!;
        public virtual DbSet<Outsssss> Outssssses { get; set; } = null!;
        public virtual DbSet<Outstanding> Outstandings { get; set; } = null!;
        public virtual DbSet<Outstudent> Outstudents { get; set; } = null!;
        public virtual DbSet<Payfromgit> Payfromgits { get; set; } = null!;
        public virtual DbSet<PaymantStatus> PaymantStatuses { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentsCopy> PaymentsCopies { get; set; } = null!;
        public virtual DbSet<PenaltyPayment> PenaltyPayments { get; set; } = null!;
        public virtual DbSet<Penaltydesc> Penaltydescs { get; set; } = null!;
        public virtual DbSet<PendingSchoolFee> PendingSchoolFees { get; set; } = null!;
        public virtual DbSet<Pgd> Pgds { get; set; } = null!;
        public virtual DbSet<Pgdfulltime> Pgdfulltimes { get; set; } = null!;
        public virtual DbSet<PostResultsUtme> PostResultsUtmes { get; set; } = null!;
        public virtual DbSet<PostResultsUtmeAll> PostResultsUtmeAlls { get; set; } = null!;
        public virtual DbSet<PostutmeAll> PostutmeAlls { get; set; } = null!;
        public virtual DbSet<PostutmeAllCopy> PostutmeAllCopies { get; set; } = null!;
        public virtual DbSet<PostutmeAllCopy1> PostutmeAllCopy1s { get; set; } = null!;
        public virtual DbSet<PostutmeAllImage> PostutmeAllImages { get; set; } = null!;
        public virtual DbSet<PostutmeAllSecond> PostutmeAllSeconds { get; set; } = null!;
        public virtual DbSet<PostutmeAllSecondCopy> PostutmeAllSecondCopies { get; set; } = null!;
        public virtual DbSet<PostutmeAllTesting> PostutmeAllTestings { get; set; } = null!;
        public virtual DbSet<PostutmeAllocation> PostutmeAllocations { get; set; } = null!;
        public virtual DbSet<PostutmeAllocationInitializer> PostutmeAllocationInitializers { get; set; } = null!;
        public virtual DbSet<PostutmeAllocationInitializerCopy> PostutmeAllocationInitializerCopies { get; set; } = null!;
        public virtual DbSet<PostutmeAllocationIssue> PostutmeAllocationIssues { get; set; } = null!;
        public virtual DbSet<PostutmeAllocationIssuesCopy> PostutmeAllocationIssuesCopies { get; set; } = null!;
        public virtual DbSet<PostutmeAllocationsCopy> PostutmeAllocationsCopies { get; set; } = null!;
        public virtual DbSet<PostutmeApplicantList> PostutmeApplicantLists { get; set; } = null!;
        public virtual DbSet<PostutmeApplicantListCopy> PostutmeApplicantListCopies { get; set; } = null!;
        public virtual DbSet<PostutmeBatch> PostutmeBatches { get; set; } = null!;
        public virtual DbSet<PostutmeBatchesCopy> PostutmeBatchesCopies { get; set; } = null!;
        public virtual DbSet<PostutmeBuilding> PostutmeBuildings { get; set; } = null!;
        public virtual DbSet<PostutmeBuildingsCopy> PostutmeBuildingsCopies { get; set; } = null!;
        public virtual DbSet<PostutmeImage> PostutmeImages { get; set; } = null!;
        public virtual DbSet<PostutmeImagesCopy> PostutmeImagesCopies { get; set; } = null!;
        public virtual DbSet<PostutmePayment> PostutmePayments { get; set; } = null!;
        public virtual DbSet<PostutmePayments3> PostutmePayments3s { get; set; } = null!;
        public virtual DbSet<PostutmeResult> PostutmeResults { get; set; } = null!;
        public virtual DbSet<PostutmeVenue> PostutmeVenues { get; set; } = null!;
        public virtual DbSet<PostutmeVenuePriority> PostutmeVenuePriorities { get; set; } = null!;
        public virtual DbSet<PostutmeVenuePriorityCopy> PostutmeVenuePriorityCopies { get; set; } = null!;
        public virtual DbSet<PostutmeVenuesCopy> PostutmeVenuesCopies { get; set; } = null!;
        public virtual DbSet<ProcessingVerificationPayment> ProcessingVerificationPayments { get; set; } = null!;
        public virtual DbSet<Progerror> Progerrors { get; set; } = null!;
        public virtual DbSet<Progmediate> Progmediates { get; set; } = null!;
        public virtual DbSet<EBPortal.Program> Programs { get; set; } = null!;
        public virtual DbSet<ProgramCampus> ProgramCampuses { get; set; } = null!;
        public virtual DbSet<ProgramCertificate> ProgramCertificates { get; set; } = null!;
        public virtual DbSet<ProgramLevel> ProgramLevels { get; set; } = null!;
        public virtual DbSet<ProgramLevelSemester> ProgramLevelSemesters { get; set; } = null!;
        public virtual DbSet<ProgramName> ProgramNames { get; set; } = null!;
        public virtual DbSet<ProgramType> ProgramTypes { get; set; } = null!;
        public virtual DbSet<ProgramTypeMap> ProgramTypeMaps { get; set; } = null!;
        public virtual DbSet<Projectiontable> Projectiontables { get; set; } = null!;
        public virtual DbSet<PtPayStatus> PtPayStatuses { get; set; } = null!;
        public virtual DbSet<PubReg1516pt> PubReg1516pts { get; set; } = null!;
        public virtual DbSet<Qualification> Qualifications { get; set; } = null!;
        public virtual DbSet<QualifiedCandidatesWithIssue> QualifiedCandidatesWithIssues { get; set; } = null!;
        public virtual DbSet<QuotaExhaustedJamb> QuotaExhaustedJambs { get; set; } = null!;
        public virtual DbSet<Redflag> Redflags { get; set; } = null!;
        public virtual DbSet<RegistrationExemption> RegistrationExemptions { get; set; } = null!;
        public virtual DbSet<RemitaDatum> RemitaData { get; set; } = null!;
        public virtual DbSet<Remoevedbyerror> Remoevedbyerrors { get; set; } = null!;
        public virtual DbSet<RetrievedMicroFinance> RetrievedMicroFinances { get; set; } = null!;
        public virtual DbSet<RetrievedMicroFinanceOld> RetrievedMicroFinanceOlds { get; set; } = null!;
        public virtual DbSet<ReverifyCategory> ReverifyCategories { get; set; } = null!;
        public virtual DbSet<ReverseAdmission> ReverseAdmissions { get; set; } = null!;
        public virtual DbSet<Rrr> Rrrs { get; set; } = null!;
        public virtual DbSet<RrrValidatorCode> RrrValidatorCodes { get; set; } = null!;
        public virtual DbSet<Rrrerror> Rrrerrors { get; set; } = null!;
        public virtual DbSet<Samplecourse> Samplecourses { get; set; } = null!;
        public virtual DbSet<ScheduleColourCode> ScheduleColourCodes { get; set; } = null!;
        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<School2> School2s { get; set; } = null!;
        public virtual DbSet<SchoolAdmissionList> SchoolAdmissionLists { get; set; } = null!;
        public virtual DbSet<SchoolFee> SchoolFees { get; set; } = null!;
        public virtual DbSet<SchoolFeesApproval> SchoolFeesApprovals { get; set; } = null!;
        public virtual DbSet<SchoolFeesBreakdown> SchoolFeesBreakdowns { get; set; } = null!;
        public virtual DbSet<SchoolFeesBreakdownCopy> SchoolFeesBreakdownCopies { get; set; } = null!;
        public virtual DbSet<SchoolFeesItem> SchoolFeesItems { get; set; } = null!;
        public virtual DbSet<SchoolOfficerApproval> SchoolOfficerApprovals { get; set; } = null!;
        public virtual DbSet<SciencePt> SciencePts { get; set; } = null!;
        public virtual DbSet<Sciencespool> Sciencespools { get; set; } = null!;
        public virtual DbSet<Screening> Screenings { get; set; } = null!;
        public virtual DbSet<ScreeningExemption> ScreeningExemptions { get; set; } = null!;
        public virtual DbSet<ScreeningLock> ScreeningLocks { get; set; } = null!;
        public virtual DbSet<ScreeningNotQualified> ScreeningNotQualifieds { get; set; } = null!;
        public virtual DbSet<ScreeningReverse> ScreeningReverses { get; set; } = null!;
        public virtual DbSet<SeRverlo> SeRverlos { get; set; } = null!;
        public virtual DbSet<SecondChoice> SecondChoices { get; set; } = null!;
        public virtual DbSet<Secondchoice1617> Secondchoice1617s { get; set; } = null!;
        public virtual DbSet<Secondchoice1617Old> Secondchoice1617Olds { get; set; } = null!;
        public virtual DbSet<SelectedSitting> SelectedSittings { get; set; } = null!;
        public virtual DbSet<Semester> Semesters { get; set; } = null!;
        public virtual DbSet<Semestersp> Semestersps { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<Sheet1> Sheet1s { get; set; } = null!;
        public virtual DbSet<Specialstudent> Specialstudents { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<Stdportal> Stdportals { get; set; } = null!;
        public virtual DbSet<SteSecondSemester1516> SteSecondSemester1516s { get; set; } = null!;
        public virtual DbSet<Steapplicant> Steapplicants { get; set; } = null!;
        public virtual DbSet<Steexception> Steexceptions { get; set; } = null!;
        public virtual DbSet<StudException> StudExceptions { get; set; } = null!;
        public virtual DbSet<StudExceptionCopy> StudExceptionCopies { get; set; } = null!;
        public virtual DbSet<StudImg> StudImgs { get; set; } = null!;
        public virtual DbSet<StudTab> StudTabs { get; set; } = null!;
        public virtual DbSet<StudTabCopy> StudTabCopies { get; set; } = null!;
        public virtual DbSet<StudTabCopy1> StudTabCopy1s { get; set; } = null!;
        public virtual DbSet<EBPortal.Student> Students { get; set; } = null!;
        public virtual DbSet<StudentFash> StudentFashes { get; set; } = null!;
        public virtual DbSet<StudentRecord> StudentRecords { get; set; } = null!;
        public virtual DbSet<StudentRecord1> StudentRecords1 { get; set; } = null!;
        public virtual DbSet<StudentRecordMaster> StudentRecordMasters { get; set; } = null!;
        public virtual DbSet<SummaryRegistration> SummaryRegistrations { get; set; } = null!;
        public virtual DbSet<SummaryRegistrationCertificate> SummaryRegistrationCertificates { get; set; } = null!;
        public virtual DbSet<SummaryRegistrationCertificate1> SummaryRegistrationCertificates1 { get; set; } = null!;
        public virtual DbSet<SummaryRegistrationCertificatesSchool> SummaryRegistrationCertificatesSchools { get; set; } = null!;
        public virtual DbSet<SummaryRegistrationCertificatesSchool1> SummaryRegistrationCertificatesSchools1 { get; set; } = null!;
        public virtual DbSet<Sup1ChangCourse1Error> Sup1ChangCourse1Errors { get; set; } = null!;
        public virtual DbSet<Suplementary1617> Suplementary1617s { get; set; } = null!;
        public virtual DbSet<Supp1new> Supp1news { get; set; } = null!;
        public virtual DbSet<Table1> Table1s { get; set; } = null!;
        public virtual DbSet<Taken2abujaSn> Taken2abujaSns { get; set; } = null!;
        public virtual DbSet<TempLga> TempLgas { get; set; } = null!;
        public virtual DbSet<TempPayment> TempPayments { get; set; } = null!;
        public virtual DbSet<TempState> TempStates { get; set; } = null!;
        public virtual DbSet<Tempsmb> Tempsmbs { get; set; } = null!;
        public virtual DbSet<Tempst> Tempsts { get; set; } = null!;
        public virtual DbSet<Tempstudent> Tempstudents { get; set; } = null!;
        public virtual DbSet<TertiaryInstitution> TertiaryInstitutions { get; set; } = null!;
        public virtual DbSet<TertiaryInstitutionGrade> TertiaryInstitutionGrades { get; set; } = null!;
        public virtual DbSet<TertiaryInstitutionResult> TertiaryInstitutionResults { get; set; } = null!;
        public virtual DbSet<TertiaryInstitutionResultApplicant> TertiaryInstitutionResultApplicants { get; set; } = null!;
        public virtual DbSet<TertiaryInstitutionResultApplicant2> TertiaryInstitutionResultApplicant2s { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Test2> Test2s { get; set; } = null!;
        public virtual DbSet<Test3> Test3s { get; set; } = null!;
        public virtual DbSet<Test4> Test4s { get; set; } = null!;
        public virtual DbSet<Test5> Test5s { get; set; } = null!;
        public virtual DbSet<Testd> Testds { get; set; } = null!;
        public virtual DbSet<Textile2> Textile2s { get; set; } = null!;
        public virtual DbSet<TotalHndwithScore20142015> TotalHndwithScore20142015s { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<Transactions2> Transactions2s { get; set; } = null!;
        public virtual DbSet<TransactionsBack1> TransactionsBack1s { get; set; } = null!;
        public virtual DbSet<TransactionsVsGtco> TransactionsVsGtcos { get; set; } = null!;
        public virtual DbSet<TranscriptPayment> TranscriptPayments { get; set; } = null!;
        public virtual DbSet<Tttputmenumber> Tttputmenumbers { get; set; } = null!;
        public virtual DbSet<UnFixedPaymentsCategory> UnFixedPaymentsCategories { get; set; } = null!;
        public virtual DbSet<UnFlagAdmission> UnFlagAdmissions { get; set; } = null!;
        public virtual DbSet<Unfound> Unfounds { get; set; } = null!;
        public virtual DbSet<Unpaidver> Unpaidvers { get; set; } = null!;
        public virtual DbSet<UpdatedVwYctpayTransaction> UpdatedVwYctpayTransactions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UtmeScore> UtmeScores { get; set; } = null!;
        public virtual DbSet<UtmeSubjectComb> UtmeSubjectCombs { get; set; } = null!;
        public virtual DbSet<UtmeSubjectCombination> UtmeSubjectCombinations { get; set; } = null!;
        public virtual DbSet<UtmeUnn> UtmeUnns { get; set; } = null!;
        public virtual DbSet<Verified> Verifieds { get; set; } = null!;
        public virtual DbSet<VerifyTransaction> VerifyTransactions { get; set; } = null!;
        public virtual DbSet<Verifygrade> Verifygrades { get; set; } = null!;
        public virtual DbSet<VwAcceptanceFee> VwAcceptanceFees { get; set; } = null!;
        public virtual DbSet<VwAdmission> VwAdmissions { get; set; } = null!;
        public virtual DbSet<VwAdmissionLetterPayment> VwAdmissionLetterPayments { get; set; } = null!;
        public virtual DbSet<VwAdmissionRejectionPayment> VwAdmissionRejectionPayments { get; set; } = null!;
        public virtual DbSet<VwAdmittable> VwAdmittables { get; set; } = null!;
        public virtual DbSet<VwApplicant> VwApplicants { get; set; } = null!;
        public virtual DbSet<VwApplicantComplaint> VwApplicantComplaints { get; set; } = null!;
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; } = null!;
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; } = null!;
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; } = null!;
        public virtual DbSet<VwBiodataApplicant> VwBiodataApplicants { get; set; } = null!;
        public virtual DbSet<VwBiodatum> VwBiodata { get; set; } = null!;
        public virtual DbSet<VwChangeOfCoursePayment> VwChangeOfCoursePayments { get; set; } = null!;
        public virtual DbSet<VwChangeofCourse> VwChangeofCourses { get; set; } = null!;
        public virtual DbSet<VwClearance> VwClearances { get; set; } = null!;
        public virtual DbSet<VwClearanceRegularization> VwClearanceRegularizations { get; set; } = null!;
        public virtual DbSet<VwClearanceRegularizationPayment> VwClearanceRegularizationPayments { get; set; } = null!;
        public virtual DbSet<VwComplaint> VwComplaints { get; set; } = null!;
        public virtual DbSet<VwCourse> VwCourses { get; set; } = null!;
        public virtual DbSet<VwCourseRegistration> VwCourseRegistrations { get; set; } = null!;
        public virtual DbSet<VwCourseRegistrationDetail> VwCourseRegistrationDetails { get; set; } = null!;
        public virtual DbSet<VwCourseRegistrationLatePayment> VwCourseRegistrationLatePayments { get; set; } = null!;
        public virtual DbSet<VwCourseRegistrationLateSubmission> VwCourseRegistrationLateSubmissions { get; set; } = null!;
        public virtual DbSet<VwCourseregistrationApproval> VwCourseregistrationApprovals { get; set; } = null!;
        public virtual DbSet<VwDirectEntryAll> VwDirectEntryAlls { get; set; } = null!;
        public virtual DbSet<VwDirectInsertAll> VwDirectInsertAlls { get; set; } = null!;
        public virtual DbSet<VwDirectentryPayment> VwDirectentryPayments { get; set; } = null!;
        public virtual DbSet<VwFlagAdmission> VwFlagAdmissions { get; set; } = null!;
        public virtual DbSet<VwFlagAdmissionWithScore> VwFlagAdmissionWithScores { get; set; } = null!;
        public virtual DbSet<VwGenmatricno> VwGenmatricnos { get; set; } = null!;
        public virtual DbSet<VwGradTable2016> VwGradTable2016s { get; set; } = null!;
        public virtual DbSet<VwHostelApplicationPayment> VwHostelApplicationPayments { get; set; } = null!;
        public virtual DbSet<VwHostelPayment> VwHostelPayments { get; set; } = null!;
        public virtual DbSet<VwLga> VwLgas { get; set; } = null!;
        public virtual DbSet<VwOlevelExam> VwOlevelExams { get; set; } = null!;
        public virtual DbSet<VwOlevelExamsApplicant> VwOlevelExamsApplicants { get; set; } = null!;
        public virtual DbSet<VwOlevelExamsApplicantUpdate> VwOlevelExamsApplicantUpdates { get; set; } = null!;
        public virtual DbSet<VwOlevelResult> VwOlevelResults { get; set; } = null!;
        public virtual DbSet<VwOlevelResultsApplicant> VwOlevelResultsApplicants { get; set; } = null!;
        public virtual DbSet<VwOnlineappAll> VwOnlineappAlls { get; set; } = null!;
        public virtual DbSet<VwOnlineappCompleted> VwOnlineappCompleteds { get; set; } = null!;
        public virtual DbSet<VwOnlineappPayment> VwOnlineappPayments { get; set; } = null!;
        public virtual DbSet<VwOnlineappPersonalinfo> VwOnlineappPersonalinfos { get; set; } = null!;
        public virtual DbSet<VwPayment> VwPayments { get; set; } = null!;
        public virtual DbSet<VwPaymentchecker> VwPaymentcheckers { get; set; } = null!;
        public virtual DbSet<VwPenaltyPayment> VwPenaltyPayments { get; set; } = null!;
        public virtual DbSet<VwPostResultsUtme> VwPostResultsUtmes { get; set; } = null!;
        public virtual DbSet<VwPostUtmePayment> VwPostUtmePayments { get; set; } = null!;
        public virtual DbSet<VwPostutmeAll> VwPostutmeAlls { get; set; } = null!;
        public virtual DbSet<VwPostutmeAllSecond> VwPostutmeAllSeconds { get; set; } = null!;
        public virtual DbSet<VwPostutmeAllocation> VwPostutmeAllocations { get; set; } = null!;
        public virtual DbSet<VwPostutmeApplicantList> VwPostutmeApplicantLists { get; set; } = null!;
        public virtual DbSet<VwPostutmeResult> VwPostutmeResults { get; set; } = null!;
        public virtual DbSet<VwProgram> VwPrograms { get; set; } = null!;
        public virtual DbSet<VwProgramLevel> VwProgramLevels { get; set; } = null!;
        public virtual DbSet<VwProgramLevelSemester> VwProgramLevelSemesters { get; set; } = null!;
        public virtual DbSet<VwPtPayStatus> VwPtPayStatuses { get; set; } = null!;
        public virtual DbSet<VwRegistrationLatePayment> VwRegistrationLatePayments { get; set; } = null!;
        public virtual DbSet<VwSchoolFee> VwSchoolFees { get; set; } = null!;
        public virtual DbSet<VwSchoolFeesApproval> VwSchoolFeesApprovals { get; set; } = null!;
        public virtual DbSet<VwSchoolFeesBreakDown> VwSchoolFeesBreakDowns { get; set; } = null!;
        public virtual DbSet<VwSchoolFessApproval> VwSchoolFessApprovals { get; set; } = null!;
        public virtual DbSet<VwSchoolfeesPt> VwSchoolfeesPts { get; set; } = null!;
        public virtual DbSet<VwScreening> VwScreenings { get; set; } = null!;
        public virtual DbSet<VwStudent> VwStudents { get; set; } = null!;
        public virtual DbSet<VwTertiaryInstitutionResult> VwTertiaryInstitutionResults { get; set; } = null!;
        public virtual DbSet<VwTertiaryInstitutionResultApplicant> VwTertiaryInstitutionResultApplicants { get; set; } = null!;
        public virtual DbSet<VwTertiaryInstitutionResultApplicant2> VwTertiaryInstitutionResultApplicant2s { get; set; } = null!;
        public virtual DbSet<VwTransaction> VwTransactions { get; set; } = null!;
        public virtual DbSet<VwUnflagAdmission> VwUnflagAdmissions { get; set; } = null!;
        public virtual DbSet<VwYctpayDamagesPayment> VwYctpayDamagesPayments { get; set; } = null!;
        public virtual DbSet<VwYctpaySuccessfulTransaction> VwYctpaySuccessfulTransactions { get; set; } = null!;
        public virtual DbSet<VwYctpayTransaction> VwYctpayTransactions { get; set; } = null!;
        public virtual DbSet<VwYctpayTransactionOther> VwYctpayTransactionOthers { get; set; } = null!;
        public virtual DbSet<VwYctpayTransactionswithMixedupDatum> VwYctpayTransactionswithMixedupData { get; set; } = null!;
        public virtual DbSet<Weldin> Weldins { get; set; } = null!;
        public virtual DbSet<Weldin16> Weldin16s { get; set; } = null!;
        public virtual DbSet<Weldin167> Weldin167s { get; set; } = null!;
        public virtual DbSet<YabaErrorDegree> YabaErrorDegrees { get; set; } = null!;
        public virtual DbSet<YabatechRemitaPayment> YabatechRemitaPayments { get; set; } = null!;
        public virtual DbSet<YabatechRemitaPaymentCopy> YabatechRemitaPaymentCopies { get; set; } = null!;
        public virtual DbSet<YabatechRemitaPaymentCopy1> YabatechRemitaPaymentCopy1s { get; set; } = null!;
        public virtual DbSet<YabatechRemitaTempData150220161026am> YabatechRemitaTempData150220161026ams { get; set; } = null!;
        public virtual DbSet<YabatechRemitaTempData210120161002am> YabatechRemitaTempData210120161002ams { get; set; } = null!;
        public virtual DbSet<YabatechRemitaTempDataCopy> YabatechRemitaTempDataCopies { get; set; } = null!;
        public virtual DbSet<YabatechRemitaTempDatum> YabatechRemitaTempData { get; set; } = null!;
        public virtual DbSet<YabavsjambLga> YabavsjambLgas { get; set; } = null!;
        public virtual DbSet<YctTranscriptApp> YctTranscriptApps { get; set; } = null!;
        public virtual DbSet<YctfixedPayment> YctfixedPayments { get; set; } = null!;
        public virtual DbSet<YctpayDamagesPayment> YctpayDamagesPayments { get; set; } = null!;
        public virtual DbSet<YctpayOtherPayment> YctpayOtherPayments { get; set; } = null!;
        public virtual DbSet<YctpayOtherPayment1> YctpayOtherPayments1 { get; set; } = null!;
        public virtual DbSet<YctpayOthersPayment> YctpayOthersPayments { get; set; } = null!;
        public virtual DbSet<YctpayPayment> YctpayPayments { get; set; } = null!;
        public virtual DbSet<YctpayPaymentBiodatum> YctpayPaymentBiodata { get; set; } = null!;
        public virtual DbSet<YctpayPaymentStatus> YctpayPaymentStatuses { get; set; } = null!;
        public virtual DbSet<YctpayReceiptTransaction> YctpayReceiptTransactions { get; set; } = null!;
        public virtual DbSet<YctpayStudentsPayment> YctpayStudentsPayments { get; set; } = null!;
        public virtual DbSet<YctpayStudentsPaymentsCopy> YctpayStudentsPaymentsCopies { get; set; } = null!;
        public virtual DbSet<YctpayStudentsPaymentsCopyCopy> YctpayStudentsPaymentsCopyCopies { get; set; } = null!;
        public virtual DbSet<YctpayStudentsPaymentsMistake> YctpayStudentsPaymentsMistakes { get; set; } = null!;
        public virtual DbSet<YctpaySuccessfulTransaction> YctpaySuccessfulTransactions { get; set; } = null!;
        public virtual DbSet<YctpayTransaction> YctpayTransactions { get; set; } = null!;
        public virtual DbSet<YctpayTransactionOther> YctpayTransactionOthers { get; set; } = null!;
        public virtual DbSet<YctpayTransactions2> YctpayTransactions2s { get; set; } = null!;
        public virtual DbSet<YctpayTransactionsWithMixedMerchantId> YctpayTransactionsWithMixedMerchantIds { get; set; } = null!;
        public virtual DbSet<YctpayTransactionswithMixedupDatum> YctpayTransactionswithMixedupData { get; set; } = null!;
        public virtual DbSet<_716> _716s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=213.171.204.36;Initial Catalog=EBPORTAL;Persist Security Info=True;User ID=Josh_dbnew;Password=<password>");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AcceptanceBal>(entity =>
            {
                entity.Property(e => e.Appnum).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AcceptanceExemption>(entity =>
            {
                entity.Property(e => e.ExemptionId).ValueGeneratedOnAdd();

                entity.Property(e => e.MatricNo).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Who).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<AcceptanceFee>(entity =>
            {
                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.AcceptanceFee)
                    .HasForeignKey<AcceptanceFee>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcceptanceFees_Admission");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.AcceptanceFees)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcceptanceFees_Banks");
            });

            modelBuilder.Entity<AcceptanceLock>(entity =>
            {
                entity.Property(e => e.Message).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.RegLockId).ValueGeneratedOnAdd();

                entity.Property(e => e.Who).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.MerchantId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Addbuffer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AdminTbl>(entity =>
            {
                entity.Property(e => e.UserName).IsFixedLength();

                entity.Property(e => e.AdminLevel).IsFixedLength();

                entity.Property(e => e.CreatedDate).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastLogin).IsFixedLength();

                entity.Property(e => e.UserPass).IsFixedLength();
            });

            modelBuilder.Entity<AdmissionCopy>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Admissio__ECD935AAC4445EB1");
            });

            modelBuilder.Entity<AdmissionLetterPayment>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK_AdmissionRejectionPayments");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.AdmissionLetterPayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionLetterPayments_Banks");
            });

            modelBuilder.Entity<AdmissionLetterPaymentsCopy>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Admissio__ECD935AA46D1745C");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.AdmissionLetterPaymentsCopies)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Admission__BankI__467E410F");
            });

            modelBuilder.Entity<AdmissionRejectionPayment>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK_AdmissionRejection");

                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.AdmissionRejectionPayment)
                    .HasForeignKey<AdmissionRejectionPayment>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionRejectionPayments_Admission");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.AdmissionRejectionPayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionRejectionPayments_Banks");
            });

            modelBuilder.Entity<AdmissionRejectionPaymentsCopy>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Admissio__ECD935AA985611B4");

                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.AdmissionRejectionPaymentsCopy)
                    .HasForeignKey<AdmissionRejectionPaymentsCopy>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Admission__Appnu__4B42F62C");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.AdmissionRejectionPaymentsCopies)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Admission__BankI__4C371A65");
            });

            modelBuilder.Entity<AdmissionSummaryAll>(entity =>
            {
                entity.HasKey(e => e.Program)
                    .HasName("PK__Admissio__B20D7B4B689CB272");
            });

            modelBuilder.Entity<AdmissionUnflagReason>(entity =>
            {
                entity.Property(e => e.ReasonId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Admittable>(entity =>
            {
                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Admittables)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admittable_Programs");
            });

            modelBuilder.Entity<Allottedstudent>(entity =>
            {
                entity.Property(e => e.PaymentApproval).IsFixedLength();
            });

            modelBuilder.Entity<Allottedstudents2>(entity =>
            {
                entity.Property(e => e.PaymentApproval).IsFixedLength();
            });

            modelBuilder.Entity<AllottedstudentsCopy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentApproval).IsFixedLength();
            });

            modelBuilder.Entity<AllottedstudentsCopy1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PaymentApproval).IsFixedLength();
            });

            modelBuilder.Entity<AllottedstudentsCopy2>(entity =>
            {
                entity.Property(e => e.PaymentApproval).IsFixedLength();
            });

            modelBuilder.Entity<AllottedstudentsCopy3>(entity =>
            {
                entity.Property(e => e.PaymentApproval).IsFixedLength();
            });

            modelBuilder.Entity<Allpaid>(entity =>
            {
                entity.HasKey(e => e.Matricnum)
                    .HasName("PK__ALLPAID__2C6806835D50E662");
            });

            modelBuilder.Entity<Alluser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AppSetup>(entity =>
            {
                entity.Property(e => e.AppId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Appbuffer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ApplicantComplaint>(entity =>
            {
                entity.HasKey(e => e.ComplaintTrackId)
                    .HasName("PK__Applican__C76C3C5F4A23E96A");

                entity.Property(e => e.ComplaintStatus).IsFixedLength();

                entity.HasOne(d => d.ComplaintNavigation)
                    .WithMany(p => p.ApplicantComplaints)
                    .HasForeignKey(d => d.Complaint)
                    .HasConstraintName("FK_ApplicantComplaints_complaintAll");
            });

            modelBuilder.Entity<ApplicantsExempt>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ApplicationinvoiceGen>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ApplicationinvoiceGenCopy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ApplicationinvoiceGenCopy1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Appstatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AppstatusTest>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98014935CB")
                    .IsClustered(false);

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).ValueGeneratedNever();
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D1FCDBCEB")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__21B6055D");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__22AA2996");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5859063A47")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__5AEE82B9");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5960A75C0F");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__628FA481");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC06656C112C")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__68487DD7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__693CA210");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C36B12243");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__38996AB5");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B4222D4EF")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__440B1D61");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC11367E606");
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D0BC6C43E")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__0DAF0CB0");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspnetUsersInRole",
                        l => l.HasOne<AspnetRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__RoleI__4AB81AF0"),
                        r => r.HasOne<AspnetUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__UserI__49C3F6B7"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD47DBAE45");

                            j.ToTable("aspnet_UsersInRoles");

                            j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                        });
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810797309D9");

                entity.Property(e => e.EventId).IsFixedLength();
            });

            modelBuilder.Entity<AuthVerify>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Biodata2>(entity =>
            {
                entity.HasKey(e => e.Matricnum)
                    .HasName("PK_Biodata_1");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.Biodata2s)
                    .HasForeignKey(d => d.Lgaid)
                    .HasConstraintName("FK_StudentInfo_LGA");

                entity.HasOne(d => d.Pob)
                    .WithMany(p => p.Biodata2s)
                    .HasForeignKey(d => d.Pobid)
                    .HasConstraintName("FK_StudentInfo_States");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.Biodata2s)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_StudentInfo_Genders");
            });

            modelBuilder.Entity<BiodataApplicant>(entity =>
            {
                entity.Property(e => e.Appnum).IsFixedLength();

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.BiodataApplicants)
                    .HasForeignKey(d => d.Lgaid)
                    .HasConstraintName("FK_BiodataApplicant_LGA");

                entity.HasOne(d => d.Pob)
                    .WithMany(p => p.BiodataApplicants)
                    .HasForeignKey(d => d.Pobid)
                    .HasConstraintName("FK_BiodataApplicant_States");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.BiodataApplicants)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_BiodataApplicant_Programs");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.BiodataApplicants)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_BiodataApplicant_Sessions");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.BiodataApplicants)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK_BiodataApplicant_Genders");
            });

            modelBuilder.Entity<BiodataLg>(entity =>
            {
                entity.HasKey(e => e.Matricnum)
                    .HasName("PK__Biodata___0D9BEFB12A51E4B8");
            });

            modelBuilder.Entity<BiodataOther>(entity =>
            {
                entity.HasKey(e => e.PayerId)
                    .HasName("PK__Biodata___0D9BEFB1D48A6DCA");
            });

            modelBuilder.Entity<Biodatum>(entity =>
            {
                entity.HasKey(e => e.Matricnum)
                    .HasName("PK__Biodata___0D9BEFB1165A2CA1");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.Biodata)
                    .HasForeignKey(d => d.Lgaid)
                    .HasConstraintName("FK__Biodata__LGAID__460A0B1A");

                entity.HasOne(d => d.Pob)
                    .WithMany(p => p.Biodata)
                    .HasForeignKey(d => d.Pobid)
                    .HasConstraintName("FK__Biodata__POBID__46FE2F53");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.Biodata)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("FK__Biodata__SexID__47F2538C");
            });

            modelBuilder.Entity<Bsc1001415>(entity =>
            {
                entity.HasKey(e => new { e.Candid, e.Examno, e.Regnumber })
                    .HasName("PK__BSC100_1__19D63F259D3348B4");
            });

            modelBuilder.Entity<Businessadmin>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Sheet1__ECD935AA721CCC2B");
            });

            modelBuilder.Entity<CarryingCapacity>(entity =>
            {
                entity.HasKey(e => e.Program)
                    .HasName("PK__carrying__1DBA722E75ED5D0F");
            });

            modelBuilder.Entity<ChangeOfCoursePayment>(entity =>
            {
                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.ChangeOfCoursePayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeOfCoursePayment_Banks");

                entity.HasOne(d => d.UtmenumberNavigation)
                    .WithOne(p => p.ChangeOfCoursePayment)
                    .HasForeignKey<ChangeOfCoursePayment>(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeOfCoursePayment_PostutmeResults");
            });

            modelBuilder.Entity<ChangeOfCoursePayment2>(entity =>
            {
                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.ChangeOfCoursePayment2s)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeOfCoursePayment_2_Banks");
            });

            modelBuilder.Entity<ChangeOfCoursePaymentCopy>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__ChangeOf__0E9761D27AB2122C");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.ChangeOfCoursePaymentCopies)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChangeOfC__BankI__7D8E7ED7");

                entity.HasOne(d => d.UtmenumberNavigation)
                    .WithOne(p => p.ChangeOfCoursePaymentCopy)
                    .HasPrincipalKey<Biodata2>(p => p.Appnum)
                    .HasForeignKey<ChangeOfCoursePaymentCopy>(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChangeOfC__Utmen__7E82A310");

                entity.HasOne(d => d.Utmenumber1)
                    .WithOne(p => p.ChangeOfCoursePaymentCopy)
                    .HasForeignKey<ChangeOfCoursePaymentCopy>(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChangeOfC__Utmen__7F76C749");
            });

            modelBuilder.Entity<ChangeofCourse>(entity =>
            {
                entity.HasOne(d => d.NewProgram)
                    .WithMany(p => p.ChangeofCourses)
                    .HasForeignKey(d => d.NewProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeofCourse_Programs");
            });

            modelBuilder.Entity<ChangeofCourse2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ChangeofCourseHistory>(entity =>
            {
                entity.HasOne(d => d.NewProgram)
                    .WithMany(p => p.ChangeofCourseHistories)
                    .HasForeignKey(d => d.NewProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeofCourse_history_Programs");
            });

            modelBuilder.Entity<Changeofcourse1617>(entity =>
            {
                entity.HasKey(e => e.RegNumb)
                    .HasName("PK__Changeof__EFCC4DEC30EF0142");
            });

            modelBuilder.Entity<CivlHnd>(entity =>
            {
                entity.HasKey(e => e.Applicationnumber)
                    .HasName("PK__Civl_HND__5FA84F21A3C2DABA");
            });

            modelBuilder.Entity<Clearance>(entity =>
            {
                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.Clearance)
                    .HasForeignKey<Clearance>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clearance_AcceptanceFees");
            });

            modelBuilder.Entity<ClearanceFlag>(entity =>
            {
                entity.Property(e => e.FlagId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ClearanceNotQualified>(entity =>
            {
                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.ClearanceNotQualified)
                    .HasForeignKey<ClearanceNotQualified>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClearanceNotQualified_AcceptanceFees");
            });

            modelBuilder.Entity<ClearanceOfficer>(entity =>
            {
                entity.Property(e => e.StaffId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ClearanceOverride>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ClearanceRegularizationPayment>(entity =>
            {
                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.ClearanceRegularizationPayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClearanceRegularizationPayments_Banks");
            });

            modelBuilder.Entity<ClearanceRejectionReason>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ClearanceRequirement1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ClearanceRequirementCompleted>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ClearanceVerificationStatus>(entity =>
            {
                entity.Property(e => e.TitleId).HasComment("");
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasKey(e => e.Clubname)
                    .HasName("PK__clubs__10E4B10C0E2EFAF4");
            });

            modelBuilder.Entity<ComplaintAll>(entity =>
            {
                entity.HasKey(e => e.ComplaintId)
                    .HasName("PK__complain__740D89AF4EE89E87");
            });

            modelBuilder.Entity<Conveyregret>(entity =>
            {
                entity.HasKey(e => new { e.Sn, e.Appnumm })
                    .HasName("PK__conveyre__C4A8650857A5491E");
            });

            modelBuilder.Entity<Conveyregrets2>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__conveyre__3214186C5F596F03");
            });

            modelBuilder.Entity<ConveyregretsChangeofcourse>(entity =>
            {
                entity.HasKey(e => e.Appnumm)
                    .HasName("PK__conveyre__C4A8650857A5491fE");
            });

            modelBuilder.Entity<ConveyregretsChangeofcoursee>(entity =>
            {
                entity.HasKey(e => new { e.Sn, e.Appnumm })
                    .HasName("PK__conveyre__C0857A5491fE");
            });

            modelBuilder.Entity<Course1>(entity =>
            {
                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.Course1s)
                    .HasForeignKey(d => d.Ccid)
                    .HasConstraintName("FK_Courses_CourseCodes");

                entity.HasOne(d => d.Cs)
                    .WithMany(p => p.Course1s)
                    .HasForeignKey(d => d.Csid)
                    .HasConstraintName("FK_Courses_CourseStatus");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.Course1s)
                    .HasForeignKey(d => d.Ctid)
                    .HasConstraintName("FK_Courses_CourseTitles");

                entity.HasOne(d => d.Pls)
                    .WithMany(p => p.Course1s)
                    .HasForeignKey(d => d.Plsid)
                    .HasConstraintName("FK_Courses_Courses");
            });

            modelBuilder.Entity<CourseRegistration11>(entity =>
            {
                entity.HasKey(e => e.Crid)
                    .HasName("PK__CourseRe__F2363F522D3D91F9");
            });

            modelBuilder.Entity<CourseRegistrationDetail>(entity =>
            {
                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseRegistrationDetails)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseRegistrationDetails_Courses");
            });

            modelBuilder.Entity<CourseRegistrationLatePayment>(entity =>
            {
                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.CourseRegistrationLatePayments)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseRegistrationLatePayments_Semesters");

                entity.HasOne(d => d.Sf)
                    .WithMany(p => p.CourseRegistrationLatePayments)
                    .HasForeignKey(d => d.Sfid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseRegistrationLatePayments_SchoolFees");
            });

            modelBuilder.Entity<CourseRegistrationLateSubmission>(entity =>
            {
                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.CourseRegistrationLateSubmissions)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseRegistrationLateSubmission_Semesters");

                entity.HasOne(d => d.Sf)
                    .WithMany(p => p.CourseRegistrationLateSubmissions)
                    .HasForeignKey(d => d.Sfid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseRegistrationLateSubmission_SchoolFees");
            });

            modelBuilder.Entity<CourseTitle>(entity =>
            {
                entity.HasKey(e => e.Ctid)
                    .HasName("PK_CourseNames");
            });

            modelBuilder.Entity<CourseregistrationApproval>(entity =>
            {
                entity.Property(e => e.Crid).ValueGeneratedNever();

                entity.HasOne(d => d.Cr)
                    .WithOne(p => p.CourseregistrationApproval)
                    .HasForeignKey<CourseregistrationApproval>(d => d.Crid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseregistrationApproval_CourseRegistration");
            });

            modelBuilder.Entity<CrimeElect>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__crimeEle__ECD935AAF7F96766");
            });

            modelBuilder.Entity<Cutof>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__cutof__32151C6407592052");
            });

            modelBuilder.Entity<Cutoff20152016>(entity =>
            {
                entity.HasKey(e => e.Department)
                    .HasName("PK__cutoff_2__1F72B96F2BC491A4");
            });

            modelBuilder.Entity<DbLog>(entity =>
            {
                entity.Property(e => e.Details).IsFixedLength();

                entity.Property(e => e.EditedMat).IsFixedLength();

                entity.Property(e => e.UserName).IsFixedLength();
            });

            modelBuilder.Entity<DirectEntryAll>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK_DirectEntry");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.DirectEntryAlls)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_DirectEntryAll_Genders");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.DirectEntryAlls)
                    .HasForeignKey(d => d.Lgaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectEntryAll_LGA");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.DirectEntryAlls)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectEntryAll_Programs");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.DirectEntryAlls)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectEntryAll_Sessions");
            });

            modelBuilder.Entity<DirectEntryAllCopy>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__DirectEn__BF537CF4DC0D78C0");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.DirectEntryAllCopies)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__DirectEnt__Gende__7F96C2DA");

                entity.HasOne(d => d.Lga)
                    .WithMany(p => p.DirectEntryAllCopies)
                    .HasForeignKey(d => d.Lgaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DirectEnt__LGAID__008AE713");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.DirectEntryAllCopies)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DirectEnt__Progr__017F0B4C");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.DirectEntryAllCopies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DirectEnt__Sessi__02732F85");
            });

            modelBuilder.Entity<DirectInsert>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186CAB11FC6A");
            });

            modelBuilder.Entity<DirectInsertChangeofCourse1>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186C9C8BFC23");
            });

            modelBuilder.Entity<DirectInsertChangeofCourseRegraded>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186CB137475C");
            });

            modelBuilder.Entity<DirectInsertCorrectedff>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186CAA9B7EEB");
            });

            modelBuilder.Entity<DirectInsertFirstChoice>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186C250AE260");
            });

            modelBuilder.Entity<DirectInsertMain>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186CB22A0187");
            });

            modelBuilder.Entity<DirectInsertOld>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186C58A82539");
            });

            modelBuilder.Entity<DirectInsertPt>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__DirectIn__ECD935AA1B94218E");
            });

            modelBuilder.Entity<DirectInsertRegraded>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__DirectIn__3214186CE5DF5B41");
            });

            modelBuilder.Entity<DirectentryPayment>(entity =>
            {
                entity.HasOne(d => d.Bank)
                    .WithMany()
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectentryPayments_Banks");

                entity.HasOne(d => d.UtmenumberNavigation)
                    .WithMany()
                    .HasPrincipalKey(p => p.Appnum)
                    .HasForeignKey(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectentryPayments_DirectentryPayments");
            });

            modelBuilder.Entity<Dob>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Eedmatnum1111>(entity =>
            {
                entity.HasKey(e => e.Matricnum)
                    .HasName("PK__eedmatnu__0D9BEFB11A83B27D");
            });

            modelBuilder.Entity<ElectricalHnd>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Ime_HND__6BC7D64EA772FBA3");
            });

            modelBuilder.Entity<EnvHnd>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__env_hnd__ECD935AA1367AD4B");
            });

            modelBuilder.Entity<Er4Bsc1516>(entity =>
            {
                entity.Property(e => e.Deptname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Facultyname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Firstname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Level).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Matricnum).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Othername).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Programme).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Surname).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<ErrBuffer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Error18>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Error18__ECD935AA4D8D1B70");
            });

            modelBuilder.Entity<Error21>(entity =>
            {
                entity.HasKey(e => e.Regnumb)
                    .HasName("PK__error21__C227F6CB4D5141FA");
            });

            modelBuilder.Entity<EscreenExemption>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EscreenExemption1>(entity =>
            {
                entity.Property(e => e.DateCreated).IsFixedLength();
            });

            modelBuilder.Entity<EscreenExemptionBck>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<FakeNdNceResult1516>(entity =>
            {
                entity.HasKey(e => e.MatricNo)
                    .HasName("PK__fakeND_N__7B8B4DBBF1734D18");
            });

            modelBuilder.Entity<FirstChoice201516>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.RegNumb })
                    .HasName("PK__FirstCho__ECE828D93F0FE06D");
            });

            modelBuilder.Entity<FlagAdmission>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK_FlagAdmission_1");

                entity.HasOne(d => d.Al)
                    .WithMany(p => p.FlagAdmissions)
                    .HasForeignKey(d => d.Alid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlagAdmission_FlagAdmission");
            });

            modelBuilder.Entity<FlagAdmissionCopy>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__FlagAdmi__ECD935AA450481C4");

                entity.HasOne(d => d.Al)
                    .WithMany(p => p.FlagAdmissionCopies)
                    .HasForeignKey(d => d.Alid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FlagAdmiss__ALID__481183C6");
            });

            modelBuilder.Entity<FlagAdmissionCopy1>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__FlagAdmi__ECD935AA40ABFDE7");

                entity.HasOne(d => d.Al)
                    .WithMany(p => p.FlagAdmissionCopy1s)
                    .HasForeignKey(d => d.Alid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FlagAdmiss__ALID__245E3335");
            });

            modelBuilder.Entity<Foodtech>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Foodtech__6BC7D64EF7096975");
            });

            modelBuilder.Entity<Found>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GenMatricno>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GenMatricnosar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Genmatric>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Genmatric1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GradTable2016>(entity =>
            {
                entity.Property(e => e.Dob).IsFixedLength();

                entity.Property(e => e.FinalRemark).IsFixedLength();

                entity.Property(e => e.Phone).IsFixedLength();
            });

            modelBuilder.Entity<HNdacc>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__hNDacc__ECD935AA6FF65BEF");
            });

            modelBuilder.Entity<Hdn>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__hdn__6BC7D64E4A0EDAD1");
            });

            modelBuilder.Entity<Hndscreeninglist>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__hndscree__ECD935AAA9934353");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HostelApplicationPayment>(entity =>
            {
                entity.HasKey(e => e.Hapid)
                    .HasName("PK_HotelApplicationPayments");

                entity.Property(e => e.Hapid).ValueGeneratedNever();

                entity.HasOne(d => d.Hap)
                    .WithOne(p => p.HostelApplicationPayment)
                    .HasForeignKey<HostelApplicationPayment>(d => d.Hapid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HotelApplicationPayments_SchoolFees");
            });

            modelBuilder.Entity<HostelExemption>(entity =>
            {
                entity.Property(e => e.ExemptionId).ValueGeneratedOnAdd();

                entity.Property(e => e.MatricNo).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Who).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<HostelLock>(entity =>
            {
                entity.Property(e => e.Message).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.RegLockId).ValueGeneratedOnAdd();

                entity.Property(e => e.Who).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<HostelPayment2>(entity =>
            {
                entity.HasKey(e => e.Hpid)
                    .HasName("PK_HotelPayments");

                entity.Property(e => e.Hpid).ValueGeneratedNever();

                entity.HasOne(d => d.Hp)
                    .WithOne(p => p.HostelPayment2)
                    .HasForeignKey<HostelPayment2>(d => d.Hpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HotelPayments_HotelApplicationPayments");
            });

            modelBuilder.Entity<Hosteladmin>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__hostelad__536C85E5F7114C28");
            });

            modelBuilder.Entity<Hostelapplication>(entity =>
            {
                entity.Property(e => e.AcadSession).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AllotDate).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AllotStatus).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Appnum).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.CollegeSport).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Completed)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.CompletedDate).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Course).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Dob).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Firstname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.HostelAllotted).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.HostelList).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.KinAddress).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.KinMobile).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.KinRelationship).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Level).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.LocalGov).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.MatricNum).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.MedicalProblemDetail).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.MedicalProblems).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Mobile).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.NextofKin).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Othername).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PGAddress).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PGMobile).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ParentGuardian).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PaymentStatus)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PrevHostel).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PrevRoomNumber).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PreviouslyAccomodated).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.QueryOption).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ResAddress).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.RoomNumber).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sex).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SocClub1).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SocClub2).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SocClub3).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SocClub4).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SocClub5).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SportDetail).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.StateofOrigin).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Surname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.YearofResidence).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<HostelapplicationCopy>(entity =>
            {
                entity.Property(e => e.Completed).IsFixedLength();

                entity.Property(e => e.PaymentStatus).IsFixedLength();
            });

            modelBuilder.Entity<HostelapplicationCopy1>(entity =>
            {
                entity.Property(e => e.Completed).IsFixedLength();

                entity.Property(e => e.PaymentStatus).IsFixedLength();
            });

            modelBuilder.Entity<HostelapplicationWithduplicate>(entity =>
            {
                entity.Property(e => e.Completed).IsFixedLength();

                entity.Property(e => e.PaymentStatus).IsFixedLength();
            });

            modelBuilder.Entity<Hostellist1>(entity =>
            {
                entity.HasKey(e => e.MatricNum)
                    .HasName("PK__hostelli__121C6D9F2B6BF809");
            });

            modelBuilder.Entity<Hostelpaydistinct>(entity =>
            {
                entity.HasKey(e => e.Payerid)
                    .HasName("PK__hostelpa__2DBED6BD99898AA1");
            });

            modelBuilder.Entity<Hostelpayment>(entity =>
            {
                entity.Property(e => e.AcadSession).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Firstname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Hostel).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Matricnum).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Middlename).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PaymentDate).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PaymentStatus)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Programme).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Surname).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<ImeHnd>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__ime_HND__6BC7D64E40FFF62A");
            });

            modelBuilder.Entity<ImeHnd2>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__ime_HND2__E42DFCEE175A6267");
            });

            modelBuilder.Entity<Invalidsex>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Matricnum).IsFixedLength();
            });

            modelBuilder.Entity<JambData201516>(entity =>
            {
                entity.HasKey(e => e.RegNumb)
                    .HasName("PK__jambData201516__ECE828D93F0FE06D");
            });

            modelBuilder.Entity<JambData201516Copy>(entity =>
            {
                entity.HasKey(e => e.RegNumb)
                    .HasName("PK__jambData__EFCC4DECE96D5E21");
            });

            modelBuilder.Entity<JambDe>(entity =>
            {
                entity.HasKey(e => e.Regnumb)
                    .HasName("PK__JambDE__C227F6CBD3130713");
            });

            modelBuilder.Entity<JambDe1617>(entity =>
            {
                entity.HasKey(e => e.Regnumb)
                    .HasName("PK__JambDE16__C227F6CB221340D2");
            });

            modelBuilder.Entity<JambDeletion>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__JambDele__0010F2D1296D0115");
            });

            modelBuilder.Entity<JambErrorAfterAdmission>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK__JambErro__3214D4A883087F50");
            });

            modelBuilder.Entity<JambErrors2>(entity =>
            {
                entity.HasKey(e => e.Utmenum)
                    .HasName("PK__JambErro__4A4D71C6679F3DB8");
            });

            modelBuilder.Entity<JambReg>(entity =>
            {
                entity.Property(e => e.SerialNumber).IsFixedLength();

                entity.Property(e => e.Phone).IsFixedLength();
            });

            modelBuilder.Entity<JambVsYabaState>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__JambVsYa__3214186CAA2EC83A");
            });

            modelBuilder.Entity<JambdataNew>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Jambimgg1617>(entity =>
            {
                entity.Property(e => e.Regnumber).IsFixedLength();
            });

            modelBuilder.Entity<JambmultipleReg1617>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__jambmult__5D9A67414667637A");
            });

            modelBuilder.Entity<Jambnoscore1617>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__jambnosc__5D9A67412A5916EF");
            });

            modelBuilder.Entity<Jambnsukkaerror>(entity =>
            {
                entity.HasKey(e => e.Regno)
                    .HasName("PK__jambnsuk__AE8D95612CB5176E");
            });

            modelBuilder.Entity<Jambvstech>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__jambvste__C92D718766792FD6");
            });

            modelBuilder.Entity<Jambvsyabaolevel>(entity =>
            {
                entity.Property(e => e.Sn).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<L18except>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__18except__ECD935AABF3BD716");
            });

            modelBuilder.Entity<LateRegToken>(entity =>
            {
                entity.Property(e => e.SummaryId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Lga>(entity =>
            {
                entity.HasOne(d => d.State)
                    .WithMany(p => p.Lgas)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LGA_States");
            });

            modelBuilder.Entity<MainstreamInvoice>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Username })
                    .HasName("PK__password__3213E83FF2375282");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ManualAdmission>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Maskprogid>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Matricbase>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Metaaalur>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__metaaalu__ECD935AA59C4616F");
            });

            modelBuilder.Entity<MicroFinanceHostel>(entity =>
            {
                entity.HasKey(e => e.MatNum)
                    .HasName("PK__MicroFin__8FECE0153106FCC4");
            });

            modelBuilder.Entity<MicroFinanceHostelCopy1>(entity =>
            {
                entity.HasKey(e => e.MatNum)
                    .HasName("PK__MicroFin__8FECE0153106FCC4_copy1");
            });

            modelBuilder.Entity<MobileNotification>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__mobileNo__C87C037C042AFD2D");

                entity.Property(e => e.MessageId).ValueGeneratedNever();
            });

            modelBuilder.Entity<MopupDay>(entity =>
            {
                entity.HasKey(e => e.PassCode)
                    .HasName("PK__MopupDay__7242CFC95AD6D91F");
            });

            modelBuilder.Entity<MysqlProgram>(entity =>
            {
                entity.HasKey(e => e.Programme)
                    .HasName("PK__mysql_pr__EB874AC94FE6CCC6");
            });

            modelBuilder.Entity<Name>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NewOtherPayment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Newmatricgen>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Newmatricgendel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NoisyDatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NyscUpdate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OlevelExam>(entity =>
            {
                entity.HasOne(d => d.Olenid1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Olenid1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelExams_OLevelExamNames");

                entity.HasOne(d => d.Olenid2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Olenid2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelExams_OLevelExamNames1");
            });

            modelBuilder.Entity<OlevelExamYear>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OlevelExamsApplicant>(entity =>
            {
                entity.HasOne(d => d.Olenid1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Olenid1)
                    .HasConstraintName("FK_OLevelExamsApplicant_OLevelExamNames");

                entity.HasOne(d => d.Olenid2Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.Olenid2)
                    .HasConstraintName("FK_OLevelExamsApplicant_OLevelExamNames1");
            });

            modelBuilder.Entity<OlevelGrade>(entity =>
            {
                entity.Property(e => e.Olgname).IsFixedLength();
            });

            modelBuilder.Entity<OlevelResult>(entity =>
            {
                entity.HasOne(d => d.Olg)
                    .WithMany(p => p.OlevelResults)
                    .HasForeignKey(d => d.Olgid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelResults_OLevelGrade");

                entity.HasOne(d => d.Ols)
                    .WithMany(p => p.OlevelResults)
                    .HasForeignKey(d => d.Olsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelResults_OLevelSubjects");
            });

            modelBuilder.Entity<OlevelResultsApplicant>(entity =>
            {
                entity.HasOne(d => d.Olg)
                    .WithMany(p => p.OlevelResultsApplicants)
                    .HasForeignKey(d => d.Olgid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelResultsApplicant_OLevelGrade");

                entity.HasOne(d => d.Ols)
                    .WithMany(p => p.OlevelResultsApplicants)
                    .HasForeignKey(d => d.Olsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelResultsApplicant_OLevelSubjects");
            });

            modelBuilder.Entity<OlevelResultsApplicantPre>(entity =>
            {
                entity.HasOne(d => d.Olg)
                    .WithMany(p => p.OlevelResultsApplicantPres)
                    .HasForeignKey(d => d.Olgid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelResultsApplicantPre_OLevelGrade");

                entity.HasOne(d => d.Ols)
                    .WithMany(p => p.OlevelResultsApplicantPres)
                    .HasForeignKey(d => d.Olsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OLevelResultsApplicantPre_OLevelSubjects");
            });

            modelBuilder.Entity<OlevelSittingSelected>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OlevelSittingTbl>(entity =>
            {
                entity.Property(e => e.SittingId).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<Olevelvsyaba>(entity =>
            {
                entity.Property(e => e.Sn).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OnlineAppLogDb>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OnlineAppVerficationPayment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OnlineappAll>(entity =>
            {
                entity.HasOne(d => d.Program)
                    .WithMany(p => p.OnlineappAlls)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnlineappAll_Programs");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.OnlineappAlls)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnlineappAll_Sessions");
            });

            modelBuilder.Entity<OnlineappComplain>(entity =>
            {
                entity.Property(e => e.ComplainId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OnlineappCompleted>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK_OnlineappCompleted_1");
            });

            modelBuilder.Entity<OnlineappPayment>(entity =>
            {
                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.OnlineappPayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnlineappPayments_Banks");
            });

            modelBuilder.Entity<OtherPayment>(entity =>
            {
                entity.HasKey(e => e.PayeeNum)
                    .HasName("PK__OtherPayments___0D9BEFB1165A2CA1");
            });

            modelBuilder.Entity<Outsssss>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__Outsssss__0010F2D1567ADF8D");
            });

            modelBuilder.Entity<Payfromgit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymantStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasOne(d => d.PayeeNumNavigation)
                    .WithMany()
                    .HasPrincipalKey(p => p.Appnum)
                    .HasForeignKey(d => d.PayeeNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payments_Applicants");
            });

            modelBuilder.Entity<PaymentsCopy>(entity =>
            {
                entity.HasOne(d => d.PayeeNumNavigation)
                    .WithMany()
                    .HasPrincipalKey(p => p.Appnum)
                    .HasForeignKey(d => d.PayeeNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payments___Payee__3DE8FB0E");
            });

            modelBuilder.Entity<PenaltyPayment>(entity =>
            {
                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PenaltyPayments)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PenaltyPayments_YCTPAY_Payments");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.PenaltyPayments)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PenaltyPayments_Semesters");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.PenaltyPayments)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PenaltyPayments_Sessions");
            });

            modelBuilder.Entity<PendingSchoolFee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PostResultsUtme>(entity =>
            {
                entity.HasKey(e => e.UtmeNumber)
                    .HasName("PK__PostResu__FA4999B5425C58B8");
            });

            modelBuilder.Entity<PostutmeAllCopy>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__Postutme__BF537CF471042FE5");
            });

            modelBuilder.Entity<PostutmeAllCopy1>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__Postutme__BF537CF47408257D");
            });

            modelBuilder.Entity<PostutmeAllImage>(entity =>
            {
                entity.Property(e => e.UtmeNumber).IsFixedLength();
            });

            modelBuilder.Entity<PostutmeAllSecond>(entity =>
            {
                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.PostutmeAllSeconds)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeAllSecond_Genders");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PostutmeAllSeconds)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeAllSecond_Programs");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.PostutmeAllSeconds)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeAllSecond_Sessions");
            });

            modelBuilder.Entity<PostutmeAllSecondCopy>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__Postutme__BF537CF4CB1E5E1E");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.PostutmeAllSecondCopies)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PostutmeA__Gende__4A2ED662");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PostutmeAllSecondCopies)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PostutmeA__Progr__4B22FA9B");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.PostutmeAllSecondCopies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PostutmeA__Sessi__4C171ED4");
            });

            modelBuilder.Entity<PostutmeAllocation>(entity =>
            {
                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.PostutmeAllocations)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeAllocations_PostutmeBatches");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.PostutmeAllocations)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeAllocations_PostutmeVenues");
            });

            modelBuilder.Entity<PostutmeAllocationIssuesCopy>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__Postutme__0E9761D2E28FBFE6");
            });

            modelBuilder.Entity<PostutmeAllocationsCopy>(entity =>
            {
                entity.HasKey(e => e.UtmeNumber)
                    .HasName("PK__Postutme__FA4999B5E57005CE");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.PostutmeAllocationsCopies)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PostutmeA__Batch__465E457E");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.PostutmeAllocationsCopies)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PostutmeA__Venue__475269B7");
            });

            modelBuilder.Entity<PostutmeApplicantList>(entity =>
            {
                entity.HasOne(d => d.UtmenumberNavigation)
                    .WithOne(p => p.PostutmeApplicantList)
                    .HasForeignKey<PostutmeApplicantList>(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeApplicantList_PostutmeResults");
            });

            modelBuilder.Entity<PostutmeApplicantListCopy>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__Postutme__0E9761D2BDBBA90F");

                entity.HasOne(d => d.UtmenumberNavigation)
                    .WithOne(p => p.PostutmeApplicantListCopy)
                    .HasForeignKey<PostutmeApplicantListCopy>(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PostutmeA__Utmen__4EF38B7F");
            });

            modelBuilder.Entity<PostutmeBatchesCopy>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PK__Postutme__5D55CE38F83DDFDA");
            });

            modelBuilder.Entity<PostutmeBuildingsCopy>(entity =>
            {
                entity.HasKey(e => e.BuildingId)
                    .HasName("PK__Postutme__5463CDE4898AF298");
            });

            modelBuilder.Entity<PostutmeImage>(entity =>
            {
                entity.Property(e => e.Appnum).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PostutmeImagesCopy>(entity =>
            {
                entity.Property(e => e.Appnum).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PostutmePayment>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK_PostutmePayments2");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.PostutmePayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmePayments2_Banks");

                entity.HasOne(d => d.UtmenumberNavigation)
                    .WithOne(p => p.PostutmePayment)
                    .HasPrincipalKey<Biodata2>(p => p.Appnum)
                    .HasForeignKey<PostutmePayment>(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmePayments_Biodata");

                entity.HasOne(d => d.Utmenumber1)
                    .WithOne(p => p.PostutmePayment)
                    .HasForeignKey<PostutmePayment>(d => d.Utmenumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmePayments2_PostutmeAll");
            });

            modelBuilder.Entity<PostutmePayments3>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_PostutmePayments");

                entity.Property(e => e.Utmenumber).IsFixedLength();

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.PostutmePayments3s)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmePayments_Banks");
            });

            modelBuilder.Entity<PostutmeResult>(entity =>
            {
                entity.HasKey(e => e.UtmeNumber)
                    .HasName("PK_ResolvedPostUtmeResults_1");

                entity.HasOne(d => d.UtmeNumberNavigation)
                    .WithOne(p => p.PostutmeResult)
                    .HasPrincipalKey<Biodata2>(p => p.Appnum)
                    .HasForeignKey<PostutmeResult>(d => d.UtmeNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeResults_Biodata");
            });

            modelBuilder.Entity<PostutmeVenue>(entity =>
            {
                entity.HasOne(d => d.Building)
                    .WithMany(p => p.PostutmeVenues)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostutmeVenues_PostutmeBuildings");
            });

            modelBuilder.Entity<PostutmeVenuePriorityCopy>(entity =>
            {
                entity.HasKey(e => e.Pvpid)
                    .HasName("PK__Postutme__641AA322817747A6");
            });

            modelBuilder.Entity<PostutmeVenuesCopy>(entity =>
            {
                entity.HasKey(e => e.VenueId)
                    .HasName("PK__Postutme__3C57E5D2E59FE96D");

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.PostutmeVenuesCopies)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PostutmeV__Build__5B596264");
            });

            modelBuilder.Entity<Progerror>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EBPortal.Program>(entity =>
            {
                entity.HasOne(d => d.Pc)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.Pcid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Programs_ProgramCertificates");

                entity.HasOne(d => d.Pn)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.Pnid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Programs_ProgramNames");

                entity.HasOne(d => d.Pt)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.Ptid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Programs_ProgramTypes");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Programs_Schools");
            });

            modelBuilder.Entity<ProgramLevel>(entity =>
            {
                entity.HasOne(d => d.Level)
                    .WithMany(p => p.ProgramLevels)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramLevels_Levels");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramLevels)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramLevels_Programs");
            });

            modelBuilder.Entity<ProgramLevelSemester>(entity =>
            {
                entity.HasOne(d => d.Level)
                    .WithMany(p => p.ProgramLevelSemesters)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramLevelSemesters_Levels");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramLevelSemesters)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramLevelSemesters_Programs");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.ProgramLevelSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramLevelSemesters_Semesters");
            });

            modelBuilder.Entity<ProgramName>(entity =>
            {
                entity.Property(e => e.Pnid).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProgramType>(entity =>
            {
                entity.HasKey(e => e.Ptid)
                    .HasName("PK_ProgramType");
            });

            modelBuilder.Entity<PtPayStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QualifiedCandidatesWithIssue>(entity =>
            {
                entity.Property(e => e.RegNumber).IsFixedLength();
            });

            modelBuilder.Entity<QuotaExhaustedJamb>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__QuotaExh__BF537CF46E4C3B47");
            });

            modelBuilder.Entity<Redflag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegistrationExemption>(entity =>
            {
                entity.Property(e => e.ExemptionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReverifyCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RrrValidatorCode>(entity =>
            {
                entity.HasKey(e => e.PassCode)
                    .HasName("PK__RRR_Vali__7242CFC9F6591E66");
            });

            modelBuilder.Entity<Samplecourse>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SchoolAdmissionList>(entity =>
            {
                entity.HasOne(d => d.Al)
                    .WithMany(p => p.SchoolAdmissionLists)
                    .HasForeignKey(d => d.Alid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolAdmissionList_AdmissionList");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SchoolAdmissionLists)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolAdmissionList_Schools");
            });

            modelBuilder.Entity<SchoolFee>(entity =>
            {
                entity.HasKey(e => e.Sfid)
                    .HasName("PK_SchoolFees_1");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.SchoolFees)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFees_Banks");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.SchoolFees)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFees_Levels");

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.SchoolFees)
                    .HasForeignKey(d => d.MerchantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFees_Accounts");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.SchoolFees)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFees_Sessions");
            });

            modelBuilder.Entity<SchoolFeesApproval>(entity =>
            {
                entity.Property(e => e.Sfid).ValueGeneratedNever();

                entity.HasOne(d => d.Sf)
                    .WithOne(p => p.SchoolFeesApproval)
                    .HasForeignKey<SchoolFeesApproval>(d => d.Sfid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFeesApproval_SchoolFees");
            });

            modelBuilder.Entity<SchoolFeesBreakdown>(entity =>
            {
                entity.Property(e => e.Code).IsFixedLength();

                entity.HasOne(d => d.CodeNavigation)
                    .WithMany(p => p.SchoolFeesBreakdowns)
                    .HasForeignKey(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFeesBreakdown_SchoolFeesItems");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.SchoolFeesBreakdowns)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFeesBreakdown_Levels");

                entity.HasOne(d => d.Pt)
                    .WithMany(p => p.SchoolFeesBreakdowns)
                    .HasForeignKey(d => d.Ptid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFeesBreakdown_ProgramTypes");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SchoolFeesBreakdowns)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchoolFeesBreakdown_Schools");
            });

            modelBuilder.Entity<SchoolFeesBreakdownCopy>(entity =>
            {
                entity.HasKey(e => e.Sfbid)
                    .HasName("PK__SchoolFe__60B2BC5F2FE101C2");

                entity.Property(e => e.Code).IsFixedLength();

                entity.HasOne(d => d.CodeNavigation)
                    .WithMany(p => p.SchoolFeesBreakdownCopies)
                    .HasForeignKey(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SchoolFees__Code__6908633D");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.SchoolFeesBreakdownCopies)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SchoolFee__Level__67201ACB");

                entity.HasOne(d => d.Pt)
                    .WithMany(p => p.SchoolFeesBreakdownCopies)
                    .HasForeignKey(d => d.Ptid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SchoolFees__PTID__68143F04");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.SchoolFeesBreakdownCopies)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SchoolFee__Schoo__69FC8776");
            });

            modelBuilder.Entity<SchoolFeesItem>(entity =>
            {
                entity.Property(e => e.Code).IsFixedLength();
            });

            modelBuilder.Entity<SchoolOfficerApproval>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Screening>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Clearanc__ECD935AA2EF735BF");

                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.Screening)
                    .HasForeignKey<Screening>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clearance__Appnu__5F14E4AF");
            });

            modelBuilder.Entity<ScreeningExemption>(entity =>
            {
                entity.Property(e => e.ExemptionId).ValueGeneratedOnAdd();

                entity.Property(e => e.MatricNo).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Who).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<ScreeningLock>(entity =>
            {
                entity.Property(e => e.Message).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.RegLockId).ValueGeneratedOnAdd();

                entity.Property(e => e.Who).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<ScreeningNotQualified>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Clearanc__ECD935AA54C6D483");

                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.ScreeningNotQualified)
                    .HasForeignKey<ScreeningNotQualified>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clearance__Appnu__67AA2AB0");
            });

            modelBuilder.Entity<ScreeningReverse>(entity =>
            {
                entity.HasKey(e => e.Crid)
                    .HasName("PK__Clearanc__F2363F52B0F465D2");
            });

            modelBuilder.Entity<SelectedSitting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.Property(e => e.SemesterId).ValueGeneratedNever();

                entity.Property(e => e.CurrentSemester).IsFixedLength();
            });

            modelBuilder.Entity<Semestersp>(entity =>
            {
                entity.HasKey(e => e.SemesterId)
                    .HasName("PK_Semesters");
            });

            modelBuilder.Entity<Specialstudent>(entity =>
            {
                entity.Property(e => e.Acadsession).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Disabilitytype).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Matricnum).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Pregnancy).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Semester).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.WccUsuage).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<Stdportal>(entity =>
            {
                entity.Property(e => e.Acadsession).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Activecount)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Address).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Appnum).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.CourseOptions).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.DateEdited).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Defer)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Dob).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Email).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.EntryYear).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Expel)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Firstname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Graduate)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Inactivecount)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Level).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.LocalGovArea).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Matricnum).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Mob).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Othername).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PGAddress).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PGPhone).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ParentGuardian).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Password).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Phone).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PlaceOfBirth).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Programme).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ProgrammeType).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Repeatclass)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sex).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.StateOfOrigin).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Stepdown)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Studenshipstatus).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Surname).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Suspension)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.TimeEdited).UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Withdrawal)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Yob).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<SteSecondSemester1516>(entity =>
            {
                entity.HasKey(e => e.Matricno)
                    .HasName("PK__ste_seco__8E52BBA180D42EAA");
            });

            modelBuilder.Entity<StudException>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StudExceptionCopy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StudTab>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StudTabCopy>(entity =>
            {
                entity.HasKey(e => e.UtmeReg)
                    .HasName("PK__StudTab___FD19424A7C7A5F0D");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StudTabCopy1>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EBPortal.Student>(entity =>
            {
                entity.HasOne(d => d.Pls)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Plsid)
                    .HasConstraintName("FK_Students_ProgramLevelSemesters");
            });

            modelBuilder.Entity<StudentRecord>(entity =>
            {
                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Failout).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();

                entity.Property(e => e.WithdrawalCertificate).IsFixedLength();
            });

            modelBuilder.Entity<StudentRecordMaster>(entity =>
            {
                entity.Property(e => e.Activecount).IsFixedLength();

                entity.Property(e => e.Defer).IsFixedLength();

                entity.Property(e => e.Expel).IsFixedLength();

                entity.Property(e => e.Graduate).IsFixedLength();

                entity.Property(e => e.Inactivecount).IsFixedLength();

                entity.Property(e => e.Repeatclass).IsFixedLength();

                entity.Property(e => e.Stepdown).IsFixedLength();

                entity.Property(e => e.Suspension).IsFixedLength();

                entity.Property(e => e.Withdrawal).IsFixedLength();
            });

            modelBuilder.Entity<Sup1ChangCourse1Error>(entity =>
            {
                entity.HasKey(e => e.Utmenumber)
                    .HasName("PK__Sup1_Cha__BF537CF44076B4B8");
            });

            modelBuilder.Entity<Supp1new>(entity =>
            {
                entity.HasKey(e => e.RegNumb)
                    .HasName("PK__Supp1new__EFCC4DECE4C87CF0");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.Property(e => e.Ta).IsFixedLength();
            });

            modelBuilder.Entity<Taken2abujaSn>(entity =>
            {
                entity.HasKey(e => e.RegNumb)
                    .HasName("PK__taken2ab__EFCC4DECC940AB2D");
            });

            modelBuilder.Entity<TempLga>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TempPayment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Tempst>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Tempstudent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TertiaryInstitutionGrade>(entity =>
            {
                entity.HasKey(e => e.Tigid)
                    .HasName("PK_TetiaryInstitutionGrades");
            });

            modelBuilder.Entity<TertiaryInstitutionResult>(entity =>
            {
                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.TertiaryInstitutionResults)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_TertiaryInstitutionResult_TertiaryInstitutionResult");

                entity.HasOne(d => d.Tig)
                    .WithMany(p => p.TertiaryInstitutionResults)
                    .HasForeignKey(d => d.Tigid)
                    .HasConstraintName("FK_TertiaryInstitutionResult_TetiaryInstitutionGrades");

                entity.HasOne(d => d.Ti)
                    .WithMany(p => p.TertiaryInstitutionResults)
                    .HasForeignKey(d => d.Tiid)
                    .HasConstraintName("FK_TertiaryInstitutionResult_TertiaryInstitutions");

                entity.HasOne(d => d.Tipn)
                    .WithMany(p => p.TertiaryInstitutionResults)
                    .HasForeignKey(d => d.Tipnid)
                    .HasConstraintName("FK_TertiaryInstitutionResult_ProgramNames");
            });

            modelBuilder.Entity<TertiaryInstitutionResultApplicant>(entity =>
            {
                entity.HasKey(e => e.ApplicationNumber)
                    .HasName("PK_TertiaryInstitutionResultApplicant_1");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.TertiaryInstitutionResultApplicants)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant_TertiaryInstitutionResultApplicant");

                entity.HasOne(d => d.Tig)
                    .WithMany(p => p.TertiaryInstitutionResultApplicants)
                    .HasForeignKey(d => d.Tigid)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant_TetiaryInstitutionGrades");

                entity.HasOne(d => d.Ti)
                    .WithMany(p => p.TertiaryInstitutionResultApplicants)
                    .HasForeignKey(d => d.Tiid)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant_TertiaryInstitutions");

                entity.HasOne(d => d.Tipn)
                    .WithMany(p => p.TertiaryInstitutionResultApplicants)
                    .HasForeignKey(d => d.Tipnid)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant_ProgramNames");
            });

            modelBuilder.Entity<TertiaryInstitutionResultApplicant2>(entity =>
            {
                entity.HasKey(e => e.ApplicationNumber)
                    .HasName("PK_TertiaryInstitutionResultApplicant2_1");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.TertiaryInstitutionResultApplicant2s)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant2_TertiaryInstitutionResultApplicant2");

                entity.HasOne(d => d.Tig)
                    .WithMany(p => p.TertiaryInstitutionResultApplicant2s)
                    .HasForeignKey(d => d.Tigid)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant2_TetiaryInstitutionGrades");

                entity.HasOne(d => d.Ti)
                    .WithMany(p => p.TertiaryInstitutionResultApplicant2s)
                    .HasForeignKey(d => d.Tiid)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant2_TertiaryInstitutions");

                entity.HasOne(d => d.Tipn)
                    .WithMany(p => p.TertiaryInstitutionResultApplicant2s)
                    .HasForeignKey(d => d.Tipnid)
                    .HasConstraintName("FK_TertiaryInstitutionResultApplicant2_ProgramNames");
            });

            modelBuilder.Entity<Textile2>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Textile2__ECD935AA423C49AD");
            });

            modelBuilder.Entity<TotalHndwithScore20142015>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__TotalHND__6BC7D64E585CFA28");
            });

            modelBuilder.Entity<Transactions2>(entity =>
            {
                entity.Property(e => e.TranId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransactionsBack1>(entity =>
            {
                entity.Property(e => e.TranId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TransactionsVsGtco>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TranscriptPayment>(entity =>
            {
                entity.HasKey(e => e.Receiptnum)
                    .HasName("PK_TranscriptNo");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.TranscriptPayments)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdmissionLetterPayments_BankID");
            });

            modelBuilder.Entity<Tttputmenumber>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK_TTTPUtmenum");
            });

            modelBuilder.Entity<UnFlagAdmission>(entity =>
            {
                entity.HasKey(e => e.UnFlagId)
                    .HasName("PK_UnFlagAdmission_1");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.UnFlagAdmissions)
                    .HasForeignKey(d => d.ReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnFlagAdmission_AdmissionUnflagReasons");
            });

            modelBuilder.Entity<Unfound>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UpdatedVwYctpayTransaction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Verified>(entity =>
            {
                entity.HasKey(e => e.Appnum)
                    .HasName("PK__Clearanc__ECD935AAAC3CAA81");

                entity.HasOne(d => d.AppnumNavigation)
                    .WithOne(p => p.Verified)
                    .HasForeignKey<Verified>(d => d.Appnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clearance__Appnu__09CA388A");
            });

            modelBuilder.Entity<VerifyTransaction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwAcceptanceFee>(entity =>
            {
                entity.ToView("vw_AcceptanceFees");
            });

            modelBuilder.Entity<VwAdmission>(entity =>
            {
                entity.ToView("vw_Admission");
            });

            modelBuilder.Entity<VwAdmissionLetterPayment>(entity =>
            {
                entity.ToView("vw_AdmissionLetterPayments");
            });

            modelBuilder.Entity<VwAdmissionRejectionPayment>(entity =>
            {
                entity.ToView("vw_AdmissionRejectionPayments");
            });

            modelBuilder.Entity<VwAdmittable>(entity =>
            {
                entity.ToView("vw_Admittable");
            });

            modelBuilder.Entity<VwApplicant>(entity =>
            {
                entity.ToView("vw_Applicants", "ApplicantPenalty");
            });

            modelBuilder.Entity<VwApplicantComplaint>(entity =>
            {
                entity.ToView("vw_ApplicantComplaints");

                entity.Property(e => e.ComplaintStatus).IsFixedLength();
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.ToView("vw_aspnet_Applications");
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.ToView("vw_aspnet_MembershipUsers");
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.ToView("vw_aspnet_Profiles");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.ToView("vw_aspnet_Roles");
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.ToView("vw_aspnet_Users");
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.ToView("vw_aspnet_WebPartState_Paths");
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.ToView("vw_aspnet_WebPartState_Shared");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.ToView("vw_aspnet_WebPartState_User");
            });

            modelBuilder.Entity<VwBiodataApplicant>(entity =>
            {
                entity.ToView("vw_BiodataApplicant");

                entity.Property(e => e.Appnum).IsFixedLength();
            });

            modelBuilder.Entity<VwBiodatum>(entity =>
            {
                entity.ToView("vw_Biodata");
            });

            modelBuilder.Entity<VwChangeOfCoursePayment>(entity =>
            {
                entity.ToView("vw_ChangeOfCoursePayment");
            });

            modelBuilder.Entity<VwChangeofCourse>(entity =>
            {
                entity.ToView("vw_ChangeofCourse");
            });

            modelBuilder.Entity<VwClearance>(entity =>
            {
                entity.ToView("vw_Clearance");
            });

            modelBuilder.Entity<VwClearanceRegularization>(entity =>
            {
                entity.ToView("vw_ClearanceRegularization");
            });

            modelBuilder.Entity<VwClearanceRegularizationPayment>(entity =>
            {
                entity.ToView("vw_ClearanceRegularizationPayments");
            });

            modelBuilder.Entity<VwComplaint>(entity =>
            {
                entity.Property(e => e.Status).IsFixedLength();
            });

            modelBuilder.Entity<VwCourse>(entity =>
            {
                entity.ToView("vw_Courses");
            });

            modelBuilder.Entity<VwCourseRegistration>(entity =>
            {
                entity.ToView("vw_CourseRegistration");
            });

            modelBuilder.Entity<VwCourseRegistrationDetail>(entity =>
            {
                entity.ToView("vw_CourseRegistrationDetails");
            });

            modelBuilder.Entity<VwCourseRegistrationLatePayment>(entity =>
            {
                entity.ToView("vw_CourseRegistrationLatePayments");
            });

            modelBuilder.Entity<VwCourseRegistrationLateSubmission>(entity =>
            {
                entity.ToView("vw_CourseRegistrationLateSubmission");
            });

            modelBuilder.Entity<VwCourseregistrationApproval>(entity =>
            {
                entity.ToView("vw_CourseregistrationApproval");
            });

            modelBuilder.Entity<VwDirectEntryAll>(entity =>
            {
                entity.ToView("vw_DirectEntryAll");

                entity.Property(e => e.Utmenumber).IsFixedLength();
            });

            modelBuilder.Entity<VwDirectInsertAll>(entity =>
            {
                entity.ToView("vw_DirectInsertAll");
            });

            modelBuilder.Entity<VwDirectentryPayment>(entity =>
            {
                entity.ToView("vw_DirectentryPayments");
            });

            modelBuilder.Entity<VwFlagAdmission>(entity =>
            {
                entity.ToView("vw_FlagAdmission");
            });

            modelBuilder.Entity<VwFlagAdmissionWithScore>(entity =>
            {
                entity.ToView("vw_FlagAdmissionWithScore");
            });

            modelBuilder.Entity<VwGenmatricno>(entity =>
            {
                entity.ToView("vw_genmatricnos");
            });

            modelBuilder.Entity<VwGradTable2016>(entity =>
            {
                entity.ToView("vw_GradTable2016");

                entity.Property(e => e.FinalRemark).IsFixedLength();
            });

            modelBuilder.Entity<VwHostelApplicationPayment>(entity =>
            {
                entity.ToView("vw_HostelApplicationPayments");
            });

            modelBuilder.Entity<VwHostelPayment>(entity =>
            {
                entity.ToView("vw_HostelPayments");
            });

            modelBuilder.Entity<VwLga>(entity =>
            {
                entity.ToView("vw_LGA");
            });

            modelBuilder.Entity<VwOlevelExam>(entity =>
            {
                entity.ToView("vw_OLevelExams");
            });

            modelBuilder.Entity<VwOlevelExamsApplicant>(entity =>
            {
                entity.ToView("vw_OlevelExamsApplicant");
            });

            modelBuilder.Entity<VwOlevelExamsApplicantUpdate>(entity =>
            {
                entity.ToView("vw_OlevelExamsApplicantUpdate");
            });

            modelBuilder.Entity<VwOlevelResult>(entity =>
            {
                entity.ToView("vw_OLevelResults");

                entity.Property(e => e.Olgname).IsFixedLength();
            });

            modelBuilder.Entity<VwOlevelResultsApplicant>(entity =>
            {
                entity.ToView("vw_OLevelResultsApplicant");

                entity.Property(e => e.Olgname).IsFixedLength();
            });

            modelBuilder.Entity<VwOnlineappAll>(entity =>
            {
                entity.ToView("vw_OnlineappAll");
            });

            modelBuilder.Entity<VwOnlineappCompleted>(entity =>
            {
                entity.ToView("vw_OnlineappCompleted");
            });

            modelBuilder.Entity<VwOnlineappPayment>(entity =>
            {
                entity.ToView("vw_OnlineappPayments");
            });

            modelBuilder.Entity<VwOnlineappPersonalinfo>(entity =>
            {
                entity.ToView("vw_OnlineappPersonalinfo");
            });

            modelBuilder.Entity<VwPayment>(entity =>
            {
                entity.ToView("vw_Payments", "ApplicantPenalty");
            });

            modelBuilder.Entity<VwPaymentchecker>(entity =>
            {
                entity.ToView("vw_paymentchecker");
            });

            modelBuilder.Entity<VwPenaltyPayment>(entity =>
            {
                entity.ToView("vw_PenaltyPayments");
            });

            modelBuilder.Entity<VwPostResultsUtme>(entity =>
            {
                entity.ToView("vw_PostResultsUtme");
            });

            modelBuilder.Entity<VwPostUtmePayment>(entity =>
            {
                entity.ToView("vw_PostUtmePayments");
            });

            modelBuilder.Entity<VwPostutmeAll>(entity =>
            {
                entity.ToView("vw_PostutmeAll");
            });

            modelBuilder.Entity<VwPostutmeAllSecond>(entity =>
            {
                entity.ToView("vw_PostutmeAllSecond");
            });

            modelBuilder.Entity<VwPostutmeAllocation>(entity =>
            {
                entity.ToView("vw_PostutmeAllocations");
            });

            modelBuilder.Entity<VwPostutmeApplicantList>(entity =>
            {
                entity.ToView("vw_PostutmeApplicantList");
            });

            modelBuilder.Entity<VwPostutmeResult>(entity =>
            {
                entity.ToView("vw_PostutmeResults");
            });

            modelBuilder.Entity<VwProgram>(entity =>
            {
                entity.ToView("vw_Programs");
            });

            modelBuilder.Entity<VwProgramLevel>(entity =>
            {
                entity.ToView("vw_ProgramLevels");
            });

            modelBuilder.Entity<VwProgramLevelSemester>(entity =>
            {
                entity.ToView("vw_ProgramLevelSemesters");
            });

            modelBuilder.Entity<VwPtPayStatus>(entity =>
            {
                entity.ToView("Vw_PT_PAY_Status");

                entity.Property(e => e.Level).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<VwRegistrationLatePayment>(entity =>
            {
                entity.ToView("vw_RegistrationLatePayments");
            });

            modelBuilder.Entity<VwSchoolFee>(entity =>
            {
                entity.ToView("vw_SchoolFees");
            });

            modelBuilder.Entity<VwSchoolFeesApproval>(entity =>
            {
                entity.ToView("vw_SchoolFeesApproval");
            });

            modelBuilder.Entity<VwSchoolFeesBreakDown>(entity =>
            {
                entity.ToView("vw_SchoolFeesBreakDown");

                entity.Property(e => e.Code).IsFixedLength();
            });

            modelBuilder.Entity<VwSchoolFessApproval>(entity =>
            {
                entity.ToView("vw_SchoolFessApproval");
            });

            modelBuilder.Entity<VwScreening>(entity =>
            {
                entity.ToView("vw_Screening");
            });

            modelBuilder.Entity<VwStudent>(entity =>
            {
                entity.ToView("vw_Students");
            });

            modelBuilder.Entity<VwTertiaryInstitutionResult>(entity =>
            {
                entity.ToView("vw_TertiaryInstitutionResult");
            });

            modelBuilder.Entity<VwTertiaryInstitutionResultApplicant>(entity =>
            {
                entity.ToView("vw_TertiaryInstitutionResultApplicant");
            });

            modelBuilder.Entity<VwTertiaryInstitutionResultApplicant2>(entity =>
            {
                entity.ToView("vw_TertiaryInstitutionResultApplicant2");
            });

            modelBuilder.Entity<VwTransaction>(entity =>
            {
                entity.ToView("vw_Transactions");
            });

            modelBuilder.Entity<VwUnflagAdmission>(entity =>
            {
                entity.ToView("vw_UnflagAdmission");
            });

            modelBuilder.Entity<VwYctpayDamagesPayment>(entity =>
            {
                entity.ToView("vw_YCTPAY_DamagesPayment");
            });

            modelBuilder.Entity<VwYctpaySuccessfulTransaction>(entity =>
            {
                entity.ToView("vw_YCTPAY_SuccessfulTransactions");
            });

            modelBuilder.Entity<VwYctpayTransaction>(entity =>
            {
                entity.ToView("vw_YCTPAY_Transactions");
            });

            modelBuilder.Entity<VwYctpayTransactionOther>(entity =>
            {
                entity.ToView("vw_YCTPAY_Transaction_Others");
            });

            modelBuilder.Entity<VwYctpayTransactionswithMixedupDatum>(entity =>
            {
                entity.ToView("vw_YCTPAY_TransactionswithMixedupData");
            });

            modelBuilder.Entity<Weldin>(entity =>
            {
                entity.Property(e => e.Utmenumber).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<Weldin16>(entity =>
            {
                entity.Property(e => e.Utmenumber).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<Weldin167>(entity =>
            {
                entity.Property(e => e.Utmenumber).UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<YabatechRemitaPayment>(entity =>
            {
                entity.HasKey(e => e.Rrr)
                    .HasName("PK__yabatech__C2B795152E7F875A");
            });

            modelBuilder.Entity<YabatechRemitaPaymentCopy>(entity =>
            {
                entity.HasKey(e => e.Rrr)
                    .HasName("PK__yabatech__C2B795158C44F968");
            });

            modelBuilder.Entity<YabatechRemitaPaymentCopy1>(entity =>
            {
                entity.HasKey(e => e.Rrr)
                    .HasName("PK__yabatech__C2B7951567F0103B");
            });

            modelBuilder.Entity<YabatechRemitaTempData150220161026am>(entity =>
            {
                entity.HasKey(e => e.Rrr)
                    .HasName("PK__yabatech__C2B795158437D133");
            });

            modelBuilder.Entity<YabatechRemitaTempData210120161002am>(entity =>
            {
                entity.HasKey(e => e.Rrr)
                    .HasName("PK__yabatech__C2B79515720E1555");
            });

            modelBuilder.Entity<YabatechRemitaTempDataCopy>(entity =>
            {
                entity.HasKey(e => e.Rrr)
                    .HasName("PK__yabatech__C2B79515305971DF");
            });

            modelBuilder.Entity<YabatechRemitaTempDatum>(entity =>
            {
                entity.HasKey(e => e.Rrr)
                    .HasName("PK__yabatech__C2B79515F9D6613F");
            });

            modelBuilder.Entity<YabavsjambLga>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__yabavsja__32151C44E2B7377A");
            });

            modelBuilder.Entity<YctTranscriptApp>(entity =>
            {
                entity.HasOne(d => d.Program)
                    .WithMany(p => p.YctTranscriptApps)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__yct_trans__Progr__6F2B50E7");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.YctTranscriptApps)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__yct_trans__Sessi__701F7520");
            });

            modelBuilder.Entity<YctpayDamagesPayment>(entity =>
            {
                entity.Property(e => e.Serial).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YctpayOtherPayment1>(entity =>
            {
                entity.Property(e => e.Serial).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YctpayOthersPayment>(entity =>
            {
                entity.HasKey(e => e.Spid)
                    .HasName("PK__YCTPAY_S__F43060C9D12BAB4C");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.YctpayOthersPayments)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Payme__367CE370");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.YctpayOthersPayments)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Sessi__3588BF37");
            });

            modelBuilder.Entity<YctpayPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_YCTPAYPAYMENT");

                entity.Property(e => e.PaymentId).ValueGeneratedNever();
            });

            modelBuilder.Entity<YctpayPaymentBiodatum>(entity =>
            {
                entity.HasOne(d => d.Program)
                    .WithMany(p => p.YctpayPaymentBiodata)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YCTPAY_PaymentBiodata_Programs");
            });

            modelBuilder.Entity<YctpayPaymentStatus>(entity =>
            {
                entity.Property(e => e.AllPaymentStatus).IsFixedLength();
            });

            modelBuilder.Entity<YctpayStudentsPayment>(entity =>
            {
                entity.HasKey(e => e.Spid)
                    .HasName("PK__YCTPAY_S__F43060C94B178C8D");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.YctpayStudentsPayments)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Payme__32774862");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.YctpayStudentsPayments)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Sessi__31832429");
            });

            modelBuilder.Entity<YctpayStudentsPaymentsCopy>(entity =>
            {
                entity.HasKey(e => e.Spid)
                    .HasName("PK__YCTPAY_S__F43060C90A647912");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.YctpayStudentsPaymentsCopies)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Payme__392445F1");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.YctpayStudentsPaymentsCopies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Sessi__3A186A2A");
            });

            modelBuilder.Entity<YctpayStudentsPaymentsCopyCopy>(entity =>
            {
                entity.HasKey(e => e.Spid)
                    .HasName("PK__YCTPAY_S__F43060C9189679BF");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.YctpayStudentsPaymentsCopyCopies)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Payme__3553B50D");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.YctpayStudentsPaymentsCopyCopies)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__YCTPAY_St__Sessi__3647D946");
            });

            modelBuilder.Entity<YctpayStudentsPaymentsMistake>(entity =>
            {
                entity.HasKey(e => e.Spid)
                    .HasName("PK_YCTPAY_StudentsPayments");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.YctpayStudentsPaymentsMistakes)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YCTPAY_StudentsPayments_YCTPAY_Payments");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.YctpayStudentsPaymentsMistakes)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YCTPAY_StudentsPayments_Sessions");
            });

            modelBuilder.Entity<YctpaySuccessfulTransaction>(entity =>
            {
                entity.HasOne(d => d.Tran)
                    .WithOne(p => p.YctpaySuccessfulTransaction)
                    .HasForeignKey<YctpaySuccessfulTransaction>(d => d.TranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YCTPAY_SuccessfulTransactions_YCTPAY_Transactions");
            });

            modelBuilder.Entity<YctpayTransaction>(entity =>
            {
                entity.HasOne(d => d.Sp)
                    .WithMany(p => p.YctpayTransactions)
                    .HasForeignKey(d => d.Spid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YCTPAY_Transactions_YCTPAY_StudentsPayments");
            });

            modelBuilder.Entity<YctpayTransactionOther>(entity =>
            {
                entity.HasKey(e => e.PayerId)
                    .HasName("PK__YCTPAY_T__0ADBE847F734E04A");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.YctpayTransactionOthers)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("PaymentID");
            });

            modelBuilder.Entity<YctpayTransactionsWithMixedMerchantId>(entity =>
            {
                entity.HasOne(d => d.Tran)
                    .WithOne(p => p.YctpayTransactionsWithMixedMerchantId)
                    .HasForeignKey<YctpayTransactionsWithMixedMerchantId>(d => d.TranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YCTPAY_TransactionsWithMixedMerchantID_YCTPAY_Transactions");
            });

            modelBuilder.Entity<YctpayTransactionswithMixedupDatum>(entity =>
            {
                entity.HasOne(d => d.Tran)
                    .WithOne(p => p.YctpayTransactionswithMixedupDatum)
                    .HasForeignKey<YctpayTransactionswithMixedupDatum>(d => d.TranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YCTPAY_TransactionswithMixedupData_YCTPAY_Transactions");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
