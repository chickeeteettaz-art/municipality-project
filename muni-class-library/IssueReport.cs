using System;
using System.Collections.Generic;
using System.Text;

namespace muni_class_library
{
    public class IssueReport
    {
        public string IssueId { get; set; }
        public string Title { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? FilePath { get; set; }
        public string? IssueCategory { get; set; }
    }
}
