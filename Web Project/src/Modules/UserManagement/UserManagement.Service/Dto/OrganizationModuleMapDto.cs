namespace UserManagement.Service.Dto
{
    public class OrganizationModuleMapDto
    {
        public long Id { get; set; }
        public long organization_id { get; set; }
        public long module_id { get; set; }
        public long created_by { get; set; }
        public long modified_by { get; set; }
    }
}
