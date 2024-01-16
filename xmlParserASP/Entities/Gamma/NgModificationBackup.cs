namespace xmlParserASP.Entities.Gamma;

public partial class NgModificationBackup
{
    public int BackupId { get; set; }

    public int ModificationId { get; set; }

    public string Code { get; set; } = null!;

    public string Xml { get; set; } = null!;

    public DateTime DateAdded { get; set; }
}
