using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using Metlife.PMS.Infrastructure.Entities;
using Metlife.PMS.Infrastructure.DataAccess.Mapping;

namespace Metlife.PMS.Infrastructure.DataAccess
{
    public partial class PMDatabaseContext : DbContext
    {
        //static PMDatabaseContext()
        //{
        //    Database.SetInitializer<PMDatabaseContext>(null);
        //}

        public PMDatabaseContext()
            : base("Name=PMDatabaseContext")
        {
        }

        public DbSet<Access> Accesses { get; set; }
        public DbSet<AccessType> AccessTypes { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationPartyRole> ApplicationPartyRoles { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<CredentialSecretQuestionAnswer> CredentialSecretQuestionAnswers { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<PartyAddress> PartyAddresses { get; set; }
        public DbSet<PartyApplicationActivity> PartyApplicationActivities { get; set; }
        public DbSet<PartyContact> PartyContacts { get; set; }
        public DbSet<PartyPreference> PartyPreferences { get; set; }
        public DbSet<PartyType> PartyTypes { get; set; }
        public DbSet<PreferenceCategory> PreferenceCategories { get; set; }
        public DbSet<PreferenceType> PreferenceTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SecretQuestion> SecretQuestions { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccessMap());
            modelBuilder.Configurations.Add(new AccessTypeMap());
            modelBuilder.Configurations.Add(new ActivityTypeMap());
            modelBuilder.Configurations.Add(new AddressTypeMap());
            modelBuilder.Configurations.Add(new ApplicationMap());
            modelBuilder.Configurations.Add(new ApplicationPartyRoleMap());
            modelBuilder.Configurations.Add(new CertificateMap());
            modelBuilder.Configurations.Add(new ComponentMap());
            modelBuilder.Configurations.Add(new CredentialMap());
            modelBuilder.Configurations.Add(new CredentialSecretQuestionAnswerMap());
            modelBuilder.Configurations.Add(new EntityMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new OrganizationMap());
            modelBuilder.Configurations.Add(new PartyMap());
            modelBuilder.Configurations.Add(new PartyAddressMap());
            modelBuilder.Configurations.Add(new PartyApplicationActivityMap());
            modelBuilder.Configurations.Add(new PartyContactMap());
            modelBuilder.Configurations.Add(new PartyPreferenceMap());
            modelBuilder.Configurations.Add(new PartyTypeMap());
            modelBuilder.Configurations.Add(new PreferenceCategoryMap());
            modelBuilder.Configurations.Add(new PreferenceTypeMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SecretQuestionMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new TokenMap());
        }
    }
}
