using System;
using System.Collections.Generic;

namespace kova.api.Models
{
    public partial class TOrganizationPerson
    {
        public TOrganizationPerson()
        {
            TOrganizationCertification = new HashSet<TOrganizationCertification>();
            TOrganizationEvent = new HashSet<TOrganizationEvent>();
            TOrganizationEventLog = new HashSet<TOrganizationEventLog>();
            TOrganizationEventParticipant = new HashSet<TOrganizationEventParticipant>();
            TOrganizationExternalMember = new HashSet<TOrganizationExternalMember>();
            TOrganizationGroupMember = new HashSet<TOrganizationGroupMember>();
            TOrganizationMessageGroupMember = new HashSet<TOrganizationMessageGroupMember>();
            TOrganizationPersonEquipment = new HashSet<TOrganizationPersonEquipment>();
            TOrganizationPersonPosition = new HashSet<TOrganizationPersonPosition>();
            TOrganizationSmsNotificationReference = new HashSet<TOrganizationSmsNotificationReference>();
            TOrganizationTask = new HashSet<TOrganizationTask>();
            TOrganizationTaskLog = new HashSet<TOrganizationTaskLog>();
        }

        public string MemberNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneMobile { get; set; }
        public string PhonePriv { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public Guid MemberGroupRef { get; set; }
        public bool? InRkhlist { get; set; }
        public bool? InRklist { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public string Position { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Guid? PassportPhotoRef { get; set; }
        public DateTime? LastLogin { get; set; }
        public double? HomeLatitude { get; set; }
        public double? HomeLongitude { get; set; }
        public string Comments { get; set; }
        public DateTime? MemberFrom { get; set; }
        public string PublicCalendarKey { get; set; }
        public int? EmailNotifications { get; set; }
        public string NextOfKin { get; set; }
        public string Employer { get; set; }
        public int? EmployerAgreement { get; set; }
        public string CardId { get; set; }
        public string Issi { get; set; }
        public Guid PrimKey { get; set; }
        public byte[] TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TOrganizationCertification> TOrganizationCertification { get; set; }
        public virtual ICollection<TOrganizationEvent> TOrganizationEvent { get; set; }
        public virtual ICollection<TOrganizationEventLog> TOrganizationEventLog { get; set; }
        public virtual ICollection<TOrganizationEventParticipant> TOrganizationEventParticipant { get; set; }
        public virtual ICollection<TOrganizationExternalMember> TOrganizationExternalMember { get; set; }
        public virtual ICollection<TOrganizationGroupMember> TOrganizationGroupMember { get; set; }
        public virtual ICollection<TOrganizationMessageGroupMember> TOrganizationMessageGroupMember { get; set; }
        public virtual ICollection<TOrganizationPersonEquipment> TOrganizationPersonEquipment { get; set; }
        public virtual ICollection<TOrganizationPersonPosition> TOrganizationPersonPosition { get; set; }
        public virtual ICollection<TOrganizationSmsNotificationReference> TOrganizationSmsNotificationReference { get; set; }
        public virtual ICollection<TOrganizationTask> TOrganizationTask { get; set; }
        public virtual ICollection<TOrganizationTaskLog> TOrganizationTaskLog { get; set; }
        public virtual TOrganizationMemberGroup MemberGroupRefNavigation { get; set; }
        public virtual TFileStoreFile PassportPhotoRefNavigation { get; set; }
    }
}
