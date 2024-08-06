using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindeterApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceUsage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncludesExcludedActivities = table.Column<bool>(type: "bit", nullable: false),
                    HasEnvironmentalDepartment = table.Column<bool>(type: "bit", nullable: false),
                    HasASPersonnel = table.Column<bool>(type: "bit", nullable: false),
                    HasEnvironmentalPolicies = table.Column<bool>(type: "bit", nullable: false),
                    HasISO14001Certification = table.Column<bool>(type: "bit", nullable: false),
                    HasEnvironmentalLegalMatrix = table.Column<bool>(type: "bit", nullable: false),
                    IdentifiesPreventsImpacts = table.Column<bool>(type: "bit", nullable: false),
                    HasComplaintMechanism = table.Column<bool>(type: "bit", nullable: false),
                    CompliesWithLaborRegulations = table.Column<bool>(type: "bit", nullable: false),
                    ConductsEnvironmentalSupervision = table.Column<bool>(type: "bit", nullable: false),
                    CommunicatesSocioEnvironmentalIssues = table.Column<bool>(type: "bit", nullable: false),
                    IdentifiesEmergencySituations = table.Column<bool>(type: "bit", nullable: false),
                    HasBeenSanctioned = table.Column<bool>(type: "bit", nullable: false),
                    HasEnvironmentalLiabilities = table.Column<bool>(type: "bit", nullable: false),
                    ReceivedCommunityComplaints = table.Column<bool>(type: "bit", nullable: false),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectPhase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectProgressPercentage = table.Column<int>(type: "int", nullable: true),
                    ProjectDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalProjectValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProjectLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandUse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedExecutionTime = table.Column<int>(type: "int", nullable: false),
                    TotalIntervenedArea = table.Column<double>(type: "float", nullable: false),
                    ProjectInfluenceZones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConsultationRequired = table.Column<bool>(type: "bit", nullable: false),
                    AreSocioEnvironmentalStudiesPublic = table.Column<bool>(type: "bit", nullable: false),
                    RequiresEnvironmentalDiagnosis = table.Column<bool>(type: "bit", nullable: false),
                    RequiresEnvironmentalLicense = table.Column<bool>(type: "bit", nullable: false),
                    RequiresEnvironmentalPermissions = table.Column<bool>(type: "bit", nullable: false),
                    HasEnvironmentalManagementPlan = table.Column<bool>(type: "bit", nullable: false),
                    GeneratesImpactOnWaterAirSoil = table.Column<bool>(type: "bit", nullable: false),
                    GeneratesImpactOnFloraFauna = table.Column<bool>(type: "bit", nullable: false),
                    GeneratesSocialLaborImpact = table.Column<bool>(type: "bit", nullable: false),
                    WaterSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkerWaterSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterEfficiencyMeasures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiresChemicalProducts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsesPesticides = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiresQuarryMaterials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LightingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnergySource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnergyEfficiencyMeasures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherResourceEfficiencyMeasures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntegratesCleanProduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AffectedByNaturalEvents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsesEmissionGeneratingEquipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeasuresCarbonFootprint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReducesGHGEmissions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClimateChangeAdaptationMeasures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneratesWastewater = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeasuresWaterFootprint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneratesHazardousWaste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneratesOrdinaryWaste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsidersHistoricalPollution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfficiencyIndicators = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsHazardousChemicals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsAirPollution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsInfrastructureDismantling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsVehicleMovement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsUnqualifiedSecurity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityPersonnelTrained = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsFreshwaterUse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasCommunityComplaintMechanism = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsUnpleasantOdors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsExcessiveNoise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunitySocializationMechanisms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COVID19PreventionMeasures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowsNonDiscriminatoryHiring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvidesEqualEmploymentOpportunities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkersKnowTheirRights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasTrainingPrograms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemporaryWorkersEarnMinimumWage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RespectsUnionAgreements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EqualConditionsForForeignWorkers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdequateAccommodationForDisplacedWorkers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoForcedLabor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerifiesWorkerAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagesChildLaborRisks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsesWorkPermitsForHazardousTasks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkersCanExpressConcerns = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvoidsCollectiveDismissals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompliesWithIndividualDismissalLaws = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordsWorkplaceAccidents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConductsHealthAndSafetyInspections = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportsHealthAndSafetyIncidents = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanApplications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanApplications");
        }
    }
}
