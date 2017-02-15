using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationOrganization
    {
        public TOrganizationOrganization()
        {
            TOrganizationEquipment = new HashSet<TOrganizationEquipment>();
            TOrganizationEvent = new HashSet<TOrganizationEvent>();
            TOrganizationExternalMember = new HashSet<TOrganizationExternalMember>();
            TOrganizationGroup = new HashSet<TOrganizationGroup>();
            TOrganizationHiddenCourse = new HashSet<TOrganizationHiddenCourse>();
            TOrganizationMailMessageTemplate = new HashSet<TOrganizationMailMessageTemplate>();
            TOrganizationMap = new HashSet<TOrganizationMap>();
            TOrganizationMemberGroup = new HashSet<TOrganizationMemberGroup>();
            TOrganizationMessageGroup = new HashSet<TOrganizationMessageGroup>();
            TOrganizationMessageLog = new HashSet<TOrganizationMessageLog>();
            TOrganizationPersonPosition = new HashSet<TOrganizationPersonPosition>();
            TOrganizationProject = new HashSet<TOrganizationProject>();
            TOrganizationTask = new HashSet<TOrganizationTask>();
        }

        public string Name { get; set; }
        public string Department { get; set; }
        public string ShortName { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        public string LogoUrl { get; set; }
        public string MeshFolder { get; set; }
        public string UmsGroup { get; set; }
        public string UmsUsername { get; set; }
        public string UmsPassword { get; set; }
        public string SmsSender { get; set; }
        public bool AllowSmsNotifications { get; set; }
        public string GmailUsername { get; set; }
        public string GmailPassword { get; set; }
        public string EmailTemplate { get; set; }
        public bool AllowSelfCertification { get; set; }
        public int? LockEventParticipationHours { get; set; }
        public string TelemenyUsername { get; set; }
        public string TelemenyPassword { get; set; }
        public int? TelemenyAccount { get; set; }
        public string SmsProvider { get; set; }
        public string PublicCalendarKey { get; set; }
        public string ApiKey { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationEquipment> TOrganizationEquipment { get; set; }
        public virtual ICollection<TOrganizationEvent> TOrganizationEvent { get; set; }
        public virtual ICollection<TOrganizationExternalMember> TOrganizationExternalMember { get; set; }
        public virtual ICollection<TOrganizationGroup> TOrganizationGroup { get; set; }
        public virtual ICollection<TOrganizationHiddenCourse> TOrganizationHiddenCourse { get; set; }
        public virtual ICollection<TOrganizationMailMessageTemplate> TOrganizationMailMessageTemplate { get; set; }
        public virtual ICollection<TOrganizationMap> TOrganizationMap { get; set; }
        public virtual ICollection<TOrganizationMemberGroup> TOrganizationMemberGroup { get; set; }
        public virtual ICollection<TOrganizationMessageGroup> TOrganizationMessageGroup { get; set; }
        public virtual ICollection<TOrganizationMessageLog> TOrganizationMessageLog { get; set; }
        public virtual ICollection<TOrganizationPersonPosition> TOrganizationPersonPosition { get; set; }
        public virtual ICollection<TOrganizationProject> TOrganizationProject { get; set; }
        public virtual ICollection<TOrganizationTask> TOrganizationTask { get; set; }
    }
}
