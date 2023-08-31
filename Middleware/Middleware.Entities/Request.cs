using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Middleware.Entities
{
    [DataContract]
    public class Request
    {
        [DataMember]
        public string EmailKey { get; set; } = string.Empty;
        [DataMember]
        public string User { get; set; } = string.Empty;
        [DataMember]
        public string From { get; set; } = string.Empty;
        [DataMember]
        public string DisplayName { get; set; } = string.Empty;
        [DataMember]
        public string Domain { get; set; } = string.Empty;
        [DataMember]
        public List<string> To { get; set; } = new List<string>();
        [DataMember]
        public List<string> CC { get; set; } = new List<string>();
        [DataMember]
        public List<string> CCO { get; set; } = new List<string>();
        [DataMember]
        public string Subject { get; set; } = string.Empty;
        [DataMember]
        public string BodyHTML { get; set; } = string.Empty;
        [DataMember]
        public bool IsBodyHTML { get; set; }
        [DataMember]
        public List<string> Parameters { get; set; } = new List<string>();
        [DataMember]
        public List<List<string>> Table { get; set; } = new List<List<string>>();
        [DataMember]
        public List<AttachmentDto> Attachments { get; set; } = new List<AttachmentDto>();

    }
    [DataContract]
    public class AttachmentDto
    {
        [DataMember]
        public string FileName { get; set; } = string.Empty;
        [DataMember]
        public string Content { get; set; } = string.Empty;
        [DataMember]
        public string Path { get; set; } = string.Empty;
    }
}

