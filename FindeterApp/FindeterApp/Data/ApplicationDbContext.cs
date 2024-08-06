using Microsoft.EntityFrameworkCore;

namespace FindeterApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LoanApplication> LoanApplications { get; set; }
    }

    public class LoanApplication
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Sector { get; set; }
        public string ResourceUsage { get; set; }
        public decimal CreditAmount { get; set; }
        public bool IncludesExcludedActivities { get; set; }
        public bool HasEnvironmentalDepartment { get; set; }
        public bool HasASPersonnel { get; set; }
        public bool HasEnvironmentalPolicies { get; set; }
        public bool HasISO14001Certification { get; set; }
        public bool HasEnvironmentalLegalMatrix { get; set; }
        public bool IdentifiesPreventsImpacts { get; set; }
        public bool HasComplaintMechanism { get; set; }
        public bool CompliesWithLaborRegulations { get; set; }
        public bool ConductsEnvironmentalSupervision { get; set; }
        public bool CommunicatesSocioEnvironmentalIssues { get; set; }
        public bool IdentifiesEmergencySituations { get; set; }
        public bool HasBeenSanctioned { get; set; }
        public bool HasEnvironmentalLiabilities { get; set; }
        public bool ReceivedCommunityComplaints { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectPhase { get; set; }
        public int? ProjectProgressPercentage { get; set; }
        public string ProjectDuration { get; set; }
        public decimal TotalProjectValue { get; set; }
        public string ProjectLocation { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectZone { get; set; }
        public string LandUse { get; set; }
        public int EstimatedExecutionTime { get; set; }
        public float TotalIntervenedArea { get; set; }
        public string ProjectInfluenceZones { get; set; }
        public bool IsConsultationRequired { get; set; }
        public bool AreSocioEnvironmentalStudiesPublic { get; set; }
        public bool RequiresEnvironmentalDiagnosis { get; set; }
        public bool RequiresEnvironmentalLicense { get; set; }
        public bool RequiresEnvironmentalPermissions { get; set; }
        public bool HasEnvironmentalManagementPlan { get; set; }
        public bool GeneratesImpactOnWaterAirSoil { get; set; }
        public bool GeneratesImpactOnFloraFauna { get; set; }
        public bool GeneratesSocialLaborImpact { get; set; }
        public string WaterSource { get; set; }
        public string WorkerWaterSource { get; set; }
        public string WaterEfficiencyMeasures { get; set; }
        public string RequiresChemicalProducts { get; set; }
        public string UsesPesticides { get; set; }
        public string RequiresQuarryMaterials { get; set; }
        public string LightingType { get; set; }
        public string EnergySource { get; set; }
        public string EnergyEfficiencyMeasures { get; set; }
        public string OtherResourceEfficiencyMeasures { get; set; }
        public string IntegratesCleanProduction { get; set; }
        public string AffectedByNaturalEvents { get; set; }
        public string UsesEmissionGeneratingEquipment { get; set; }
        public string MeasuresCarbonFootprint { get; set; }
        public string ReducesGHGEmissions { get; set; }
        public string ClimateChangeAdaptationMeasures { get; set; }
        public string GeneratesWastewater { get; set; }
        public string MeasuresWaterFootprint { get; set; }
        public string GeneratesHazardousWaste { get; set; }
        public string GeneratesOrdinaryWaste { get; set; }
        public string ConsidersHistoricalPollution { get; set; }
        public string EfficiencyIndicators { get; set; }
        public string AvoidsHazardousChemicals { get; set; }
        public string AvoidsAirPollution { get; set; }
        public string AvoidsInfrastructureDismantling { get; set; }
        public string AvoidsVehicleMovement { get; set; }
        public string AvoidsUnqualifiedSecurity { get; set; }
        public string SecurityPersonnelTrained { get; set; }
        public string AvoidsFreshwaterUse { get; set; }
        public string HasCommunityComplaintMechanism { get; set; }
        public string AvoidsUnpleasantOdors { get; set; }
        public string AvoidsExcessiveNoise { get; set; }
        public string CommunitySocializationMechanisms { get; set; }
        public string COVID19PreventionMeasures { get; set; }
        public string AllowsNonDiscriminatoryHiring { get; set; }
        public string ProvidesEqualEmploymentOpportunities { get; set; }
        public string WorkersKnowTheirRights { get; set; }
        public string HasTrainingPrograms { get; set; }
        public string TemporaryWorkersEarnMinimumWage { get; set; }
        public string RespectsUnionAgreements { get; set; }
        public string EqualConditionsForForeignWorkers { get; set; }
        public string AdequateAccommodationForDisplacedWorkers { get; set; }
        public string NoForcedLabor { get; set; }
        public string VerifiesWorkerAge { get; set; }
        public string ManagesChildLaborRisks { get; set; }
        public string UsesWorkPermitsForHazardousTasks { get; set; }
        public string WorkersCanExpressConcerns { get; set; }
        public string AvoidsCollectiveDismissals { get; set; }
        public string CompliesWithIndividualDismissalLaws { get; set; }
        public string RecordsWorkplaceAccidents { get; set; }
        public string ConductsHealthAndSafetyInspections { get; set; }
        public string ReportsHealthAndSafetyIncidents { get; set; }
    }
}

